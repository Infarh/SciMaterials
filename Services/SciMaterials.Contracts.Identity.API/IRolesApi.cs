using SciMaterials.Contracts.Identity.API.Requests.Roles;
using SciMaterials.Contracts.Identity.API.Responses.DTO;
using SciMaterials.Contracts.Result;

namespace SciMaterials.Contracts.Identity.API;

/// <summary> �������� ��� ����� ������������� </summary>
public interface IRolesApi
{
    /// <summary> ����� ��� ��� �������� ���� ������������ � Identity </summary>
    /// <param name="CreateRoleRequest"> ������ �� �������� ���� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> CreateRoleAsync(CreateRoleRequest CreateRoleRequest, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ��������� ���. � ���� ����� � Identity </summary>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ������ ����� </returns>
    Task<Result<IEnumerable<AuthRole>>> GetAllRolesAsync(CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ��������� ���. � ���� �� �������������� � Identity </summary>
    /// <param name="RoleId"> ������������� ���� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� � ��� ������� �������� ���� ������� ��������� <paramref name="RoleId"/> </returns>
    Task<Result<AuthRole>> GetRoleByIdAsync(string RoleId, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� �������������� ���� �� �������������� � Identity </summary>
    /// <param name="EditRoleRequest"> ������ �� �������������� ���� �� �������������� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> EditRoleNameByIdAsync(EditRoleNameByIdRequest EditRoleRequest, CancellationToken Cancel = default);

    /// <summary> ����� ��� �� �������� ���� �� �������������� � Identity </summary>
    /// <param name="RoleId"> ������������� ���� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> DeleteRoleByIdAsync(string RoleId, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ���������� ���� � ������������ � Identity </summary>
    /// <param name="AddRoleRequest"> ������ �� ���������� ���� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> AddRoleToUserAsync(AddRoleToUserRequest AddRoleRequest, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� �������� ���� ������������ �� email � Identity </summary>
    /// <param name="Email"> Email ������������ </param>
    /// <param name="RoleName"> ��� ���� </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns> ��������� ���������� �������� </returns>
    Task<Result.Result> DeleteUserRoleByEmailAsync(string Email, string RoleName, CancellationToken Cancel = default);

    /// <summary> ����� ��� ��� ��������� ���������� � ���� ����� � ������� � Identity </summary>
    /// <param name="Email"> Email ������������ </param>
    /// <param name="Cancel"> ����� ������ </param>
    /// <returns>
    /// ��������� ���������� �������� � ��� ������� �������� ������ �����
    /// ����������� � ���������� ������������ � <paramref name="Email"/>
    /// </returns>
    Task<Result<IEnumerable<AuthRole>>> GetUserRolesAsync(string Email, CancellationToken Cancel = default);
}