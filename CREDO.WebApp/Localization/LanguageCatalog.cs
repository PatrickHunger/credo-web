namespace CREDO.WebApp.Localization;

public static class LanguageCatalog
{
    public const string English = "en";
    public const string German = "de";

    public const string DefaultCultureName = English;

    public static IReadOnlyList<SupportedLanguage> All { get; } =
    [
        new(English, "English", "EN"),
        new(German, "Deutsch", "DE")
    ];

    public static SupportedLanguage GetByCulture(string? cultureName)
    {
        if (!TryNormalize(cultureName, out var normalizedCulture))
        {
            normalizedCulture = DefaultCultureName;
        }

        return All.First(language => language.CultureName == normalizedCulture);
    }

    public static bool TryNormalize(string? cultureName, out string normalizedCulture)
    {
        normalizedCulture = DefaultCultureName;

        if (string.IsNullOrWhiteSpace(cultureName))
        {
            return false;
        }

        var candidate = cultureName.Trim().ToLowerInvariant();

        foreach (var language in All)
        {
            if (candidate == language.CultureName ||
                candidate.StartsWith($"{language.CultureName}-", StringComparison.Ordinal))
            {
                normalizedCulture = language.CultureName;
                return true;
            }
        }

        return false;
    }
}
