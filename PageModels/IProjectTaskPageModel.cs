using CommunityToolkit.Mvvm.Input;
using smoralesS6A1.Models;

namespace smoralesS6A1.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}