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
        var f = request.Params["id"];
        int start;
        if (!int.TryParse(f, out start))
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
