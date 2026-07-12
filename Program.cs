using System.Text.Json;
using ChatAgregator2.data;

var CONFIG_PATH = "config.json";

if (!File.Exists(CONFIG_PATH))
{
    Console.WriteLine("Config file  \"config.json\" not found");
    Console.WriteLine("Please input the proper file name:");
    CONFIG_PATH = Console.ReadLine();
    if (!File.Exists(CONFIG_PATH))
    {
        //Todo: OpenFileDialog for easier navigation
        Console.WriteLine("File does not exist, exiting");
        return;
    }
}

var reader = new StreamReader(CONFIG_PATH);
var userConfig = JsonSerializer.Deserialize<UserConfig>(reader.BaseStream);
reader.Close();


Console.WriteLine("Youtube : " + userConfig.YoutubeUrl);
Console.WriteLine("Twitch : " + userConfig.TwitchUrl);
Console.WriteLine("Kick : " + userConfig.KickUrl);