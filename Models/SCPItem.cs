using System.Text.Json.Serialization;

namespace SCPFoundation.Models;

public class SCPItem
{
    private string _class = "unknown";

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("class")]
    public string? Class
    {
        get => _class;
        set
        {
            if (value == null)
                _class = "unknown";
            else if (value.Contains("KETER", StringComparison.OrdinalIgnoreCase))
                _class = "keter";
            else if (value.Contains("EUCLID", StringComparison.OrdinalIgnoreCase))
                _class = "euclid";
            else if (value.Contains("SAFE", StringComparison.OrdinalIgnoreCase))
                _class = "safe";
            else
                _class = "unknown";
        }
    }

    [JsonPropertyName("procedure")]
    public string? Procedure { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("caption")]
    public string? Caption { get; set; }
}
