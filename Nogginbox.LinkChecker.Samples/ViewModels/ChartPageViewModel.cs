using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Collections.ObjectModel;

namespace Nogginbox.LinkChecker.Samples.ViewModels;

public class ChartPageViewModel : ObservableViewModelBase
{
    public ChartPageViewModel()
    {
        AddLine("OK", 56);
        AddLine("Not found", 5);
        AddLine("Pending", 12);
        Total = Lines.Sum(l => l.Value);
    }

    public ObservableCollection<LineViewModel> Lines { get; set; } = new ();

    public ObservableCollection<ISeries> ChartData { get; private set; } = new ();

    public int Total
    {
        get => _total;
        set => SetProperty(ref _total, value);
    }
    private int _total = default;

    private void AddLine(string name, int value)
    {
        var pieSeries = new PieSeries<int>
        {
            Name = name,
            Values = new int[] { value },
            IsVisible = value > 0
        };
        ChartData.Add(pieSeries);
        Lines.Add(new LineViewModel(name, _lineNum++) { Value = value });
    }
    private int _lineNum = 0;
}