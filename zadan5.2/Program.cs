using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace zadan5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "person1.txt";
            //Коллекция студентов
            List<StudentPass> student = new List<StudentPass>();
            //Коллекция преподователей
            List<TeacherPass> teacher = new List<TeacherPass>();
            //Коллекция строителей
            List<BuilderPass> builder = new List<BuilderPass>();
            //Коллекция пропусков на обновление и аннулирование
            List<IPass> passes = new List<IPass>();
            //Чтение информации из txt
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == "student")
                    {
                        StudentPass student1 = new StudentPass(parts[1], parts[2], parts[3], parts[4], parts[5]);
                        student.Add(student1);
                    }
                    if (parts[0] == "teacher")
                    {
                        TeacherPass teacher1 = new TeacherPass(parts[1], parts[2], parts[3], parts[4], parts[5]);
                        teacher.Add(teacher1);
                    }
                    if (parts[0] == "builder")
                    {
                        BuilderPass builder1 = new BuilderPass(parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]);
                        builder.Add(builder1);
                    }
                }
            }
            Methods item = new Methods();
            item.TeacherInfo(teacher);
            item.StudentInfo(student);
            item.BuilderInfo(builder);
            item.CancelUpdateInfo(passes);
        }
    }
}
