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
        public string ClassName { get; set; }
         public int? Dormitory { get; set; }
        public int? Room { get; set; }
       


        public int? Class_ID { get; set; } = 0;
        public int? Dormitory_ID { get; set; } = null;
        public int? Room_ID { get; set; } = null;

    }
}
