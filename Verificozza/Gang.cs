using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificozza
{
    class Gang
    {
       //Le variabili private non devono esserci per forze , servono solo per immagazzinare il dato della propretà in maniera privata
        public string Nomegang { get; set; }     // Proprietà in lettura e scrittura

        private string _Mottogang;
        public string Mottogang { get { return _Mottogang; } } // proprietà in sola lettura 

        private string _Abbreviazionegang; // proprietà con filtro neutro
        public string Abbreviazionegang
        {
            get
            {
                return _Abbreviazionegang; 
            }

            set
            {
                _Abbreviazionegang = value;
            }
        }

        private int  _numcomponentigang;
        public int  numcomponentigang { get { return _numcomponentigang; } }

        public Gang (string Nomegang, string Mottogang, string Abbreviazonegang, int numcomponentigang)   // COSTRUTTORE 
        {
            _Mottogang = Mottogang;

            _Abbreviazionegang = Abbreviazionegang;

            if (numcomponentigang < 2) numcomponentigang = 777;                                             //Filtro di una proprietà in sola Lettura
            _numcomponentigang = numcomponentigang;
            


        }

        public override string ToString()                                   // OVERRIDE DEL TOSTRING Come è rappresentata quella istanza
        {
           return  Nomegang + ' ' + Abbreviazionegang;
        }

        public string describe()
        {
            string output = "Questa è la gang: "+ Nomegang +"\r\n";
            output += "non provare a infamare la gang di " + numcomponentigang + " pischelli" + "\r\n";
            return output;
        }
           
        public virtual string Rimadellagang()
        {
            string output = "Perchè quando plano dall'alto ";
            return output;

            
        }
    }
}
