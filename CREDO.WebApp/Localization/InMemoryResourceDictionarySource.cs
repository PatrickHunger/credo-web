namespace CREDO.WebApp.Localization;

public sealed class InMemoryResourceDictionarySource : IResourceDictionarySource
{
    private static readonly IReadOnlyDictionary<string, IReadOnlyDictionary<string, string>> Dictionaries =
        new Dictionary<string, IReadOnlyDictionary<string, string>>(StringComparer.OrdinalIgnoreCase)
        {
            [LanguageCatalog.English] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["Shared.BrandSubtitleShort"] = "Community · Respect · Excellence",
                ["Shared.BrandSubtitleFull"] = "Community · Respect · Excellence · Dedication · Order",
                ["Shared.OrganizationImageAlt"] = "C.R.E.D.O. organization image",

                ["Header.Nav.AriaLabel"] = "Public navigation",
                ["Header.Nav.Home"] = "Home",
                ["Header.Nav.Organization"] = "Organization",
                ["Header.Nav.Fleet"] = "Fleet",
                ["Header.Nav.Media"] = "Media",
                ["Header.Nav.Events"] = "Events",
                ["Header.Nav.JoinUs"] = "Join Us",
                ["Header.MemberLogin"] = "Member Login",
                ["Header.ApplyNow"] = "Apply Now",
                ["Header.LanguageLabel"] = "Language",
                ["Header.ChangeLanguage"] = "Change",

                ["Footer.Rights"] = "All rights reserved.",
                ["Footer.Nav.AriaLabel"] = "Secondary public navigation",
                ["Footer.Contact"] = "Contact",
                ["Footer.JoinUs"] = "Join Us",

                ["Shared.BackHome"] = "Back to Home",

                ["Home.PageTitle"] = "C.R.E.D.O. - Community. Respect. Excellence.",
                ["Home.Hero.Eyebrow"] = "Welcome to",
                ["Home.Hero.MottoLine1"] = "Community. Respect. Excellence.",
                ["Home.Hero.MottoLine2"] = "Dedication. Order.",
                ["Home.Hero.Text"] = "We are a disciplined and dedicated Star Citizen organization united by respect, teamwork, and a drive for excellence. Together, we build stronger missions, stronger bonds, and a better verse.",
                ["Home.Hero.ExploreOrganization"] = "Explore Organization",
                ["Home.Hero.JoinOrganization"] = "Join the Organization",
                ["Home.Video.Title"] = "Watch Our Story",
                ["Home.Video.PlayAria"] = "Play video",
                ["Home.Organization.Title"] = "Organization & Culture",
                ["Home.Organization.Paragraph1"] = "C.R.E.D.O. is a Star Citizen organization built on the foundation of community, respect, excellence, dedication and order.",
                ["Home.Organization.Paragraph2"] = "We are more than a group of pilots. We are a team of citizens, explorers, builders and protectors who believe that structure, teamwork and trust create lasting success.",
                ["Home.Organization.Paragraph3"] = "Whether you are new to the verse or a seasoned veteran, you will find a place where your effort matters and your growth is supported.",
                ["Home.Values.Community.Title"] = "Community",
                ["Home.Values.Community.Text"] = "A welcoming and reliable group of citizens who value respect, loyalty and camaraderie.",
                ["Home.Values.Operations.Title"] = "Operations",
                ["Home.Values.Operations.Text"] = "From combat to cargo, exploration to support, we operate with purpose, structure and coordination.",
                ["Home.Values.Excellence.Title"] = "Excellence",
                ["Home.Values.Excellence.Text"] = "We strive to improve, prepare and act with discipline in everything we do as an organization.",

                ["Organization.PageTitle"] = "Organization - C.R.E.D.O.",
                ["Organization.Title"] = "Organization",
                ["Organization.Paragraph1"] = "C.R.E.D.O. is a Star Citizen organization built around community, respect, excellence, dedication and order.",
                ["Organization.Paragraph2"] = "This is where our identity and structure come together: who we are, how we operate, and what kind of member experience we want to create.",
                ["Organization.Paragraph3"] = "We value coordinated play, reliable teamwork and a clear sense of belonging without losing sight of the people behind every pilot, specialist and crew member.",
                ["Organization.Identity.Title"] = "Identity",
                ["Organization.Identity.Text"] = "A disciplined community with a shared standard for respect, reliability and long-term growth.",
                ["Organization.Structure.Title"] = "Structure",
                ["Organization.Structure.Text"] = "Clear roles, coordinated divisions and operational focus give members a path to contribute with purpose.",
                ["Organization.Standards.Title"] = "Standards",
                ["Organization.Standards.Text"] = "We prepare, communicate and improve together so that every mission benefits from trust and discipline.",
                ["Organization.Joining.Title"] = "Joining C.R.E.D.O.",
                ["Organization.Joining.Text"] = "If the organization feels like the right fit, the next step is the Join Us page. For direct questions, diplomacy or external requests, use Contact.",
                ["Organization.Joining.JoinUs"] = "Join Us",
                ["Organization.Joining.Contact"] = "Contact",

                ["NotFound.PageTitle"] = "Page Not Found - C.R.E.D.O.",
                ["NotFound.Code"] = "404 - Not Found",
                ["NotFound.Heading"] = "Page Not Found",
                ["NotFound.Text"] = "The requested page does not exist.",
                ["NotFound.SecondaryText"] = "The page may have been moved, deleted, or the URL may be incorrect.",
                ["NotFound.ImageAlt"] = "A space pilot raising both hands in a questioning gesture.",
                ["NotFound.BackPrevious"] = "Go Back",

                ["ComingSoon.Code"] = "Soon",
                ["ComingSoon.Heading"] = "Coming Soon",
                ["ComingSoon.Text"] = "This area is currently under development and will be available soon.",
                ["ComingSoon.ExploreOrganization"] = "Explore Organization",
                ["ComingSoon.Section.Default"] = "Upcoming section",
                ["ComingSoon.Section.coming-soon"] = "Upcoming section",
                ["ComingSoon.Section.fleet"] = "Fleet",
                ["ComingSoon.Section.media"] = "Media",
                ["ComingSoon.Section.events"] = "Events",
                ["ComingSoon.Section.join-us"] = "Join Us",
                ["ComingSoon.Section.contact"] = "Contact",
                ["ComingSoon.Section.member-login"] = "Member Login"
            },
            [LanguageCatalog.German] = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["Shared.BrandSubtitleShort"] = "Gemeinschaft · Respekt · Exzellenz",
                ["Shared.BrandSubtitleFull"] = "Gemeinschaft · Respekt · Exzellenz · Hingabe · Ordnung",
                ["Shared.OrganizationImageAlt"] = "C.R.E.D.O.-Organisationsbild",

                ["Header.Nav.AriaLabel"] = "Öffentliche Navigation",
                ["Header.Nav.Home"] = "Start",
                ["Header.Nav.Organization"] = "Organisation",
                ["Header.Nav.Fleet"] = "Flotte",
                ["Header.Nav.Media"] = "Medien",
                ["Header.Nav.Events"] = "Events",
                ["Header.Nav.JoinUs"] = "Mitmachen",
                ["Header.MemberLogin"] = "Member Login",
                ["Header.ApplyNow"] = "Jetzt bewerben",
                ["Header.LanguageLabel"] = "Sprache",
                ["Header.ChangeLanguage"] = "Ändern",

                ["Footer.Rights"] = "Alle Rechte vorbehalten.",
                ["Footer.Nav.AriaLabel"] = "Sekundäre öffentliche Navigation",
                ["Footer.Contact"] = "Kontakt",
                ["Footer.JoinUs"] = "Mitmachen",

                ["Shared.BackHome"] = "Zur Startseite",

                ["Home.PageTitle"] = "C.R.E.D.O. - Gemeinschaft. Respekt. Exzellenz.",
                ["Home.Hero.Eyebrow"] = "Willkommen bei",
                ["Home.Hero.MottoLine1"] = "Gemeinschaft. Respekt. Exzellenz.",
                ["Home.Hero.MottoLine2"] = "Hingabe. Ordnung.",
                ["Home.Hero.Text"] = "Wir sind eine disziplinierte und engagierte Star-Citizen-Organisation, vereint durch Respekt, Teamwork und den Anspruch, besser zu werden. Gemeinsam schaffen wir stärkere Missionen, stärkere Verbindungen und ein besseres Verse.",
                ["Home.Hero.ExploreOrganization"] = "Organisation entdecken",
                ["Home.Hero.JoinOrganization"] = "Organisation beitreten",
                ["Home.Video.Title"] = "Unsere Geschichte ansehen",
                ["Home.Video.PlayAria"] = "Video abspielen",
                ["Home.Organization.Title"] = "Organisation & Kultur",
                ["Home.Organization.Paragraph1"] = "C.R.E.D.O. ist eine Star-Citizen-Organisation auf dem Fundament von Gemeinschaft, Respekt, Exzellenz, Hingabe und Ordnung.",
                ["Home.Organization.Paragraph2"] = "Wir sind mehr als eine Gruppe von Piloten. Wir sind ein Team aus Citizens, Entdeckern, Aufbauern und Beschützern, die daran glauben, dass Struktur, Teamwork und Vertrauen nachhaltigen Erfolg schaffen.",
                ["Home.Organization.Paragraph3"] = "Ob du neu im Verse bist oder ein erfahrener Veteran: Bei uns findest du einen Platz, an dem dein Einsatz zählt und deine Entwicklung unterstützt wird.",
                ["Home.Values.Community.Title"] = "Gemeinschaft",
                ["Home.Values.Community.Text"] = "Eine einladende und verlässliche Gruppe von Citizens, die Respekt, Loyalität und Zusammenhalt schätzt.",
                ["Home.Values.Operations.Title"] = "Operationen",
                ["Home.Values.Operations.Text"] = "Von Kampf bis Cargo, von Erkundung bis Support: Wir handeln mit Ziel, Struktur und Koordination.",
                ["Home.Values.Excellence.Title"] = "Exzellenz",
                ["Home.Values.Excellence.Text"] = "Wir wollen uns verbessern, vorbereiten und in allem, was wir als Organisation tun, diszipliniert handeln.",

                ["Organization.PageTitle"] = "Organisation - C.R.E.D.O.",
                ["Organization.Title"] = "Organisation",
                ["Organization.Paragraph1"] = "C.R.E.D.O. ist eine Star-Citizen-Organisation, die auf Gemeinschaft, Respekt, Exzellenz, Hingabe und Ordnung aufbaut.",
                ["Organization.Paragraph2"] = "Hier kommen unsere Identität und Struktur zusammen: wer wir sind, wie wir operieren und welche Member Experience wir schaffen wollen.",
                ["Organization.Paragraph3"] = "Wir schätzen koordiniertes Spiel, verlässliches Teamwork und ein klares Zugehörigkeitsgefühl, ohne die Menschen hinter jedem Piloten, Spezialisten und Crewmitglied aus dem Blick zu verlieren.",
                ["Organization.Identity.Title"] = "Identität",
                ["Organization.Identity.Text"] = "Eine disziplinierte Gemeinschaft mit einem gemeinsamen Anspruch an Respekt, Verlässlichkeit und langfristiges Wachstum.",
                ["Organization.Structure.Title"] = "Struktur",
                ["Organization.Structure.Text"] = "Klare Rollen, koordinierte Divisionen und operativer Fokus geben Mitgliedern einen Weg, mit Sinn beizutragen.",
                ["Organization.Standards.Title"] = "Standards",
                ["Organization.Standards.Text"] = "Wir bereiten uns vor, kommunizieren und verbessern uns gemeinsam, damit jede Mission von Vertrauen und Disziplin profitiert.",
                ["Organization.Joining.Title"] = "C.R.E.D.O. beitreten",
                ["Organization.Joining.Text"] = "Wenn die Organisation sich passend anfühlt, ist die nächste Station die Mitmachen-Seite. Für direkte Fragen, Diplomatie oder externe Anliegen nutze Kontakt.",
                ["Organization.Joining.JoinUs"] = "Mitmachen",
                ["Organization.Joining.Contact"] = "Kontakt",

                ["NotFound.PageTitle"] = "Seite nicht gefunden - C.R.E.D.O.",
                ["NotFound.Code"] = "404 - Nicht gefunden",
                ["NotFound.Heading"] = "Seite nicht gefunden",
                ["NotFound.Text"] = "Die angeforderte Seite existiert nicht.",
                ["NotFound.SecondaryText"] = "Die Seite wurde möglicherweise verschoben, gelöscht oder die URL ist falsch.",
                ["NotFound.ImageAlt"] = "Eine Raumpilotin hebt beide Hände in einer fragenden Geste.",
                ["NotFound.BackPrevious"] = "Zurück",

                ["ComingSoon.Code"] = "Bald",
                ["ComingSoon.Heading"] = "Bald verfügbar",
                ["ComingSoon.Text"] = "Dieser Bereich befindet sich aktuell in Entwicklung und wird bald verfügbar sein.",
                ["ComingSoon.ExploreOrganization"] = "Organisation entdecken",
                ["ComingSoon.Section.Default"] = "Kommender Bereich",
                ["ComingSoon.Section.coming-soon"] = "Kommender Bereich",
                ["ComingSoon.Section.fleet"] = "Flotte",
                ["ComingSoon.Section.media"] = "Medien",
                ["ComingSoon.Section.events"] = "Events",
                ["ComingSoon.Section.join-us"] = "Mitmachen",
                ["ComingSoon.Section.contact"] = "Kontakt",
                ["ComingSoon.Section.member-login"] = "Member Login"
            }
        };

    public IReadOnlyDictionary<string, string>? GetResourceDictionary(string cultureName)
    {
        if (!LanguageCatalog.TryNormalize(cultureName, out var normalizedCulture))
        {
            normalizedCulture = LanguageCatalog.DefaultCultureName;
        }

        return Dictionaries.TryGetValue(normalizedCulture, out var dictionary)
            ? dictionary
            : null;
    }
}
