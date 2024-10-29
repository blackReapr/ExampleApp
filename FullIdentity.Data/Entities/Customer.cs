namespace FullIdentity.Data.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string ResponsibleFullName { get; set; }
    public string Phone { get; set; }
}
