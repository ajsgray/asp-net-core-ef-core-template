namespace AspNetCoreEfCoreTemplate.Data;

public class EntityBase
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; } = DateTime.UtcNow;
}
