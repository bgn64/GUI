using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Calculator.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentCalculation))]
    [NotifyPropertyChangedFor(nameof(InputDisplay))]
    string? _firstNumber;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentCalculation))]
    string? _operator;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(CurrentCalculation))]
    string? _secondNumber;

    public string CurrentCalculation
    {
        get
        {
            string res = string.Empty;
            
            if (FirstNumber is null)
            {
                return res;
            }

            res += $"{FirstNumber}";

            if (Operator is null)
            {
                return res; 
            }

            res += $" {Operator}";

            if (SecondNumber is null)
            {
                return res;
            }

            res += $" {SecondNumber} =";

            return res;
        }
    }

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(InputDisplay))]
    string? _inputNumber;

    public string InputDisplay
    {
        get
        {
            return InputNumber ?? FirstNumber ?? "What happened?"; 
        }
    }

    public MainWindowViewModel()
    {
        InputNumber = "0";
    }

    [RelayCommand]
    void InputOne()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "1";
    }

    [RelayCommand]
    void InputTwo()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "2";
    }

    [RelayCommand]
    void InputThree()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "3";
    }

    [RelayCommand]
    void InputFour()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "4";
    }

    [RelayCommand]
    void InputFive()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "5";
    }

    [RelayCommand]
    void InputSix()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "6";
    }

    [RelayCommand]
    void InputSeven()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "7";
    }

    [RelayCommand]
    void InputEight()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "8";
    }

    [RelayCommand]
    void InputNine()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "9";
    }

    [RelayCommand]
    void InputZero()
    {
        if (InputNumber is null || InputNumber == "0")
        {
            InputNumber = "";
        }

        InputNumber += "0";
    }

    [RelayCommand]
    void InputAdditionSign()
    { 
        if (TryComputeBinaryResult(out double res))
        {
            FirstNumber = res.ToString();
        }
        else
        {
            FirstNumber = InputNumber;
        }

        InputNumber = null;
        Operator = "+";
        SecondNumber = null;
    }

    [RelayCommand]
    void InputSubtractionSign()
    {
        if (TryComputeBinaryResult(out double res))
        {
            FirstNumber = res.ToString();
        } 
        else
        {
            FirstNumber = InputNumber;
        }

        InputNumber = null;
        Operator = "-";
        SecondNumber = null;
    }

    [RelayCommand]
    void InputMultiplicationSign()
    {
        if (TryComputeBinaryResult(out double res))
        {
            FirstNumber = res.ToString();
        }
        else
        {
            FirstNumber = InputNumber;
        }

        InputNumber = null;
        Operator = "*";
        SecondNumber = null;
    }

    [RelayCommand]
    void InputDivisionSign()
    {
        if (TryComputeBinaryResult(out double res))
        {
            FirstNumber = res.ToString();
        } 
        else
        {
            FirstNumber = InputNumber;
        }

        InputNumber = null;
        Operator = "/";
        SecondNumber = null;
    }

    [RelayCommand]
    void Equals()
    {
        if (TryComputeBinaryResult(out double res))
        {
            SecondNumber = InputNumber;
            InputNumber = res.ToString();
        } 
    }

    [RelayCommand]
    void C()
    {
        InputNumber = "0";
        FirstNumber = null;
        Operator = null;
        SecondNumber = null;
    }

    bool TryComputeBinaryResult(out double d)
    {
        d = 0;

        if (Operator is null || SecondNumber is not null || !double.TryParse(FirstNumber, out double d1) || !double.TryParse(InputNumber, out double d2))
        {
            return false;
        }

        if (Operator.Equals("+"))
        {
            d = d1 + d2;

            return true;
        }
        else if (Operator.Equals("-"))
        {
            d = d1 - d2;

            return true;
        }
        else if (Operator.Equals("*"))
        {
            d = d1 * d2;

            return true;
        }
        else if (Operator.Equals("/"))
        {
            d = d1 / d2;

            return true;
        }

        // We should not hit this case
        return false;
    }
}
