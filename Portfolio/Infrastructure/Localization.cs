using Microsoft.Extensions.Configuration;

namespace Portfolio.Infrastructure
{
    public static class Localization
    {
        public static RequestLocalizationOptions GetLocalizationOption(ConfigurationManager configuration)
        {
            var cultures = configuration.GetSection("Cultures")
                .GetChildren().ToDictionary(x => x.Key, x => x.Value);
            var supportedCultures=cultures.Keys.ToArray();
            var localizationOptions = new RequestLocalizationOptions()
                .AddSupportedCultures(supportedCultures)
                .AddSupportedUICultures(supportedCultures);
            return localizationOptions;
        }
    }
}
