using static System.Net.Mime.MediaTypeNames;

namespace Saga.Model
{
    public class OccupationCard
    {
        public int Number { get; set; }
        public char Deck { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public CardAbilityType CardType{ get; set; }
        public string Image { get; set; }
        public EnumOccuCard EnumOccuCard { get; set; }
        public OccupationCard()
        {
            
        }
        public OccupationCard(int number, char deck, string name, int points, CardAbilityType cardType, string image, EnumOccuCard enumOccuCard)
        {
            Number = number;
            Deck = deck;
            Name = name;
            Points = points;
            CardType = cardType;
            Image = image;
            EnumOccuCard = enumOccuCard;
        }
        public OccupationCard(int number, char deck, string name, int points, CardAbilityType cardType, EnumOccuCard enumOccuCard)
        {
            Number = number;
            Deck = deck;
            Name = name;
            Points = points;
            CardType = cardType;
            EnumOccuCard = enumOccuCard;
        }
    }
}
