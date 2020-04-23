using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Win_Instructions:AbstractFactory
    {
        private List<Instruction> InstructionList;
        private Mediator InstructionData;
        private ConsoleSpeaker con;
        private string[] MenuMSGS = { "Show All Instructions", "Change All Instructions", "Change Speific Instruction", "Exit" };
        public Win_Instructions()
        {
            InstructionList = new List<Instruction>();
            InstructionData = new Mediator();
            con = new ConsoleSpeaker();
            InstructionList.Add(new Instruction(InstructionData, "U_1", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_2", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_3", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_4", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_5", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_6", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_7", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_8", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_9", "U gay?", "Ye", "Nah"));
            InstructionList.Add(new Instruction(InstructionData, "U_10", "U gay?", "Ye", "Nah"));
            InstructionData.Instructions = InstructionList;
        }
        public void CreateInstructionSet()
        {
            while (true)
            {
                switch (con.showMenu("What do you want to do?", MenuMSGS))
                {
                    case 0:
                        {
                            InstructionData.showAllInstr();
                            continue;
                        }
                    case 1:
                        {
                            InstructionData.setAllInstructions();
                            continue;
                        }
                    case 2:
                        {
                            InstructionData.changeSpecificInstruction();
                            continue;
                        }
                    case 3:
                        {
                            return;
                        }
                };
            }

        }
    }
}
