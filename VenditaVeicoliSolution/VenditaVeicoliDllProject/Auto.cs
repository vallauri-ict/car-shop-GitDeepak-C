using System;

namespace VenditaVeicoliDllProject
{

    [Serializable()]
    public class Auto : Veicolo
    {

        private int numAirbag;

        public Auto() : base(
            "DT290FG",
            "Mercedes",
            "GLX",
            "Nero",
            2100,
            175.20,
            DateTime.Now,
            false,
            false,
            0)
        {
            NumAirbag = 6;
        }

        public Auto(string targa, string marca, string modello, string colore,
            int cilindrata, double potenzaKw, DateTime immatricolazione,
            bool isUsato, bool isKmZero, int kmPercorsi, int numAirbag) 
            : base(
                targa,
                marca, 
                modello, 
                colore,
                cilindrata, 
                potenzaKw, 
                immatricolazione,
                isUsato, 
                isKmZero, 
                kmPercorsi)
        {
            this.NumAirbag = numAirbag;
        }

        public int NumAirbag { get => numAirbag; set => numAirbag = value; }

        public override string ToString()
        {
            return $"Auto: {base.ToString()} - {this.NumAirbag} Airbag" ;
        }

    }
}
