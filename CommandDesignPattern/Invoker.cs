using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Invoker
    {
       public void PressButton(Command command)
        {
            command.Execute();
        }
    }
}
