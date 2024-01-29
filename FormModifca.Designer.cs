namespace _21___Anagrafica_in_classe
{
    partial class FormModifica
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
            labelNome = new Label();
            textBoxNome = new TextBox();
            textBoxCognome = new TextBox();
            labelCognome = new Label();
            labelDataNascita = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            pictureBoxImmagine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImmagine).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(8, 20);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(130, 17);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(242, 23);
            textBoxNome.TabIndex = 1;
            // 
            // textBoxCognome
            // 
            textBoxCognome.Location = new Point(130, 52);
            textBoxCognome.Name = "textBoxCognome";
            textBoxCognome.Size = new Size(242, 23);
            textBoxCognome.TabIndex = 3;
            // 
            // labelCognome
            // 
            labelCognome.AutoSize = true;
            labelCognome.Location = new Point(8, 55);
            labelCognome.Name = "labelCognome";
            labelCognome.Size = new Size(60, 15);
            labelCognome.TabIndex = 2;
            labelCognome.Text = "Cognome";
            // 
            // labelDataNascita
            // 
            labelDataNascita.AutoSize = true;
            labelDataNascita.Location = new Point(8, 90);
            labelDataNascita.Name = "labelDataNascita";
            labelDataNascita.Size = new Size(86, 15);
            labelDataNascita.TabIndex = 4;
            labelDataNascita.Text = "Data di Nascita";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(397, 126);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Salva";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(316, 126);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Annulla";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(130, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // pictureBoxImmagine
            // 
            pictureBoxImmagine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxImmagine.Location = new Point(378, 12);
            pictureBoxImmagine.Name = "pictureBoxImmagine";
            pictureBoxImmagine.Size = new Size(100, 100);
            pictureBoxImmagine.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImmagine.TabIndex = 9;
            pictureBoxImmagine.TabStop = false;
            // 
            // FormModifica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 161);
            Controls.Add(pictureBoxImmagine);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelDataNascita);
            Controls.Add(textBoxCognome);
            Controls.Add(labelCognome);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormModifica";
            Text = "Modifica";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImmagine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox textBoxNome;
        private TextBox textBoxCognome;
        private Label labelCognome;
        private Label labelDataNascita;
        private Button buttonSave;
        private Button buttonCancel;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBoxImmagine;
    }
}