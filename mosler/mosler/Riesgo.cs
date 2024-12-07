using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mosler
{
    public class Riesgo
    {
        public int Id { get; set; }
        public string RiesgoName { get; set; }
        public string AnalistaName { get; set; }
        public DateTime Fecha { get; set; }
        public string ActivoBien { get; set; }
        public string DescDano { get; set; }
        public int CriterioInmune { get; set; }
        public int CriterioTrato { get; set; }
        public int CriterioEstado { get; set; }
        public int CriterioSecuela { get; set; }
        public int CriterioAgresion { get; set; }
        public int CriterioPresion { get; set; }
        public int CaracterRiesgo { get; set; }
        public int ProbabilidadRiesgo { get; set; }
        public int CuantificacionRiesgo { get; set; }
        public int ImportanciaRiesgo { get; set; }
        public int DanoRiego { get; set; }

        public void CalcularRiesgo()
        {
            // Ejemplo de cálculo
            ProbabilidadRiesgo = (CriterioInmune + CriterioTrato + CriterioEstado) / 3;
            CuantificacionRiesgo = (CriterioSecuela + CriterioAgresion + CriterioPresion) / 3;
            DanoRiego = CaracterRiesgo * CuantificacionRiesgo;
            ImportanciaRiesgo = ProbabilidadRiesgo * DanoRiego;
        }
    }
}
