namespace ConverterGui;

using System;
using System.Diagnostics;
using System.Reflection;

internal record Command(string InputFile, string OutputFile, string OutputFileClean, bool Clean, bool SaveLog,string Bitness)
{
   
    private string ExecutablePath =>
        Path.Combine(
            Path.GetDirectoryName(System.AppContext.BaseDirectory!)!,
            @"Tools\"+ Bitness + @"\retime_phoneme.exe"
        );

    public string GetBatchLine() => string.Join(" ", new[] { $"\"{ExecutablePath}\"" }.Concat(GetArguments().Select(arg => $"\"{arg}\"")));

    public Process GetProcess()
    {
        try
        {
            var proc = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ExecutablePath
                },
                EnableRaisingEvents = true,
            };
            foreach (var item in this.GetArguments())
            {
                proc.StartInfo.ArgumentList.Add(item);
            }

            return proc;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Restart();
            return null!;
        }
    }

    private IEnumerable<string> GetArguments()
    {
        yield return "-s";
        yield return InputFile;
        yield return "-d";
        yield return OutputFile;
        if (Clean)
        {
            yield return "-oc";
            yield return OutputFileClean; 
        }
        if (SaveLog)
        {
            yield return "-l";
        }
    }
}
