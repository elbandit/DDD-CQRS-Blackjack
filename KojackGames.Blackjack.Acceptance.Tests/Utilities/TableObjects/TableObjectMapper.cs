using KojackGames.Blackjack.Domain.GamePlay.Model.CardDeck;
using KojackGames.Blackjack.Infrastructure.Helpers;
using TechTalk.SpecFlow;

namespace KojackGames.Blackjack.Acceptance.Tests.Utilities.TableObjects
{
    public class TableObjectMapper
    {
        public CardInHandRow create_card_in_hand_row_from(TableRow row)
        {
            CardInHandRow card = new CardInHandRow();

            var suit = EnumParser.parse_enum<Suit>(row["Suit"]);
            var value = EnumParser.parse_enum<CardValue>(row["Value"]);
           
            card.suit = (int)suit;
            card.card_value = (int)value;

            card.name = string.Format("{0} of {1}", value.ToString(), suit.ToString());

            return card;
        }

        public DeckRow create_deck_row_from(TableRow row, int card_position)
        {
            DeckRow deckRow = new DeckRow();

            var suit = EnumParser.parse_enum<Suit>(row["Suit"]);
            var value = EnumParser.parse_enum<CardValue>(row["Value"]);

            deckRow.suit = (int)suit;
            deckRow.card_value = (int)value;
            deckRow.position_in_pack = card_position;
            
            return deckRow;
        }
    }
}