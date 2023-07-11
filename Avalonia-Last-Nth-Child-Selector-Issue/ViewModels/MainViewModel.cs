using System.Collections.ObjectModel;
using ReactiveUI;

namespace Avalonia_Last_Nth_Child_Selector_Issue.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ObservableCollection<string> _elements = new();

    public ObservableCollection<string> Elements
    {
        get => _elements;
        set => this.RaiseAndSetIfChanged(ref _elements, value);
    }

    public void AddElement()
    {
        Elements.Add($"Element {Elements.Count + 1}");
    }

    public void RemoveLastElement()
    {
        if (Elements.Count > 0)
        {
            Elements.RemoveAt(Elements.Count - 1);
        }
    }
}
