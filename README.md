# Stefandevo.Genyman.Loco
Genyman generator for transforming Loco https://localise.biz/ input to json, resx, code, ...
## Getting Started
Stefandevo.Genyman.Loco is a **[genyman](http://genyman.net)** code generator. If you haven't installed **genyman** run following command:
```
dotnet tool install -g genyman
```
_Genyman is a .NET Core Global tool and thereby you need .NET Core version 2.1 installed._
## New Configuration file 
```
genyman new Stefandevo.Genyman.Loco
```
## Sample Configuration file 
```
{
    "genyman": {
        "packageId": "Stefandevo.Genyman.Loco",
        "info": "This is a Genyman configuration file - https://genyman.github.io/docs/"
    },
    "configuration": {
        "apiKey": "YourApiKey",
        "tag": "",
        "masterFile": "en-US.json",
        "masterLanguageId": "en",
        "fallbackLanguageId": "en",
        "languages": [
            {
                "id": "en",
                "fileName": "en-US.json"
            },
            {
                "id": "nl",
                "fileName": "nl-NL.json"
            }
        ],
        "outputFormat": "VueJs"
    }
}
```
## Documentation 
### Class Configuration
| Name | Type | Req | Description |
| --- | --- | :---: | --- |
| ApiKey | String | * | Get an API key from the portal |
| Tag | String |  | Optionally you can give a tag; keys will be filtered based upon the tag |
| MasterFile | String | * | The input, containing the master file; the keys within will be used to be added to the portal |
| MasterLanguageId | String | * | Language id for the master file; must be available in Loco |
| FallbackLanguageId | String |  | Optionally a fallback language Id; this means that for all translations not entered in the different languages, the translation of the fallback language are returned. |
| Languages | Language[] |  | Languages to return |
| OutputFormat | OutputFormat (Enum) | * | The output format |
### Class Language
| Name | Type | Req | Description |
| --- | --- | :---: | --- |
| Id | String | * | The language Id |
| FileName | String | * | Name of the json file to return |
### Enum OutputFormat
| Name | Description |
| --- | --- |
| VueJs | VueJs |
| Xamarin | Xamarin (Not Implemented ATM) |
