using Umumi_TaskLar_Vehicle.Models;

namespace Umumi_TaskLar_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Gallery adini daxil edin");
                string galleryname = Console.ReadLine();
                Gallery gallery = new Gallery(galleryname);

                string secim;

                do
                {
                    start:
                    Console.WriteLine("Masin elave edin (1)");
                    Console.WriteLine("Masinlari Qaytar (2)");
                    Console.WriteLine("Masin Axtarmaq (3)");
                    Console.WriteLine("Exit (0)");

                    Console.WriteLine("Secimi daxil edin: ");
                    secim = Console.ReadLine();

                    switch(secim)
                    {
                        
                        case "1":
                            Console.WriteLine("Brand daxil edin: ");
                            string brandad = Console.ReadLine();

                            Console.WriteLine("Model daxil edin: ");
                            string modelad = Console.ReadLine();

                            double mile;
                            while (true)
                            {
                                Console.Write("Mile daxil edin: ");
                                string daxil_edilen_qiymet = Console.ReadLine();
                                if (double.TryParse(daxil_edilen_qiymet, out mile))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ancaq reqem daxil edin nidaa");
                                }
                            }

                            int doorsnum;
                            while (true)
                            {
                                Console.Write("Doorsnum daxil edin: ");
                                string daxil_edilen_qiymet0 = Console.ReadLine();
                                if (int.TryParse(daxil_edilen_qiymet0, out doorsnum))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Ancaq reqem daxil edin nidaa");
                                }
                            }

                            Car car = new Car(brandad,modelad,mile,doorsnum);
                            Console.WriteLine("Car yaradildi xeyirli olsun");

                            break;
                        case "2":
                            Console.WriteLine("Butun carlari geri qaytar");
                            gallery.AllCars();
                            break;


                        case "3":


                            do
                            {
                                Console.WriteLine("Filteri uygun masin axtar");
                                Console.WriteLine("Brand adina gore axtarmaq (1)");
                                Console.WriteLine("Mile gore axtarmaq (2)");
                                Console.WriteLine("Geri qayitmaq (3)");
                                Console.WriteLine("Exit (0)");

                                switch (secim)
                                {
                                    case "1":
                                        Console.WriteLine("Brand adini daxil edin: ");
                                        string brand101 = Console.ReadLine();

                                        gallery.FilterCarsB(brand101);
                                        break;
                                    case "2":

                                        double mile01;
                                        while (true)
                                        {
                                            Console.Write("Mile adini daxil edin: ");
                                            string daxil_edilen_qiymet = Console.ReadLine();
                                            if (double.TryParse(daxil_edilen_qiymet, out mile01))
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Ancaq reqem daxil edin nidaa");
                                            }
                                        }
                                        gallery.FilterCarsM(mile01);



                                        break;
                                    case "3":
                                        Console.WriteLine("Geriye qayidin");
                                        goto start; 
                                        break;
                                    case "0":
                                        Console.WriteLine("Proqramdan cixildi");
                                        break;
                                    default:
                                        Console.WriteLine("duzgun secim daxil edinnn");
                                        break ;
                                }

                            }
                            while (secim != "0");

                            break;
                        case "0":
                            Console.WriteLine("Proqramdan cixildi");
                            break;
                        default:
                            Console.WriteLine("Duzgun secim daxil edin");
                            break;
                    }



                }
                while (secim != "0");




            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Kod xetasi:" + ex.Message);
            }


            

        }
    }
}
