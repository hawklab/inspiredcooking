namespace recipes.Core
{
    public partial class Recipe
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string PrepTime { get; set; }
        public string CookTime { get; set; }
        public int Servings { get; set; }
        public int Difficulty { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}