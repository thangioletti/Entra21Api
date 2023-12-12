using MinhaApiBonita.Entity;

namespace MinhaApiBonita.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserEntity user);
        Task Update(UserEntity user);
        Task Delete(UserEntity user);
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> Get();
    }
}
