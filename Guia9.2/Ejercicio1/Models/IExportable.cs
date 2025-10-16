using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Models.Exportadores;

namespace Ejercicio1.Models
{
    public class IExportable
    {
        bool Importar(string data, IExportador exportador);
        string Exportar(IExportador exportador);
    }
}
