namespace Nogginbox.LinkChecker.Samples.ViewModels;

public class LineViewModel : ObservableViewModelBase
{
    public LineViewModel(string name, int lineNumber)
    {
        Name = name;
        LineNumber = lineNumber;
    }

    public int LineNumber { get; private set; }

    public string Name { get; init; }

    public int Value
    {
        get => _value;
        set => SetProperty(ref _value, value);
    }
    private int _value = default;
}