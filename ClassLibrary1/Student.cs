using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        //public string ClassNumber { get; set; }
        //public int DormitoryNumber { get; set; }
        //public int RoomNumber { get; set; }
        public int? Class_ID { get; set; }
        public int? Dormitory_ID { get; set; } = 0;
        public int? Room_ID { get; set; } = 0;

    }
}
