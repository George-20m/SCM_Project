namespace RESTApi.Entities
{
    public class SuperHero
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LirstName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
