namespace PickMyProf;

public class Course
{
    public int status { get; set; }
    public string message { get; set; }
    public CourseDatum[] data { get; set; }
}

public class CourseDatum
{
    public string _id { get; set; }
    public string subject_prefix { get; set; }
    public string course_number { get; set; }
    public string title { get; set; }
    public string credit_hours { get; set; }
    public string class_level { get; set; }
    public string activity_type { get; set; }
    public string description { get; set; }
    public string grading { get; set; }
    public string internal_course_number { get; set; }
    public string laboratory_contact_hours { get; set; }
    public string lecture_contact_hours { get; set; }
    public string offering_frequency { get; set; }
    public Prerequisites prerequisites { get; set; }
    public Corequisites corequisites { get; set; }
    public Co_Or_Pre_Requisites co_or_pre_requisites { get; set; }
    public string school { get; set; }
    public string[] sections { get; set; }
}

public class Prerequisites
{
    public string type { get; set; }
    public int required { get; set; }
    public Option[] options { get; set; }
}

public class Option
{
    public string type { get; set; }
    public int required { get; set; }
    public Option1[] options { get; set; }
}

public class Option1
{
    public string type { get; set; }
    public string description { get; set; }
    public object condition { get; set; }
    public int required { get; set; }
    public Option2[] options { get; set; }
}

public class Option2
{
    public string type { get; set; }
    public string class_reference { get; set; }
    public string minimum_grade { get; set; }
}

public class Corequisites
{
    public string type { get; set; }
    public int required { get; set; }
    public object[] options { get; set; }
}

public class Co_Or_Pre_Requisites
{
    public string type { get; set; }
    public object[] options { get; set; }
    public int required { get; set; }
}
