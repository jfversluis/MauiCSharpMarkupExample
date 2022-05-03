using CommunityToolkit.Maui.Markup;

namespace MauiCSharpMarkupExample;

public class MainPageCSharpMarkup : ContentPage
{
    int count = 0;

    public MainPageCSharpMarkup()
    {
        var scrollView = new ScrollView();
        var verticalStackLayout = new VerticalStackLayout
        {
            Spacing = 25,
            Children =
            {
                new Label
                {
                    Text = "Hello, World from C# Markup!",
                }
                .Font(size: 32)
                .CenterHorizontal(),

                new Label
                {
                    Text = "Welcome to .NET Multi-platform App UI",
                }
                .Font(size: 18)
                .CenterHorizontal(),

                new Label
                {
                    Text = "Current count: 0"
                }
                .Font(size: 18, bold: true)
                .CenterHorizontal()
                .Assign(out Label countLabel),

                new Button
                {
                    Text = "Click me"
                }
                .Font(bold: true)
                .CenterHorizontal()
                .Invoke(b => b.Clicked += (sender, e) =>
                {
                    count++;
                    countLabel.Text = $"Current count: {count}";

                    SemanticScreenReader.Announce(countLabel.Text);
                }),

                new Image
                {
                    Source = new FileImageSource
                    {
                        File = "dotnet_bot.png",
                    },
                    WidthRequest = 250,
                    HeightRequest = 310
                }
                .CenterHorizontal()
            }
        }
        .Paddings(30, 30, 30, 30);

        scrollView.Content = verticalStackLayout;

        Content = scrollView;
    }
}
