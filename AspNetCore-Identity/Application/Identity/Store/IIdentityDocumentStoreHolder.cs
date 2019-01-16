using Raven.Client.Documents;

namespace Identity.Service.Application.Identity.Store
{
    public interface IIdentityDocumentStoreHolder
    {
        IDocumentStore Store { get; }
    }
}
