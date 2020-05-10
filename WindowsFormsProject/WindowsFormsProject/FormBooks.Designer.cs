namespace WindowsFormsProject
{
    partial class FormBooks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCautaTitlu = new System.Windows.Forms.Label();
            this.labelGrafic = new System.Windows.Forms.Label();
            this.labelCautaAutor = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxAn = new System.Windows.Forms.TextBox();
            this.textBoxPrenumeA = new System.Windows.Forms.TextBox();
            this.textBoxNumeA = new System.Windows.Forms.TextBox();
            this.labelPret = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrenumeAutor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTitlu = new System.Windows.Forms.TextBox();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 280);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonMeniu);
            this.groupBox1.Controls.Add(this.labelCautaTitlu);
            this.groupBox1.Controls.Add(this.labelGrafic);
            this.groupBox1.Controls.Add(this.labelCautaAutor);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.textBoxPret);
            this.groupBox1.Controls.Add(this.textBoxAn);
            this.groupBox1.Controls.Add(this.textBoxPrenumeA);
            this.groupBox1.Controls.Add(this.textBoxNumeA);
            this.groupBox1.Controls.Add(this.labelPret);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelPrenumeAutor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxTitlu);
            this.groupBox1.Controls.Add(this.labelTitlu);
            this.groupBox1.Location = new System.Drawing.Point(19, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrare stoc de carte";
            // 
            // labelCautaTitlu
            // 
            this.labelCautaTitlu.AutoSize = true;
            this.labelCautaTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCautaTitlu.Location = new System.Drawing.Point(247, 167);
            this.labelCautaTitlu.Name = "labelCautaTitlu";
            this.labelCautaTitlu.Size = new System.Drawing.Size(113, 17);
            this.labelCautaTitlu.TabIndex = 15;
            this.labelCautaTitlu.Text = "Selectati un Titlu";
            this.labelCautaTitlu.Click += new System.EventHandler(this.labelCautaTitlu_Click);
            // 
            // labelGrafic
            // 
            this.labelGrafic.AutoSize = true;
            this.labelGrafic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrafic.Location = new System.Drawing.Point(189, 215);
            this.labelGrafic.Name = "labelGrafic";
            this.labelGrafic.Size = new System.Drawing.Size(202, 17);
            this.labelGrafic.TabIndex = 14;
            this.labelGrafic.Text = "Grafic distribuite an de aparitie";
            this.labelGrafic.Click += new System.EventHandler(this.labelGrafic_Click);
            // 
            // labelCautaAutor
            // 
            this.labelCautaAutor.AutoSize = true;
            this.labelCautaAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCautaAutor.Location = new System.Drawing.Point(72, 167);
            this.labelCautaAutor.Name = "labelCautaAutor";
            this.labelCautaAutor.Size = new System.Drawing.Size(119, 17);
            this.labelCautaAutor.TabIndex = 13;
            this.labelCautaAutor.Text = "Selectati un autor";
            this.labelCautaAutor.Click += new System.EventHandler(this.labelCautaAutor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(882, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(882, 161);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(93, 29);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "MODIFICA";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(764, 161);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(91, 29);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "STERGE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(333, 90);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 22);
            this.textBoxPret.TabIndex = 10;
            // 
            // textBoxAn
            // 
            this.textBoxAn.Location = new System.Drawing.Point(100, 90);
            this.textBoxAn.Name = "textBoxAn";
            this.textBoxAn.Size = new System.Drawing.Size(100, 22);
            this.textBoxAn.TabIndex = 9;
            // 
            // textBoxPrenumeA
            // 
            this.textBoxPrenumeA.Location = new System.Drawing.Point(641, 92);
            this.textBoxPrenumeA.Name = "textBoxPrenumeA";
            this.textBoxPrenumeA.Size = new System.Drawing.Size(316, 22);
            this.textBoxPrenumeA.TabIndex = 8;
            // 
            // textBoxNumeA
            // 
            this.textBoxNumeA.Location = new System.Drawing.Point(641, 36);
            this.textBoxNumeA.Name = "textBoxNumeA";
            this.textBoxNumeA.Size = new System.Drawing.Size(316, 22);
            this.textBoxNumeA.TabIndex = 7;
            // 
            // labelPret
            // 
            this.labelPret.AutoSize = true;
            this.labelPret.Location = new System.Drawing.Point(236, 95);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(34, 17);
            this.labelPret.TabIndex = 6;
            this.labelPret.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "An aparitie";
            // 
            // labelPrenumeAutor
            // 
            this.labelPrenumeAutor.AutoSize = true;
            this.labelPrenumeAutor.Location = new System.Drawing.Point(499, 97);
            this.labelPrenumeAutor.Name = "labelPrenumeAutor";
            this.labelPrenumeAutor.Size = new System.Drawing.Size(99, 17);
            this.labelPrenumeAutor.TabIndex = 4;
            this.labelPrenumeAutor.Text = "PrenumeAutor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NumeAutor";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(641, 161);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "ADAUGA";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTitlu
            // 
            this.textBoxTitlu.Location = new System.Drawing.Point(100, 33);
            this.textBoxTitlu.Name = "textBoxTitlu";
            this.textBoxTitlu.Size = new System.Drawing.Size(333, 22);
            this.textBoxTitlu.TabIndex = 1;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(6, 38);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(35, 17);
            this.labelTitlu.TabIndex = 0;
            this.labelTitlu.Text = "Titlu";
            this.labelTitlu.Click += new System.EventHandler(this.labelTitlu_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 290);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1030, 296);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 293);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniu.Location = new System.Drawing.Point(22, 215);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(117, 46);
            this.buttonMeniu.TabIndex = 16;
            this.buttonMeniu.Text = "MENIU PRINCIPAL";
            this.buttonMeniu.UseVisualStyleBackColor = true;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // FormBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 586);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormBooks";
            this.Text = "FormBooks";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTitlu;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxAn;
        private System.Windows.Forms.TextBox textBoxPrenumeA;
        private System.Windows.Forms.TextBox textBoxNumeA;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPrenumeAutor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelCautaTitlu;
        private System.Windows.Forms.Label labelGrafic;
        private System.Windows.Forms.Label labelCautaAutor;
        private System.Windows.Forms.Button buttonMeniu;
    }
}