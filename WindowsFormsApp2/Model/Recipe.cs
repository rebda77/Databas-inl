﻿namespace WindowsFormsApp2.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public RecipeCategory Category { get; set; }


        
    }
}