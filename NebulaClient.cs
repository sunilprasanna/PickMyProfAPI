using System.Net;
using System.Text.Json;
using PickMyProf;

public class NebulaClient
{
    private string baseUrl = "https://api.utdnebula.com";
    private string APIToken = "AIzaSyBZepdJRCOQNteDxZfpwP-odDVrae4UTHw";
    
    public Section GetSection(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
        request.Method = "GET";
        request.Headers.Add("x-api-key", APIToken);
        request.Headers.Add("Accept", "application/json");
        using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
            string json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Section>(json);
        }
    }

    public Course GetCourse(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
        request.Method = "GET";
        request.Headers.Add("x-api-key", APIToken);
        request.Headers.Add("Accept", "application/json");
        using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
            string json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Course>(json);
        }
    }
    
    public Professor GetProfessor(string url)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
        request.Method = "GET";
        request.Headers.Add("x-api-key", APIToken);
        request.Headers.Add("Accept", "application/json");
        using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        using(Stream stream = response.GetResponseStream())
        using(StreamReader reader = new StreamReader(stream))
        {
            string json = reader.ReadToEnd();
            return JsonSerializer.Deserialize<Professor>(json);
        }
    }
}