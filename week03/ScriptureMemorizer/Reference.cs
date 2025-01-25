public class Reference
{
    public string Book { get; set; }
    public string Chapter { get; set; }
    public string Verse { get; set; }

    public Reference(string book, string chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    public override string ToString()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
