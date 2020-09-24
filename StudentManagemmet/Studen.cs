using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagemmet
{
    class Studen : IStudent
    {
        public string Fullname { set; get; }
        public int Id { set; get; }
        public DateTime Dateofbirth { set; get; }
        public string Native { set; get; }
        public string Class { set; get; }
        public string Phoneno { set; get; }
        public int Mobile { set; get; }
        public Studen () {      
        }
       public Studen(string Fullname,int Id,DateTime Dateofbirth,string Native,string Class,string Phoneno,int Mobile)
        {
            this.Fullname = Fullname;
            this.Id = Id;
            this.Dateofbirth = Dateofbirth;
            this.Native = Native;
            this.Class = Class;
            this.Phoneno = Phoneno;
            this.Mobile = Mobile;
        }
        public void Display()
        {
            Console.WriteLine("Id:" + Id);
            Console.WriteLine("Fullname:" + Fullname);
            Console.WriteLine("DateofBith:" + Dateofbirth);
            Console.WriteLine("Native:" + Native);
            Console.WriteLine("Class:" + Class);
            Console.WriteLine("Phoneno:" + Phoneno);
            Console.WriteLine("Mobile:" + Mobile);

        }
    }
}
