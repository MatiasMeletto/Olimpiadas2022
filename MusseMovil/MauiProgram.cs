using Microsoft.AspNetCore.Components.WebView.Maui;
using MusseMovil.Data;
using MusseMovil.Services;

namespace MusseMovil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddHttpClient();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddScoped<IMapaService, MapaService>();
            builder.Services.AddScoped<IResenaService, ResenaService>();

            return builder.Build();
        }
    }
}