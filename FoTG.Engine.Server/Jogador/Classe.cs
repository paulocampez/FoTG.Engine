using FoTG.Engine.Core;
using FoTG.Engine.Core.Helpers;
using FoTG.Engine.Server.Enumeradores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Jogador
{
    public class Classe
    {
        public string[] Nome = { "", "" };                              
        public int[] StatusPrimario = new int[(int)StatusPrimarios.Contador];   
        public string[] DescricaoDaClasse = { "", "" };                       
        public int[] OutfitMasculino, OutfitFeminino;
        public int IdMapa = 0;
        public Vetor PosicaoDeInicio;
        public static List<Classe> Classes = new List<Classe>();


        public static void InicializarClasse()
        {
            Console.WriteLine("Carregando classes...");
            int i = 0;
            var dirpath = Environment.CurrentDirectory + "/data/classes/";
            while (File.Exists(dirpath + $"{i}.json"))
            {
                Classe classe;
                JsonHelper.Load(dirpath + $"{i}.json", out classe);
                Classes.Add(classe);
                Console.WriteLine($"-> {classe.Nome[0]} carregado!");
                i++;
            }
        }
    }
}
