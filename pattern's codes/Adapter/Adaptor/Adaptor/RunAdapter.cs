using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor;

public class RunAdapter
{
    public void Execute()
    {
        Adaptee adaptee = new Adaptee();
        ITarget adapter = new Adapter(adaptee);
        adapter.Request(); 
    }
}
