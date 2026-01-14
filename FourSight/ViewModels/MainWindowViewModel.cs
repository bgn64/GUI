using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FourSight.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    ObservableCollection<WordItemViewModel> _wordItems;

    public MainWindowViewModel()
    {
        WordItems = new ObservableCollection<WordItemViewModel>();

        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                WordItems.Add(new WordItemViewModel()
                {
                    Row = row,
                    Column = col,
                    Text = $"Word{row}{col}"
                });
            }
        }
    }
}
