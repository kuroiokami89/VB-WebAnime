public class JikanResponse
{
    public List<AnimeDTO> Data { get; set; }
}

public class AnimeDTO
{
    public int MalId { get; set; }
    public string Title { get; set; } = String.Empty;

    public string Url { get; set; } = String.Empty;
    public Images Images { get; set; } = new Images();
}
