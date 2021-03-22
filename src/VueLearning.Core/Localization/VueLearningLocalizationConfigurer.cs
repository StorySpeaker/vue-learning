using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace VueLearning.Localization
{
    public static class VueLearningLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(VueLearningConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(VueLearningLocalizationConfigurer).GetAssembly(),
                        "VueLearning.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
