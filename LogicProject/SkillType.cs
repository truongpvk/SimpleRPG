using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicProject
{
    public class SkillType
    {
        public int ID {  get; set; }
        public string TypeName { get; set; }

        public SkillType() { }
        public SkillType(int iD, string typeName)
        {
            ID = iD;
            TypeName = typeName;
        }
    }
}
