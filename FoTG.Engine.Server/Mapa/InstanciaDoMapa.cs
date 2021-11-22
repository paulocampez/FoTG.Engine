using FoTG.Engine.Core;
using FoTG.Engine.Core.Servicos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Mapa
{
    public partial class InstanciaDoMapa
    {

        public string Nome = "";               
        public Int2 Tamanho = new Int2(41, 41);      
        public Camada[] Camadas;                   
        public List<Atributos>[,] Atributo;   
        public TiposDePvp TipoDePvp = TiposDePvp.Normal;
        public string NomeMusica = "SemNome";
        public int PanoramaID = 0;
        public int[] Teleporte = new int[4];
        public static InstanciaDoMapa[] Mapas = new InstanciaDoMapa[100];
        public static readonly string Diretorio = Environment.CurrentDirectory + "/dados/mapa/";

        private InstanciaDoMapa()
        {
            Camadas = new Camada[(int)CamadasEnum.Contador];
            for (int i = 0; i < Camadas.Length; i++)
                Camadas[i] = new Camada();

            Atributo = new List<Atributos>[Tamanho.x + 1, Tamanho.y + 1];
            for (int x = 0; x <= Tamanho.x; x++)
                for (int y = 0; y <= Tamanho.y; y++)
                    Atributo[x, y] = new List<Atributos>();
        }
        public static void InicializarInstanciaDoMapa()
        {
            for (int i = 0; i < 100; i++)
            {
                Mapas[i] = Carregar(i);
                Console.Write("\rCarregando os mapas...{0}", (int)(((i + 1) / (float)100) * 100) + "%");
            }
            Console.Write("");
        }
        public static InstanciaDoMapa Carregar(int ID)
        {
            var path = Diretorio;
            var filePath = path + $"{ID}.map";

            if (!File.Exists(filePath))
            {
                Mapas[ID] = new InstanciaDoMapa();
                Salvar(ID);
            }

            var data = Memoria.Descomprimir(File.ReadAllBytes(filePath));
            var json = Encoding.UTF8.GetString(data);
            return JsonConvert.DeserializeObject<InstanciaDoMapa>(json);
        }

        public static void Salvar(int ID)
        {
            var filePath = Diretorio + $"{ID}.map";
            var json = JsonConvert.SerializeObject(Mapas[ID]);
            File.WriteAllBytes(filePath, Memoria.Comprimir(Encoding.UTF8.GetBytes(json)));
        }
    }
}
