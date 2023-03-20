class HarleyDavidson : Cruiser
{
    public int SeatHeight;
    public HarleyDavidson(string model, int year) : base("Harley Davidson", "Softail", 2022, 68)
    {
    }

    public override string Ride()
    {
        return $"{base.Ride()} and with pride.";
    }
}