# Configuration

```csharp
[SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Predefined")]
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
            app.UseContentTypeOptions();
            app.UseContentSecurityPolicy();
            app.UseFrameOptions();
            app.UseReferrerPolicy();
        }

        app.UseDeveloperExceptionPage();
        app.UseHttpsRedirection();
        app.UseStaticFiles(StaticFileOptionsFactory.Create());
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
    }
}
```

## Documentation

```csharp
public static class ApplicationBuilderExtensions
{
    /// <summary>
    /// Sets the <c>X-Content-Type-Options</c> response header to prevent XSS attacks.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks>
    /// <c>X-Content-Type-Options</c> is a non-standard HTTP header telling browsers not to load scripts and
    /// stylesheets unless the server indicates the correct MIME type.
    /// </remarks>
    /// <seealso href="https://infosec.mozilla.org/guidelines/web_security#x-content-type-options">
    /// Mozilla's Web Security Guidelines, X-Content-Type-Options
    /// </seealso>
    public static IApplicationBuilder UseContentTypeOptions(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
            await next();
        });

    /// <summary>
    /// Sets the <c>Content Security Policy</c> response header to prevent XSS attacks.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks>
    /// <para>
    /// Content Security Policy header controls where resources can be loaded from, being the best method to prevent
    /// cross-site scripting (XSS) attacks.
    /// </para>
    /// <para>
    /// The <c>frame-ancestors</c> directive supercedes the <c>X-Frame-Options</c> header, but is not yet supported
    /// by all major browsers.
    /// </para>
    /// </remarks>
    /// <seealso cref="UseFrameOptions(IApplicationBuilder)"/>
    /// <seealso cref="https://infosec.mozilla.org/guidelines/web_security.html#content-security-policy">
    /// Mozilla's Web Security Guidelines, Content Security Policy
    /// </seealso>
    public static IApplicationBuilder UseContentSecurityPolicy(this IApplicationBuilder app)
    {
        var directives = new string[]
        {
            // Fetch directives, controlling locations from which certain resource types may be loaded:
            "connect-src 'self'",
            "default-src 'none'",
            "font-src 'self'",
            "img-src 'self'",
            "media-src 'self'",
            "script-src 'self'",
            "style-src 'self'",

            // Restricts the URLs which can be used in a document's <base> element.
            "base-uri 'none'",

            // Restricts the URLs which can be used as the target of a form submissions.
            "form-action 'self'",

            // Specifies valid parents that may embed a page using <frame>, <iframe>, <object>, <embed> or <applet>.
            "frame-ancestors 'none'"
        };

        const string Separator = "; ";
        string headerValue = string.Join(Separator, directives);

        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add(HeaderNames.ContentSecurityPolicy, headerValue);
            await next();
        });

        return app;
    }

    /// <summary>
    /// Sets the <c>X-Frame-Options</c> response header to prevent clickjacking attacks.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks><c>X-Frame-Options</c> is a HTTP header controlling site's framing within an iframe.</remarks>
    /// <seealso href="https://infosec.mozilla.org/guidelines/web_security#x-frame-options">
    /// Mozilla's Web Security Guidelines, X-Frame-Options
    /// </seealso>
    public static IApplicationBuilder UseFrameOptions(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add("X-Frame-Options", "DENY");
            await next();
        });

    /// <summary>
    /// Sets the <c>Referrer-Policy</c> header to honor user's privacy.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks>
    /// The original header name <c>Referer</c> is a misspelling of the word "referrer". The <c>Referrer-Policy</c>
    /// header does not share this misspelling.
    /// </remarks>
    /// <seealso href="https://infosec.mozilla.org/guidelines/web_security#referrer-policy">
    /// Mozilla's Web Security Guidelines, Referrer Policy
    /// </seealso>
    public static IApplicationBuilder UseReferrerPolicy(this IApplicationBuilder app) =>
        app.Use(async (context, next) =>
        {
            context.Response.Headers.Add("Referrer-Policy", "same-origin");
            await next();
        });
}
```

## Creation

```csharp
public static class StaticFileOptionsFactory
{
    public static StaticFileOptions Create() =>
        new StaticFileOptions
        {
            OnPrepareResponse = (context) =>
            {
                const int CachePeriodInSeconds = 31_536_000; // 1 year
                string cacheControlHeaderValue = $"public, max-age={CachePeriodInSeconds}";
                context.Context.Response.Headers.Append(HeaderNames.CacheControl, cacheControlHeaderValue);
            }
        };
}
```