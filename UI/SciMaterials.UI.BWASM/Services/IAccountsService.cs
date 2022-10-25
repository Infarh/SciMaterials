﻿using SciMaterials.UI.BWASM.Models;

namespace SciMaterials.UI.BWASM.Services;

public interface IAccountsService
{
    Task<IReadOnlyList<UserInfo>> UsersList();
    Task ChangeAuthority(Guid userId, Guid authorityId);
    Task Delete(Guid userId);
}