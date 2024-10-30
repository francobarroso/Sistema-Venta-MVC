using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsitemaVenta.BLL.Interfaces
{
    public interface IUtilidadesService
    {
        string generarClave();
        string convertirSha256(string texto);
    }
}
