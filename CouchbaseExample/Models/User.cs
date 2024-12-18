
namespace CouchbaseExample.Models
{
    public sealed class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? Surname { get; set; }

        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
