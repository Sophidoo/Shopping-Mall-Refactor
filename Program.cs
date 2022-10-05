namespace Shopping_Mall
{
    internal class Program
    {
        public class Shopping
        {
            public static void Main(string[] args)
            {

                Console.WriteLine("================================================");
                Console.WriteLine("|              SHOPPING MALL                   |");
                Console.WriteLine("================================================");

                Console.WriteLine("\n\n Our Available Items:");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|id        |Item              |Price($)        |");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("|1         |Laptop            |1000.00         |");
                Console.WriteLine("|2         |Mouse             |50.00           |");
                Console.WriteLine("|3         |Keyboard          |500.00          |");
                Console.WriteLine("------------------------------------------------");

                Shop user = new Shop();

                Console.WriteLine("\n\nPlease input the id of the Item you want to buy, note that you can't buy more than 6 items");
                user.SetId(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("\n\nPlease Input the quantity you want to buy?");
                user.SetQuantity(Convert.ToInt32(Console.ReadLine()));

                
                user.Items();

                user.UserItems();
                


                Console.ReadLine();
            }
            public void ShoppingMall()
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

                Shop users = new Shop();

                Console.WriteLine("\n\nPlease input the id of the Item you want to buy, note that you can't buy more than 6 items");
                users.SetId(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("\n\nPlease Input the quantity you want to buy?");
                users.SetQuantity(Convert.ToInt32(Console.ReadLine()));

                

                
            }
        
        }
        
    }
}