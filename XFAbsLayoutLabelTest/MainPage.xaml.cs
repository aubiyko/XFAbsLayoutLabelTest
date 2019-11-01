using System;
using Xamarin.Forms;

namespace XFAbsLayoutLabelTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private void Button_Clicked(object sender, EventArgs e)
        {
            stack.Children.Add(new Button()
            {
                Text = "Sample Text",
                CornerRadius = 20,
                BackgroundColor = Color.Aqua
            });
        }

        private bool labelSmallText = true,
            buttonSmallText = true;

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            label.Text = labelSmallText ? "Very long Sample Text, Sample Text and Sample Text that should overflow and wrap" : "Sample Text";
            labelSmallText = !labelSmallText;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            button.Text = buttonSmallText ? "Very long Sample Text, Sample Text and Sample Text that should overflow and wrap" : "Sample Text";
            buttonSmallText = !buttonSmallText;
        }

        private void Button_Clicked_3(object sender, EventArgs e) => button.HeightRequest = 100;
    }
}