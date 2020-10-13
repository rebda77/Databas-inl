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
    public partial class FormNewRecipe : Form
    {
        public FormNewRecipe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var repository = new RecipeRepository();
            repository.Add(new Recipe
            {
                Title = textBox1.Text,
                Description = textBox2.Text
            });
            Close();
        }
    }
}
