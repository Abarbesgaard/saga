using Debugger = Debugland.Debugger;
namespace Saga.Model.Scenario
{
    public class ScenarioManager(CardList cardList)
    {
        private readonly List<ScenarioItem> scenarioList = [];
        private readonly CardList linkedCardList = cardList;

        public void GenerateScenarios()
        {
            Debugger.MethodInitiated("GenerateScenarios");
            Debugger.ForLoopInitiated();
            // Generate 3 to 5 scenarios
            for (int i = 1; i <= 5; i++)
            {
                // Create a new scenario item
                ScenarioItem? scenarioItem = new()
                {
                    Title = $"Scenario {i}",
                    Description = $"Description for Scenario {i}",
                    DifficultyLevel = DifficultyLevel.Medium,
                    // Link scenario to CardList
                    LinkedCardList = linkedCardList,

                };
                Debugger.Variable("Scenario", $"{scenarioItem}");

                // Add scenario item to the scenario list
                scenarioList.Add(scenarioItem);
            }
            Debugger.ForLoopTerminated();

            Debugger.MethodTerminated("GenerateScenarios");
        }
        public void GenerateEasyScenario()
        {
            Debugger.MethodInitiated("GenerateScenarios");
            Debugger.ForLoopInitiated();
            // Generate 3 to 5 scenarios
            for (int i = 1; i <= 5; i++)
            {
                // Create a new scenario item
                ScenarioItem scenarioItem = new()
                {
                    Title = $"Scenario {i}",
                    Description = $"Description for Scenario {i}",
                    DifficultyLevel = DifficultyLevel.Medium,
                    // Link scenario to CardList
                    LinkedCardList = linkedCardList,

                };
                Debugger.Variable("Scenario", $"{scenarioItem}");

                // Add scenario item to the scenario list
                scenarioList.Add(scenarioItem);
            }
            Debugger.ForLoopTerminated();

            Debugger.MethodTerminated("GenerateScenarios");
        }
    }
}
