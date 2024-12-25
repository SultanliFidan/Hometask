using GenericRepository.Entites;
using GenericRepository.Repositories.Abstractions;
using GenericRepository.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Services.Concretes
{
    public class GroupService : IGroupService
    {
        private readonly ITRepository<Group> _repository;

        public GroupService(ITRepository<Group> repository)
        {

            _repository = repository;
        }
      

        public async Task<List<Group>> GetAllGroupsAsync()
        {
            IQueryable<Group> queryableGroups = _repository.GetAllT(false, "Students");
            List<Group> groups = await queryableGroups.ToListAsync();
            return groups;
        }
    }
}
 