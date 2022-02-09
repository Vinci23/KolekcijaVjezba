using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcijaPodaci
{
    internal class Podatci
    {
        private string podatak1, podatak2, podatak3, podatak4;

        public override string ToString()
        {
            string ispis = this.podatak1 + "\t" + this.podatak2 + "\t"
                + this.podatak3 + "\t" + this.podatak4;
            return ispis;
        }
        public Podatci(string podatak1, string podatak2, string podatak3, string podatak4)
        {
            this.podatak1 = podatak1;
            this.podatak2 = podatak2;
            this.podatak3 = podatak3;
            this.podatak4 = podatak4;
        }
        public string Podatak1 { get => podatak1; set => podatak1 = value; }
        public string Podatak2 { get => podatak2; set => podatak2 = value; }  
        public string Podatak3 { get => podatak3; set => podatak3 = value; }
        public string Podatak4 { get => podatak4; set => podatak4 = value; }
    }    
}
