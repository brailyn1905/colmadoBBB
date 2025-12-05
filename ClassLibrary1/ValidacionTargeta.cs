using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PagoService
    {
        public async Task<bool> ValidarTarjetaAsync(string numero)
        {
            await Task.Delay(2000); // simulación
            return numero.StartsWith("4"); // ej: VISA
        }
    }

}
