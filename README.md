# Genyman.Loco

Genyman code generator for use with Loco (https://localise.biz/).

Basic idea of this generator: 
- you use 1 master file/language
- this file will be uploaded to Loco (it will merge keys and translations)
- next you define which languages you want to return
- you can specify a fallback language
- translated files will return (including the master)

Use [genyman](https://genyman.github.io/docs/) to create a new configuration template:

```
genyman new stefandevo.genyman.loco
```

```
Class: Configuration
--------------------

Name                    Type                     Req      Description                                                                                                                                                           
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
ApiKey                  String                   *        Get an API key from the portal                                                                                                                                        
Tag                     String                            Optionally you can give a tag; keys will be filtered based upon the tag                                                                                               
MasterFile              String                   *        The input, containing the master file; the keys within will be used to be added to the portal                                                                         
MasterLanguageId        String                   *        Language id for the master file; must be available in Loco                                                                                                            
FallbackLanguageId      String                            Optionally a fallback language Id; this means that for all translations not entered in the different languages, the translation of the fallback language are returned.
Languages               Language[]                        Languages to return                                                                                                                                                   
OutputFormat            OutputFormat (Enum)      *        The output format                                                                                                                                                     

Class: Language
---------------

Name          Type        Req      Description                    
------------------------------------------------------------------
Id            String      *        The language Id                
FileName      String      *        Name of the json file to return

Enum: OutputFormat
------------------

Name         Description                  
------------------------------------------
VueJs        VueJs                        
Xamarin      Xamarin (Not Implemented ATM)

```