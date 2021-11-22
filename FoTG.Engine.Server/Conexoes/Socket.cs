using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteNetLib;
using LiteNetLib.Utils;

namespace FoTG.Engine.Server.Conexoes
{
    public class Socket
    {
        public static NetManager Device { get; private set; }
        public static int PORT = 5002;

        static EventBasedNetListener listener;

        public static void Initialize()
        {
            Console.WriteLine("Inicializando conexão...");
            listener = new EventBasedNetListener();
            Device = new NetManager(listener);
            Device.AutoRecycle = true;
            Device.Start(PORT);
            Console.WriteLine($"Server conectado na porta {PORT}.");
        }
    }
}
