using AnimeKingdomAPI.Application.Common.Interfaces;

namespace AnimeKingdomAPI.Application.Animes.Commands.CreateAnime;

public record CreateAnimeCommand : IRequest<int>
{
}

public class CreateAnimeCommandValidator : AbstractValidator<CreateAnimeCommand>
{
    public CreateAnimeCommandValidator()
    {
    }
}

public class CreateAnimeCommandHandler : IRequestHandler<CreateAnimeCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateAnimeCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateAnimeCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
