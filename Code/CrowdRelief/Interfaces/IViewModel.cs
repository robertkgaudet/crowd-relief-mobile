namespace CrowdRelief.Interfaces
{
    public interface IViewModel
    {
        ViewModels.BaseViewModel Initialize(object navigationData);
    }
    public interface IViewModel<T> : IViewModel where T : ViewModels.BaseViewModel
    {
        new T Initialize(object navigationData);
    }
}