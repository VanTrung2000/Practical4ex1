using System;
using System.Collections.Generic;

namespace StudentManagemmet
{
    class Program
    {
        static void Main(string[] args)
        {
            Program t = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("1.Add student");
                Console.WriteLine("2.View all student ");
                Console.WriteLine("3.Search Student ");
                Console.WriteLine("4.Exit ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        t.AddStudent();
                        break;
                    case 2:
                        t.ViewAllStudent();
                        break;
                    case 3:
                        t.SearchStudent();
                        break;
                    case 4:
                        return;
                        break;
                }
            } while (choice != 5);
        }
        int count = 0;
        Dictionary<int, object> ListStudent = new Dictionary<int, object>();
        public void AddStudent()
        {
            Studen stu = new Studen();
            stu.Id = count;
            Console.WriteLine("Nhap full name :");
            stu.Fullname = Console.ReadLine();
            Console.WriteLine("Nhap Dateof Birth :");
            stu.Dateofbirth = DateTime.Parse(Console.ReadLine()); ;
            Console.WriteLine("Nhap Native :");
            stu.Native = Console.ReadLine();
            Console.WriteLine("Nhap Class : ");
            stu.Class = Console.ReadLine();
            Console.WriteLine("Nhap Phone No : ");
            stu.Phoneno = Console.ReadLine();
            Console.WriteLine("Nhap Mobile : ");
            stu.Mobile = int.Parse(Console.ReadLine());
            ListStudent.Add(count, stu);
            count++;
        }
        public void ViewAllStudent()
        {
            foreach (Studen item in ListStudent.Values)
            {
                item.Display();
            }
        }
        public void SearchStudent()
        {
            Console.WriteLine("Nhap ten hoc sinh: ");
            string name = Console.ReadLine();
            foreach (Studen item in ListStudent.Values)
             if (item.Fullname.Equals(name))
                    item.Display();
            
                else Console.WriteLine("Khong tim thay ten");
            
        }
    }
}



