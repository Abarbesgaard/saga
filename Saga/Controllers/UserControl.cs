using Saga.Model;
using Saga.Model.Scenario;
namespace Saga.Controllers
{
    public class UserControl
    {

        readonly CardList? cardList = new();
        readonly Randomizer? randomizer = new();
        private readonly ScenarioManager? scenarioManager;
        public UserControl()
        {
            cardList = new CardList();
            scenarioManager = new ScenarioManager(new());
        }

        public List<OccupationCard> GetCards()
        {
            return cardList?.GetOccupationCards() ?? [];
        }
        public List<OccupationCard> GetRandomOccupationCard(int availableCards)
        {

            return randomizer?.RandomOccupationCard(availableCards) ?? [];
        }
        public OccupationCard GetRandomStartingOccupationCard()
        {

            return randomizer?.RandomStartingOccupationCard() ?? new OccupationCard();
        }
        public void GenerateScenarios()
        {
            // Tjek om scenarioManager er initialiseret
            if (scenarioManager != null)
            {
                // Kalder GenerateScenarios-metoden på ScenarioManager
                scenarioManager.GenerateScenarios();
            }
            else
            {
                // Håndter tilfælde hvor scenarioManager ikke er initialiseret
                // Dette kan være en fejl i koden, så det er vigtigt at logge eller informere om det.
                Console.WriteLine("Error: scenarioManager is not initialized.");
                // Alternativt kan du kaste en exception eller håndtere dette på anden måde afhængigt af din applikations krav.
            }
        }
        public void GenerateScenarioWithDifficulty()
        {
            if (scenarioManager != null)
            {
                scenarioManager.GenerateScenarios();
            }
            else
            {
                Console.WriteLine("Error: scenarioManager is not initialized.");
            }
        }      
        public List<OccupationCard> GetRandomDifficultyOccupationCard(char character, int availableCards)
        {

            return randomizer?.RandomDifficultyOccupationCard(character, availableCards) ?? [];
        }
        public OccupationCard GetRandomDifficultyStartingOccupationCard(char character)
        {

            return randomizer?.RandomDifficultyStartingOccupationCard(character) ?? new OccupationCard();
        }
        
    }
}
