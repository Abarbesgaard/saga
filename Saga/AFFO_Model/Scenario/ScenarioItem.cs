using System.ComponentModel.DataAnnotations;

namespace Saga.Model.Scenario
{
    public class ScenarioItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public DifficultyLevel DifficultyLevel{ get; set; }

        public string Type { get; set; }
        public string TypeDescription { get; set; }
        public string Name { get; internal set; }

        public CardList LinkedCardList { get; set; }
        public ScenarioItem()
        {
            
        }

    }
}
