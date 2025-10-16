using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exportadores
{
    internal class ExportadorFactory
    {
        public IExportador GetInstance(int tipo)
        {
            IExportador exportador = null;
            if (tipo == 1)
            {
                return new CSVExportador();
            }
            else if (tipo == 2)
            {
                return new XMLExportador();
            }
            else if (tipo == 3)
            {
                return new CampoFijoExportador();
            }
            else if (tipo == 4)
            {
                return new XMLExportador();
            }
            return null;
        }
    }
}
