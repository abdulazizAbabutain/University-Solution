using RestSharp;

namespace University_CRM_UI.MVC.Interfaces
{
    public interface IRestClintService<T>
    {
        T? Get(string name);
        RestResponse Post(string name, T model); 
    }
}
