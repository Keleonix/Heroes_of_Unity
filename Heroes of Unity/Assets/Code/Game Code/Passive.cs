using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_HoU
{
    public class Passive : Buff, ValueBuff
    {
        public Passive(int uId) : base(uId)
        { }

        public List<int> Values { get; set; }
        public List<string> Stats { get; set; }

    }
}
