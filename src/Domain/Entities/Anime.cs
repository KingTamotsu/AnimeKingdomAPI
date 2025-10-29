namespace AnimeKingdomAPI.Domain.Entities;

public class Anime : BaseAuditableEntity
{
    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Genre { get; set; }

    public int? Year { get; set; }

    public string? Status { get; set; }

    public string? ImageUrl { get; set; }

    public decimal? Rating { get; set; }

    public IList<AnimeEpisode> Episodes { get; private set; } = new List<AnimeEpisode>();
}