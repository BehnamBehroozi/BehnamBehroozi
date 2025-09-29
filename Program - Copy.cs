using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace تمرین_برنامه_نویس_مسُول_استراحتگاه_لوکس
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int singleroom = 10000000;
            int doubleroom = 150000000;              //input variable
            int familyroom = 20000000;
            int countsingleroom = 5;
            int countdoubleroom = 10;
            int countfamilyroom = 15;
            int n = 0;

            int boxextra = 2000000;
            int datearrival;
            int dateexit;
            string yes;
            string no;
            {
                Console.WriteLine("*Welcome to the luxurious Toranj beach resort*");
                Console.WriteLine("*I hope you enjoy your stay*");
                Console.Write("Please choose your room =");
                Console.ReadLine();
                Console.Write("Enter the number of rooms you choose =");
                countsingleroom = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the arrival date = ");
                datearrival = Convert.ToInt32(Console.ReadLine());               //funtion
                Console.Write("Please enter the exit date =");
                dateexit = Convert.ToInt32(Console.ReadLine());
                Console.Write("Are you sure about your choice?");
                yes = Console.ReadLine();
                if (yes == yes)
                {
                    Console.Write("Final cost =");
                    Console.Write(singleroom * (datearrival - dateexit) + boxextra);
                    Console.Write("number of singleroom remaining =");
                    for (int h = countsingleroom; h < countsingleroom; h--)
                    {
                        Console.WriteLine(h);
                        {
                            no = Console.ReadLine();
                            if (no == no)
                            {
                                Console.Write("Please choose your room =");
                                Console.Write("Enter the number of rooms you choose =");
                                countsingleroom = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Please enter the arrival date = ");
                                datearrival = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Please enter the exit date =");
                                dateexit = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Final cost =");
                                Console.Write(singleroom * (datearrival - dateexit) + boxextra);
                                Console.Write("number of singleroom remaining =");
                                for (int k = countsingleroom; k < countsingleroom; k--)
                                {
                                    Console.WriteLine(h);
                                }




                                {
                                    Console.WriteLine();
                                    Console.Write("Please choose your room =");
                                    Console.Write("Enter the number of rooms you choose =");
                                    countdoubleroom = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Please enter the arrival date = ");
                                    datearrival = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Please enter the exit date =");
                                    dateexit = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Are you sure about your choice?");
                                    yes = Console.ReadLine();
                                    if (yes == yes)
                                    {
                                        Console.Write("Final cost =");
                                        Console.Write(doubleroom * (datearrival - dateexit) + boxextra);
                                        Console.Write("number of doubleroom remaining =");
                                        for (int d = countdoubleroom; d < countdoubleroom; d--)
                                        {
                                            Console.WriteLine(d);
                                            {
                                                no = Console.ReadLine();
                                                if (no == no)
                                                {
                                                    Console.Write("Please choose your room =");
                                                    Console.Write("Enter the number of rooms you choose =");
                                                    countdoubleroom = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Please enter the arrival date = ");
                                                    datearrival = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Please enter the exit date =");
                                                    dateexit = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Final cost =");
                                                    Console.Write(familyroom * (datearrival - dateexit) + boxextra);
                                                    Console.Write("number of family remaining =");
                                                    for(int t = countdoubleroom; t<countdoubleroom; t--)
                                                    {
                                                        Console.WriteLine(t);
                                                    }
                                                }
                                            }
                                        }
                                    } 
                                   

                                    
                                        
                                    
                                    {
                                        Console.Write("Please chose your room =");
                                        Console.Write("Enter the number of rooms you choose =");
                                        countfamilyroom = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Please enter the arrival date=");
                                        datearrival = Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Please enter thr exit date =");
                                        dateexit = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Are you sure about your choice?");
                                        yes = Console.ReadLine();
                                        if (yes==yes)
                                        {
                                            Console.Write("Final cost =");
                                            Console.Write(familyroom * (datearrival - dateexit) + boxextra);
                                            Console.Write("number of family remaining =");
                                            for (int y = countdoubleroom; y < countdoubleroom; y--)
                                            {
                                                Console.WriteLine(y);
                                            }
                                            {
                                                no = Console.ReadLine();
                                                if (no == no)
                                                {
                                                    Console.Write("Please choose your room =");
                                                    Console.Write("Enter the number of rooms you choose =");
                                                    countfamilyroom = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Please enter the arrival date = ");
                                                    datearrival = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Please enter the exit date =");
                                                    dateexit = Convert.ToInt32(Console.ReadLine());
                                                    Console.Write("Final cost =");
                                                    Console.Write(familyroom * (datearrival - dateexit) + boxextra);
                                                    Console.Write("number of family remaining =");
                                                    for (int b = countfamilyroom; n < countfamilyroom; b++)
                                                    {
                                                        Console.WriteLine(b);
                                                    }
                                                } Console.ReadKey();                   //output
                                            }
                                        }
                                      
                                        {



                                        }

                                    }

                                }





                            }
                        }
                    }
                }
            }
        }
    }
}


    

