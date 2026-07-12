namespace ChatAgregator2.data;

public record UserConfig
{
    public string? YoutubeUrl { get; init; }
    public string? TwitchUrl { get; init; }
    public string? KickUrl { get; init; }
}