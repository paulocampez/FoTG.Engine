using FoTG.Engine.Core.Helpers;
using LiteNetLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoTG.Engine.Server.Jogador
{
    public class ContaJogador
    {
        public static List<ContaJogador> ContasJogador = new List<ContaJogador>();
        public string Nome = "";
        public string Password = "";
        public string[] Characters = new string[3];
        public static readonly string Pasta = "data/conta/";
        [JsonIgnore]
        public NetPeer peer;

        public ContaJogador()
        {
            for (int i = 0; i < Characters.Length; i++)
                Characters[i] = "";
        }
        public static bool ExisteConta(string nomeDaConta)
        {
            var nomeDoArquivo = Pasta + nomeDaConta.ToLower() + ".json";
            return File.Exists(nomeDoArquivo);
        }

        public static void Salvar(ContaJogador contaJogador)
        {
            var fileName = Pasta + contaJogador.Nome.ToLower() + ".json";
            JsonHelper.Save(fileName, contaJogador);
        }

        public static ContaJogador Carregar(string nome)
        {
            var nomeArquivo = Pasta + nome.ToLower() + ".json";
            ContaJogador acc;
            JsonHelper.Load(nomeArquivo, out acc);
            return acc;
        }

        public static ContaJogador Encontrar(NetPeer peer)
         => ContasJogador.Find(i => i.peer == peer);

    }
}
