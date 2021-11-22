using System;

namespace FoTG.Engine.Server.Helpers
{
    public class ConsoleLoop
    {

        public static void ConsoleCore()
        {
        inicioLoop:;
            Console.WriteLine("Digite a ação:");
            string cmd = Console.ReadLine();

            string[] commands = cmd.Split();
            if (commands.Length == 0) goto inicioLoop;

            switch (commands[0].Trim().ToLower())
            {
                case "sair":
                    LoopServidor.estaConectado = false;
                    break;
            }

            goto inicioLoop;
        }
    }
}