using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shopping_Mall.Program;

namespace Shopping_Mall
{
    public class Shop
    {
        private int id;
        private int quantity;
        private string progress = "";
        private string[,] itemsBought = new string[6,5];
        private int subtotal;
        private int total;


        public void SetId(int id)
        {
            id = Valid(id);
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }


        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }


        public void SetProgress(string progress)
        {
            this.progress = progress;
        }
        public string GetProgress()
        {
            return progress;
        }

        public void SetSubtotal(int subtotal)
        {
            this.subtotal = subtotal;
        }
        public int GetSubtotal()
        {
            return subtotal;
        }

        public void SetTotal(int total)
        {
            this.total = total;
        }
        public int GetTotal()
        {
            return total;
        }


        public void Items()
        {
            int row = 6;
            int column = 5;
            
            /*itemsBought = new string[row, column];*/

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    switch (GetId())
                    {
                        case 1:
                            itemsBought[i, 0] = "|1        ";
                            itemsBought[i, 1] = "|Laptop       ";
                            itemsBought[i, 2] = "|1000.00       ";
                            itemsBought[i, 3] = "|" + Convert.ToString(GetQuantity()) + "        |";
                            itemsBought[i, 4] = Convert.ToString(1000 * GetQuantity()) + "       ";

                            break;
                        case 2:
                            itemsBought[i, 0] = "|2        ";
                            itemsBought[i, 1] = "|Mouse        ";
                            itemsBought[i, 2] = "|50.00         ";
                            itemsBought[i, 3] = "|" + Convert.ToString(GetQuantity()) + "        |";
                            itemsBought[i, 4] = Convert.ToString(50 * GetQuantity()) + "        ";

                            break;
                        case 3:
                            itemsBought[i, 0] = "|3        ";
                            itemsBought[i, 1] = "|Keyboard     ";
                            itemsBought[i, 2] = "|500.00        ";
                            itemsBought[i, 3] = "|" + Convert.ToString(GetQuantity()) + "        |";
                            itemsBought[i, 4] = Convert.ToString(500 * GetQuantity()) + "        ";

                            break;
                    }
                /*Console.WriteLine(GetId());*/
                }

                SetSubtotal(Convert.ToInt32(itemsBought[i, 4].Trim()));
                SetTotal(GetTotal() + GetSubtotal());

                Console.WriteLine("\n \nDo you want to buy another item? if yes write y, if no write n");
                SetProgress(Console.ReadLine());

                if (GetProgress().ToLower() == "y")
                {
                    Console.WriteLine("\n\n Our Available Items:");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("|id        |Item              |Price($)        |");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("|1         |Laptop            |1000.00         |");
                    Console.WriteLine("|2         |Mouse             |50.00           |");
                    Console.WriteLine("|3         |Keyboard          |500.00          |");
                    Console.WriteLine("------------------------------------------------");

                    /*Shop users = new Shop();*/

                    Console.WriteLine("\n\nPlease input the id of the Item you want to buy, note that you can't buy more than 6 items");
                    SetId(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("\n\nPlease Input the quantity you want to buy?");
                    SetQuantity(Convert.ToInt32(Console.ReadLine()));
                }
                else
                {
                    break;
                }
            }
            
        }

        public void UserItems()
        {
            Console.WriteLine("\n\n\n================================================================");
            Console.WriteLine("\n\n>>>>Your Items Bought\n\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|   Id    |    Item     |   Price($)   |  Quantity |  SubTotal |");
            Console.WriteLine("----------------------------------------------------------------");
            for (int i = 0; i < itemsBought.GetLength(0); i++)
            {
                for (int j = 0; j < itemsBought.GetLength(1); j++)
                {
                    Console.Write(itemsBought[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(">>>> Total of all items is " + GetTotal());
            Console.WriteLine("==================================================================");
        /*Console.WriteLine(GetId());*/


        }

        public static int Valid(int id)
        {
            if (id <= 0 || id > 3)
            {
                Console.WriteLine("Please Input a valid id");
                id = Convert.ToInt32(Console.ReadLine());
                id = Valid(id);
            }

            return id;

        }
    }
}
