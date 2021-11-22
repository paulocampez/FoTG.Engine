using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Helpers
{

    public class LoopServidor
    {
        public static bool estaConectado = false;
        public static float FloatTime;

        public static void LoopCore()
        {
            estaConectado = true;

            long timerDelay = 0;
            Clock clock = new Clock();
            while (estaConectado)
            {
                if (Environment.TickCount64 > timerDelay)
                {
                    FloatTime = clock.Restart().AsSeconds();

                    //loop

                    timerDelay = Environment.TickCount64 + 1;
                }
                Thread.Sleep(1);
            }

        }
    }
}
