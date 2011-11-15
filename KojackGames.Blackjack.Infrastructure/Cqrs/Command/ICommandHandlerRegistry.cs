namespace KojackGames.Blackjack.Infrastructure.Cqrs.Command
{
    public interface ICommandHandlerRegistry
    {
        ICommandHandler<TCommand> find_handler_for<TCommand>(TCommand command) where TCommand : ICommand;
    }
}