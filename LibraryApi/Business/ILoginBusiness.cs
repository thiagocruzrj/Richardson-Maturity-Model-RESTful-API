using LibraryApi.Data.VO;

namespace LibraryApi.Business
{
    public interface ILoginBusiness
    {
        object FindByLogin(UserVO user);
    }
}