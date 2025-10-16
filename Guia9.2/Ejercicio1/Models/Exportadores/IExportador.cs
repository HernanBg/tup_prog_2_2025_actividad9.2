using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models.Exportadores
{
    public class IExportador
    {
        bool Importar(string data, Multa m);
        string Exportar(Multa m);
    }
}
