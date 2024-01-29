namespace _21___Anagrafica_in_classe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cognome = new DataGridViewTextBoxColumn();
            DataNascita = new DataGridViewTextBoxColumn();
            textBoxCerca = new TextBox();
            labelCerca = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cognome, DataNascita });
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(695, 529);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.FillWeight = 200F;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Cognome
            // 
            Cognome.FillWeight = 200F;
            Cognome.HeaderText = "Cognome";
            Cognome.Name = "Cognome";
            Cognome.ReadOnly = true;
            // 
            // DataNascita
            // 
            DataNascita.FillWeight = 300F;
            DataNascita.HeaderText = "DataNascita";
            DataNascita.Name = "DataNascita";
            DataNascita.ReadOnly = true;
            // 
            // textBoxCerca
            // 
            textBoxCerca.Location = new Point(55, 1);
            textBoxCerca.Name = "textBoxCerca";
            textBoxCerca.Size = new Size(244, 23);
            textBoxCerca.TabIndex = 1;
            textBoxCerca.TextChanged += textBoxCerca_TextChanged;
            // 
            // labelCerca
            // 
            labelCerca.AutoSize = true;
            labelCerca.Location = new Point(12, 9);
            labelCerca.Name = "labelCerca";
            labelCerca.Size = new Size(37, 15);
            labelCerca.TabIndex = 2;
            labelCerca.Text = "Cerca";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 571);
            Controls.Add(labelCerca);
            Controls.Add(textBoxCerca);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxCerca;
        private Label labelCerca;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cognome;
        private DataGridViewTextBoxColumn DataNascita;
    }
}