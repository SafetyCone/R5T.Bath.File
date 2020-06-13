using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.Bath.File
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddFileHumanOutput(this IServiceCollection services,
            IServiceAction<IHumanOutputFilePathProvider> addHumanOutputFilePathProvider)
        {
            services
                .AddSingleton<IHumanOutput, FileHumanOutput>()
                .RunServiceAction(addHumanOutputFilePathProvider)
                ;

            return services;
        }

        public static ServiceAction<IHumanOutput> AddFileHumanOutputAction(this IServiceCollection services,
            IServiceAction<IHumanOutputFilePathProvider> addHumanOutputFilePathProvider)
        {
            var serviceAction = ServiceAction<IHumanOutput>.New(() => services.AddFileHumanOutput(addHumanOutputFilePathProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SpecifiedHumanOutputFilePathProvider"/> implementation of <see cref="IHumanOutputFilePathProvider"/>.
        /// </summary>
        public static IServiceCollection AddSpecifiedHumanOutputFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<IHumanOutputFilePathProvider, SpecifiedHumanOutputFilePathProvider>();

            return services;
        }

        public static IServiceAction<IHumanOutputFilePathProvider> AddSpecifiedHumanOutputFilePathProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IHumanOutputFilePathProvider>.New(() => services.AddSpecifiedHumanOutputFilePathProvider());
            return serviceAction;
        }
    }
}
