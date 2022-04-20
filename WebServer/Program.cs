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
        var url = "http://localhost:8082/";
        Console.WriteLine("Start server...");
        var server = new PandaServer(url, typeof(Program));
        server.Start();
        Console.WriteLine("Server started at " + url);
        Console.WriteLine("Press any key to stop server...");
        Console.Read();
        server.Stop();
    }
}