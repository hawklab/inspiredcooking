using System.Text.Json.Serialization;

namespace InspiredCooking.Core
{
    public class Step
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        // Reference property
        [JsonIgnore]
        public Recipe Recipe { get; set; }

        //Explicit integer property containing the foreign key value
        public int RecipeId { get; set; }
    }
}
