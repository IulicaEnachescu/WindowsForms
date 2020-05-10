using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProject.Data;

namespace WindowsFormsProject
{
    public partial class Form1 : Form
    {
        //private UserRepository userRep;
        private DBUser dBUserCon;
        public Form1()
        {
            
            InitializeComponent();
            dBUserCon = new DBUser();
            //userRep = new UserRepository();
            //var list = userRep.GetAll();


            // var types = dBUserContext.UserTypes.ToList();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {   
          
            
            string userName = textBoxUserName.Text;
            string password = textBoxPassword.Text;
            
            var user = dBUserCon.Users.Select(b => (b.UserName==userName&&b.Parola==password));
            bool flag = user != null;
            //bool flag = userRep.VerifyUser(userName, password);
            //MessageBox.Show(flag.ToString());
            if (flag == true)
            {   
                FormAdmin settingsForm = new FormAdmin();
                settingsForm.Show();
            }
            else
            {
                MessageBox.Show("UserName sau Parola incorecte!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelRecPass_Click(object sender, EventArgs e)
        {

        }
    }
}

