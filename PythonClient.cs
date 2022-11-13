using System.Net;
using System.Text.Json;
using IronPython.Hosting;
using PickMyProf;

public class PythonClient
{
    public void AnalyzeProfessor()
    {
        Microsoft.Scripting.Hosting.ScriptEngine pythonEngine = 
            Python.CreateEngine();                  
        ICollection<string> paths = pythonEngine.GetSearchPaths();
        paths.Add("C:\\Users\\sunil\\Documents\\GitHub\\PickMyProf\\PickMyProf\\RateMyProfAnalyzer.py");

        pythonEngine.SetSearchPaths(paths);
        
        Microsoft.Scripting.Hosting.ScriptSource pythonScript = 
            pythonEngine.CreateScriptSourceFromFile("RateMyProfAnalyzer.py");
        Microsoft.Scripting.Hosting.ScriptScope scope = pythonEngine.CreateScope();
        scope = pythonEngine.ImportModule("praw");
        
        pythonScript.Execute(scope);
    }
}