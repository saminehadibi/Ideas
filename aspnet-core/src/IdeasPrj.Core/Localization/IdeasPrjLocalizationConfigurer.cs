using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace IdeasPrj.Localization
{
    public static class IdeasPrjLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(IdeasPrjConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(IdeasPrjLocalizationConfigurer).GetAssembly(),
                        "IdeasPrj.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
