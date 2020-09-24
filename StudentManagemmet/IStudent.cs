using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagemmet
{
    interface IStudent
    {
        public string Fullname { set; get; }
        public int Id { set; get; }
        public DateTime Dateofbirth { set; get; }
        public string Native { set; get; }
        public string Class { set; get; }
        public string Phoneno { set; get; }
        public int Mobile { set; get; }

      public void Display();

    }
}
