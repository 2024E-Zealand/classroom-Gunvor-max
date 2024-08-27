using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    public class Student
    {
        private int _birthMonth;

        public string Name { get; private set; }
        public int BirthMonth 
        {
            get { return _birthMonth; }
            private set 
            {
                if(value > 0 && value < 13)
                {
                _birthMonth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Birth Month must be between 1-12");
                }
            }
        }
        public int BirthDay { get; private set;}

        public Student(string name, int birthMonth, int birthDay)
        {
            Name = name;
            BirthMonth = birthMonth;
            BirthDay = birthDay;
        }

        public string season(int birthMonth)
        {
            switch (birthMonth)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                    case 3:
                    case 4:
                    case 5:
                    return "Spring";
                    case 6:
                    case 7:
                    case 8:
                    return "Summer";
                    case 9:
                    case 10:
                    case 11:
                    return "Autumn";
                default:
                    return "Not specified";
            }
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(BirthMonth)}={BirthMonth.ToString()}, {nameof(BirthDay)}={BirthDay.ToString()}, {season(BirthMonth)}}}";
        }
    }
}
