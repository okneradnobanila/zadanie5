using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshGit5
{
    public class Student
    {
        public int ID
        {
            get;
            set;
        }
        public string FIO
        {
            get;
            set;
        }
        public string Group
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }

        public Student(int id, string fio, string group, string date)
        {
            ID = id;
            FIO = fio;
            Group = group;
            Date = date;
        }

        public static List<Student> students = new List<Student>();
        
        public static void newstudent()
        {
            students.Add(new Student(1, "Бондаренко Алина Юрьевна", "ИСиП 19-11-1", "01.04.2001"));

            string fio = "";
            string group = "";
            string date = "";
            int id = 0;

            Console.Write("\nВведите ФИО студента:");
            fio = Console.ReadLine();

            Console.Write("\nВведите группу студента: ");
            group = Console.ReadLine();

            Console.Write("\nВведите дату рождения студента (дд.мм.гггг): ");
            date = Console.ReadLine();

            Console.WriteLine("\nВведите ID студента: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count; i++)
            {
                while (id == students[i].ID)
                {
                    Console.WriteLine("Студент с данным ID уже существует, введите другое: ");
                    id = Convert.ToInt32(Console.ReadLine());
                }
            }

            students.Add(new Student(id, fio, group, date));

            for (int i = 0; i < students.Count(); i++)
            {
                Console.WriteLine("\nID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", дата рождения: " + students[i].Date + ", группа: " + students[i].Group);
            }
        }

        public static void correctinfo()
        {
            students.Add(new Student(1, "Бондаренко Алина Юрьевна", "ИСиП 19-11-1", "01.04.2001"));

            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    Console.WriteLine("\nВыберите параметр, который хотите изменить:\n1) ФИО\n2) Дата рождения\n3) Группа\n");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n == 1)
                    {
                        Console.WriteLine("\nВведите новые ФИО: ");
                        string fio = Console.ReadLine();
                        students[i].FIO=fio;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", дата рождения: " + students[i].Date + ", группа: " + students[i].Group);
                        
                    }

                    if (n == 2)
                    {
                        Console.WriteLine("\nВведите новую дату рождения (дд.мм.гггг): ");
                        string date = Console.ReadLine();
                        students[i].Date = date;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", дата рождения: " + students[i].Date + ", группа: " + students[i].Group);
                    }

                    if (n == 3)
                    {
                        Console.WriteLine("\nВведите новую группу: ");
                        string group = Console.ReadLine();
                        students[i].Group = group;

                        Console.WriteLine("\nИзмененные данные: ");
                        Console.WriteLine("ID: " + students[i].ID + ", ФИО: " + students[i].FIO + ", дата рождения: " + students[i].Date + ", группа: " + students[i].Group);
                    }
                }
            }
        }

        public static void deletestudent()
        {
            students.Add(new Student(1, "Бондаренко Алина Юрьевна", "ИСиП 19-11-1", "01.04.2001"));

            Console.WriteLine("\nВведите ID студента: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < students.Count(); i++)
            {
                if (id == students[i].ID)
                {
                    students.Remove(students[i]);
                    Console.WriteLine("\nДанные о студенте удалены.");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВыберите действие: \n1) Добавить студента \n2) Изменить информацию о студенте " +
                "\n3) Удалить студента\n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                Student.newstudent();
            }

            if (n == 2)
            {
                Student.correctinfo();
            }

            if (n == 3)
            {
                Student.deletestudent();
            }
        }
    }
}
