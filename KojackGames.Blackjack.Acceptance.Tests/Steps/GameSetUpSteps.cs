using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KojackGames.Blackjack.Acceptance.Tests.Utilities;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.StateBuilder;
using KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects;
using KojackGames.Blackjack.Domain.GamePlay.Model;
using KojackGames.Blackjack.Domain.GamePlay.Model.PlayingPosition.Hands.Status;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace KojackGames.Blackjack.Acceptance.Tests.Steps
{
    [Binding]
    public class GameSetUpSteps
    {       
        [Given(@"the deck contains the following cards:")]
        public void GivenTheDeckContainsTheFollowingCards(Table table)
        {
            var mapper = new TableObjectMapper();
            var game_builder = new GameBuilder().find_game_by_player_id(PlayerToken.player_id);

            int card_position = 1;
            foreach(var row in table.Rows)
            {                
                game_builder.add_to_deck(mapper.create_deck_row_from(row, card_position));
                card_position++;
            }            

            var game = game_builder.build();

            DataBaseHelper.save_or_add<BlackJackTableRow>(game);
        }

        [Given(@"I have started a new game and bet ""(.*)""")]
        public void GivenIHaveStartedANewGameAndBet(decimal bet_amount)
        {            
            var game = new GameBuilder().create_for(PlayerToken.player_id)
                                         .add_dealers_hand()
                                            .with_status_of(HandStatus.in_play)
                                            .build()
                                         .add_hand_with_bet_of(bet_amount)
                                            .with_status_of(HandStatus.in_play)
                                            .set_as_active()
                                            .build()                                        
                                        .set_game_state_to(TableStatus.full_table)
                                        .build();

            DataBaseHelper.save_or_add(game);                             
        }

        [Given(@"my hand contains the following cards:")]
        public void GivenMyHandContainsTheFollowingCards(Table table)
        {
            var mapper = new TableObjectMapper();
            var game_builder = new GameBuilder().find_game_by_player_id(PlayerToken.player_id);
            var cards = new List<CardInHandRow>();
            foreach(var row in table.Rows)
                cards.Add(mapper.create_card_in_hand_row_from(row));

            game_builder.for_players_hand()
                        .add_cards(cards);

            var game = game_builder.build();

            DataBaseHelper.save_or_add(game);
        }

        [Given(@"the dealers hand contains the following cards:")]
        public void GivenTheDealersHandContainsTheFollowingCards(Table table)
        {
            var mapper = new TableObjectMapper();
            var game_builder = new GameBuilder().find_game_by_player_id(PlayerToken.player_id);
            var cards = new List<CardInHandRow>();
            foreach (var row in table.Rows)
                cards.Add(mapper.create_card_in_hand_row_from(row));

            game_builder.add_cards_to_dealers_hand(cards);

            var game = game_builder.build();

            DataBaseHelper.save_or_add(game);
        }

        [Given(@"the dealers has dealt me in")]
        public void GivenIHaveBeenDealtMyInitalTwoCards()
        {
            var game_builder = new GameBuilder().find_game_by_player_id(PlayerToken.player_id);

            var game = game_builder.set_game_state_to(TableStatus.hands_dealt)
                                    .mark_cards_as_dealt()
                                    .add_dealers_hand()
                                        .with_status_of(HandStatus.in_play)                                           
                                        .build()
                                    .build();
                                                    
            DataBaseHelper.save_or_add(game);
        }

    }
}
