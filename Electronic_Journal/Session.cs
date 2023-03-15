using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronic_Journal
{
    public class Session
    {
        public static User CurrentUser { get; set; }
        public static Group CurrentGroup { get; set; }
        public static Discipline CurrentDiscipline { get; set; }
    }
}
