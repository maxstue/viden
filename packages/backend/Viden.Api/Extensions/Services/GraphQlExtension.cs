using Viden.Api.GraphQl.Resolvers;
using Viden.Application.UseCases.Article;

namespace Viden.Api.Extensions.Services;

internal static class GraphQlExtension
{
    internal static IServiceCollection AddCustomGraphQl(this IServiceCollection services,
        IConfiguration configuration)
    {
        // var graphQlOptions = configuration.GetSection(nameof(ApplicationOptions.GraphQl)).Get<GraphQlOptions>();
        return services.AddGraphQLServer()
                .AddQueryType<RootQueryResolver>()
                .AddTypeExtension<ArticleQueryResolver>()
                // .AddMutationType<RootMutationResolver>()
                // .AddAuthorization()
                // .AddDirectiveType<DeferDirectiveType>()
                // .AddProjectScalarTypes()
                // .AddProjectDirectives()
                // .AddProjectDataLoaders()
                // .AddProjectTypes()
                .AddProjections()
                .AddFiltering()
                .AddSorting()
                // .AddApolloTracing() // onDemand: add "GraphQl-tracing": 1 to http Header
                // .EnableRelaySupport()
                // .TrimTypes()
                // .ModifyOptions(options => options.UseXmlDocumentation = false)
                // .AddMaxComplexityRule(graphQlOptions.MaxAllowedComplexity)
                // .AddMaxExecutionDepthRule(graphQlOptions.MaxAllowedExecutionDepth)
                // .SetPagingOptions(graphQlOptions.Paging)
                // .SetRequestOptions(() => graphQlOptions.Request)
                .Services
            ;
    }
}