using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPhoto
{
    class Check
    {
        static bool ToBool(string check)
        {
            if (check.ToLower().Equals("да"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void CheckDoc()
        {
        Link1:
            Console.WriteLine("Среди поданых документов есть фотография?");
            string check1 = Console.ReadLine();
            if (Check.ToBool(check1))
            {
                Console.WriteLine("Фотография сделана менее 3 месяцев назад?");
                string check2 = Console.ReadLine();
                if (Check.ToBool(check2))
                {
                    Console.WriteLine("Фотография не использовалась на паспорт?");
                    string check3 = Console.ReadLine();
                    if (Check.ToBool(check3))
                    {
                    Link2:
                        Console.WriteLine("Фотография вклеена?");
                        string check4 = Console.ReadLine();
                        if (Check.ToBool(check4))
                        {

                            Console.WriteLine("Отправить на оплату.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Попросить вклеить фотографию.");
                            goto Link2;

                        }
                    }
                    else
                    {
                        Console.WriteLine("Отправить в фотокомнату");
                        goto Link1;

                    }
                }
                else
                {
                    Console.WriteLine("Отправить в фотокомнату");
                    goto Link1;

                }
            }
            else
            {
                Console.WriteLine("Отправить в фотокомнату");
                goto Link1;

            }
        }
    }
}
