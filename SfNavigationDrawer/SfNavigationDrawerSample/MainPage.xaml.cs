using System.Collections.ObjectModel;
using SfNavigationDrawerSample;
using Syncfusion.Maui.ListView;


namespace SfNavigationDrawerSample
{
    public partial class MainPage : ContentPage
    {
        [Obsolete]
        public MainPage()
        {
            InitializeComponent();
            Initialize();           
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            navigationDrawer.ToggleDrawer();
        }

        [Obsolete]
        private void Initialize()
        {
            navigationDrawer.ContentView = new Inbox().Content;
            headerLabel.Text = "Inbox";
            inboxEffectsBorder.Background = Color.FromHex("#f2daf7");
            inboxTitle.FontAttributes = FontAttributes.Bold;
        }

        private void ResetSelection()
        {
            inboxEffectsBorder.Background = Colors.Transparent;
            inboxTitle.FontAttributes = FontAttributes.None;
            contactsEffectsBorder.Background = Colors.Transparent;
            contactsTitle.FontAttributes = FontAttributes.None;
            remaindersEffectsBorder.Background = Colors.Transparent;
            remaindersTitle.FontAttributes = FontAttributes.None;
            toDoListEffectsBorder.Background = Colors.Transparent;
            toDolistTitle.FontAttributes = FontAttributes.None;
        }

        [Obsolete]
        private void InboxTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();
            inboxEffectsBorder.Background = Color.FromHex("#f2daf7");
            inboxTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Inbox";
            navigationDrawer.ContentView = new Inbox().Content;           
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void ContactsTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();           
            contactsEffectsBorder.Background = Color.FromHex("#f2daf7");
            contactsTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Contacts";
            navigationDrawer.ContentView = new Contacts().Content;           
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void RemaindersTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();
            remaindersEffectsBorder.Background = Color.FromHex("#f2daf7");
            remaindersTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "Remainders";
            navigationDrawer.ContentView = new Remainders().Content;          
            this.navigationDrawer!.ToggleDrawer();
        }

        [Obsolete]
        private void ToDoListTapGestureRecognizer_Tapped(object? sender, TappedEventArgs e)
        {
            this.ResetSelection();           
            toDoListEffectsBorder.Background = Color.FromHex("#f2daf7");
            toDolistTitle.FontAttributes = FontAttributes.Bold;
            this.headerLabel.Text = "ToDoList";
            navigationDrawer.ContentView = new ToDoList().Content;           
            this.navigationDrawer!.ToggleDrawer();
        }
    }

}
