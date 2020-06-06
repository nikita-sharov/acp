# Expressiveness, law, and order

[![Azure DevOps builds](https://img.shields.io/azure-devops/build/235u/acp/3?style=for-the-badge)](https://dev.azure.com/235u/acp/_build?definitionId=3)
[![Azure DevOps releases](https://img.shields.io/azure-devops/release/235u/27f9276e-b3a3-4db4-87b8-3d67e46cd9ae/1/1?style=for-the-badge)](https://dev.azure.com/235u/acp/_release?definitionId=1)
[![Mozilla HTTP Observatory](https://img.shields.io/mozilla-observatory/grade/acp.235u.net?publish&style=for-the-badge)](https://observatory.mozilla.org/analyze/acp.235u.net)
[![W3C Validation](https://img.shields.io/w3c-validation/html?style=for-the-badge&targetUrl=https%3A%2F%2Facp.235u.net)](https://validator.w3.org/nu/?doc=https%3A%2F%2Facp.235u.net%2F)

![GitHub language count](https://img.shields.io/github/languages/count/nikita-sharov/acp?style=for-the-badge)
[![GitHub top language](https://img.shields.io/github/languages/top/nikita-sharov/acp?style=for-the-badge)](https://github.com/search?q=repo%3A235u%2FActinUranium.Web+language%3AC%23&type=Code&ref=advsearch&l=C%23)

## Layout

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
        <div class="masthead-slogan">Miteinander<br />weiter denken.</div>
    </header>
    <div class="container">
        <aside>
            <partial name="_Sidebar" />
        </aside>
        <main>
            @RenderBody()
        </main>
    </div>
</body>
</html>
```