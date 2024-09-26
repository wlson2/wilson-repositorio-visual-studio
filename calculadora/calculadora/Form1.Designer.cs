namespace calculadora
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
            BotonSigno = new Button();
            BotonCero = new Button();
            BotonPunto = new Button();
            BotonTres = new Button();
            BotonDos = new Button();
            BotonUno = new Button();
            BotonSeis = new Button();
            BotonCinco = new Button();
            BotonCuatro = new Button();
            BotonNueve = new Button();
            BotonOcho = new Button();
            BotonSiete = new Button();
            BotonBorrar = new Button();
            BotonLimpiar = new Button();
            BotonQuitar = new Button();
            BotonElevado = new Button();
            BotonRaiz = new Button();
            BotonResta = new Button();
            BotonSuma = new Button();
            BotonMultiplicar = new Button();
            BotonDividir = new Button();
            BotonResultado = new Button();
            TxtResultado = new TextBox();
            SuspendLayout();
            // 
            // BotonSigno
            // 
            BotonSigno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BotonSigno.Location = new Point(9, 259);
            BotonSigno.Name = "BotonSigno";
            BotonSigno.Size = new Size(45, 45);
            BotonSigno.TabIndex = 0;
            BotonSigno.Text = "+/-";
            BotonSigno.UseVisualStyleBackColor = true;
            BotonSigno.Click += BotonSigno_Click;
            // 
            // BotonCero
            // 
            BotonCero.Font = new Font("Segoe UI", 14.25F);
            BotonCero.Location = new Point(60, 259);
            BotonCero.Name = "BotonCero";
            BotonCero.Size = new Size(45, 45);
            BotonCero.TabIndex = 1;
            BotonCero.Text = "0";
            BotonCero.UseVisualStyleBackColor = true;
            BotonCero.Click += agregarNumero;
            // 
            // BotonPunto
            // 
            BotonPunto.Font = new Font("Segoe UI", 14.25F);
            BotonPunto.Location = new Point(111, 259);
            BotonPunto.Name = "BotonPunto";
            BotonPunto.Size = new Size(45, 45);
            BotonPunto.TabIndex = 2;
            BotonPunto.Text = ".";
            BotonPunto.UseVisualStyleBackColor = true;
            BotonPunto.Click += BotonPunto_Click;
            // 
            // BotonTres
            // 
            BotonTres.Font = new Font("Segoe UI", 14.25F);
            BotonTres.Location = new Point(111, 208);
            BotonTres.Name = "BotonTres";
            BotonTres.Size = new Size(45, 45);
            BotonTres.TabIndex = 5;
            BotonTres.Text = "3";
            BotonTres.UseVisualStyleBackColor = true;
            BotonTres.Click += agregarNumero;
            // 
            // BotonDos
            // 
            BotonDos.Font = new Font("Segoe UI", 14.25F);
            BotonDos.Location = new Point(60, 208);
            BotonDos.Name = "BotonDos";
            BotonDos.Size = new Size(45, 45);
            BotonDos.TabIndex = 4;
            BotonDos.Text = "2";
            BotonDos.UseVisualStyleBackColor = true;
            BotonDos.Click += agregarNumero;
            // 
            // BotonUno
            // 
            BotonUno.Font = new Font("Segoe UI", 14.25F);
            BotonUno.Location = new Point(9, 208);
            BotonUno.Name = "BotonUno";
            BotonUno.Size = new Size(45, 45);
            BotonUno.TabIndex = 3;
            BotonUno.Text = "1";
            BotonUno.UseVisualStyleBackColor = true;
            BotonUno.Click += agregarNumero;
            // 
            // BotonSeis
            // 
            BotonSeis.Font = new Font("Segoe UI", 14.25F);
            BotonSeis.Location = new Point(111, 157);
            BotonSeis.Name = "BotonSeis";
            BotonSeis.Size = new Size(45, 45);
            BotonSeis.TabIndex = 8;
            BotonSeis.Text = "6";
            BotonSeis.UseVisualStyleBackColor = true;
            BotonSeis.Click += agregarNumero;
            // 
            // BotonCinco
            // 
            BotonCinco.Font = new Font("Segoe UI", 14.25F);
            BotonCinco.Location = new Point(60, 157);
            BotonCinco.Name = "BotonCinco";
            BotonCinco.Size = new Size(45, 45);
            BotonCinco.TabIndex = 7;
            BotonCinco.Text = "5";
            BotonCinco.UseVisualStyleBackColor = true;
            BotonCinco.Click += agregarNumero;
            // 
            // BotonCuatro
            // 
            BotonCuatro.Font = new Font("Segoe UI", 14.25F);
            BotonCuatro.Location = new Point(9, 157);
            BotonCuatro.Name = "BotonCuatro";
            BotonCuatro.Size = new Size(45, 45);
            BotonCuatro.TabIndex = 6;
            BotonCuatro.Text = "4";
            BotonCuatro.UseVisualStyleBackColor = true;
            BotonCuatro.Click += agregarNumero;
            // 
            // BotonNueve
            // 
            BotonNueve.Font = new Font("Segoe UI", 14.25F);
            BotonNueve.Location = new Point(111, 106);
            BotonNueve.Name = "BotonNueve";
            BotonNueve.Size = new Size(45, 45);
            BotonNueve.TabIndex = 11;
            BotonNueve.Text = "9";
            BotonNueve.UseVisualStyleBackColor = true;
            BotonNueve.Click += agregarNumero;
            // 
            // BotonOcho
            // 
            BotonOcho.Font = new Font("Segoe UI", 14.25F);
            BotonOcho.Location = new Point(60, 106);
            BotonOcho.Name = "BotonOcho";
            BotonOcho.Size = new Size(45, 45);
            BotonOcho.TabIndex = 10;
            BotonOcho.Text = "8";
            BotonOcho.UseVisualStyleBackColor = true;
            BotonOcho.Click += agregarNumero;
            // 
            // BotonSiete
            // 
            BotonSiete.Font = new Font("Segoe UI", 14.25F);
            BotonSiete.Location = new Point(9, 106);
            BotonSiete.Name = "BotonSiete";
            BotonSiete.Size = new Size(45, 45);
            BotonSiete.TabIndex = 9;
            BotonSiete.Text = "7";
            BotonSiete.UseVisualStyleBackColor = true;
            BotonSiete.Click += agregarNumero;
            // 
            // BotonBorrar
            // 
            BotonBorrar.Font = new Font("Segoe UI", 14.25F);
            BotonBorrar.Location = new Point(111, 55);
            BotonBorrar.Name = "BotonBorrar";
            BotonBorrar.Size = new Size(45, 45);
            BotonBorrar.TabIndex = 14;
            BotonBorrar.Text = "<-";
            BotonBorrar.UseVisualStyleBackColor = true;
            BotonBorrar.Click += BotonBorrar_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.Font = new Font("Segoe UI", 14.25F);
            BotonLimpiar.Location = new Point(60, 55);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(45, 45);
            BotonLimpiar.TabIndex = 13;
            BotonLimpiar.Text = "C";
            BotonLimpiar.UseVisualStyleBackColor = true;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // BotonQuitar
            // 
            BotonQuitar.Font = new Font("Segoe UI", 14.25F);
            BotonQuitar.Location = new Point(9, 55);
            BotonQuitar.Name = "BotonQuitar";
            BotonQuitar.Size = new Size(45, 45);
            BotonQuitar.TabIndex = 12;
            BotonQuitar.Text = "CE";
            BotonQuitar.UseVisualStyleBackColor = true;
            BotonQuitar.Click += BotonQuitar_Click;
            // 
            // BotonElevado
            // 
            BotonElevado.Font = new Font("Segoe UI", 14.25F);
            BotonElevado.Location = new Point(234, 55);
            BotonElevado.Name = "BotonElevado";
            BotonElevado.Size = new Size(45, 45);
            BotonElevado.TabIndex = 20;
            BotonElevado.Tag = "²";
            BotonElevado.Text = "X²";
            BotonElevado.UseVisualStyleBackColor = true;
            BotonElevado.Click += clickOperador;
            // 
            // BotonRaiz
            // 
            BotonRaiz.Font = new Font("Segoe UI", 14.25F);
            BotonRaiz.Location = new Point(183, 55);
            BotonRaiz.Name = "BotonRaiz";
            BotonRaiz.Size = new Size(45, 45);
            BotonRaiz.TabIndex = 19;
            BotonRaiz.Tag = "√";
            BotonRaiz.Text = "√";
            BotonRaiz.UseVisualStyleBackColor = true;
            BotonRaiz.Click += clickOperador;
            // 
            // BotonResta
            // 
            BotonResta.Font = new Font("Segoe UI", 14.25F);
            BotonResta.Location = new Point(234, 106);
            BotonResta.Name = "BotonResta";
            BotonResta.Size = new Size(45, 45);
            BotonResta.TabIndex = 18;
            BotonResta.Tag = "-";
            BotonResta.Text = "-";
            BotonResta.UseVisualStyleBackColor = true;
            BotonResta.Click += clickOperador;
            // 
            // BotonSuma
            // 
            BotonSuma.Font = new Font("Segoe UI", 14.25F);
            BotonSuma.Location = new Point(183, 106);
            BotonSuma.Name = "BotonSuma";
            BotonSuma.Size = new Size(45, 45);
            BotonSuma.TabIndex = 17;
            BotonSuma.Tag = "+";
            BotonSuma.Text = "+";
            BotonSuma.UseVisualStyleBackColor = true;
            BotonSuma.Click += clickOperador;
            // 
            // BotonMultiplicar
            // 
            BotonMultiplicar.Font = new Font("Segoe UI", 14.25F);
            BotonMultiplicar.Location = new Point(234, 157);
            BotonMultiplicar.Name = "BotonMultiplicar";
            BotonMultiplicar.Size = new Size(45, 45);
            BotonMultiplicar.TabIndex = 16;
            BotonMultiplicar.Tag = "X";
            BotonMultiplicar.Text = "X";
            BotonMultiplicar.UseVisualStyleBackColor = true;
            BotonMultiplicar.Click += clickOperador;
            // 
            // BotonDividir
            // 
            BotonDividir.Font = new Font("Segoe UI", 14.25F);
            BotonDividir.Location = new Point(183, 157);
            BotonDividir.Name = "BotonDividir";
            BotonDividir.Size = new Size(45, 45);
            BotonDividir.TabIndex = 15;
            BotonDividir.Tag = "/";
            BotonDividir.Text = "/";
            BotonDividir.UseVisualStyleBackColor = true;
            BotonDividir.Click += clickOperador;
            // 
            // BotonResultado
            // 
            BotonResultado.Font = new Font("Segoe UI", 14.25F);
            BotonResultado.Location = new Point(183, 208);
            BotonResultado.Name = "BotonResultado";
            BotonResultado.Size = new Size(96, 45);
            BotonResultado.TabIndex = 21;
            BotonResultado.Text = "=";
            BotonResultado.UseVisualStyleBackColor = true;
            BotonResultado.Click += BotonResultado_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtResultado.Location = new Point(9, 12);
            TxtResultado.MaxLength = 20;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.ReadOnly = true;
            TxtResultado.Size = new Size(270, 39);
            TxtResultado.TabIndex = 22;
            TxtResultado.Text = "0";
            TxtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 321);
            Controls.Add(TxtResultado);
            Controls.Add(BotonResultado);
            Controls.Add(BotonElevado);
            Controls.Add(BotonRaiz);
            Controls.Add(BotonResta);
            Controls.Add(BotonSuma);
            Controls.Add(BotonMultiplicar);
            Controls.Add(BotonDividir);
            Controls.Add(BotonBorrar);
            Controls.Add(BotonLimpiar);
            Controls.Add(BotonQuitar);
            Controls.Add(BotonNueve);
            Controls.Add(BotonOcho);
            Controls.Add(BotonSiete);
            Controls.Add(BotonSeis);
            Controls.Add(BotonCinco);
            Controls.Add(BotonCuatro);
            Controls.Add(BotonTres);
            Controls.Add(BotonDos);
            Controls.Add(BotonUno);
            Controls.Add(BotonPunto);
            Controls.Add(BotonCero);
            Controls.Add(BotonSigno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonSigno;
        private Button BotonCero;
        private Button BotonPunto;
        private Button BotonTres;
        private Button BotonDos;
        private Button BotonUno;
        private Button BotonSeis;
        private Button BotonCinco;
        private Button BotonCuatro;
        private Button BotonNueve;
        private Button BotonOcho;
        private Button BotonSiete;
        private Button BotonBorrar;
        private Button BotonLimpiar;
        private Button BotonQuitar;
        private Button BotonElevado;
        private Button BotonRaiz;
        private Button BotonResta;
        private Button BotonSuma;
        private Button BotonMultiplicar;
        private Button BotonDividir;
        private Button BotonResultado;
        private TextBox TxtResultado;
    }
}
