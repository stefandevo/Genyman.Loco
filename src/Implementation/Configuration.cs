using System.Collections.Generic;
using Genyman.Core;

namespace Stefandevo.Genyman.Loco.Implementation
{
	[Documentation(Source = "https://github.com/stefandevo/Genyman.Loco")]
	public class Configuration
	{
		[Description("Get an API key from the portal")]
		[Required]
		public string ApiKey { get; set; }
		
		[Description("Optionally you can give a tag; keys will be filtered based upon the tag")]
		public string Tag { get; set; }
		
		[Description("The input, containing the master file; the keys within will be used to be added to the portal")]
		[Required]
		public string MasterFile { get; set; }
		
		[Description("Language id for the master file; must be available in Loco")]
		[Required]
		public string MasterLanguageId { get; set; }
		
		[Description("Optionally a fallback language Id; this means that for all translations not entered in the different languages, the translation of the fallback language are returned.")]
		public string FallbackLanguageId { get; set; }

		[Description("Languages to return")]
		public List<Language> Languages { get; set; } = new List<Language>();

		[Description("The output format")]
		[Required]
		public OutputFormat OutputFormat { get; set; }
	}

	[Documentation]
	public class Language
	{
		[Description("The language Id")]
		[Required]
		public string Id { get; set; }
		
		[Description("Name of the json file to return")]
		[Required]
		public string FileName { get; set; }
	}

	[Documentation]
	public enum OutputFormat
	{
		[Description("VueJs")]
		VueJs,
		[Description("Xamarin (Not Implemented ATM)")]
		Xamarin
	}
}