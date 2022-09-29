using System.Collections.ObjectModel;

namespace Nogginbox.LinkChecker.Samples.ViewModels;

public class ChartPageViewModel : ObservableViewModelBase
{
    public ChartPageViewModel()
    {
        Lines.Add(new LineViewModel("OK", 0) { Value = 56 } );
        Lines.Add(new LineViewModel("Not found", 1) { Value = 5 });
        Lines.Add(new LineViewModel("Pending", 2) { Value = 12 });
        Total = Lines.Sum(l => l.Value);
    }

    public ObservableCollection<LineViewModel> Lines { get; set; } = new();

    public int Total
    {
        get => _total;
        set => SetProperty(ref _total, value);
    }
    private int _total = default;
}