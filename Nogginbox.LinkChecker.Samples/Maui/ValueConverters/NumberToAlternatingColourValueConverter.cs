using System.Globalization;

namespace Nogginbox.LinkChecker.Samples.Maui.ValueConverters;

/// <summary>
/// Convert a number to an alternating colour (used to make alternating coloured rows in a table)
/// </summary>
public class NumberToAlternatingColourValueConverter : IValueConverter
{
    public Color EvenNumberColour { get; init; } = Colors.Green;

    public Color OddNumberColour { get; init; } = Colors.Red;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value is not int intValue
            ? Colors.Transparent
            : intValue % 2 == 0
                ? EvenNumberColour
                : OddNumberColour;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException("NumberToAlternatingColourValueConverter.ConvertBack");
    }
}