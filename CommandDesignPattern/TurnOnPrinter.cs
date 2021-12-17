using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnOnPrinter : Command
    {
        PrintMachine _printMachine;
        string _commandName = null;
        public TurnOnPrinter(PrintMachine printMachine)
        {
            _printMachine = printMachine;
            _commandName = "TurnOn";
        }
        public override void Execute()
        {
            _printMachine.Turnon();
        }

    }
}
