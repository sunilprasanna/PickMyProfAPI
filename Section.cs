using System.Text.Json.Serialization;

namespace PickMyProf;


public class Section
{
    public int status { get; set; }
    public string message { get; set; }
    public Datum data { get; set; }
}

public class Datum
{
    public int __v { get; set; }
    public string _id { get; set; }
    public Academic_Session academic_session { get; set; }
    public Attributes attributes { get; set; }
    public string[] core_flags { get; set; }
    public string course_reference { get; set; }
    public int[] grade_distribution { get; set; }
    public string instruction_mode { get; set; }
    public string internal_class_number { get; set; }
    public Meeting[] meetings { get; set; }
    public string[] professors { get; set; }
    public Section_Corequisites section_corequisites { get; set; }
    public string section_number { get; set; }
    public string syllabus_uri { get; set; }
    public object[] teaching_assistants { get; set; }
}

public class Academic_Session
{
    public string end_date { get; set; }
    public string name { get; set; }
    public string start_date { get; set; }
}

public class Attributes
{
    public object[] raw_attributes { get; set; }
}

public class Section_Corequisites
{
    public object[] options { get; set; }
    public string type { get; set; }
}

public class Meeting
{
    public string end_date { get; set; }
    public string end_time { get; set; }
    public Location location { get; set; }
    public string[] meeting_days { get; set; }
    public object? modality { get; set; }
    public string start_date { get; set; }
    public string start_time { get; set; }
}

public class Location
{
    public string building { get; set; }
    public string map_uri { get; set; }
    public string room { get; set; }
}
