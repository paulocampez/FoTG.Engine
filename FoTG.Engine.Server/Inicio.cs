using FoTG.Engine.Server.Helpers;
using FoTG.Engine.Server.Jogador;
using FoTG.Engine.Server.Mapa;
using SFML.System;
using System;
using System.Threading;

namespace FoTG.Engine.Server
{
    public class Inicio
    {
   
        static void Main(string[] args)
        {
            Console.Title = "Servidor Fate Of The Gods";
            

            Console.WriteLine("--------------------------");
            Console.WriteLine("Inicializando servidor....");
            Console.WriteLine("--------------------------");
            Conexoes.Socket.Initialize();
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Checando e criando pastas...");
            Pastas.ChecarECriar();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Inicializando classes...");
            Classe.InicializarClasse();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Inicializando Mapas...");
            InstanciaDoMapa.InicializarInstanciaDoMapa();


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Servidor inicializado com sucesso.");
            Console.WriteLine("----------------------------------");



            ConsoleLoop.ConsoleCore();
            LoopServidor.LoopCore();
        }
    }

}
