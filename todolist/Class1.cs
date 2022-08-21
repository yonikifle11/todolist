using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    internal class Class1
    {
        static private List<String> items = new List<String>();
        public string thing1 { get; set; }



        public void save()
        {
            MessageBox.Show("saved");
        }
        public static List <String> GetAllProducts()
        {
            return Class1.GetAllProducts();
        }

    }
}

