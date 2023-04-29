using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeAndRegistry
{
    class IntelligentStudent :  Student
    {
        public int IQ;

        public IntelligentStudent()
        {

        }
        public IntelligentStudent(IntelligentStudent intelligent) : base(intelligent)
        {
            this.IQ = intelligent.IQ;
        }
        public override IntelligentStudent Clone()
        {
            //IntelligentStudent intelligent = new IntelligentStudent();
            //intelligent.IQ = 180;
            return new IntelligentStudent(this);
        }
    }
}
