using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SistemaBancodeSangre.Entities
{
    public class seguridad
    {
        public static class Seguridad
        {
          
                public static string Encriptar(string texto)
                {
                    using (SHA256 sha = SHA256.Create())
                    {
                        byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));

                        StringBuilder sb = new StringBuilder();

                        foreach (byte b in bytes)
                        {
                            sb.Append(b.ToString("x2"));
                        }

                        return sb.ToString();
                    }
                }

                public static bool Verificar(string claveIngresada, string claveGuardada)
                {
                    return Encriptar(claveIngresada) == claveGuardada;
                }
            
        }
    }
 }
