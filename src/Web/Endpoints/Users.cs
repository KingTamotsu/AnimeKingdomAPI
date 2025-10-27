﻿using AnimeKingdomAPI.Infrastructure.Identity;

namespace AnimeKingdomAPI.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapIdentityApi<ApplicationUser>();
    }
}

