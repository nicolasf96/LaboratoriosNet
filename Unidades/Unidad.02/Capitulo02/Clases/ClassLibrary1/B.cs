using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class B : A
    {

        public void M4()
        {
            Console.WriteLine("Método del hijo invocado");
        }

        public B() : base("Instancia de B")
        {

        }
    }
}
