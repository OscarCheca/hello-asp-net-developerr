using Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

namespace Acme.Hello.Platform.Profiles.Domain.Model.Entities;

public class Developer(PersonName name)
{
    public Guid Id { get; } = Guid.NewGuid();

    public PersonName Name { get; } = name;
    
    public Developer(string firstName, string lastName)
     : this(new PersonName(firstName, lastName)) { }
    
    public string GetFullName() => Name.FullName;
    
    public bool IsAnyNameEmpty() => Name.IsAnyNameEmpty;
}