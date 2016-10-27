using System;

namespace Vsite.CSharp.StatičkiČlanovi
{
    public class BrojačInstanci
    {
        //  Dodati privatni statički član "brojač" tipa int i inicijalizirati ga na 0
        static int brojač = 0;
        int instanca;

        //  U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana brojač
        public static void IspišiBrojStvorenihObjekata()
        {
            Console.WriteLine(brojač);
        }

        //  U klasu dodati privatni član "instanca" tipa int

        //  U konstruktor dodati naredbu koja će uvećati "brojač" za 1 i uvećanu vrijednost dodijeliti članu "instanca"
        public BrojačInstanci()
        {
            instanca = ++brojač;
        }

        //  U metodu dodati naredbu koja će ispisati vrijednost člana "instanca"
        public void IspišiRedniBrojObjekta()
        {
            Console.WriteLine(instanca);
        }
    }
}
