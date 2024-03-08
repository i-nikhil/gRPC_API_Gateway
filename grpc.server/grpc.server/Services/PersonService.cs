using Bogus;
using Google.Protobuf.WellKnownTypes;
using grpc.server.Models;
using grpc.server.Protos;
using Grpc.Core;
using static grpc.server.Protos.PersonService;

namespace grpc.server.Services
{
    public class PersonService : PersonServiceBase
    {
        private readonly List<Models.Person> _people;

        public PersonService()
        {
            _people = PersonSeeder.GenerateRandomPersons(100).ToList();
        }

        public override Task<PersonResponse> AddPerson(PersonRequest request, ServerCallContext context)
        {
            Models.Person newPerson = new()
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Age = request.Age,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = default
            };

            _people.Add(newPerson);

            return Task.FromResult(new PersonResponse
            {
                Id = newPerson.Id.ToString(),
                Name = request.Name,
                Age = request.Age,
                CreatedAt = Timestamp.FromDateTime(newPerson.CreatedAt),
                UpdatedAt = newPerson.UpdatedAt.HasValue ? Timestamp.FromDateTime(newPerson.UpdatedAt.Value) : null
            });
        }

        public override async Task GetPersons(PersonPaginationRequest request, IServerStreamWriter<PersonResponse> responseStream, ServerCallContext context)
        {
            CancellationToken cancellationToken = context.CancellationToken;

            IEnumerable<Models.Person> pagedPersons = _people.Skip((request.Page - 1) * request.Limit).Take(request.Limit);

            foreach (Models.Person person in pagedPersons)
            {
                await responseStream.WriteAsync(new PersonResponse
                {
                    Id = person.Id.ToString(),
                    Name = person.Name,
                    Age = person.Age,
                    CreatedAt = Timestamp.FromDateTime(person.CreatedAt),
                    UpdatedAt = person.UpdatedAt.HasValue ? Timestamp.FromDateTime(person.UpdatedAt.Value) : null
                });
            }
        }
    }
}
