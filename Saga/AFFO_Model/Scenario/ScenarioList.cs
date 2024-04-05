namespace Saga.Model.Scenario
{
    public class ScenarioList
    {
        private ScenarioItem scenarioItem {  get; set; }

        public List<ScenarioItem> LinkedCardList{ get; set; }



        //Scnarie listen skal indeholde en liste over scenarier
        // Denne liste kan være en campaign som ruller over 3-5 plays
        // den skal indeholde 3,5 scenario items som er linked til CardList


    }
}
