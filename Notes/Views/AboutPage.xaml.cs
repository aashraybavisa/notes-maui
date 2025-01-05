using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;
using Maps = Microsoft.Maui.Maps;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
        // Map map = new Map
        // {
        //     MapType = Maps.MapType.Satellite,
        //     IsTrafficEnabled = true,
        //     IsShowingUser = true
        // };
        Location location = new Location(36.9628066, -122.0194722);
        MapSpan mapSpan = new MapSpan(location, 0.01, 0.01);
        Map map = new Map(mapSpan);
        Pin pin = new Pin
        {
            Label = "Santa Cruz",
            Address = "The city with a boardwalk",
            Type = PinType.Place,
            Location = new Location(36.9628066, -122.0194722)
        };
        map.Pins.Add(pin);
        Content = map;
    }

    // private async void LearnMore_Clicked(object sender, EventArgs e)
    // {
    //     // Navigate to the specified URL in the system browser.
    //     if (BindingContext is Models.About about)
    //     {
    //         // Navigate to the specified URL in the system browser.
    //         await Launcher.Default.OpenAsync(about.MoreInfoUrl);
    //     }
    // }
}