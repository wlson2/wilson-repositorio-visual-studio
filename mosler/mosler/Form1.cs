namespace mosler
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        private List<Riesgo> riesgos = new List<Riesgo>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bindingSource.DataSource = riesgos;
            dataGridViewRiesgos.DataSource = bindingSource;
        }

        private int GenerarId()
        {
            return riesgos.Count == 0 ? 1 : riesgos[^1].Id + 1; // Último Id + 1
        }

        private void buttonAgregarRiesgo_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear un nuevo riesgo con Id generado automáticamente
                var riesgo = new Riesgo
                {
                    Id = GenerarId(),
                    RiesgoName = "Riesgo " + (riesgos.Count + 1),
                    AnalistaName = "Analista " + (riesgos.Count + 1),
                    Fecha = DateTime.Now,
                    ActivoBien = "Activo Ejemplo",
                    DescDano = "Descripción del daño",
                    CriterioInmune = 3,
                    CriterioTrato = 4,
                    CriterioEstado = 2,
                    CriterioSecuela = 5,
                    CriterioAgresion = 3,
                    CriterioPresion = 4,
                    CaracterRiesgo = 2
                };

                // Agregar el riesgo a la lista
                riesgos.Add(riesgo);
                bindingSource.ResetBindings(false);
                MessageBox.Show("Riesgo agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar riesgo: " + ex.Message);
            }
        }

        private void buttonCalcularValores_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var riesgo in riesgos)
                {
                    riesgo.CalcularRiesgo();
                }

                // Refrescar DataGridView
                bindingSource.ResetBindings(false);
                MessageBox.Show("Valores calculados correctamente para todos los riesgos.", "Cálculo Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular valores: " + ex.Message);
            }
        
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewRiesgos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewRiesgos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewRiesgos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
