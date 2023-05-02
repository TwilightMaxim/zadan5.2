using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using zadan5._2;

namespace zadan5._2
{
    internal class Methods
    {
        /// <summary>
        /// Вывод информации о пропусках студентов
        /// </summary>
        /// <param name="student"></param>
        public void StudentInfo(List<StudentPass> student)
        {
            foreach (var pass in student)
            {
                if (pass is StudentPass)
                {
                    Console.WriteLine(pass.Name + " " + pass.Surname + " " + pass.Patronymic + " (" + pass.Faculty + ")");
                    Console.WriteLine("Студент " + pass.YearOfAdmission + " года поступления");
                }
            }
        }
        /// <summary>
        /// Вывод информации о пропусках преподователей
        /// </summary>
        /// <param name="teacher"></param>
        public void TeacherInfo(List<TeacherPass> teacher)
        {
            foreach (var item in teacher)
            {
                if (item is TeacherPass)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " " + item.Patronymic + " (" + item.Faculty + ")");
                    Console.WriteLine("Преподователь кафедры: " + item.Department);
                }
            }
        }
        /// <summary>
        /// Вывод информации о пропусках строителей
        /// </summary>
        /// <param name="builder"></param>
        public void BuilderInfo(List<BuilderPass> builder)
        {
            foreach (var item in builder)
            {
                if (item is BuilderPass)
                {
                    Console.WriteLine(item.Name + " " + item.Surname + " " + item.Patronymic + " (" + item.Faculty + ")");
                    Console.WriteLine("Дата начала работ: {0}\nДата окончания работ: {1} ", item.StartDate, item.EndDate);
                }

            }
        }
        /// <summary>
        /// Кол-во пропусков на обновление
        /// </summary>
        /// <param name="passes"></param>
        /// <returns></returns>
        public int Update(List<IPass> passes)
        {
            int updateCount = 0;
            foreach (IPass pass in passes)
            {
                pass.UpdatePass();
                updateCount++;
            }
            return updateCount;
        }
        /// <summary>
        /// Кол-во пропусков на аннулирование
        /// </summary>
        /// <param name="passes"></param>
        /// <returns></returns>
        public int Cancel(List<IPass> passes)
        {
            int cancelCount = 0;
            foreach (IPass pass in passes)
            {
                pass.AnnulPass();
                cancelCount++;
            }
            return cancelCount;
        }
        /// <summary>
        /// Вывод количества пропусков на обновление и аннулирование
        /// </summary>
        /// <param name="passes"></param>
        public void CancelUpdateInfo(List<IPass> passes)
        {
            int countUpdate = Update(passes);
            int countClose = Cancel(passes);
            Console.WriteLine($"Количество пропусков на обновление: {countUpdate}");
            Console.WriteLine($"Количество пропусков на аннулирование: {countClose}");
        }
    }
}
