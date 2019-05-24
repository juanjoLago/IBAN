using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioIban
{
    public class iban
    {
        public bool EsIBANvalido(string IBAN)
        {
            return IBAN == calcularIban(IBAN.Substring(4));
        }

        private string calcularIban(string ccc)
        {
            // Calculamos el IBAN
            string numeroCalcular = ccc.Trim();
            if (numeroCalcular.Length != 20)
            {
                return "La CCC debe tener 20 dígitos";
            }
            // Le añadimos el codigo del pais al ccc
            numeroCalcular = añadir_codigo_pais(numeroCalcular);

            // Troceamos el ccc en partes (26 digitos)
            string resultado = trocear(numeroCalcular);
            // Le restamos el resultado a 98
            return restar(ccc, resultado);
            
        }

        private static string restar(string ccc, string resultado)
        {
            int miRestoIban = 98 - int.Parse(resultado);
            string restoIban = miRestoIban.ToString();
            if (restoIban.Length == 1)
                restoIban = "0" + restoIban;

            return "ES" + restoIban + ccc;
        }

        private static string trocear(string numeroCalcular)
        {
            string[] partesCCC = new string[5];
            partesCCC[0] = numeroCalcular.Substring(0, 5);
            partesCCC[1] = numeroCalcular.Substring(5, 5);
            partesCCC[2] = numeroCalcular.Substring(10, 5);
            partesCCC[3] = numeroCalcular.Substring(15, 5);
            partesCCC[4] = numeroCalcular.Substring(20, 6);

            int miResultado = int.Parse(partesCCC[0]) % 97;
            string resultado = miResultado.ToString();
            for (int i = 0; i < partesCCC.Length - 1; i++)
            {
                miResultado = int.Parse(resultado + partesCCC[i + 1]) % 97;
                resultado = miResultado.ToString();
            }
            return resultado;
        }

        private static string añadir_codigo_pais(string numeroCalcular)
        {
            numeroCalcular = numeroCalcular + "142800";
            return numeroCalcular;
        }

    }
}
