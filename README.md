# ACP Career

This repo showcases:

- expressiveness in [C#](src/Acp.Career/Startup.cs), [HTML], and CSS
- law and order

https://jobs.acp.at/Job/7382

## Audits

Generated by Google's [Lighthouse](https://developers.google.com/web/tools/lighthouse) 6.0.0 (via Chrome DevTools), for desktop devices.

### Original

![Lighthouse report results](media/jobs.acp.at-20200602T123354.png)

[Report](https://googlechrome.github.io/lighthouse/viewer/?gist=d299e20bdb290bd04b71dc6044a19cc9)

### Refactored

![Lighthouse report results](media/acp.235u.net-20200602T121522.png)

[Report](https://googlechrome.github.io/lighthouse/viewer/?gist=90cc77a5ff49e6c9913b550ff7c21cf0)

## Configuration

## Representation

### Layout

```razor
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

### Sidebar

```razor
<img class="killer-argument-illustration" src="~/img/generic-stock-image.jpg" width="398" height="264" alt="Dual-Monitor Mac Pro 2013 Setup" />
<nav>
    <p class="lead killer-argument">Ich biete mehr als nur eine Position für die Lohn- und Gehaltsabrechnung: echtes Interesse für das kollektive Gesamtergebnis.</p>    
    <div class="h2">Kontakt</div>
    <p>Ich freue mich über eine informative Rückmeldung, auch ohne Lebenslauf und Foto.</p>
    <div class="h2">Herr Nikita Sharov</div>
    <address>Actin Uranium<br />Mariatroster Straße 172<br />A-8044 Graz<br /><a href="https://www.235u.net">www.235u.net</a></address>
    <a href="https://acp.235u.net" class="button" role="button">Online betrachten</a>
</nav>
```

### Main content

```razor
@page
@{
    ViewData["Title"] = "Senior Full-Stack Developer aus Leidenschaft";
}

<article>
    <p class="lead">Ich suche am Standort Graz eine Stelle als</p>
    <h1>@ViewData["Title"]</h1>
    <p class="lead">in Teil- oder Vollzeit</p>
    <h2>Meine Aufgaben</h2>
    <ul>
        <li>Sie sind als .NET SoftwareentwicklerIn (für Azure und SharePoint) von der Konzeption, über die Implementierung, bis hin zum Testing, und der Auslieferung von Kundenlösungen involviert.</li>
        <li>Ihre Verantwortung liegt darin die Anforderungen effiz[i]ent und mit einer hohen Qualität umzusetzen, dabei unterstützt Sie ein Team von erfahrenen Entwickler(n)Innen.</li>
    </ul>
    <h2>Mein Profil</h2>
    <ul>
        <li>Fundierte IT-Ausbildung (Uni)</li>
        <li>Genauigkeit, Motivation, Lernbereitschaft</li>
        <li>Teamfähigkeit, hohe Kundenorientierung, analytisches Denkvermögen</li>
        <li>Verantwortungsbewusstsein und hohe Eigeninitiative</li>
        <li>Kenntnisse in C#, HTML, CSS und JavaScript</li>
        <li>Erfahrung mit SharePoint (2010, 2013; Farm Solutions) und Azure (Web Apps, DevOps)</li>
    </ul>
    <h2>Mein Angebot</h2>
    <ul>
        <li>Sicherer und stabiler Arbeitnehmer</li>
        <li>Spannendes, eigenständiges und herausforderndes Aufgabengebiet mit Selbstverantwortung</li>
        <li>Guter Teamspirit und kollegiales Miteinander</li>
        <li>Kurze Entscheidungswege, flache Hierarchien</li>
        <li>TOP Arbeitsatmosphäre und Team-Events</li>
        <li>Privatnutzung der Arbeitsausstattung (Handy und Notebook)</li>
        <li>Fortbildungsmöglichkeiten (interne Workshops, Bücher, Seminare, Konferenzen, Lernplattformen)</li>
        <li>Beteiligung am Firmenerfolg über ein Provisionsmodell</li>
        <li>Essensgutscheine (Sodexo), gratis Kaffee, Tee, Obst und Mineralwasser</li>
        <li>Homeoffice-Möglichkeit nach Absprache</li>
    </ul>
    <h2>Gehaltsinformation</h2>
    <p>Ich erwarte mir eine leistungsgerechte Entlohnung; dabei sollte mein Bruttogehalt mit dem der erfahrenen SoftwareentwicklerInnen, die mich bei der hochqualitativen Umsetzung der Anforderungen unterstützen, korrelieren.</p>
    <div class="red-label">
        <img class="red-label-illustration" src="~/img/red-label.svg" alt="IT for innovators." />
    </div>    
</article>
```

### Styling

```css
@font-face {
    font-display: swap;
    font-family: "Apex New Book";
    src: local("Apex New Book"), url('../fonts/apex-new-book.woff') format('woff');
}

@font-face {
    font-display: swap;
    font-family: "Apex New Medium";
    src: local("Apex New Medium"), url('../fonts/apex-new-medium.woff') format('woff');
}

@font-face {
    font-display: swap;
    font-family: "Apex Rounded Medium";
    src: local("Apex Rounded Medium"), url('../fonts/apex-rounded-medium.woff') format('woff');
}

:root {
    --bright-red: #f00f40;
    --dark-gray: #2b2a2f;
    --light-gray: #ebeced;
    --pure-black: #000;
    --pure-white: #fff;
}

*,
::after,
::before {
    box-sizing: border-box;
}

body {
    color: var(--dark-gray);
    font-family: "Apex New Book", sans-serif;
    line-height: 1.3;
    margin: 60px auto;
    max-width: 1140px;
}

img {
    display: block;
}

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

nav {
    padding: 60px;
}

address {
    font-style: normal;
    margin-bottom: 40px;
}

a {
    text-decoration: none;
    color: var(--dark-gray);
}

    a:hover {
        text-decoration: underline;
        color: var(--pure-black);
    }

.button {
    background-color: var(--dark-gray);
    border: none;
    color: var(--pure-white);
    font-family: "Apex New Medium", sans-serif;
    font-size: 16px;
    padding: 14px 50px;
    display: inline-block;
}

    .button:hover {
        background-color: var(--pure-black);
        color: var(--pure-white);
        text-decoration: none;
    }

article {
    border-right: 1px solid var(--light-gray);
    border-bottom: 1px solid var(--light-gray);
    padding: 60px;
}

h1,
h2,
.h2 {
    font-family: "Apex New Medium", sans-serif;
    line-height: 1.2;
}

h1 {
    font-size: 50px;
    margin: 0 0 20px;
}

h2,
.h2 {
    font-size: 18px;
    margin: 40px 0 10px;
}

h2 {
    color: var(--bright-red);
}

p {
    margin: 0 0 20px;
}

.lead {
    font-size: 22px;
}

ul {
    margin: 0;
}

.red-label {
    display: flex;
    justify-content: flex-end;
    margin-top: 32px;
}

.red-label-illustration {
    margin-right: -61px;
    width: 250px;
}
```


https://jeremylindsayni.wordpress.com/2019/02/18/adding-middleware-to-your-net-core-mvc-pipeline-that-formats-and-indents-html-output/

~~Miteinander weiter denken ist aus 2 Schriftarten gesetzt, die sich nur geringfügig unterscheiden; schaut nicht nach einem vollständigen Satz aus (Punkt); schlecht / inkosequent ausgerichtet~~

~~Auf karriere.at überschneidet sich das Logo mit dem Photo~~






Mit freundlichen Grüßen,
Nikita Sharov


Dies würde eine gewisse Transparenz sowie . Von einem echten Team, dessen Mitglieder einer Berufung nachgehen, sollte es kein Problem sein.

Die logische Document Outline ist inkonsistent.

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
