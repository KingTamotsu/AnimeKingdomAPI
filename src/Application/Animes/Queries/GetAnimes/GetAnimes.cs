using AnimeKingdomAPI.Application.Common.Interfaces;

namespace AnimeKingdomAPI.Application.Animes.Queries.GetAnimes;

public record GetAnimesQuery : IRequest<AnimesVm>
{
}

public class GetAnimesQueryValidator : AbstractValidator<GetAnimesQuery>
{
    public GetAnimesQueryValidator()
    {
    }
}

public class GetAnimesQueryHandler : IRequestHandler<GetAnimesQuery, AnimesVm>
{
    private readonly IApplicationDbContext _context;

    public GetAnimesQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<AnimesVm> Handle(GetAnimesQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
