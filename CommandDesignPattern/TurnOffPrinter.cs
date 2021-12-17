using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class TurnOffPrinter:Command
    {
        PrintMachine _printMachine;
        public  string _commandName = null;
        public TurnOffPrinter(PrintMachine printMachine)
        {
            _printMachine = printMachine;
            _commandName = "TurnOff";
        }
        public override void Execute()
        {
            _printMachine.TurnOff();
        }
    }
}
