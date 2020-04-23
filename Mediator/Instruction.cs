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
        private ConsoleSpeaker con;
        public Instruction(Mediator dialog,string InstructionID,string InstructionMsgText, string InstructionMsg_True, string InstructionMsg_False)
        {
            this.dialog = dialog;
            id = InstructionID;
            msgText = InstructionMsgText;
            status = false;
            msg_True = InstructionMsg_True;
            msg_False = InstructionMsg_False;
            con = new ConsoleSpeaker();
        }
        public void SetInstruction()
        {
            if (con.getUserInput_bool(msgText,msg_True,msg_False))
            {
                status = true;
            }
            else
            {
                status = false;
            }
            dialog.notify(this);
        }
        public string GetMsgText()
        {
            return msgText;
        }

        public string GetStatus()
        {
            if (status)
            {
                return msg_True;
            }
            else
            {
                return msg_False;
            }
        }

    }
}
