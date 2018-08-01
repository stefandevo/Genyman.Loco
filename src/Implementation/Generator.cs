using System;
using System.IO;
using System.Text;
using Genyman.Core;
using ServiceStack;

namespace Stefandevo.Genyman.Loco.Implementation
{
	internal class Generator : GenymanGenerator<Configuration>
	{
		public override void Execute()
		{
			try
			{
				var masterContents = File.ReadAllText(Configuration.MasterFile);

				var importUrl = $"https://localise.biz/api/import/json?index=id&locale={Configuration.MasterLanguageId}";
				if (!Configuration.Tag.IsNullOrEmpty())
					importUrl += $"&tag-all={Configuration.Tag}";

				Log.Information($"Uploading...");

				var importResult = importUrl.PostStringToUrl(masterContents, requestFilter: request => { request.Headers.Add("Authorization", $"Loco {Configuration.ApiKey}"); });
				Log.Debug(importResult);

				switch (Configuration.OutputFormat)
				{
					case OutputFormat.VueJs:
						ExportVueJs();
						break;

					case OutputFormat.Xamarin:
						break;
					
					default:
						throw new ArgumentOutOfRangeException();
				}


				Log.Information($"Finished");
			}
			catch (Exception e)
			{
				Log.Fatal(e.ToString());
			}
		}
		
		void ExportVueJs()
		{
			foreach (var language in Configuration.Languages)
			{
				Log.Information($"Downloading {language.Id}...");

				try
				{
					var url = $"https://localise.biz/api/export/locale/{language.Id}.json?index=id&pretty";
					if (!Configuration.FallbackLanguageId.IsNullOrEmpty())
						url += $"&fallback={Configuration.FallbackLanguageId}";

					var contents = url.GetStringFromUrl(requestFilter: request => { request.Headers.Add("Authorization", $"Loco {Configuration.ApiKey}"); });

					File.WriteAllText(language.FileName, contents, Encoding.UTF8);
				}
				catch (Exception e)
				{
					Log.Error($"Could not download {language.Id}");
				}
			}
		}
	}
}