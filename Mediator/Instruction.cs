using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    /// <summary>
    /// Класс инструкции
    /// </summary>
    class Instruction
    {
        private string id;
        private string msgText;
        private bool status;
        private string msg_True;
        private string msg_False;
        private Mediator dialog;
        private ConsoleSpeaker con;
        /// <summary>
        /// Конструктор Класса
        /// </summary>
        /// <param name="dialog">Посредник</param>
        /// <param name="InstructionID">ID инструкции</param>
        /// <param name="InstructionMsgText">Текст инструкции для вывода в консоль</param>
        /// <param name="InstructionMsg_False">Текст при состоянии false</param>
        /// <param name="InstructionMsg_True">Текст при состоянии true</param>
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
        /// <summary>
        /// Установка значения инструкции
        /// </summary>
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
        /// <summary>
        /// Получить значение текстового сообщения
        /// </summary>
        /// <returns>Заданное сообщение</returns>
        public string GetMsgText()
        {
            return msgText;
        }
        /// <summary>
        /// Получить статус инструкции
        /// </summary>
        /// <returns>Заданное сообщение при true/false</returns>
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
