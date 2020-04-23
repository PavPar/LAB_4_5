using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    /// <summary>
    /// Класс Посредник
    /// </summary>
    class Mediator :Lead
    {
        public List<Instruction> Instructions;
        private ConsoleSpeaker con;
        /// <summary>
        ///Констркутор класса
        /// </summary>
        public Mediator()
        {
            Instructions = new List<Instruction>();
            con = new ConsoleSpeaker();
        }
        /// <summary>
        /// Получение данных при обновлении инструкции
        /// </summary>
        public void notify(Instruction sender)
        {
        }
        /// <summary>
        /// Вывести все иструкции в консоль
        /// </summary>
        public void showAllInstr()
        {
            foreach(Instruction instr in Instructions)
            {
                con.showMessage_Normal(instr.GetMsgText() + "-" + instr.GetStatus());
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Установить все инструкции
        /// </summary>
        public void setAllInstructions()
        {
            for(int i=0; i < Instructions.Count; i++)
            {
                Instructions[i].SetInstruction();
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Изменить конкретную иструкцию
        /// </summary>
        public void changeSpecificInstruction()
        {
            con.getInstructionMenu("Choose Instruction", Instructions).SetInstruction();
            Console.WriteLine();
        }
    }
}
