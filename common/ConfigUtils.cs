using System.Text.Json;
using ChatAgregator2.data;

namespace ChatAgregator2.common;

public class ConfigUtils
{
    public static T LoadConfig<T>(string configPath)
    {
        if (!File.Exists(configPath))
        {
            Console.WriteLine("Config file  \"config.json\" not found");
            Console.WriteLine("Please input the proper file name:");
            var newPath = Console.ReadLine();
            if (!File.Exists(newPath))
            {
                //Todo: OpenFileDialog for easier navigation
                Console.WriteLine("Files " + configPath + " & " + newPath + " does not exist, exiting");
                throw new FileNotFoundException("Neither the " + configPath + " nor " + newPath + " file exists");
            }

            configPath = newPath;
        }

        var reader = new StreamReader(configPath);
        var userConfig = JsonSerializer.Deserialize<T>(reader.BaseStream);
        reader.Close();
        return userConfig is null ? throw new FileNotFoundException("Config could not be loaded from file : " + configPath): userConfig;
    }
    
    public static void WriteConfig<T>(string configPath, T config)
    {
        using var writer = new StreamWriter(configPath);
        JsonSerializer.Serialize(writer.BaseStream, config);
        writer.Close();
    }

    public static void DebugPrintConfig<T>(T config)
    {
        Console.WriteLine(JsonSerializer.Serialize(config));
    }
}