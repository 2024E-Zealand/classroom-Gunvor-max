using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string ClassName { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();
        public DateTime SemesterStart { get; set; }
        public string StudentInfo { get; set; }

        public ClassRoom()
        {
            
        }

        public void printlist()
        {
            foreach (Student student in StudentList)
            {
                StudentInfo += student.ToString();
            }
        }

        public override string ToString()
        {
            printlist();
            return $"{{{nameof(ClassName)}={ClassName}, {StudentInfo}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }
    }
}
