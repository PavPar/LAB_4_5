using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Instruction
    {
        private string id;
        private string msgText;
        private bool status;
        private string msg_True;
        private string msg_False;
        private Mediator dialog;

        public Instruction(Mediator dialog,string InstructionID,string InstructionMsgText, string InstructionMsg_True, string InstructionMsg_False)
        {
            id = InstructionID;
            msgText = InstructionMsgText;
            status = false;
            msg_True = InstructionMsg_True;
            msg_False = InstructionMsg_False;
        }
        public void SetInstruction()
        {
            //ShowMsg(InstructionMsgText);
            //InstructionStatus = AskUserInput(valueFalse,valueTrue);
        }
    }
}
