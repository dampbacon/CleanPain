using Microsoft.Extensions.DependencyInjection;
using ScopedVmBundleClean.Application.SetText;
using ScopedVmBundleClean.Application.ValidateText;
using ScopedVmBundleClean.Presentation.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopedVmBundleClean.Services
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection TestViewModelServices(this IServiceCollection services)
        {
            services.AddTransient<TestViewModel>();
            services.AddTransient<TextPresenter>();
            services.AddTransient<ValidationPresenter>();
            services.AddTransient<LoadTextUseCase>();
            services.AddTransient<ValidateTextUseCase>();
            return services;
        }

    }

}
