using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace zadan5._2
{
    internal class TeacherPass : Person, IPass
    {
        /// <summary>
        /// Кафедра
        /// </summary>
        public string Department { get; set; }
        public TeacherPass(string surname, string name, string patronymic, string faculty, string department) : base(surname, name, patronymic, faculty)
        {
            Department = department;
        }
        public void UpdatePass()
        {
            
        }

        public void AnnulPass()
        {
            
        }
    }
}
