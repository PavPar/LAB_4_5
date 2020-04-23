using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    /// <summary>
    /// Класс производящий вывод в консоль сообщений
    /// </summary>
    class ConsoleSpeaker
    {
        /// <summary>
        /// Вывод обычного сообщения
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// 
        public void showMessage_Normal(string text)
        {
            showMessage(text, ConsoleColor.White);
        }
        /// <summary>
        /// Вывод системного сообщения
        ///  </summary>
        /// <param name="text">Текст сообщения</param>
        ///
        public void showMessage_System(string text)
        {
            showMessage(text, ConsoleColor.Blue);
        }
        /// <summary>
        /// Вывод предупреждения
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// 
        public void showMessage_Warning(string text)
        {
            showMessage(text, ConsoleColor.Yellow);
        }
        /// <summary>
        /// Вывод ошибки
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// 
        public void showMessage_Error(string text)
        {
            showMessage(text, ConsoleColor.Red);
        }
        /// <summary>
        /// Вывод удачи
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// 
        public void showMessage_Success(string text)
        {
            showMessage(text, ConsoleColor.Green);
        }
        /// <summary>
        /// Вывод сообщения определенного цвета
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        /// <param name="color">Цвет текста сообщения</param>
        /// 
        public void showMessage(string text, ConsoleColor color)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = prev;
        }
        /// <summary>
        /// Вывод меню
        /// </summary>
        /// <param name="title">Заголовок меню</param>
        /// <param name="arr">Элементы меню</param>
        /// 
        public int showMenu(string title, string[] arr)
        {
            while (true)
            {
                showMessage_System(title);
                for (int i = 0; i < arr.Length; i++)
                {
                    showMessage_Normal(i + "-" + arr[i]);
                }
                Console.WriteLine();
                string val = Console.ReadLine();
                try
                {
                    int choice = Convert.ToInt32(val);
                    if (choice >= 0 && choice < arr.Length)
                    {
                        return choice;
                    }
                }
                catch
                {
                    showMessage_Error("Ошибка ввода. Введите число");
                }
                showMessage_Error("Ошибка ввода. Выберете из списка");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Вывод сообщения инструкции о замене 
        /// </summary>
        /// <param name="msg">Текст сообщения</param>
        /// <param name="val_true">Значение при true</param>
        /// <param name="val_false">Значение при false</param>
        public bool getUserInput_bool(string msg, string val_true, string val_false)
        {
            while (true)
            {
                showMessage_System(msg);
                showMessage_System("Y/N ?");
                string val = Console.ReadLine().Trim().ToUpper();
                if (val == "Y")
                {
                    showMessage_Success("Value changed to " + val_true);
                    return true;
                }
                if (val == "N")
                {
                    showMessage_Success("Value changed to " + val_false);
                    return false;
                }
                showMessage_Error("Please answer Y/N");
                showMessage_Warning("Value is not changed");
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Вывод меню выбора инструкций
        /// </summary>
        /// <param name="title">Заголовок меню</param>
        /// <param name="list">Элементы меню</param>
        /// 
        public Instruction getInstructionMenu(string title, List<Instruction> list)
        {
            while (true)
            {
                showMessage_System(title);
                Console.WriteLine();
                for (int i = 0; i < list.Count; i++)
                {
                    showMessage_Normal(i + "-" + list[i].GetMsgText() + " == " + list[i].GetStatus());
                }
                Console.WriteLine();
                string val = Console.ReadLine();
                try
                {
                    int choice = Convert.ToInt32(val);
                    if (choice >= 0 && choice < list.Count)
                    {
                        return list[choice];
                    }
                }
                catch
                {
                    showMessage_Error("Ошибка ввода. Введите число");
                }
                showMessage_Error("Ошибка ввода. Выберете из списка");
                Console.WriteLine();
            }

        }
    }
}
