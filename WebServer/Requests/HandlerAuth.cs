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
