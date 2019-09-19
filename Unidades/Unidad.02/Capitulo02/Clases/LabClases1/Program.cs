using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {

            A variableA = new A();

            B variableB = new B();

            variableA.M1();
            variableA.M2();
            variableA.M3();

            variableB.M1();
            variableB.M2();
            variableB.M3();
            variableB.M4();

        }
    }
}
