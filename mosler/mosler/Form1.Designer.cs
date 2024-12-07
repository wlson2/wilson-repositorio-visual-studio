namespace mosler
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
            dataGridViewRiesgos = new DataGridView();
            buttonAgregarRiesgo = new Button();
            buttonCalcularValores = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiesgos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRiesgos
            // 
            dataGridViewRiesgos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiesgos.Location = new Point(12, 244);
            dataGridViewRiesgos.Name = "dataGridViewRiesgos";
            dataGridViewRiesgos.Size = new Size(615, 150);
            dataGridViewRiesgos.TabIndex = 0;
            dataGridViewRiesgos.CellContentClick += dataGridViewRiesgos_CellContentClick;
            // 
            // buttonAgregarRiesgo
            // 
            buttonAgregarRiesgo.Location = new Point(660, 254);
            buttonAgregarRiesgo.Name = "buttonAgregarRiesgo";
            buttonAgregarRiesgo.Size = new Size(106, 39);
            buttonAgregarRiesgo.TabIndex = 1;
            buttonAgregarRiesgo.Text = "agregar riesgo";
            buttonAgregarRiesgo.UseVisualStyleBackColor = true;
            // 
            // buttonCalcularValores
            // 
            buttonCalcularValores.Location = new Point(660, 318);
            buttonCalcularValores.Name = "buttonCalcularValores";
            buttonCalcularValores.Size = new Size(106, 33);
            buttonCalcularValores.TabIndex = 2;
            buttonCalcularValores.Text = "calcular";
            buttonCalcularValores.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 406);
            Controls.Add(buttonCalcularValores);
            Controls.Add(buttonAgregarRiesgo);
            Controls.Add(dataGridViewRiesgos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiesgos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewRiesgos;
        private Button buttonAgregarRiesgo;
        private Button buttonCalcularValores;
    }
}
