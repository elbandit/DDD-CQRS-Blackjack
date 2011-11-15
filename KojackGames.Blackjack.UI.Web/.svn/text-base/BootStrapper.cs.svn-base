using System.Collections.Generic;
using System.Web;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Actions;
using KojackGames.Blackjack.Domain.GamePlay.Model.Dealer.Observations;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Dealer;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using KojackGames.Blackjack.Domain.Membership;
using KojackGames.Blackjack.Domain.Membership.Model;
using KojackGames.Blackjack.Infrastructure;
using KojackGames.Blackjack.Infrastructure.Authentication;
using KojackGames.Blackjack.Infrastructure.Cqrs.Command;
using KojackGames.Blackjack.Infrastructure.Cqrs.Query;
using KojackGames.Blackjack.Infrastructure.Domain;
using KojackGames.Blackjack.Infrastructure.Nhibernate;
using KojackGames.Blackjack.Infrastructure.Nhibernate.EventHandlers;
using KojackGames.Blackjack.UI.Web.Models;
using NHibernate;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace KojackGames.Blackjack.UI.Web
{
    public class BootStrapper
    {
        public static void configure_dependencies()
        {
            ObjectFactory.Initialize(x =>
            {
                x.AddRegistry<ControllerRegistry>();
                x.AddRegistry<CommandHandlerRegistry>();
                x.AddRegistry<CommandMappersRegistry>();
                x.AddRegistry<DomainRegistry>();
                x.AddRegistry<DomainEventHandlerRegistry>();
                
            });            
        }

        public class CommandMappersRegistry : Registry
        {
            public CommandMappersRegistry()
            {
                Scan(s =>
                {
                    s.TheCallingAssembly();
                    s.ConnectImplementationsToTypesClosing(typeof(ICommandMapper<,>));
                });   
            }
        }

        public class CommandHandlerRegistry : Registry
        {
            public CommandHandlerRegistry()
            {
                Scan(s =>
                {
                    s.Assembly("KojackGames.Blackjack.Domain");
                    s.ConnectImplementationsToTypesClosing(typeof(ICommandHandler<>));                    
                });
            }
        }

        public class DomainEventHandlerRegistry : Registry
        {
            public DomainEventHandlerRegistry()
            {
                Scan(s =>
                {
                    s.Assembly("KojackGames.Blackjack.Infrastructure.Nhibernate");
                    s.ConnectImplementationsToTypesClosing(typeof(IDomainEventHandler<>));
                });
            }
        }
  
        public class DomainRegistry : Registry
        {
            public DomainRegistry()
            {
                For<IPlayerAuthenticator>().Use<HttpPlayerAuthenticator>();
                For<IBlackJackTableFactory>().Use<BlackJackTableFactory>();
                For<IHandScorer>().Use<HandScorer>();
                For<IHandStatusFactory>().Use<HandStatusFactory>();
                For<ICardShoe>().Use<CardShoe>();
                For<Deck>().Use<Deck>();

                For<ICanHitDealerSpecification>().Use<CanHitDealer>();
                For<ICanDoubleDown>().Use<CanDoubleDown>();
                For<ICanSplit>().Use<CanSplit>();
                For<ICanTakeInsurance>().Use<CanTakeInsurance>();
                For<IHasBlackjackSpecification>().Use<HasBlackJack>();
                For<IHasBustedSpecification>().Use<HasBust>();
                For<ISpecification<IDealersHand>>().Use<CanHitDealer>();
                For<IHasSoftBlackJackSpecification>().Use<HasSoftBlackJack>();
                For<IAnnouceWinnerAction>().Use<AnnouceWinnerAction>();
                For<IPlayDealersHand>().Use<PlayDealersHand>();

                For<ICommandHandlerRegistry>().Use<StructureMapCommandHandlerRegistry>();

                DomainEvents.set_registry(new StructureMapDomainEventHandlerRegistry());
                
                For<IUnitOfWorkFactory>().Use<NhUnitOfWorkFactory>();
                For<IRepository<BlackJackTable>>().Use<NhRepository<BlackJackTable>>();
                For<IRepository<Player>>().Use<NhRepository<Player>>();
                For<IReadRepository<MembershipEvent>>().Use<NhReadRepository<MembershipEvent>>();                

                For<ISession>().HttpContextScoped().Use(SessionFactory.GetNewSession);   
            }
        }
        
        public class ControllerRegistry : Registry
        {
            public ControllerRegistry()
            {
                For<ICommandBus>().Use<InProcessCommandBus>();                
                For<IQueryService>().Use<NhQueryService>();
                For<IFormsAuthentication>().Use<AspFormsAuthentication>();
                For<ILocalAuthenticationService>().Use<AspMembershipAuthorisation>();
                             
            }
        }
    }
}