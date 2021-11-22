using FoTG.Engine.Core;

namespace FoTG.Engine.Server.Mapa
{
    public partial class InstanciaDoMapa
    {
        public class Piso
        {
            public int IdTitle = 0;
            public Vetor Fonte;                      
            public TiposDePiso TipoDePiso = TiposDePiso.Normal; 
            public Vetor Posicao;                    
        }
    }
}
