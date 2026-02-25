class Character
{
    public string Name;
    public int Level;
    public string Job;

    public override string ToString()
    {
        return $"{Name} - {Job} Lv.{Level}";
    }
}