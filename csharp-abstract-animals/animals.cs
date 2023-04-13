using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    abstract class animal
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzzzzzzzzz");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }

    class Cane : animal
    {

        string nome = "cane";
        public override void Verso()
        {
            Console.WriteLine($"il verso del {nome} è: bau bau arf arf");
        }

        public override void Mangia()
        {
            Console.WriteLine($"il {nome} è onnivoro; quindi carne, verdure, bambini");
        }
    }

    class Passerotto : animal, iVola
    {

        string nome = "passerotto";
        public override void Verso()
        {
            Console.WriteLine($"il verso del {nome} è: pio pio chip chip");
        }

        public override void Mangia()
        {
            Console.WriteLine($"il {nome} mangia: semi, granaglie, frutta, bacche e insetti");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    class Aquila : animal, iVola
    {

        string nome = "aquila";
        public override void Verso()
        {
            Console.WriteLine($"il verso dell'{nome} è: krak-krak-krak eek-eek-eek");
        }

        public override void Mangia()
        {
            Console.WriteLine($"il {nome} mangia: roditori, conigli, serpenti, pesci, uccelli");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    class Delfino : animal, iNuota
    {

        string nome = "delfino";
        public override void Verso()
        {
            Console.WriteLine($"il verso del {nome} è: iiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii");
        }

        public override void Mangia()
        {
            Console.WriteLine($"il {nome} mangia: pesci, calamari, gamberetti, crostacei");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
    }
}
