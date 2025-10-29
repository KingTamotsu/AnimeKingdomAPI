using AnimeKingdomAPI.Domain.Entities;

namespace AnimeKingdomAPI.Application.Animes.Queries.GetAnimes;

public class AnimeDto
{
    public AnimeDto()
    {
        Episodes = Array.Empty<AnimeEpisodeDto>();
    }

    public int Id { get; init; }

    public string? Title { get; init; }

    public string? Description { get; init; }

    public string? Genre { get; init; }

    public int? Year { get; init; }

    public string? Status { get; init; }

    public IReadOnlyCollection<AnimeEpisodeDto> Episodes { get; init; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Anime, AnimeDto>();
        }
    }
}