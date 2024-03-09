using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioI.Abstraccion
{
    public interface IMedicina
    {
        public void AñadirMedicina();

        public void ActualizarMedicina();

        public void BuscarMedicina();

        public void EliminarMedicina();
    }
}
