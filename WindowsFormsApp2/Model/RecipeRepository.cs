using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2.Model
{
    public class RecipeRepository
    {
        private static List<RecipeCategory> _receiptCategories;
        private static List<Recipe> _receipts;

        public RecipeRepository()
        {
            if (_receiptCategories == null)
            {
                _receiptCategories = new List<RecipeCategory>
                {
                    new RecipeCategory { Id = 1, Name = "Asiatiskt"},
                    new RecipeCategory { Id = 2, Name = "Husmanskost"},
                };
                _receipts = new List<Recipe>
                {
                    new Recipe {Id = 1, Category = _receiptCategories.First(e=>e.Id == 1), Title = "Sushi", Ingredients = "Fisk, soja"},
                    new Recipe { Id = 2, Category = _receiptCategories.First(e => e.Id == 2), Title = "Pannkakor", Ingredients = "Mjölk,mjöl,ägg,smör,sylt" },
                    new Recipe { Id = 3, Category = _receiptCategories.First(e => e.Id == 1), Title = "Yakiniku", Ingredients = "Ris,entrocote,soja" }
                };
            }
        }
        public Recipe GetById(int id)
        {
            return _receipts.FirstOrDefault(r => r.Id == id);
        }



        public void Add(Recipe newReceipt)
        {
            newReceipt.Id = _receipts.Max(r => r.Id) + 1;
            if (newReceipt.Category == null)
                newReceipt.Category = _receiptCategories.First();
            _receipts.Add(newReceipt);
        }

        public void Update(Recipe receipt)
        {

        }

        public void Remove(int receiptId)
        {

        }


        public IEnumerable<Recipe> Search(string title, string catepory)
        {
            return _receipts.Where(r => r.Title.Contains(title));
        }



        //public IEnumerable<Recipe> GetAll()
        //{
        //    return _receipts;
        //}
    }
}