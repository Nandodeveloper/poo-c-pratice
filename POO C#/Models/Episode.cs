public class Episode
{
    private List<string> guests = new();
    public string Title { get; }
    public string Summary => $"{Title} ({Duration}min) - Guests: {string.Join(", ", guests)}";
    public int Order { get; }
    public int Duration { get; set; }

    public Episode(int order, string title)
    {
        Order = order;
        Title = title;
    }
    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }
}