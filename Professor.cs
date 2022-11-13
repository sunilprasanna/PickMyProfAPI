using System.Text.Json.Serialization;

namespace PickMyProf;


public class Professor
{
    public int status { get; set; }
    public string message { get; set; }
    public ProfessorDatum data { get; set; }
}

public class ProfessorDatum
{
    public string _id { get; set; }
    public string email { get; set; }
    public string first_name { get; set; }
    public string image_uri { get; set; }
    public string last_name { get; set; }
    public Office office { get; set; }
    public object[] office_hours { get; set; }
    public string phone_number { get; set; }
    public string profile_uri { get; set; }
    public string[] sections { get; set; }
    public string[] titles { get; set; }
}

public class Office
{
    public string building { get; set; }
    public string room { get; set; }
    public string map_uri { get; set; }
}
