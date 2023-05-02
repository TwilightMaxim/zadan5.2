using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadan5._2
{
    internal class Person
    {
        /// <summary>
        /// фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Факультет
        /// </summary>
        public string Faculty { get; set; }
        public Person(string surname, string name, string patronymic, string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Faculty = faculty;
        }
       
    }
}
