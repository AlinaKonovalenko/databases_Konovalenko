using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PostgreConsoleInteractorCS
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseView view = new DatabaseView();
            view.Process();
        }
    }
}