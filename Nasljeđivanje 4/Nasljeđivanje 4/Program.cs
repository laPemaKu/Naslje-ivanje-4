using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje_4
{
    internal class Program
    {
        class Biljka
        {

        }
        class Stablo : Biljka
        {
            public string ime;
            public bool otpadajuListovi;
            public string vrstaStabla;

            public virtual bool OtpadajuListovi()
            {
                return this.otpadajuListovi;
            }
            public virtual string VrstaStabla()
            {
                return this.vrstaStabla;
            }
            public virtual string Ime()
            {
                return this.ime;
            }

            public Stablo()
            {

            }
            public Stablo(string ime, bool otpadajuListovi, string vrstaStabla)
            {
                this.otpadajuListovi = otpadajuListovi;
                this.vrstaStabla = vrstaStabla;
                this.ime = ime;
            }

        }
        class Cvijet : Biljka
        {
            
        }
        class Crnogoricno : Stablo
        {
            public Crnogoricno()
            {

            }
            public Crnogoricno(string ime)
            {
                this.ime = ime;
            }
            public override bool OtpadajuListovi()
            {
                this.otpadajuListovi = false;
                return this.otpadajuListovi;
            }
            public override string VrstaStabla()
            {
                this.vrstaStabla = "Crnogorično";
                return this.vrstaStabla;
            }
        }

        class Bijelogoricno : Stablo
        {
            public Bijelogoricno()
            {

            }
            public Bijelogoricno(string ime)
            {
                this.ime = ime;
            }
            public override bool OtpadajuListovi()
            {
                this.otpadajuListovi = true;
                return this.otpadajuListovi;
            }
            public override string VrstaStabla()
            {
                this.vrstaStabla = "Bijelogorično";
                return this.vrstaStabla;
            }
        }
        static void Main(string[] args)
        {
            Crnogoricno bor = new Crnogoricno("Bor");
            Bijelogoricno hrast = new Bijelogoricno("Hrast");
            Console.WriteLine(bor.Ime() +" "+ bor.OtpadajuListovi());
            Console.WriteLine(hrast.Ime() + " " + hrast.OtpadajuListovi());
            Console.ReadKey();
        }
    }
}
