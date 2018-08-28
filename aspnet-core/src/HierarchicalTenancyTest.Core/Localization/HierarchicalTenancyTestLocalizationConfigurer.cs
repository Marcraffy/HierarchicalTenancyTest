using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HierarchicalTenancyTest.Localization
{
    public static class HierarchicalTenancyTestLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HierarchicalTenancyTestConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HierarchicalTenancyTestLocalizationConfigurer).GetAssembly(),
                        "HierarchicalTenancyTest.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
