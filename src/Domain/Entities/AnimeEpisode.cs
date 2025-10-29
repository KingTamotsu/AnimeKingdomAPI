namespace AnimeKingdomAPI.Domain.Entities;

public class AnimeEpisode : BaseAuditableEntity
{
    public int AnimeId { get; set; }

    public string? Title { get; set; }

    public int EpisodeNumber { get; set; }

    public string? Description { get; set; }

    public TimeSpan? Duration { get; set; }

    public DateTime? AirDate { get; set; }

    private bool _watched;
    public bool Watched
    {
        get => _watched;
        set
        {
            if (value && !_watched)
            {
                // You can add domain events here later if needed
                // AddDomainEvent(new AnimeEpisodeWatchedEvent(this));
            }

            _watched = value;
        }
    }

    public Anime Anime { get; set; } = null!;
}