using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Helpers
{
    public class DadosDeConfiguracao
    {

        public static void InicializarDadosDeConfiguracao()
        {
            Console.WriteLine("Carregando dados de configuração...");

            List<string> listaDePastas = Pastas.ListaDePastas();

            foreach (var caminhoDaPasta in listaDePastas)
            {
                var diretorioDaPasta = Environment.CurrentDirectory + caminhoDaPasta + "/";

            }


        }
    }
}
