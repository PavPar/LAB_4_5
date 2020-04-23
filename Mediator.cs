using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Mediator:Lead
    {
        public List<Instruction> Instructions;
        public void notify(Instruction sender)
        {
            Console.WriteLine(sender.GetStatus());
        }
        public void showAllInstr()
        {
            foreach(Instruction instr in Instructions)
            {
                Console.WriteLine(instr.GetMsgText() + "-" + instr.GetStatus());
            }
        }
        public void SetAllInstructions()
        {
            for(int i=0; i < Instructions.Count; i++)
            {
                Instructions[i].SetInstruction();
            }
        }
    }
}
