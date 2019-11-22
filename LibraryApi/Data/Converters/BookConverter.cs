using System.Collections.Generic;
using System.Linq;
using LibraryApi.Data.Converter;
using LibraryApi.Data.VO;
using RestWithASPNETUdemy.Model;

namespace LibraryApi.Data.Converters
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if(origin == null) return new Book();
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public BookVO Parse(Book origin)
        {
            if(origin == null) return new BookVO();
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public List<Book> ParseList(List<BookVO> origin)
        {
            if(origin == null) return new List<Book>();
            return origin.Select(i => Parse(i)).ToList();
        }

        public List<BookVO> ParseList(List<Book> origin)
        {
            if(origin == null) return new List<BookVO>();
            return origin.Select(i => Parse(i)).ToList();
        }
    }
}