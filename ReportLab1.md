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


<p align = center>Отчет по лабораторной работе № 9

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
Цель: реализовать отправку электронного письма условному пользователю от имени веб-приложения на целевом языке программирования.

Задачи:

1. Организовать процесс работы над лабораторной работой
1. Реализовать отправку электронного письма условному пользователю
    - Отправка текстового сообщения
    - Отправка тесктового сообщения с pdf документом
    - Отправка HTML-разметки, содержащей картинку и таблицу


Ход выполнения:

1. Организовать процесс работы над лабораторной работой

Для работы в репозитории *[ссылка на репозиторий](https://github.com/Dementoriy/Web)* на сайте github.com была создана новая ветвь с названием lab9 от ветки main.

2. Реализовать отправку электронного письма условному пользователю.

В ходе лабораторной работы был создан класс HandlerEmail. С помощью встроенной библиотеки SmtpClient реализован метод отправления электронного письма с текстовым сообщением и pdf-документом и отправления электронного сообщения, содержащего HTML-разметку. Результат работы метода представлен на рисунках 1 и 2. Листинг класса представлен в приложении А.

<p align=center><img src="./img/Lab9/pdf.png" alt="PDF"></p>
<p align = center>Рисунок 1 – Письмо, содержащее вложенный файл и текст

<p align=center><img src="./img/Lab9/img.png" alt="Html"></p>
<p align = center>Рисунок 2 – Письмо, содержащее HTML-разметку


Вывод: в ходе выполнения лабораторной работы были получены навыки работы со встроенной библиотекой для рассылки электронных писем SmtpClient. 

<p align = center>Приложение А

<p align = center>(обязательное) 

<p align = center>Листинг класса HandlerEmail.cs

```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using RestPanda.Requests.Attributes;
using RestPanda.Requests;
using WebServer.Entity;
using System.Net;

namespace WebServer.Requests
{
    [RequestHandler]
    public class HandlerEmail
    {
        private static string FillTable()
        {
            var s = new StringBuilder("<table style=\"border-collapse: collapse\">" + Environment.NewLine);
            s.Append("<tr><th>id</th><th>ФИО</th><th>Возраст</th><th>Почта</th></tr>" + Environment.NewLine);
            foreach (var student in Student.Students)
            {
                s.Append("<tr>").Append($"<td>{student.id}</td>").Append($"<td>{student.fio}</td>")
                    .Append($"<td>{student.age}</td>").Append($"<td>{student.email}</td>").Append("</tr>" + Environment.NewLine);
            }

            s.Append("</table>");
            return s.ToString();
        }

        [Get]
        public static void CommitMessange(PandaRequest request, PandaResponse response)
        {
            var from = new MailAddress("dim01-02@mail.ru", "Клининговая компания Чистый дом");
            var to = new MailAddress("dementoriy@vk.com", "Пользователь");
            var msg = new MailMessage(from, to);
            msg.Subject = "PDF file";
            msg.Attachments.Add(
                new Attachment("C://Users/demen/OneDrive/Рабочий стол/Cleaning/message.pdf"));
            msg.Body = "Рассылка:";
            using (var smtp = new SmtpClient("smtp.mail.ru", 587))
            {
                smtp.Credentials = new NetworkCredential("dim01-02@mail.ru", "4maYhT90pS5KgM67M1wN");
                smtp.EnableSsl = true;
                smtp.Send(msg);
            }

            var msg2 = new MailMessage(from, to);
            msg2.Subject = "Html документ";
            msg2.Body = "<img src=\"data:image/jpeg;base64,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\" alt=\"Алеша\"/>" + Environment.NewLine;
            msg2.Body += FillTable();
            msg2.IsBodyHtml = true;
            using (var smtp = new SmtpClient("smtp.mail.ru", 587))
            {
                smtp.Credentials = new NetworkCredential("dim01-02@mail.ru", "4maYhT90pS5KgM67M1wN");
                smtp.EnableSsl = true;
                smtp.Send(msg2);
            }

            response.Send("");
        }
    }
}
```