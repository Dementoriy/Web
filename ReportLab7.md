<p align = center>МИНИСТЕРСТВО НАУКИ И ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>РОССИЙСКОЙ ФЕДЕРАЦИИ

<p align = center>ФЕДЕРАЛЬНОЕ ГОСУДАРСТВЕННОЕ БЮДЖЕТНОЕ ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ ВЫСШЕГО ОБРАЗОВАНИЯ

<p align = center>«ВЯТСКИЙ ГОСУДАРСТВЕННЫЙ УНИВЕРСИТЕТ»

<p align = center>Институт математики и информационных систем

<p align = center>Факультет автоматики и вычислительной техники

<p align = center>Кафедра систем автоматизации управления
<br>
<br>
<br>
<br>

<p align = right>Дата сдачи на проверку:

<p align = right>«___» __________ 2022 г.

<p align = right>Проверено:

<p align = right>«___» __________ 2022 г.
<br>
<br>
<br>
<br>
<br>


<p align = center>Отчет по лабораторной работе № 7

<p align = center>по дисциплине

<p align = center>«Web-программирование»

<br>
<br>
<br>
<br>


<p align = center>Разработал студент гр. ИТб-2301-01-00 ________________ /Ведерников Д.М./

<p align = center>Проверил ст. преподаватель _________________ /Земцов М.А./

<p align = center>Работа защищена с оценкой «___________» «___» __________ 2022 г.

<br>
<br>
<br>
<br>

<p align = center>Киров 2022

<hr>
Цель:  реализовать web-сервер на целевом языке программирования (C#)

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Создать web-сервер на языке программирования C# без использования ASP.NET core.
1. Реализовать задание на третью и пятую лабораторные работы с использованием собственного сервера.
    - Реализовать проверку логина и пароля при авторизации.
    - Реализовать проверку уникальности логина при регистрации.
    - Реализовать вывод информации о студентах в таблицу.
    - Реализовать вывод информации о конкретном студенте.


Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Dementoriy/Web)* на сайте github.com была создана новая ветвь с названием lab7 от ветки lab5.

2. Создать web-сервер на языке программирования C# без использования ASP.NET core.

В ходе лабораторной работы было создано консольное приложение. Через NuGet пакеты добавлена библиотека RestPanda, основання на базе библиотеки HTTP.sys. Для выполнения запросов были созданы два класса-сущности: User и Student. Листинг этих классов представлен в приложении А. В классе Program был реализован старт и остановка сервера, листинг этого класса представлен в приложении Б. Демонтсрация работы сервера представлена на рисунке 1.

<p align=center><img src="./img/Lab7/HttpServer.png" alt="Server"></p>
<p align = center>Рисунок 1 – web-сервер


3. Реализовать задание на третью и пятую лабораторные работы с использованием собственного сервера.

Для реализации соответствующих запросов были созданы два класса: HandlerAuth и HandlerGetStudent. Листинг классов представлен в приложении В. Были созданы два Post-запроса для реализации задания на 3 лабараторную работу и один Get-запрос для реализации задания на 5 лабораторную работу, также была частично изменена структура компонентов из 3 и 5 лабораторных работ. полученные результаты отражены на рисунках 2-7. Для каждого запроса реализованы 3 заголовка(headers): время, токен, и частота запросов в минуту, результат отражен на рисунке 8.

<p align=center><img src="./img/Lab7/Enter.png" alt="free login"></p>
<p align = center>Рисунок 2 – Успешная авторизация

<p align=center><img src="./img/Lab7/BadEnter.png" alt="no free login"></p>
<p align = center>Рисунок 3 – Неуспешная авторизация

<p align=center><img src="./img/Lab7/Lab7Autorization.png" alt="auth"></p>
<p align = center>Рисунок 4 – Уникальный логин

<p align=center><img src="./img/Lab7/Lab7BadAutorization.png" alt="noauth"></p>
<p align = center>Рисунок 5 – Неуникальный логин

<p align=center><img src="./img/Lab7/Lab7Table.png" alt="table"></p>
<p align = center>Рисунок 6 – Таблица студентов

<p align=center><img src="./img/Lab7/Lab7FullInfo.png" alt="one stud"></p>
<p align = center>Рисунок 7 – Подробная информация о студенте

<p align=center><img src="./img/Lab7/Lab7Responce.png" alt="headers"></p>
<p align = center>Рисунок 7 – Заголовки запроса

Вывод: в ходе выполнения лабораторной работы были получены данные с собственного web-сервера и организовано взаимодействие пользователя с ними. 

<p align = center>Приложение А

<p align = center>(обязательное) 

<p align = center>Листинг классов User и Student

```C#
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer.Entity;

public class User
{
    public string login { get; set; }
    public string pass { get; set; }

    public static List<User> Users = new List<User>()
    {
        new User() { login = "log", pass = "pass" },
        new User() { login = "log1", pass = "pass1" },
        new User() { login = "log2", pass = "pass2" },
    };

}
```

<p align = center>Приложение Б

<p align = center>(обязательное) 

<p align = center>Листинг класса Program

```C#
using RestPanda;

namespace WebServer;

public class Program
{
    private static List<DateTime> _times = new();

    public static int GetTimes()
    {
        _times.Add(DateTime.Now);
        foreach (var time in _times.Where(time => (time - _times[^1]).Minutes >= 1))
        {
            _times.Remove(time);
        }
        return _times.Count;
    }

    public static void Main(string[] args)
    {
        var url = "http://localhost:8081/";
        Console.WriteLine("Start server...");
        var server = new PandaServer(url, typeof(Program));
        server.Start();
        Console.WriteLine("Server started at " + url);
        Console.WriteLine("Press Enter to stop server...");
        Console.Read();
        server.Stop();
    }
}
```

<p align = center>Приложение В

<p align = center>(обязательное) 

<p align = center>Листинг классов HandlerAuth и HandlerGetStudent

```C#
using RestPanda.Requests;
using RestPanda.Requests.Attributes;
using WebServer.Entity;

namespace WebServer.Requests;

[RequestHandler("/auth")]
public class HandlerAuth
{
    [Post("check")]
    public static void Check(PandaRequest request, PandaResponse response)
    {
        var user = request.GetObject<User>();
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());

        foreach (var u in User.Users)
        {
            if (user.login == u.login)
            {
                response.Send(new { IsValid = false });
                return;
            }
        }
        response.Send(new { IsValid = true });


    }

    [Post("login")]
    public static void Login(PandaRequest request, PandaResponse response)
    {
        var user = request.GetObject<User>();
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());

        foreach (var u in User.Users)
        {
            if (user.login == u.login && user.pass == u.pass)
            {
                response.Send(new { completed = true });
                return;
            }
        }
        response.Send(new { completed = false });

    }
}
using RestPanda.Requests.Attributes;
using RestPanda.Requests;
using WebServer.Entity;
namespace WebServer.Requests;

[RequestHandler("/getstudent")]
public class HandlerGetStudent
{
    [Get]
    public static void GetStuds(PandaRequest request, PandaResponse response)
    {
        response.AddHeader("Time", DateTime.Now.ToString("O"));
        response.AddHeader("Token", Guid.NewGuid().ToString());
        response.AddHeader("Request-Per-Minutes", Program.GetTimes().ToString());
        if (!request.Params.ContainsKey("id"))
        {
            response.Send(Student.Students);
            return;
        }
        var studentId = request.Params["id"];
        int start;
        if (!int.TryParse(studentId, out start))
        {
            response.Send("Error");
            return;
        }
        if (Student.Students.All(s => s.id != start))
        {
            response.Send("Error");
            return;
        }
        response.Send(Student.Students.Single(s => s.id == start));
    }
}
```