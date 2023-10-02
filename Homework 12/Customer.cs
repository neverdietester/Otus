using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Customer
    {
        public void OnItemChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Изменение в ассортименте магазина.");
        }
    }
}
