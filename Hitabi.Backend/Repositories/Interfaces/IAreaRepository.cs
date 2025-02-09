﻿using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IAreaRepository
    {
        IList<Area> GetAreas();

        Area GetAreaByGuid(Guid guid);

        Area CreateArea(Area area);

        bool UpdateArea(Area area);
    }
}
