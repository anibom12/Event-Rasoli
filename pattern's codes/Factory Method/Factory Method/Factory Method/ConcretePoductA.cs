using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method;

public class ConcreteProductA : IProduct
{
    public void ShowInfo() => Console.WriteLine("Product A created.");
}