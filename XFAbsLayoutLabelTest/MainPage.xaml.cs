using Xamarin.Forms;

namespace XFAbsLayoutLabelTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            stack.Children.Add(new Button()
            {
                Text = "Sample Text",
                CornerRadius = 20,
                BackgroundColor = Color.Aqua
            });
        }

        private bool smallText = true;

        private void Button_Clicked_1(object sender, System.EventArgs e)
        {
            label.Text = smallText ? "Very long Sample Text, Sample Text and Sample Text that should overflow and wrap" : "Sample Text";
            smallText = !smallText;
        }

        private void Button_Clicked_2(object sender, System.EventArgs e) => button.HeightRequest = 100;
    }
}
