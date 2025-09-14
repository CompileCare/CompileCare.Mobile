using Compilecare.Application.UseCases;
using Compilecare.Infrastructure.API;
using Microsoft.Extensions.Logging;

namespace Compilecare.Mobile
{
    //(.NET MAUI Project: Views, ViewModels, Resources)
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            const string ApiBaseUrl = "https://api.yourserver.com";
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(ApiBaseUrl);
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
