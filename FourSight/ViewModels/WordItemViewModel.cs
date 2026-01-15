using CommunityToolkit.Mvvm.ComponentModel;

namespace FourSight.ViewModels;

public partial class WordItemViewModel : ViewModelBase
{
    [ObservableProperty]
    int _row;

    [ObservableProperty]
    int _column;

    [ObservableProperty]
    string _text = "";

    [ObservableProperty]
    bool _isSelected;
}
