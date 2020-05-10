using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Windows.Forms;
using WindowsFormsProject.Data;
using DataAccess;

namespace WindowsFormsProject
{
    public partial class FormUsers : Form
    {
        private DBUser dBUserContext;
       // private UserRepository userRepository;
        public FormUsers()
        {
            InitializeComponent();
            dBUserContext = new DBUser();
            var types = dBUserContext.UserTypes.ToList();
            foreach (UserType item in types)
            {
                comboBoxTip.Items.Add(item);
            }
            refreshGrid();
        }

        private void refreshGrid()
        {
            BindingSource bi = new BindingSource();

            var query = from t in dBUserContext.Users
              orderby t.UserName
            select new { t.Id, t.UserName, Nume = t.Nume, Prenume = t.Prenume, TipUtilizator = t.UserType.Name, Oras = t.Address.City };
           // var query = userRepository.GetAll();
            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCode.SelectedText != null && textBoxNr != null && textBoxNume != null && textBoxOras != null && textBoxParola != null &&
                textBoxPrenume != null && textBoxStrada != null && textBoxUserName != null && comboBoxTip != null)
            {
                CreateUser();
                refreshGrid();
                ClearInputData();
            }

            else
            {
                MessageBox.Show("Va rugam sa introduceti toate datele!");
            }
        }

        private void CreateUser()
        {
                var address = new Address
                {
                    City = textBoxOras.Text,
                    Street = textBoxStrada.Text,
                    StreetNumber = textBoxNr.Text,
                    CodPostal = textBoxCode.Text,
                };

                dBUserContext.Addresses.Add(address);

                var user = new User
                {
                    AddressId = address.Id,
                    UserTypeId = (comboBoxTip.SelectedItem as UserType).Id,
                    Nume = textBoxNume.Text,
                    Prenume = textBoxPrenume.Text,
                    UserName = textBoxUserName.Text,
                    Parola = textBoxParola.Text
                };

                dBUserContext.Users.Add(user);
                dBUserContext.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteUser();
            refreshGrid();
        }

        private void DeleteUser()
        {
            var t = dBUserContext.Users.Find((int)dataGridView1.SelectedCells[0].Value);
            dBUserContext.Users.Remove(t);
            dBUserContext.SaveChanges();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            button_Modifica.Text = "MODIFICA";
            ClearInputData();
        }

        private void ClearInputData()
        {
            textBoxCode.Text = string.Empty;
            textBoxNr.Text = string.Empty;
            textBoxNume.Text = string.Empty;
            textBoxOras.Text = string.Empty;
            textBoxParola.Text = string.Empty;
            textBoxPrenume.Text = string.Empty;
            textBoxStrada.Text = string.Empty;
            textBoxUserName.Text = string.Empty;
            comboBoxTip.Text = "Please Select...";
        }

        private void button_Modifica_Click(object sender, EventArgs e)
        {
            if (button_Modifica.Text == "MODIFICA")
            {
                var t = dBUserContext.Users.Find((int)dataGridView1.SelectedCells[0].Value);
                var a = dBUserContext.Addresses.Find(t.AddressId);
                textBoxCode.Text = t.Address.CodPostal;
                textBoxNr.Text = t.Address.StreetNumber;
                textBoxNume.Text = t.Nume;
                textBoxOras.Text = t.Address.City;
                textBoxParola.Text = t.Prenume;
                textBoxPrenume.Text = t.Prenume;
                textBoxStrada.Text = t.Address.Street;
                textBoxUserName.Text = t.UserName;
                comboBoxTip.Text = t.UserType.Name;
                button_Modifica.Text = "Save";
            }
            else if (button_Modifica.Text == "Save")
            {
                int userId = (int)dataGridView1.SelectedCells[0].Value;
                var updateUser = dBUserContext.Users.Find((int)dataGridView1.SelectedCells[0].Value);
                var updateAddress = dBUserContext.Addresses.Find(updateUser.AddressId);

                updateUser.Nume = textBoxNume.Text;
                updateUser.Parola = textBoxParola.Text;
                updateUser.Prenume = textBoxPrenume.Text;
                updateUser.UserName = textBoxUserName.Text;
                updateUser.UserTypeId = (comboBoxTip.SelectedItem as UserType).Id;
                updateAddress.Street = textBoxStrada.Text;
                updateAddress.CodPostal = textBoxCode.Text;
                updateAddress.StreetNumber = textBoxNr.Text;
                updateAddress.City = textBoxOras.Text;

                dBUserContext.SaveChanges();
                refreshGrid();
                ClearInputData();
            }
        }
    }
}
