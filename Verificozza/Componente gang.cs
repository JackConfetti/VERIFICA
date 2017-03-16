using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificozza
{
    class Componente_gang : Gang
    {
        public int BravuraFlow { get; set; }

        //COSTRUTTORE DELLA CLASSE FIGLIA DI GANG Gli argomenti dichiarati nella classe figlia che sono in comunella con quelli della classe madre devono per forza avere o stesso nome

        public Componente_gang(string Nomegang, string Mottogang, string AbbreviazioneGang, int numcomponentigang, int BravuraFlow) : base(Nomegang, Mottogang, AbbreviazioneGang, 0) // Lo 0 per il numero componenti
        {
            this.BravuraFlow = BravuraFlow;

        }

        public override string Rimadellagang()  //METODO EREDITATO so benissimo che è inutile e anzi sensa senso ed è per questo che non worka un cazzo di niente

        {
            return base.Rimadellagang();

            string output = " vedo il mondo davvero";

            Console.WriteLine(output);

        }
    }
}
