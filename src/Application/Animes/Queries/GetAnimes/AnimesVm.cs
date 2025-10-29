using AnimeKingdomAPI.Application.Common.Models;

namespace AnimeKingdomAPI.Application.Animes.Queries.GetAnimes;

public class AnimesVm
{
    public IReadOnlyCollection<LookupDto> Genres { get; init; } = Array.Empty<LookupDto>();

    public IReadOnlyCollection<AnimeDto> Animes { get; init; } = Array.Empty<AnimeDto>();
}