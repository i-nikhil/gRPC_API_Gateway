using grpc.client.Models;

namespace grpc.client.Services;

public interface IPersonService
{
    public Task<List<Person>> GetPersonPaginatedAsync(int page, int limit, CancellationToken cancellationToken = default);

    public Task AddPersonAsync(string name, int age, CancellationToken cancellationToken = default);
}