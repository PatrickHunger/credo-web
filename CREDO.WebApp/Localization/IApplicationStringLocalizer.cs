namespace CREDO.WebApp.Localization;

public interface IApplicationStringLocalizer
{
    string this[string key] { get; }

    SupportedLanguage CurrentLanguage { get; }

    IReadOnlyList<SupportedLanguage> SupportedLanguages { get; }

    string Get(string key);
}
