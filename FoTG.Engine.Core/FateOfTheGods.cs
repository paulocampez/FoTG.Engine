using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Core
{
    public sealed class FateOfTheGods
    {
        public static bool Running = false;                                                 // Estado do jogo
        public static int FPS = 0;                                                          // FPS atual
        public static float DeltaTime;                                                      // Tempo do delta
        public static Vetor MousePosition;                                                // Posição do Mouse
        public static readonly string Path = AppDomain.CurrentDomain.BaseDirectory + "/";   // Diretório do jogo
                                                         // Dispositivo gráfico para janela
        public static readonly float FixedTime = 1f / 60f;                                  // Tempo fixo em 60FPS

        public static Vetor Tamanho = new Vetor(1024, 600);
        public static bool Fullscreen = false;
        public static RenderWindow Window;
        public static void Run()
        {
            var video = new VideoMode((uint)Tamanho.x, (uint)Tamanho.y);
            if (!Fullscreen)
                Window = new RenderWindow(video, "Fate of The Gods",  Styles.Close | Styles.Resize , new ContextSettings(32, 0, 8));
            else
                Window = new RenderWindow(video, "Fate of The Gods", Styles.Fullscreen, new ContextSettings(32, 0, 8));

            Running = true;
            GameLoop();
        }

        static void GameLoop()
        {
            var clock = new Clock();
            var pressed = new MouseButtonEvent();
            bool ispressed = false;
            long timer_fps = 0;
            int count_fps = 0;
            long timer_animation = 0;
            long timer_delay = 0;

            while (Running)
            {
                if (Environment.TickCount64 > timer_delay) // 60 FPS
                {
                    // Delta Time
                    DeltaTime = clock.Restart().AsSeconds();

                  

                    // Dispara os eventos da janela                    
                    Window.DispatchEvents();

                    Window.Display();

                    count_fps++;
                    if (Environment.TickCount64 > timer_fps)
                    {
                        FPS = count_fps;
                        count_fps = 0;
                        timer_fps = Environment.TickCount64 + 1000;
                    }

                    timer_delay = Environment.TickCount64 + 1;
                }

            }
        }

    }
}
