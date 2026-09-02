namespace Acme.Hello.Platform.Profiles.Domain.Model.ValueObjects;

public readonly record struct PersonName
{
    public string? FirstName
    {
        get => field ?? string.Empty; 
        private init => field = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
    }

    public string? LastName
    {
        get => field ?? string.Empty; 
        private init => field = string.IsNullOrWhiteSpace(value) ? string.Empty : value.Trim();
    }
    
    public PersonName(string? firstName, string? lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    public PersonName() : this(string.Empty, string.Empty) { }
    
    public string FullName => $"{FirstName} {LastName}".Trim();
    
    public bool IsAnyNameEmpty => string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName);
}