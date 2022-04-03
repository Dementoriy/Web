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