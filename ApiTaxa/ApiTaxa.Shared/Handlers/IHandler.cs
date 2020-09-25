using ApiTaxa.Shared.Commands;

namespace ApiTaxa.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
         ICommandResult Handle(T command);
    }
}