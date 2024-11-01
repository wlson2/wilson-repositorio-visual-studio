namespace OpenFileDialog___SaveFileDialog
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
            btnAbrir = new Button();
            lblAbrir = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnSalvar = new Button();
            lblSalvar = new Label();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(12, 12);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 23);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // lblAbrir
            // 
            lblAbrir.AutoSize = true;
            lblAbrir.Location = new Point(27, 48);
            lblAbrir.Name = "lblAbrir";
            lblAbrir.Size = new Size(38, 15);
            lblAbrir.TabIndex = 1;
            lblAbrir.Text = "label1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivos PNG(*.png)|*.png|Archivos de texto(*.txt)|*.txt";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(120, 12);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblSalvar
            // 
            lblSalvar.AutoSize = true;
            lblSalvar.Location = new Point(31, 84);
            lblSalvar.Name = "lblSalvar";
            lblSalvar.Size = new Size(38, 15);
            lblSalvar.TabIndex = 3;
            lblSalvar.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 432);
            Controls.Add(lblSalvar);
            Controls.Add(btnSalvar);
            Controls.Add(lblAbrir);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAbrir;
        private Label lblAbrir;
        private OpenFileDialog openFileDialog1;
        private Button btnSalvar;
        private Label lblSalvar;
        private SaveFileDialog saveFileDialog1;
    }
}
