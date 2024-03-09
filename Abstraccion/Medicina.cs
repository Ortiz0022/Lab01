using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioI.Abstraccion
{
    public class Medicina : IMedicina
    {
        public string Nombre { get; set; }
        public int Cod {  get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }

        public void ActualizarMedicina()
        {
        }

        public void AñadirMedicina()
        {
        }

        public void BuscarMedicina()
        {
        }

        public void EliminarMedicina()
        {
        }
    }
}
