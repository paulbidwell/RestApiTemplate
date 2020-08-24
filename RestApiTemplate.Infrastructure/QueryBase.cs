using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core;

namespace RestApiTemplate.Infrastructure
{
    public abstract class QueryBase<TContext> : IQuery
        where TContext : DbContext
    {
        protected readonly TContext DbContext;

        protected QueryBase(TContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}