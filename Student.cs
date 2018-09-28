using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate bool StudentQualify(StudentInfo info);
    public class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rank { get; set; }
        public string College { get; set; }

        public static void QualifyStudent(List<StudentInfo> slist,StudentQualify sq)
        {
            foreach(StudentInfo stu in slist)
            {
                if(sq(stu))
                {
                    Console.WriteLine("The Qualified Student Name is :" + stu.Name);
                }
            }
        }
    }




    public class Student
    {
        public static bool Qualify(StudentInfo sinf)
        {
            if(sinf.College == "SVEC")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            List<StudentInfo> sli = new List<StudentInfo>();
            sli.Add(new StudentInfo() { Id = 101, Name = "Mahesh", Rank = 10,College = "SVCE" });
            sli.Add(new StudentInfo() { Id = 102, Name = "Naresh", Rank = 2, College = "SVEW" });
            sli.Add(new StudentInfo() { Id = 103, Name = "Suresh", Rank = 4, College = "SVDC" });
            sli.Add(new StudentInfo() { Id = 104, Name = "Mukesh", Rank = 7, College = "SVEC" });
            sli.Add(new StudentInfo() { Id = 105, Name = "Ganesh", Rank = 6, College = "CHDL" });

            StudentQualify qualify = new StudentQualify(Qualify);
            StudentInfo.QualifyStudent(sli,qualify);
        }
    }

}
