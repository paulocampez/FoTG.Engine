using FoTG.Engine.Core.Constantes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Helpers
{
    public class Pastas
    {
        public static void ChecarECriar()
        {
            Console.WriteLine("Iniciando configurações de pastas...");

            List<string> listaDePastas = ListaDePastas();

            foreach (var caminhoDaPasta in listaDePastas)
                if (!Directory.Exists(caminhoDaPasta))
                    Directory.CreateDirectory(caminhoDaPasta);

            Console.WriteLine("Configurações de pastas criadas.");
        }

        public static List<string> ListaDePastas()
        {
            List<string> lstOfConstants = new List<string>();
            foreach (var constante in typeof(Constantes.PastasParaCriar).GetFields())
            {
                if (constante.IsLiteral && !constante.IsInitOnly)
                {
                    lstOfConstants.Add((string)constante.GetValue(null));
                }
            }

            return lstOfConstants;
        }


    }


}
