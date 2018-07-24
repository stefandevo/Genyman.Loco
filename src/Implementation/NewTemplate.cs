namespace Stefandevo.Genyman.Logo.Implementation
{
	public class NewTemplate : Configuration
	{
		public NewTemplate()
		{
			ApiKey = "YourApiKey";
			MasterFile = "en-US.json";
			MasterLanguageId = "en";
			FallbackLanguageId = "en";
			Tag = "";
			Languages.Add(new Language() {Id = "en", FileName = "en-US.json"});
			Languages.Add(new Language() {Id = "nl", FileName = "nl-NL.json"});
			OutputFormat = OutputFormat.VueJs;
		}
	}
}