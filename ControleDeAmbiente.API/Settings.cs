using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API
{
    public static class Settings
    {
        public static string ChaveSecreta = Guid.NewGuid().ToString();
    }
}
