using Microsoft.AspNetCore.Components.WebView.Maui;
using MusseMovil.Data;

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
            return builder.Build();

        https://learn.microsoft.com/es-es/aspnet/core/blazor/call-web-api?view=aspnetcore-6.0&pivots=server
        }
    }
}