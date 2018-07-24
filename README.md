# Genyman.Loco

Genyman code generator for use with Loco (https://localise.biz/).

Basic idea of this generator: 
- you use 1 master file/language
- this file will be uploaded to Loco (it will merge keys and translations)
- next you define which languages you want to return
- you can specify a fallback language
- translated files will return (including the master)

Create a new configuration file:

```
genyman new stefandevo.genyman.loco
```

Sample configuration file:

```
{
	"genyman": {
		"packageId": "Stefandevo.Genyman.Loco",
		"version": ""
	},
	"configuration": {
		"apiKey": "<YOURAPIKEY>",
		"masterFile": "en-US.json",
		"masterLanguageId": "en",
		"fallbackLanguageId": "en",
		"languages": [{
				"id": "en",
				"fileName": "en-US.json"
			},
			{
				"id": "nl",
				"fileName": "nl-NL.json"
			}
		]
	}
}
```

Configuration options:

- `ApiKey`: get an API key from the portal.
- `Tag`: optionally you can give a tag; keys will be filtered based upon the tag.
- `MasterFile`: the input, containing the master file; the keys within will be used to be added to the portal.
- `MasterLanguageId`: language id for the master file; must be available in Loco.
- `FallbackLanguageId`: optionally a fallback language Id; this means that for all translations not entered in the different languages, the translation of the fallback language are returned.
- `Languages`: array of languages to return; an item contains a `id` = languageId, `fileName` = name of the json file to return.
- `OutputFormat`: enum `VueJs`, `Xamarin`. Currently only `VueJs` is implemented.
