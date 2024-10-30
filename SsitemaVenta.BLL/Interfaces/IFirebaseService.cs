using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SsitemaVenta.BLL.Interfaces
{
    public interface IFirebaseService
    {
        Task<string> SubirStorage(Stream streamArchivo, string carpetaDestino, string nombreArchivo);

        Task<bool> EliminarStorage(string carpetaDestino, string nombreArchivo);
    }
}
