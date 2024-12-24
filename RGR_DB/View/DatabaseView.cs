using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreConsoleInteractorCS
{
    public class DatabaseView
    {
        DatabaseController controller;

        public void Process()
        {
            string connection_string = "Server=localhost;Port=5432;User ID=postgres;Password=0000;Database=postgres;";
            controller = new DatabaseController(connection_string);
            while (true)
            {
                int action = controller.ShowActionList();
                controller.Execute(action);
            }
        }
    }
}