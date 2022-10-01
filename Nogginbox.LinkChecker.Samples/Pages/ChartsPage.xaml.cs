using Nogginbox.LinkChecker.Samples.ViewModels;

namespace Nogginbox.LinkChecker.Samples.Pages;

public partial class ChartsPage : ContentPage
{
	public ChartsPage(ChartPageViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
    }
}