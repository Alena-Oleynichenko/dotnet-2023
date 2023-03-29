namespace Realtor;
public class Application
{
    /// <summary>
    /// Id - guid typed value for storing Id of the room
    /// </summary>
    public Guid Id { get; set; } = Guid.Empty;
    /// <summary>
    /// Type - string typed value representing a type of the room
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// Cost - uint for storing a cost of the room
    /// </summary>
    public uint Cost { get; set; } = uint.MinValue;
    /// <summary>
    /// Data - DateTime typed value for storing a date of application
    /// </summary>
    public DateTime Data { get; set; } = DateTime.MinValue;
    public List<Client> Clients { get; set; } = new();
    public List<House> House { get; set; } = new();
    public Application() { }
    public Application(Guid id, string type, uint cost, DateTime data)
    {
        Id = id;
        Type = type;
        Cost = cost;
        Data = data;
    }
}