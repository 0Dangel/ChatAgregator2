using ChatAgregator2.common;
using ChatAgregator2.data;

class main
{
    public static void Main(string[] args)
    {
        var CONFIG_PATH = "config.json";

        var userConfig = ConfigUtils.LoadConfig<UserConfig>(CONFIG_PATH);

        ConfigUtils.DebugPrintConfig(userConfig);
    }
}