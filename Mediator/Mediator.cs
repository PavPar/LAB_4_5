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
        private ConsoleSpeaker con;
        public Mediator()
        {
            Instructions = new List<Instruction>();
            con = new ConsoleSpeaker();
        }
        public void notify(Instruction sender)
        {
        }
        public void showAllInstr()
        {
            foreach(Instruction instr in Instructions)
            {
                con.showMessage_Normal(instr.GetMsgText() + "-" + instr.GetStatus());
            }
            Console.WriteLine();
        }
        public void setAllInstructions()
        {
            for(int i=0; i < Instructions.Count; i++)
            {
                Instructions[i].SetInstruction();
                Console.WriteLine();
            }
        }

        public void changeSpecificInstruction()
        {
            con.getInstructionMenu("Choose Instruction", Instructions).SetInstruction();
            Console.WriteLine();
        }
    }
}
