namespace WindowsFormsProject
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonCarti = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCarti);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(57, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 445);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALEGETI OPTIUNILE DE ADMINISTRARE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrare utilizatori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Administrare stocuri de carte";
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(411, 104);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(112, 23);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Selecteaza";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonCarti
            // 
            this.buttonCarti.Location = new System.Drawing.Point(411, 199);
            this.buttonCarti.Name = "buttonCarti";
            this.buttonCarti.Size = new System.Drawing.Size(112, 23);
            this.buttonCarti.TabIndex = 4;
            this.buttonCarti.Text = "Selecteaza";
            this.buttonCarti.UseVisualStyleBackColor = true;
            this.buttonCarti.Click += new System.EventHandler(this.buttonCarti_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 507);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCarti;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Label label3;
    }
}