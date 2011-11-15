namespace KojackGames.Blackjack.Infrastructure.Cqrs.Command
{
    public class InProcessCommandBus : ICommandBus
    {
        private readonly ICommandHandlerRegistry _command_handler_registry;

        public InProcessCommandBus(ICommandHandlerRegistry command_handler_registry)
        {
            _command_handler_registry = command_handler_registry;
        }

        public void send<TCommand>(TCommand command) where TCommand : ICommand 
        {            
            _command_handler_registry.find_handler_for(command).handle(command);
        }
    }
}