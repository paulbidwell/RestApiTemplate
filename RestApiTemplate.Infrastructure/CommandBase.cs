using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core;

namespace RestApiTemplate.Infrastructure
{
    public abstract class CommandBase<TContext> : ICommand
        where TContext : DbContext
    {
        protected readonly TContext DbContext;

        protected CommandBase(TContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}