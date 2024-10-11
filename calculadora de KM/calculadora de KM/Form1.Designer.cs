namespace calculadora_de_KM
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
            lblConsMin = new Label();
            lblConsMax = new Label();
            lblPrecio = new Label();
            txtConsMin = new TextBox();
            txtConsMax = new TextBox();
            txtPrecio = new TextBox();
            btnCalcular = new Button();
            btnBorrar = new Button();
            cosumo = new DataGridViewTextBoxColumn();
            costo = new DataGridViewTextBoxColumn();
            kilometros = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cosumo, costo, kilometros });
            dataGridView1.Location = new Point(3, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 158);
            dataGridView1.TabIndex = 0;
            // 
            // lblConsMin
            // 
            lblConsMin.AutoSize = true;
            lblConsMin.Location = new Point(12, 30);
            lblConsMin.Name = "lblConsMin";
            lblConsMin.Size = new Size(102, 15);
            lblConsMin.TabIndex = 1;
            lblConsMin.Text = "consumo minimo";
            // 
            // lblConsMax
            // 
            lblConsMax.AutoSize = true;
            lblConsMax.Location = new Point(12, 60);
            lblConsMax.Name = "lblConsMax";
            lblConsMax.Size = new Size(104, 15);
            lblConsMax.TabIndex = 2;
            lblConsMax.Text = "consumo maximo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(12, 89);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(92, 15);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "precio del galon";
            // 
            // txtConsMin
            // 
            txtConsMin.Location = new Point(120, 27);
            txtConsMin.Name = "txtConsMin";
            txtConsMin.Size = new Size(100, 23);
            txtConsMin.TabIndex = 4;
            // 
            // txtConsMax
            // 
            txtConsMax.Location = new Point(120, 57);
            txtConsMax.Name = "txtConsMax";
            txtConsMax.Size = new Size(100, 23);
            txtConsMax.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(120, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 129);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(120, 129);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // cosumo
            // 
            cosumo.HeaderText = "Consumo (L/100Km)";
            cosumo.Name = "cosumo";
            cosumo.ReadOnly = true;
            // 
            // costo
            // 
            costo.HeaderText = "Costo por Km";
            costo.Name = "costo";
            costo.ReadOnly = true;
            // 
            // kilometros
            // 
            kilometros.HeaderText = "Km por Galón";
            kilometros.Name = "kilometros";
            kilometros.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 351);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPrecio);
            Controls.Add(txtConsMax);
            Controls.Add(txtConsMin);
            Controls.Add(lblPrecio);
            Controls.Add(lblConsMax);
            Controls.Add(lblConsMin);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblConsMin;
        private Label lblConsMax;
        private Label lblPrecio;
        private TextBox txtConsMin;
        private TextBox txtConsMax;
        private TextBox txtPrecio;
        private Button btnCalcular;
        private Button btnBorrar;
        private DataGridViewTextBoxColumn cosumo;
        private DataGridViewTextBoxColumn costo;
        private DataGridViewTextBoxColumn kilometros;
    }
}
