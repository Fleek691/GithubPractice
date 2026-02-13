public class New
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public string Type { get; set; }
    public string TypeDescription { get; set; }
     public New(int id, string name, string description, string type, string typeDescription)
    {
        Id = id;
        Name = name;
        Description = description;
        Type = type;
        TypeDescription = typeDescription;
    }
}