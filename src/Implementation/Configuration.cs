using System.Collections.Generic;

namespace Stefandevo.Genyman.Loco.Implementation
{
	public class Configuration
	{
		public string ApiKey { get; set; }
		public string Tag { get; set; }
		public string MasterFile { get; set; }
		public string MasterLanguageId { get; set; }
		public string FallbackLanguageId { get; set; }

		public List<Language> Languages { get; set; } = new List<Language>();

		public OutputFormat OutputFormat { get; set; }
	}

	public class Language
	{
		public string Id { get; set; }
		public string FileName { get; set; }
	}

	public enum OutputFormat
	{
		VueJs,
		Xamarin
	}
}