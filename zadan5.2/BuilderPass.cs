using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadan5._2
{
    internal class BuilderPass : Person, IPass
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public BuilderPass(string surname, string name, string patronymic, string faculty, string startDate, string endDate) : base(surname, name, patronymic, faculty)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        public void UpdatePass()
        {
            
        }

        public void AnnulPass()
        {
            
        }
    }
}
