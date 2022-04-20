using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebServer.Entity
{
    public class Student
    {
        public static List<Student> Students { get; } = new(new[]
    {
        new Student(1, "Ведерников", "Дмитрий", "Михайлович", 19, "email1@mail.ru"),
        new Student(2, "Бессонов", "Иван", "Анатольевич", 20, "email2@mail.ru"),
        new Student(3, "Кокорин", "Егор", "Дмитриевич", 19, "email3@mail.ru"),
        new Student(4, "Суслов", "Роман", "Владимирович", 20, "email4@mail.ru")
    });

        public int id { get; set; }
        public string fio { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        public Student()
        {
        }

        public Student(int id, string lastName, string firstName, string middleName, int age, string email)
        {
            this.id = id;
            this.fio = lastName + " " + firstName + " " + middleName;
            this.age = age;
            this.email = email;
        }

        public static Student? GetByID(dynamic id)
        {
            return Students.FirstOrDefault(stud => stud.id == id);
        }

        public static string Serialize(Student stud)
        {
            return JsonSerializer.Serialize(stud);
        }
    
    }
}
