namespace csharp_abstract_animals
{
    internal class Program
    {

        //Dobbiamo realizzare un programma che rappresenti il regno animale.
        //Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
        //Vogliamo che gli animali abbiano i seguenti metodi
        //void Dormi() (mostra a video “Zzz”)
        //void Verso() (mostra a video il verso fatto dall'animale specifico)
        //void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
        //Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
        //Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

        static void Main(string[] args)
        {
            Cane cane = new Cane();
            cane.Verso();
            cane.Mangia();
            cane.Dormi();

            Passerotto passerotto = new Passerotto();
            passerotto.Verso();
            passerotto.Mangia();
            passerotto.Dormi();


            Aquila aquila = new Aquila();
            aquila.Verso();
            aquila.Mangia();
            aquila.Dormi();


            Delfino delfino = new Delfino();
            delfino.Verso();
            delfino.Mangia();
            delfino.Dormi();

            static void FaiVolare(iVola animals)
            {
                animals.Vola();
            }

            static void FaiNuotare(iNuota animals)
            {
                animals.Nuota();
            }

            Console.WriteLine("il passerotto sta volando: ");
            Passerotto passerottoVolante = new Passerotto();
            FaiVolare(passerottoVolante);
            Console.WriteLine("l'aquila sta volando: ");
            Aquila aquilaVolante = new Aquila();
            FaiVolare(aquilaVolante);


            Console.WriteLine("il delfino sta nuotando: ");
            Delfino delfinoNuotante = new Delfino();
            FaiNuotare(delfinoNuotante);
        }
    }
}