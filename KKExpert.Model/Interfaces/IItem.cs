namespace KKExpert.Model.Interfaces
{
    public interface IItem
    {
        int Id { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }

        string Category { get; set; }
    }
}
