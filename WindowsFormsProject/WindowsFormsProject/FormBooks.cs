using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Data;

namespace WindowsFormsProject
{
    public partial class FormBooks : Form
    {
        private DBUser dBUserContext;
        public FormBooks()
        {
            InitializeComponent();
            dBUserContext = new DBUser();
            var types = dBUserContext.UserTypes.ToList();
          
            refreshGrid();
        }

       

        private void refreshGrid()
        {
            BindingSource bi = new BindingSource();

            var query = from b in dBUserContext.Books
                        orderby b.Title
                        select new { b.Id, b.Title, Autor = b.Author.Nume+" "+b.Author.Prenume, AnAparitie=b.Year, Pret=b.Price};

            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTitlu_Click(object sender, EventArgs e)
        {

        }

        private void labelGrafic_Click(object sender, EventArgs e)
        {

        }

        private void labelCautaAutor_Click(object sender, EventArgs e)
        {

        }

        private void labelCautaTitlu_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNumeA.SelectedText != null && textBoxAn != null && textBoxPrenumeA != null
                && textBoxTitlu != null && textBoxPret!= null)
            {
                CreateBook();
                refreshGrid();
                //ClearInputData();
            }

            else
            {
                MessageBox.Show("Va rugam sa introduceti toate datele!");
            }

        }

        private void CreateBook()
        {
            var author= new Author
            {
               Nume = textBoxNumeA.Text,
                Prenume = textBoxPrenumeA.Text,
            };

            dBUserContext.Authors.AddOrUpdate(author);

            var book = new Book
            {
                AuthorId = author.Id,
                Title = textBoxTitlu.Text,
                Year = int.Parse(textBoxAn.Text),
                Price=decimal.Parse(textBoxPret.Text)
            };

            dBUserContext.Books.Add(book);
            dBUserContext.SaveChanges();
        }


        private void DeleteBook()
        {
            var t = dBUserContext.Books.Find((int)dataGridView1.SelectedCells[0].Value);
            dBUserContext.Books.Remove(t);
            dBUserContext.SaveChanges();
        }



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (buttonUpdate.Text == "MODIFICA")
            {
                var t = dBUserContext.Books.Find((int)dataGridView1.SelectedCells[0].Value);
                var a = dBUserContext.Authors.Find(t.AuthorId);
                textBoxTitlu.Text = t.Title;
                textBoxNumeA.Text = t.Author.Nume;
                textBoxPrenumeA.Text = t.Author.Prenume;
                textBoxPret.Text = t.Price.ToString();
                textBoxAn.Text = t.Year.ToString();
                buttonUpdate.Text = "Save";
            }
            else
            {
                int userId = (int)dataGridView1.SelectedCells[0].Value;
                var updateBook = dBUserContext.Books.Find((int)dataGridView1.SelectedCells[0].Value);
                var updateAuthor = dBUserContext.Authors.Find(updateBook.AuthorId);

                updateBook.Title = textBoxTitlu.Text;
                updateBook.Price = decimal.Parse(textBoxPret.Text);
                updateBook.Year = int.Parse(textBoxAn.Text);
                updateAuthor.Nume = textBoxNumeA.Text;
                updateAuthor.Prenume = textBoxPrenumeA.Text;
                dBUserContext.SaveChanges();
                refreshGrid();
                ClearInputData();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            buttonUpdate.Text = "MODIFICA";
            ClearInputData();
        }
        private void ClearInputData()
        {
            textBoxTitlu.Text = string.Empty;
            textBoxNumeA.Text = string.Empty;
            textBoxPrenumeA.Text = string.Empty;
            textBoxPret.Text = string.Empty;
            textBoxAn.Text = string.Empty;
       
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteBook();
            ClearInputData();
            refreshGrid();
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            FormAdmin settingsForm = new FormAdmin();
            settingsForm.Show();
        }
    }
}
