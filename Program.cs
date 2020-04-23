using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator test = new Mediator();
            List<Instruction> temp = new List<Instruction>();
            Instruction instr = new Instruction(test, "1", "U gay?", "Ye", "Nah");
            temp.Add(instr);
            test.Instructions = temp;
            test.SetAllInstructions();
            test.showAllInstr();
            Console.ReadKey();
        }
    }
}
