using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Ubuntu_Instructions:AbstractFactory
    {
        private List<Instruction> InstructionList;
        private Mediator InstructionData;
        Ubuntu_Instructions()
        {
            InstructionList = new List<Instruction>();
            InstructionData = new Mediator();
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
        }
    }
}
