using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace CREDO.WebApp.Localization;

public static class LocalizationExtensions
{
    public static IServiceCollection AddApplicationLocalization(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddSingleton<IResourceDictionarySource, InMemoryResourceDictionarySource>();
        services.AddScoped<IApplicationStringLocalizer, ApplicationStringLocalizer>();

        return services;
    }

    public static IApplicationBuilder UseApplicationRequestLocalization(this IApplicationBuilder app)
    {
        var supportedCultures = LanguageCatalog.All
            .Select(language => new CultureInfo(language.CultureName))
            .ToArray();

        var options = new RequestLocalizationOptions
        {
            DefaultRequestCulture = new RequestCulture(LanguageCatalog.DefaultCultureName),
            SupportedCultures = supportedCultures,
            SupportedUICultures = supportedCultures,
            RequestCultureProviders =
            [
                new CookieRequestCultureProvider(),
                new AcceptLanguageHeaderRequestCultureProvider()
            ]
        };

        return app.UseRequestLocalization(options);
    }

    public static void MapLanguagePreferenceEndpoint(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/language/set", (HttpContext context, string? culture, string? returnUrl) =>
        {
            if (!LanguageCatalog.TryNormalize(culture, out var normalizedCulture))
            {
                normalizedCulture = LanguageCatalog.DefaultCultureName;
            }

            context.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(normalizedCulture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    HttpOnly = true,
                    IsEssential = true,
                    Path = "/",
                    SameSite = SameSiteMode.Lax,
                    Secure = context.Request.IsHttps
                });

            return Results.LocalRedirect(GetSafeReturnUrl(returnUrl));
        });
    }

    private static string GetSafeReturnUrl(string? returnUrl)
    {
        if (string.IsNullOrWhiteSpace(returnUrl) ||
            !returnUrl.StartsWith("/", StringComparison.Ordinal) ||
            returnUrl.StartsWith("//", StringComparison.Ordinal) ||
            returnUrl.StartsWith("/\\", StringComparison.Ordinal))
        {
            return "/";
        }

        return returnUrl;
    }
}
