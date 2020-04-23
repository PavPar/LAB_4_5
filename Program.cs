using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSpeaker con = new ConsoleSpeaker();
            string[] Menu = { "Windows", "Ubuntu", "MacOS", "Exit" };
            AbstractFactory instr;
            while (true)
                switch (con.showMenu("Choose your OS", Menu))
                {
                    case 0:
                        {
                            instr = new Win_Instructions();
                            instr.CreateInstructionSet();
                            return;
                        }
                    case 1:
                        {
                           instr = new Ubuntu_Instructions();
                           instr.CreateInstructionSet();
                           return;
                        }
                    case 2:
                        {
                            instr = new Mac_Instructions();
                            instr.CreateInstructionSet();
                            return;
                        }
                    case 3:
                        {
                            return;
                        }
                };
        }
    }
}
