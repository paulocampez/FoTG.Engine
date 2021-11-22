namespace FoTG.Engine.Server.Mapa
{
    public partial class InstanciaDoMapa
    {
        public class Atributos
        {
            public TiposDeAtributos Tipo; 
            public string[] args = { };

         
         
            public Atributos(TiposDeAtributos Tipo, params string[] args)
            {
                this.Tipo = Tipo;
                this.args = args;
            }
        }
    }
}
