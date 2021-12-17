using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Printer:Command
    {
        PrintMachine _printMachine;
        string _commandName = null;
        public Printer(PrintMachine printMachine)
        {
            _printMachine = printMachine;
            _commandName = "Print";
        }
        public override void Execute()
        {
            _printMachine.Print();
        }
    }
}
