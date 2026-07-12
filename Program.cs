using System.Text.Json;
using ChatAgregator2.data;

var CONFIG_PATH = "config.json";

if (!File.Exists(CONFIG_PATH))
{
    Console.WriteLine("Config file  \"config.json\" not found");
    Console.WriteLine("Please input the proper file name:");
    var newPath = Console.ReadLine();
    if (!File.Exists(newPath))
    {
        //Todo: OpenFileDialog for easier navigation
        Console.WriteLine("Files " + CONFIG_PATH + " & " + newPath + " does not exist, exiting");
        return;
    }
    CONFIG_PATH = newPath;
}

var reader = new StreamReader(CONFIG_PATH);
var userConfig = JsonSerializer.Deserialize<UserConfig>(reader.BaseStream);
reader.Close();


Console.WriteLine("Youtube : " + userConfig.YoutubeUrl);
Console.WriteLine("Twitch : " + userConfig.TwitchUrl);
Console.WriteLine("Kick : " + userConfig.KickUrl);