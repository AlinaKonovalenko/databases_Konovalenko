using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PostgreConsoleInteractorCS
{
    public class DatabaseController
    {
        DatabaseModel db = null;
        public DatabaseController(string connection_string)
        {
            db = new DatabaseModel(connection_string);
        }

        public int ShowActionList()
        {
            int choose;
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1.Insert data in the database");
            Console.WriteLine("2.Remove data from database");
            Console.WriteLine("3.Edit data in the database");
            Console.WriteLine("4.Generate random data in the database");
            Console.WriteLine("5.Search data in the database");
            Console.WriteLine("6.Print data in the database");
            Console.Write("Enter your choice: ");
            choose = int.Parse(Console.ReadLine());
            return choose;
        }

        public void Execute(int action)
        {
            if (db != null)
            {
                switch (action)
                {
                    case 1:
                        db.Insert();
                        break;
                    case 2:
                        db.Delete();
                        break;
                    case 3:
                        db.Update();
                        break;
                    case 4:
                        db.Generate();
                        break;
                    case 5:
                        db.Search();
                        break;
                    case 6:
                        db.Print();
                        break;
                    default:
                        Console.WriteLine("Not correct operation. Try again!");
                        break;
                }
            }
        }
    }
}