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
            InstructionList.Add(new Instruction(InstructionData, "1", "Доступ к аккаунту Windows", "Вкл", "Выкл"));
            InstructionList.Add(new Instruction(InstructionData, "2", "Доступ к CMD ", "Разрешен", "Запрещен"));
            InstructionList.Add(new Instruction(InstructionData, "3", "Доступ к BLUETOOTH", "Разрешен", "Запрещен"));
            InstructionList.Add(new Instruction(InstructionData, "4", "Доступ к приложению через терминал", "Разрешен", "Запрещен"));
            InstructionList.Add(new Instruction(InstructionData, "5", "Ограничение энергосбрегающего режима", "Разрешен", "Запрещен"));
            InstructionList.Add(new Instruction(InstructionData, "6", "Выская контрастность", "Включена", "Выключена"));
            InstructionList.Add(new Instruction(InstructionData, "7", "Требование пароля при обращении к приложению", "Включен", "Выключен"));
            InstructionList.Add(new Instruction(InstructionData, "8", "Доступ к WI-Fi", "Разрешен", "Запрещен"));
            InstructionList.Add(new Instruction(InstructionData, "9", "Автоматическое обновление приложения", "Разрешено", "Запрещено"));
            InstructionList.Add(new Instruction(InstructionData, "10", "Проверка обновлений", "Влючена", "Выключена"));
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
