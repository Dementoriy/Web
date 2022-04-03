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

        public int id { get; set; }
        public string fio { get; set; }
        public int age { get; set; }
        public string email { get; set; }

        public static List<Student> Students { get; } = new(new[]
        {
            new Student(){ id = 1, fio = "Ведерников Дмитрий Михайлович", age = 19, email = "email1@mail.ru" },
            new Student(){ id = 2, fio = "Бессонов Иван Анатольевич", age = 20, email = "email2@mail.ru" },
            new Student(){ id = 3, fio = "Кокорин Егор Дмитриевич", age = 19, email = "email3@mail.ru" },
        });

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