using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace PickMyProf.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet(Name = "GetProfessors")]
    public IEnumerable<ProfessorDto> Get(string subjectPrefix, string couseNumber)
    {
        List<ProfessorDto> professors = new();
        NebulaClient client = new();

        string url = "/course?subject_prefix=" + subjectPrefix + "&course_number=" + couseNumber;
        Course courseInfo =
            client.GetCourse(url);

        foreach (var section in courseInfo.data[0].sections)
        {
            Section sectionInfo = client.GetSection("/section/" + section);
            foreach (var professor in sectionInfo.data.professors)
            {
                if (professors.Any(p => p.id == professor))
                {
                    continue;
                }
                Professor professorInfo = client.GetProfessor("/professor/" + professor);
                ProfessorDto prof = new ProfessorDto(professorInfo);
                Process p = new Process();
                p.StartInfo = new ProcessStartInfo(@"C:\Users\sunil\AppData\Local\Programs\Python\Python38\python.exe",
                    "RateMyProfAnalyzer.py " + prof.name)
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                p.Start();
                using (StreamReader reader = p.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Double.TryParse(result, out double rating);
                    prof.rating = rating;
                }
                professors.Add(prof);
            }
        }
        return professors;
    }

    public class ProfessorDto
    {
        public string id { get; set; }
        public string name { get; set; }

        public string profile { get; set; }

        public double rating { get; set; }

        public ProfessorDto(Professor prof)
        {
            id = prof.data._id;
            name = prof.data.first_name + " " + prof.data.last_name;
            profile = prof.data.profile_uri;
        }
    }

}