﻿using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ICopyInfoRepository
    {
        IList<CopyInfo> GetCopyInfos();

        CopyInfo GetCopyInfoByGuid(Guid guid);

        CopyInfo CreateCopyInfo();

        bool UpdateCopyInfo();
    }
}
