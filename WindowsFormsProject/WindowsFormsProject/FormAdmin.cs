﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormUsers settingsForm = new FormUsers();
            settingsForm.Show();
        }

        private void buttonCarti_Click(object sender, EventArgs e)
        {
            FormBooks settingsForm = new FormBooks();
            settingsForm.Show();
        }
    }
}
