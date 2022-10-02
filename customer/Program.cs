using static System.Console;
using ConvertTime;
namespace ConsoleApplication
{
    class Onlineshop
    {
        static void Main()
        {
            Welcome();
        }
        /*static  BuyTime()
        {
            DateTime t = DateTime.Now;
            string r1 = ConvertDateTime.ConvertDateToString(t);
            WriteLine(r1);
            ConvertDateTime.ConvertMiladiToShamsi(t);
            double result = ConvertDateTime.ConvertDateTimeToTimestamp(t);
            WriteLine(result);
        }*/
        static void Welcome()
        {
            WriteLine("*****WELLCOME!*****");
            WriteLine("We have Books, Clothes and Electric devices.\nPlease enter the name to choose: ");
            string? ch = ReadLine();
            DateTime t = DateTime.Now;
            switch (ch)
            {
                case "books":
                    
                    WriteLine("Books available in the shop are:");
                    Book b1 = new()
                    {
                        Name = "Animal Farm",
                        Price = 6.4,
                        Author = "George Orwell",
                        Type = "Novel"
                    };
                    Book b2 = new()
                    {
                        Name = "The Little Prince",
                        Price = 8.5,
                        Author = "Antoine de Saint-Exupery",
                        Type = "Novel"
                    };
                    Book b3 = new()
                    {
                        Name = "Daddy Long Legs",
                        Price = 7,
                        Author = "Jean Webster",
                        Type = "Novel"
                    };

                    WriteLine($"a: {b1.Name}, price: {b1.Price:C}, written by: {b1.Author}, type: {b1.Type}");
                    WriteLine($"b: {b2.Name}, price: {b2.Price:C}, written by: {b2.Author}, type: {b2.Type}");
                    WriteLine($"c: {b3.Name}, price: {b3.Price:C}, written by: {b3.Author}, type: {b3.Type}");
                    WriteLine("Please enter to select:");
                    string? b = ReadLine();
                    Write("On:");
                    ConvertDateTime.ConvertMiladiToShamsi(t);
                    switch(b)
                    {
                        case "a":
                        WriteLine($"You bought {b1.Name} with the price of {b1.Price:C} from our online shop.");
                        break;
                        case "b":
                        WriteLine($"You bought {b2.Name} with the price of {b2.Price:C} from our online shop.");
                        break;
                        case "c":
                        WriteLine($"You bought {b3.Name} with the price of {b3.Price:C} from our online shop.");
                        break;
                
                    }
                    break;

                case "clothes":
                    WriteLine("Clothes available in the shop are:");
                    Cloth c1 = new()
                    {
                        Name = "Scarf",
                        Price = 40,
                        Color = "Red",
                        Size = 0
                    };
                    Cloth c2 = new()
                    {
                        Name = "Coat",
                        Price = 180.5,
                        Color = "Blue",
                        Size = 38
                    };
                    Cloth c3 = new()
                    {
                        Name = "Shirt",
                        Price = 142.58,
                        Color = "White",
                        Size = 40
                    };
                    WriteLine($"a: {c1.Name}, price: {c1.Price:C}, color: {c1.Color}, size: {c1.Size}");
                    WriteLine($"b: {c2.Name}, price: {c2.Price:C}, color: {c2.Color}, size: {c2.Size}");
                    WriteLine($"c: {c3.Name}, price: {c3.Price:C}, color: {c3.Color}, size: {c3.Size}");
                    WriteLine("Please enter to select:");
                    string? c = ReadLine();
                    Write("On:");
                    ConvertDateTime.ConvertMiladiToShamsi(t);
                    switch(c)
                    {
                        case "a":
                        WriteLine($"You bought {c1.Name} with the price of {c1.Price:C} from our online shop.");
                        break;
                        case "b":
                        WriteLine($"You bought {c2.Name} with the price of {c2.Price:C} from our online shop.");
                        break;
                        case "c":
                        WriteLine($"You bought {c3.Name} with the price of {c3.Price:C} from our online shop.");
                        break;
                
                    }
                    break;

                case "electric devices":
                    WriteLine("Electric devices available in the shop are:");
                    Electronic e1 = new()
                    {
                        Name = "USB flashdrive",
                        Price = 80,
                        Origin = "Japan",
                        Color = "red"
                    };
                    Electronic e2 = new()
                    {
                        Name = "Headphone",
                        Price = 120,
                        Origin = "Spain",
                        Color = "Black"
                    };
                    Electronic e3 = new()
                    {
                        Name = "Laptop",
                        Price = 3000,
                        Origin = "Taiwan",
                        Color = "White"
                    };
                    WriteLine($"a: {e1.Name}, price: {e1.Price:C}, made in: {e1.Origin}, color: {e1.Color}");
                    WriteLine($"b: {e2.Name}, price: {e2.Price:C}, made in: {e2.Origin}, color:{e2.Color}");
                    WriteLine($"c: {e3.Name}, price: {e3.Price:C}, made in: {e3.Origin}, color:{e3.Color}");
                    WriteLine("Please enter to select:");
                    string? e = ReadLine();
                    Write("On:");
                    ConvertDateTime.ConvertMiladiToShamsi(t);
                    switch(e)
                    {
                        case "a":
                        WriteLine($"You bought {e1.Name} with the price of {e1.Price:C} from our online shop.");
                        break;
                        case "b":
                        WriteLine($"You bought {e2.Name} with the price of {e2.Price:C} from our online shop.");
                        break;
                        case "c":
                        WriteLine($"You bought {e3.Name} with the price of {e3.Price:C} from our online shop.");
                        break;
                
                    }
                    break;

            }
        }
        public class Items
        {
            public string? Name;
            public double Price;
        }

        private class Book : Items
        {
            public string? Author;
            public string? Type;
        }
        private class Cloth : Items
        {
            public string? Color;
            public int Size;
        }
        private class Electronic : Items
        {
            public string? Origin;
            public string? Color;
        }  


    }
}
