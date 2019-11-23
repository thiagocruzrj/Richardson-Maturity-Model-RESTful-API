using System.IO;
using LibraryApi.Business;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business.Implementattions
{
    public class FileBusinessImpl : IFileBusiness
    {
        public byte[] GetPDFFile()
        {
            string path = Directory.GetCurrentDirectory();
            var fullPath = path + "\\Other\\Bradesco – Para Você _ Pagamentos.pdf";
            return File.ReadAllBytes(fullPath);
        }
    }
}
