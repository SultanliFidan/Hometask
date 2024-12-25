using GenericRepository.Entites;

namespace GenericRepository.Services.Abstractions
{
    public interface IGroupService
    {
        Task<List<Group>> GetAllGroupsAsync();
    }
}
