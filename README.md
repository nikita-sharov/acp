# Expressiveness, law, and order

[![Build status](https://dev.azure.com/235u/acp/_apis/build/status/full-stack-developer%20-%20CI)](https://dev.azure.com/235u/acp/_build/latest?definitionId=3)

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