using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class PlayerSkill
    {
        public Skill Details { get; set; }
        public bool IsFirst { get; set; }
        public bool IsSecond { get; set; }
        public bool IsThird { get; set; }

        public PlayerSkill() { }
        public PlayerSkill(Skill details, bool isFirst = false, bool isSecond = false, bool isThird = false)
        {
            Details = details;
            IsFirst = isFirst;
            IsSecond = isSecond;
            IsThird = isThird;
        }
    }
}
