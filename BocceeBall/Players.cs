using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceeBall
{
    class Players
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string Number { get; set; }
        public string ThrowingArm { get; set; }

        public int? TeamID { get; set; }
        public Teams Team { get; set; }
    }
}
