using System.Collections.ObjectModel;

namespace Nogginbox.LinkChecker.Samples.ViewModels;

public class ChartPageViewModel : ObservableViewModelBase
{
    public ObservableCollection<LineViewModel> Lines { get; set; } = new();

    public int Total
    {
        get => _total;
        set => SetProperty(ref _total, value);
    }
    private int _total = default;
}