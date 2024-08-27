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

        public ClassRoom()
        {
            
        }

        public override string ToString()
        {
            return $"{{{nameof(ClassName)}={ClassName}, {nameof(StudentList)}={StudentList}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }
    }
}
