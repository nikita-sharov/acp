# acp

Job application in code



CSS

```css
.masthead {
    background-color: var(--bright-red);
}

.masthead-logo {
    margin-left: 60px;
    position: absolute;
    width: 120px;
}

.masthead-slogan {
    color: var(--pure-white);
    font-family: "Apex Rounded Medium", sans-serif;
    font-size: 90px;
    line-height: 1;
    margin-left: 398px;
    padding: 71px 60px 49px;
}

.container {
    display: flex;
}

aside {
    width: 398px;
    background-color: var(--light-gray);
}

.killer-argument-illustration {
    margin-top: -170px;
}

.killer-argument::after {
    content: "";
    width: 100px;
    height: 1px;
    background-color: var(--dark-gray);
    margin-top: 40px;
    display: block;
}
```


https://jeremylindsayni.wordpress.com/2019/02/18/adding-middleware-to-your-net-core-mvc-pipeline-that-formats-and-indents-html-output/

~~Miteinander weiter denken ist aus 2 Schriftarten gesetzt, die sich nur geringfügig unterscheiden; schaut nicht nach einem vollständigen Satz aus (Punkt); schlecht / inkosequent ausgerichtet~~

~~Auf karriere.at überschneidet sich das Logo mit dem Photo~~

```csharp
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Required")]
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services) => services.AddRazorPages();

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseBrowserLink();
        }
        else
        {
            app.UseHsts();
        }

        app.UseDeveloperExceptionPage();
        app.UseHttpsRedirection();
        app.UseStaticFiles(
            new StaticFileOptions
            {
                OnPrepareResponse = (context) =>
                {
                    const int CachePeriodInSeconds = 31_536_000; // 1 year
                    string cacheControlHeaderValue = $"public, max-age={CachePeriodInSeconds}";
                    context.Context.Response.Headers.Append(HeaderNames.CacheControl, cacheControlHeaderValue);
                }
            });

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}
```

Razor

```cshtml
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <meta name="keywords" content="ASP.NET Core, C#, CSS, HTML, Microsite, Microsoft Azure, Nachbau, Optimierung" />
    <meta name="description" content="Individuelle Bewerbung; Beweisführung durch Einzelanfertigung." />
    <title>@ViewData["Title"]</title>
    <link rel="icon" href="~/favicon.ico" />
    <environment include="Development">
        <link rel="stylesheet" href="~/css/site.css" />
    </environment>
    <environment exclude="Development">
        <link rel="stylesheet" href="~/css/site.min.css" asp-append-version="true" />
    </environment>
</head>
<body>
    <header class="masthead">
        <a href="https://github.com/nikita-sharov/acp" title="Quellcode statt Barcode">
            <img class="masthead-logo" src="~/img/logo.svg" alt="Logo" />
        </a>        
        <div class="masthead-slogan">Gemeinsam<br />weiter gehen.</div>
    </header>
    <div class="container">
        <aside>
            <partial name="_Sidebar" />
        </aside>
        <main role="main">
            @RenderBody()
        </main>
    </div>
</body>
</html>
```

~~mailto hat keinen Empfänger~~

> Es erwartet Sie eine verantwortungsvolle Tätigkeit mit Zukunftsperspektiven.

Ist keine Gehaltsinfromation.

"Ihre Verantwortung", "Verantwortungsbewusstsein", "Aufgabengebiet mit Selbstverantwortung",

Verantwortung stellt, normalerweise, eine Last dar, und hat hiermit unter "Unser Angebot" nichts verloren.

Wie deckt sich ein eigenständiges Aufgabengebiet mit 

dabei unterstützt Sie ein Team von erfahrenen Entwickler(n)Innen. und

kollegiales Miteinander

Kurze Entscheidungswege oha bei eigenständiger Selbstverantwortung trifft doch jemand anderer die Entscheidungen?

> Kenntnisse in C#, HTML5, CSS[,] und JavaScript

> SharePoint (~~SP~~ Farm Solutions, SPFx, PnP[,] …) und Azure (Functions, Web Apps, ~~Azure~~DevOps)

> Idealerweise besitzen Sie Microsoft Azure, SharePoint oder Office 365 Zertifizierungen



Ich erwarte mir

dass Kollegen, die die Volljährigkeit erreicht haben, grundsätzlich für alle ihre Handlungen Verantwortung übernehmen. Das gilt auch für Entscheidungen

Das gilt in manchen Fällen auch für Nicht-Handlungen
, bestimmte Entscheidungen




Sehr geehrte Frau Braun,
werte Kollegen,


Mit freundlichen Grüßen,
Nikita Sharov


Dies würde eine gewisse Transparenz sowie . Von einem echten Team, dessen Mitglieder einer Berufung nachgehen, sollte es kein Problem sein.

Die logische Document Outline ist falsch.

Lebenslauf: https://de.wikipedia.org/wiki/Microsoft_Windows

Zeitleisten für: Sprachen, IDEs, DBMSs, Arbeitgeber, Branchen, Plattformen

Mehr Rechte, mehr Pflichten; mehr Macht, mehr Verantwortung.

Geduld aber bringt Erfahrung; Erfahrung aber bringt Hoffnung; Römer 5:4 / LUT

Nicht darum, daß wir es nicht Macht haben, sondern daß wir uns selbst zum Vorbilde euch gäben, uns nachzufolgen. Und da wir bei euch waren, geboten wir euch solches, daß, so jemand nicht will arbeiten, der soll auch nicht essen. Denn wir hören, daß etliche unter euch wandeln unordentlich und arbeiten nichts, sondern treiben Vorwitz.

Der www.acp.at link auf karierre.at ist broken.

Mein Angebot:

- Ortsunabhängige Entwicklung

Mein Profil

- Mehrjährige Berufserfahrung

> Das gebotene monatliche Bruttogehalt liegt bei (mind.) 3.300 - je nach relevanter Arbeitserfahrung und Qualifikation.

Ändert sich das gebotene *Mindest*-Bruttogehalt je nach relevanter Arbeitserfahrung und Qualifikation?

Soll das ein Hinweis auf die

Anders formuliert:  

Sollte das einen Hinweis auf die Bereitschaft zur kollektivvertraglichen Überzahlung darstellen? Die vorliegende Formulierung lässt einen Mindestwert (kleinstmöglicher Wert) variabel erscheinen:

Je nach relevanter Arbeitserfahrung und Qualifikation liegt das gebotene monatliche Mindestgehalt bei € 3.300,- brutto.

(Arbeitsrechtlich ist jenes Entgelt anzugeben, das als Mindestgrundlage für die Arbeitsvertragsverhandlungen dienen soll.)