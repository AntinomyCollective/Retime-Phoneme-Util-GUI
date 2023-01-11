namespace ConverterGui;

using System.Diagnostics;
using System.Reflection;

internal record Command(string InputFile, string OutputFile, bool Clean, bool SaveLog)
{
    private string ExecutablePath =>
        Path.Combine(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location!)!,
            @"Tools\x64\retime_phoneme.exe"
        );

    public string GetBatchLine() => string.Join(" ", new[] { $"\"{ExecutablePath}\"" }.Concat(GetArguments().Select(arg => $"\"{arg}\"")));

    public Process GetProcess()
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

    private IEnumerable<string> GetArguments()
    {
        yield return "-s";
        yield return InputFile;
        yield return "-d";
        yield return OutputFile;
        if (Clean)
        {
            yield return "-oc";
        }
        if (SaveLog)
        {
            yield return "-o";
        }
    }
}
