# Expressiveness, law, and order

[![Azure DevOps builds](https://img.shields.io/azure-devops/build/235u/acp/3?style=for-the-badge)](https://dev.azure.com/235u/acp/_build?definitionId=3)
[![Azure DevOps releases](https://img.shields.io/azure-devops/release/235u/27f9276e-b3a3-4db4-87b8-3d67e46cd9ae/1/1?style=for-the-badge)](https://dev.azure.com/235u/acp/_release?definitionId=1&_a=deployments)
[![Website](https://img.shields.io/website?style=for-the-badge&url=https%3A%2F%2Facp.235u.net)](https://acp.235u.net)
[![W3C Validation](https://img.shields.io/w3c-validation/html?style=for-the-badge&targetUrl=https%3A%2F%2Facp.235u.net)](https://validator.w3.org/nu/?doc=https%3A%2F%2Facp.235u.net%2F)
[![Mozilla HTTP Observatory](https://img.shields.io/mozilla-observatory/grade/acp.235u.net?publish&style=for-the-badge)](https://observatory.mozilla.org/analyze/acp.235u.net)

```razor
<!DOCTYPE html>
<html lang="de">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no" />
    <meta name="keywords" content="ASP.NET Core, Azure App Service, C#, CSS, HTML, Microsite, Optimierung" />
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
        <div class="masthead-slogan">Prudentia<br />potentia est.</div>
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