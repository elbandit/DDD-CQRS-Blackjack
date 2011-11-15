namespace KojackGames.Blackjack.Infrastructure
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork create();
    }
}