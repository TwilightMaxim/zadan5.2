using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace zadan5._2
{
    internal class StudentPass : Person, IPass
    {
        /// <summary>
        /// Год поступления
        /// </summary>
        public string YearOfAdmission { get; set; }
        public StudentPass(string surname, string name, string patronymic, string faculty, string yearOfAdmission) : base(surname, name, patronymic, faculty)
        {
            this.YearOfAdmission = yearOfAdmission;
        }
        public void UpdatePass()
        {
        }

        public void AnnulPass()
        {
            
        }

    }
}
