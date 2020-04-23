using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4_5
{
    class Mediator
    {
        private List<Instruction> Inst_List;
        public Mediator(List<Instruction> Inst_List)
        {
           Inst_List = new List<Instruction>();
        }
    }
}
