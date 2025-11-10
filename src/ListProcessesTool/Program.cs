using System.Diagnostics;

Process.GetProcesses().ToList().ForEach(p => 
{
    try
    {
        Console.WriteLine($"Process: {p.ProcessName}, ID: {p.Id}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Could not access process ID: {p.Id}. Exception: {ex.Message}");
    }
});