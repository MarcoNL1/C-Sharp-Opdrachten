class Song
{
    public string Title;
    public Artist Singer = new("Unknown");

    public Song(string title)
    {
        Title = title;
    }

    public void SetSinger(Artist singer) => Singer = singer;
    public string Info() => $"{Title} is by {Singer.Name}";
}