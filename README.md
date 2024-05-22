**Overview**

The [.NET MAUI NavigationDrawer](https://www.syncfusion.com/maui-controls/maui-navigationdrawer) is a simpler component to create a navigation pane in the application. It consists of a content area and a sliding pane that slides out from the edge of the page. The NavigationDrawer does not directly support ContentPages. However, we can use the content of a ContentPage to display within the NavigationDrawer. This article demonstrates how to load content pages into the `SfNavigationDrawer’s ContentView`.

**Setting Up the NavigationDrawer in XAML**

First, define the NavigationDrawer in your XAML file. Here's an example of how to set up the drawer with a DrawerContentView:

```xml
<navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer">
    <navigationdrawer:SfNavigationDrawer.DrawerSettings>
        <!-- DrawerSettings Configuration -->
        <navigationdrawer:DrawerSettings >
            <!-- Drawer Header View -->
            <!-- ... -->
            <!-- Drawer Content View -->
            <navigationdrawer:DrawerSettings.DrawerContentView>
                <!-- ScrollView with VerticalStackLayout for menu items -->
                <ScrollView>
                    <VerticalStackLayout Spacing="10" Padding="5,0">
                        <Border StrokeThickness="0" x:Name="inboxEffectsBorder">
                            <Border.StrokeShape>
                                <RoundRectangle CornerRadius="30"/>
                            </Border.StrokeShape>
                            <core:SfEffectsView x:Name="inboxEffects" RippleBackground="#ab56e3">
                                <core:SfEffectsView.GestureRecognizers>
                                    <TapGestureRecognizer 
                                    Tapped="InboxTapGestureRecognizer_Tapped"/>
                                </core:SfEffectsView.GestureRecognizers>
                                <Grid Padding="20,5,10,5" HeightRequest="48">
                                    <!-- ... -->
                                </Grid>
                            </core:SfEffectsView>
                        </Border>
                        <!-- ... -->                        
                    </VerticalStackLayout>
                </ScrollView>
            </navigationdrawer:DrawerSettings.DrawerContentView>
        </navigationdrawer:DrawerSettings>
    </navigationdrawer:SfNavigationDrawer.DrawerSettings>
</navigationdrawer:SfNavigationDrawer>
```

**Create Your Content Pages**

Create the content pages that you want to load into the NavigationDrawer. For example, `Inbox.xaml` and `Contacts.xaml`, etc.

**Handling Content Page Navigation in Code-Behind**

In the code-behind file, you can manage the navigation between content pages by changing the `ContentView` of the NavigationDrawer. Here's how to initialize the drawer with a default content page and handle item taps to switch content:

```csharp
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        Initialize();           
    }

    private void Initialize()
    {
        navigationDrawer.ContentView = new Inbox().Content;
        // Additional initialization logic
    }

    private void ResetSelection()
    {
        // Reset the visual state of menu items
    }

    private void InboxTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
    {
        ResetSelection();
        navigationDrawer.ContentView = new Inbox().Content;
        // Update UI accordingly
    }

    private void ContactsTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
    {
        ResetSelection();
        navigationDrawer.ContentView = new Contacts().Content;
        // Update UI accordingly
    }

    // Additional tap handlers for other menu items
}
```

**Output**

![NavigationDrawer.gif](https://support.syncfusion.com/kb/agent/attachment/article/15674/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjIzMTI3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.-7LIh-NyfE6Cu6eU7kU5A4Usru12DkUUJh0ktWQuVJQ)