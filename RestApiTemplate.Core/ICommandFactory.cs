namespace RestApiTemplate.Core
{
    public interface ICommandFactory
    {
        T ResolveCommand<T>()
            where T : class, ICommand;
    }
}