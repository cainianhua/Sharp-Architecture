namespace SharpArch.RavenDb
{
    using Raven.Client;

    using SharpArch.Domain.DomainModel;
    using SharpArch.Domain.PersistenceSupport;
    using SharpArch.RavenDb.Contracts.Repositories;

    public class RavenDbRepository<T> : RavenDbRepositoryWithTypedId<T, int>,
        IRavenDbRepository<T>,
        ILinqRepository<T>
        where T : EntityWithTypedId<int>
    {
        public RavenDbRepository(IDocumentSession session) : base(session)
        {
        }
    }
}