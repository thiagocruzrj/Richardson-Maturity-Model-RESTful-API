using System;
using System.Runtime.Serialization;

namespace LibraryApi.Data.VO
{
    [DataContract]
    public class BookVO
    {
        [DataMember (Order = 1)]
        public long? Id { get; set; }
        [DataMember (Order = 2, Name ="titulo")]
        public string Title { get; set; }
        [DataMember (Order = 3, Name ="autor")]
        public string Author { get; set; }
        [DataMember (Order = 5, Name ="preco")]
        public decimal Price { get; set; }
        [DataMember (Order = 4, Name ="dataLancamento")]
        public DateTime LaunchDate { get; set; }
    }
}