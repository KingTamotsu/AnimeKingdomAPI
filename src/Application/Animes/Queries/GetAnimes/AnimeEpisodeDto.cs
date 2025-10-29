using AnimeKingdomAPI.Domain.Entities;

namespace AnimeKingdomAPI.Application.Animes.Queries.GetAnimes;

public class AnimeEpisodeDto
{
    public int Id { get; init; }

    public int AnimeId { get; init; }

    public string? Title { get; init; }

    public int EpisodeNumber { get; init; }

    public string? Description { get; init; }

    public TimeSpan? Duration { get; init; }

    public DateTime? AirDate { get; init; }

    public bool Watched { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AnimeEpisode, AnimeEpisodeDto>();
        }
    }
}