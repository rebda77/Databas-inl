using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Model;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<Recipe> recipes = new List<Recipe>();

        public Form1()
        {
            InitializeComponent();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var repository = new RecipeRepository();
            
            string title = titleTextBox.Text;
            string category = categoryTextBox.Text;
            var coll = repository.Search(title, category);
            
            dataGridView1.DataSource = coll.Select(r=>new
            {
                Id = r.Id, 
                Titel = r.Title,
                Kategori = r.Category.Name
            }).ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormNewRecipe();
            form.ShowDialog();
        }

        

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
