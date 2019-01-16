using Identity.Service.Application.Identity.Store;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

public static class IdentityBuilderExtensions
{
    public static IdentityBuilder AddRavenDBDataStoreAdaptor<TDocumentStoreHolder>(
        this IdentityBuilder builder
    ) where TDocumentStoreHolder : class, IIdentityDocumentStoreHolder
        => builder
            .AddRavenDBUserStore()
            .AddRavenDBRoleStore<TDocumentStoreHolder>();

    private static IdentityBuilder AddRavenDBUserStore(
        this IdentityBuilder builder
    )
    {
        var userStoreType = typeof(RavenDBUserStore<>).MakeGenericType(builder.UserType);

        builder.Services.AddScoped(
            typeof(IUserStore<>).MakeGenericType(builder.UserType),
            userStoreType
        );

        return builder;
    }

    private static IdentityBuilder AddRavenDBRoleStore<TDocumentStoreHolder>(
        this IdentityBuilder builder
    ) where TDocumentStoreHolder : class, IIdentityDocumentStoreHolder
    {
        var roleStoreType = typeof(RavenDBRoleStore<,>).MakeGenericType(builder.RoleType, typeof(TDocumentStoreHolder));

        builder.Services.AddScoped(
            typeof(IRoleStore<>).MakeGenericType(builder.RoleType),
            roleStoreType
        );

        return builder;
    }
}
