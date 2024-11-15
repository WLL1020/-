using CommunityToolkit.Mvvm.ComponentModel;

namespace SurApp2024Wll0338
{
    public partial class GPoint : ObservableObject
    {
        [ObservableProperty]
        private string? name = "";
        [ObservableProperty]
        private double x = 0.0;
        [ObservableProperty]
        private double y = 0.0;
    }
}
