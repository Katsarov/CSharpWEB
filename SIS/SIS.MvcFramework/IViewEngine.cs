
namespace SIS.MvcFramework
{

    public interface IViewEngine
    {
        string GetHtml(string TemplateHtml, object model);
    }
}
