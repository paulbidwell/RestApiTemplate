using System;

namespace RestApiTemplate.Core
{
    public class CommandFactory : ICommandFactory
    {
        private readonly Func<Type, object> _resolveCallback;

        public CommandFactory(Func<Type, object> resolveCallback)
        {
            _resolveCallback = resolveCallback;
        }

        public T ResolveCommand<T>()
            where T : class, ICommand
        {
            return _resolveCallback(typeof(T)) as T;
        }
    }
}