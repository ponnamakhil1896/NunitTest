using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2
{
    enum availopts
    {
        Getrectanglelength,
        Changerectanglelength,
        Getrectanglewidth,
        Changerectanglewidth,
        Getrectangleheight,
        Changerectangleheigth,
        getrectanglevolume,
        exit
    }
        
        class Program
        {
            static void Main(string[] args)
            {
                Program p = new Program();
                p.Go();
            }
            public void Go()
            {
            Rectangle rec = new Rectangle();
            string input = String.Empty;
            int length, width, height = 0;
            Console.WriteLine("\n Please enter the dimensions:");

            do
            {

                Console.Write("\n Length:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out length) || (length <= 0))
                {
                    Console.WriteLine("\nIncorrect input!!!! Try again");
                }
            } while (!(length > 0));

            do
            {

                Console.Write("\n Width:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out width) || (width <= 0))
                {
                    Console.WriteLine("\nIncorrect input!!!! Try again");
                }
            } while (!(width > 0));

            do
            {

                Console.Write("\n Height:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out height) || (height <= 0))
                {
                    Console.WriteLine("\n Incorrect input!!!! Try again");
                }
            } while (!(height > 0));

            var getops = Enum.GetNames(typeof(availopts));

                string slotChoice = string.Empty;
                Rectangle c = new Rectangle();
                do
                {
                    int i = 0;
                    foreach (string val in getops)
                    {

                        {
                            Console.WriteLine("{0}. {1}", i + 1, val);
                            i = i + 1;
                        }
                    }
                    Console.Write("Please choose the option: ");

                    slotChoice = Console.ReadLine();

                    Console.WriteLine(slotChoice);

                    switch (slotChoice)
                    {
                        case "1":

                            Console.WriteLine(c.GetLength());
                            break;

                        case "2":
                            string len;
                            int j;
                            do
                            {
                                Console.WriteLine("enter length:");
                                len = Console.ReadLine();
                            } while (!int.TryParse(len, out j));
                            c.SetLength(j);
                            break;

                        case "3":
                            Console.WriteLine(c.GetWidth());
                            break;

                        case "4":
                        string wid;
                        int k;
                        do
                        {
                            Console.WriteLine("enter width:");
                            wid = Console.ReadLine();
                        } while (!int.TryParse(wid, out k));
                        c.SetWidth(k);

                        break;

                        case "5":
                            Console.WriteLine(c.GetHeight());
                            break;

                        case "6":
                        string hgt;
                        int l;
                        do
                        {
                            Console.WriteLine("enter height:");
                            hgt = Console.ReadLine();
                        } while (!int.TryParse(hgt, out l));
                        c.SetHeight(l);

                        break;

                        case "7":
                            Console.WriteLine(c.GetVolume());
                            break;

                        case "8":
                            continue;


                }

            } while (!string.Equals(slotChoice, "8"));
                Console.ReadKey();
            }
        }
}
