using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargAuto
{
    class Program
    {
        private static readonly object marca;

        static void Main()
        {
            Masini masina = new Masini();

           // masina = AdaugaMasini();
            //AfisareMasini(masina);

            string optiune;
            do
            {
                Console.WriteLine("1.Adauga o masina la vanzare");
                Console.WriteLine("2.Afisarea masinilor");
                Console.WriteLine("3.Modifica o masina");
                Console.WriteLine("4.Cauta o masina dupa");
                Console.WriteLine("5.Imprumuta o masina");
                Console.WriteLine("6.Sterge o masina de la vanzare");
                Console.WriteLine("X.Inchide programul");
                Console.WriteLine("Alege o optiune:");
                optiune = Console.ReadLine();
                switch(optiune.ToUpper())
                {
                    case "1":
                        masina = AdaugaMasini();
                        break;

                    case "2":
                        AfisareMasini(masina);
                        StreamWriter sw = new StreamWriter("Masini.txt");
                        sw.WriteLine(masina.Cod);
                        sw.WriteLine(masina.marca);
                        sw.WriteLine(masina.model);
                        sw.WriteLine(masina.an);
                        sw.WriteLine(masina.motor);
                        sw.WriteLine(masina.tractiune);
                        sw.WriteLine(masina.pret);

                        sw.Close();
                        break;
                    case "X":

                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");

                        break;
                }

            } while (optiune.ToUpper() != "X");


            Console.ReadKey();
        }
        public static Masini AdaugaMasini()
        {
            


            Console.WriteLine("Introdu datele masinii:\n");
            Console.WriteLine("Marca:");
            string marca = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            Console.WriteLine("An:");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Motor:");
            string motor = Console.ReadLine();
            Console.WriteLine("Tractiune:");
            string tractiune = Console.ReadLine();
            Console.WriteLine("Pret:");
            string pret = Console.ReadLine();

           
            

            Masini masina = new Masini(marca, model, an, motor, tractiune,pret);


            return masina;


        }
        public static void AfisareMasini(Masini masina)
        {

            Console.WriteLine("Masinile sunt:\n");
            Console.WriteLine("Cod    Marca    Model    An    Motor    Tractiune    Pret\n");
            
           
                Console.WriteLine("{0}      {1}    {2}    {3}    {4}    {5}    {6}\n", masina.Cod,masina.marca,masina.model,masina.an,masina.motor,masina.tractiune,masina.pret);
              /***  Console.WriteLine("Marca:{0}", masina.marca);
                Console.WriteLine("Model:{0}", masina.model);
                Console.WriteLine("An:{0}", masina.an);
                Console.WriteLine("Motor:{0}", masina.motor);
                Console.WriteLine("Tractiune:{0}", masina.tractiune);
                Console.WriteLine("Pret:{0}", masina.pret);
              ***/
           
            

            
            
            
        }
        
    }

}
