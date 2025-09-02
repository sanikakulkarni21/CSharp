namespace FirstAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }=null!; //value should not be null
        public string Author { get; set; }=null!;
        public int YearPublished { get; set; }
    }
}
