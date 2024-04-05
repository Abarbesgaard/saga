using Debugger = Debugland.Debugger;
namespace Saga.Model
{
    public class Randomizer
    {
        private readonly CardList? _cards = new();

        public List<OccupationCard> RandomDifficultyOccupationCard(char character, int availableCards)
        {
            Debugger.MethodInitiated("RandomDifficultyOccupationCard");
            var cards = _cards.GetOccupationCards().Where(card => card.Deck == character).ToList();
            var random = new Random();
            var selectedCards = new List<OccupationCard>();
            var imageMapper = new CardImageMapper();

            for (int i = 0; i < availableCards; i++)
            {
                Debugger.ForLoopInitiated();
                int randomIndex = random.Next(cards.Count);
                Debugger.Variable("randomIndex", $"{randomIndex}");

                var selectedCard = cards[randomIndex];
                Debugger.Variable("selectedCard", $"{selectedCard}");

                selectedCard.Image = imageMapper.GetImageForCard(selectedCard.Name);
                Debugger.Variable("selectedCard.Image", $"{selectedCard.Image}");

                selectedCards.Add(selectedCard);

                cards.RemoveAt(randomIndex);
            }
            Debugger.MethodTerminated("RandomDifficultyOccupationCard");
            return selectedCards;
        }
        public List<OccupationCard> RandomOccupationCard(int userInput)
        {
            Debugger.MethodInitiated("RandomOccupationCard");
            var cards = _cards.GetOccupationCards().Where(card => card.EnumOccuCard == EnumOccuCard.Occupation_Card).ToList();
            Debugger.Variable("cards", $"{cards}");
            var random = new Random();
            Debugger.Variable("random", $"{random}");
            var selectedCards = new List<OccupationCard>();
            Debugger.Variable("selectedCards", $"{selectedCards}");
            var imageMapper = new CardImageMapper();
            Debugger.Variable("imageMapper", $"{imageMapper}");


            for (int i = 0; i < userInput; i++)
            {
                Debugger.ForLoopInitiated();
                int randomIndex = random.Next(cards.Count);
                Debugger.Variable("randomIndex", $"{randomIndex}");

                var selectedCard = cards[randomIndex];
                Debugger.Variable("selectedCard", $"{selectedCard}");

                selectedCard.Image = imageMapper.GetImageForCard(selectedCard.Name);
                Debugger.Variable("selectedCard.Image", $"{selectedCard.Image}");

                selectedCards.Add(selectedCard);

                cards.RemoveAt(randomIndex);
            }
            Debugger.ForLoopTerminated();
            Debugger.MethodTerminated("RandomOccupationCard");
            return selectedCards;
        }

        public OccupationCard RandomStartingOccupationCard()
        {


            var cards = _cards.GetOccupationCards().Where(card => card.EnumOccuCard == EnumOccuCard.starting_Occupation_Card).ToList();

            if (cards.Count == 0)
            {
                return null; // If there are no cards matching the criteria, return null or handle the scenario accordingly
            }

            var random = new Random();


            var randomIndex = random.Next(cards.Count);


            var selectedCard = cards[randomIndex];


            var imageMapper = new CardImageMapper();


            selectedCard.Image = imageMapper.GetImageForCard(selectedCard.Name);

            return selectedCard;
        }

        public OccupationCard RandomDifficultyStartingOccupationCard(char character)
        {
            Debugger.MethodInitiated("RandomDifficultyStartingOccupationCard");
            var cards = _cards.GetOccupationCards().Where(card => card.Deck == character).ToList();
            Debugger.Variable("cards", $"{cards}");
            if (cards.Count == 0)
            {
                Debugger.IfInitiated();
                Debugger.IfTerminated();
                return null; // If there are no cards matching the criteria, return null or handle the scenario accordingly
            }

            var random = new Random();
            Debugger.Variable("random", $"{random}");


            var randomIndex = random.Next(cards.Count);
            Debugger.Variable("randomIndex", $"{randomIndex}");


            var selectedCard = cards[randomIndex];
            Debugger.Variable("selectedCard", $"{selectedCard}");


            var imageMapper = new CardImageMapper();
            Debugger.Variable("imageMapper", $"{imageMapper}");


            selectedCard.Image = imageMapper.GetImageForCard(selectedCard.Name);
            Debugger.Variable("selectedCard.Image", $"{selectedCard.Image}");

            Debugger.MethodInitiated("RandomDifficultyStartingOccupationCard");

            return selectedCard;
        }
    }
}
