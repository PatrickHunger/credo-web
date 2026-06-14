namespace CREDO.WebApp.Localization;

public interface IResourceDictionarySource
{
    IReadOnlyDictionary<string, string>? GetResourceDictionary(string cultureName);
}
