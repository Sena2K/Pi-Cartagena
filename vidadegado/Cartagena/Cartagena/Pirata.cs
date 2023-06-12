using System;

namespace Cartagena
{
    public class Pirata
    {
        private string _cor; // Cor do pirata
        public string Cor { get { return _cor; } } // Propriedade para acessar a cor do pirata
        public int Local { get; set; } // Posição atual do pirata no tabuleiro

        public Pirata(string cor)
        {
            _cor = cor;
            Local = 0;
        }

        public Pirata(string cor, int local)
        {
            _cor = cor;
            Local = local;
        }

        public Pirata Copiar()
        {
            Pirata pirataCopia = new Pirata(Cor, Local);
            return pirataCopia;
        }

        public override string ToString()
        {
            return Local.ToString() + " " + Cor;
        }
    }
}
