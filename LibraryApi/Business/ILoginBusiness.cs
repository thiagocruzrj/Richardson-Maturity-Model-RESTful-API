using LibraryApi.Model;

namespace LibraryApi.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(User user);
    }
}