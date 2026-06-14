using System.Globalization;

namespace CREDO.WebApp.Localization;

public sealed class ApplicationStringLocalizer(IResourceDictionarySource resourceDictionarySource) : IApplicationStringLocalizer
{
    public string this[string key] => Get(key);

    public SupportedLanguage CurrentLanguage => LanguageCatalog.GetByCulture(CultureInfo.CurrentUICulture.Name);

    public IReadOnlyList<SupportedLanguage> SupportedLanguages => LanguageCatalog.All;

    public string Get(string key)
    {
        var currentCulture = CurrentLanguage.CultureName;

        if (TryGet(currentCulture, key, out var value))
        {
            return value;
        }

        if (currentCulture != LanguageCatalog.DefaultCultureName &&
            TryGet(LanguageCatalog.DefaultCultureName, key, out value))
        {
            return value;
        }

        return key;
    }

    private bool TryGet(string cultureName, string key, out string value)
    {
        value = string.Empty;

        var dictionary = resourceDictionarySource.GetResourceDictionary(cultureName);

        if (dictionary is null || !dictionary.TryGetValue(key, out var foundValue))
        {
            return false;
        }

        value = foundValue;
        return true;
    }
}
