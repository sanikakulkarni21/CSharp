using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstAPI.Models;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Attribute
    public class BooksController : ControllerBase
    {
        static private List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", YearPublished = 1960 },
            new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 },
            new Book { Id = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 }
        };
        [HttpGet]
        public ActionResult<List<Book>> GetBooks()
        {
            return Ok(books);
        }

        [HttpGet("{id}")]//api/books/1
        public ActionResult<Book> GetBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook)
        {
           if (newBook == null)
           {
                return BadRequest();
                books.Add(newBook);
               
            }
            return CreatedAtAction(nameof(GetBook), new { id = newBook.Id }, newBook);

        }

    }
}
