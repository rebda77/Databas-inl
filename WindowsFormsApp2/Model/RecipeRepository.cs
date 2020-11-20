using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp2.Model
{

    public class RecipeRepository
    {
        public List<Recipe> GetAllRecipes(int id)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Query<Recipe>("select * from recipe").ToList();
            }
        }

        public List<Recipe> GetAll()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return conn.Query<Recipe>("select * from recipes").ToList();
            }
        }

        public void Insert(Recipe recipe)
        {

            string sql = @"
INSERT INTO [Recipe]
            ([Title]
            ,[Description]
            ,[Ingredients]
            ,[Category])
    VALUES
            (@Title
            ,@Description
            ,@Ingredients
            ,@Category)
GO

";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.Execute(sql, recipe);
            }

            

        }

        public void Update(Recipe recipe)
        {
            string sql = @"UPDATE [Recipes]
    SET [Title] = @Title
       ,[Description] = @Description
       ,[Ingredients] = @Ingrediens
       ,[Category] = @Category
    WHERE ID = @RID
";
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.Execute(sql, recipe);
            }
        }

        public void Delete(Recipe recipe)
        {
            var sql = "DELETE Recipe WHERE id = @Id";

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                conn.Execute(sql, recipe);
            }
        }

    }
    

    
}
    