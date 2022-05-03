namespace MauiCSharpMarkupExample;

public class MainPageCSharp : ContentPage
{
    int count = 0;

    public MainPageCSharp()
    {
        var scrollView = new ScrollView();
        var verticalStackLayout = new VerticalStackLayout
        {
            Spacing =  25,
            Padding = 30,
        };

        scrollView.Content = verticalStackLayout;

        var helloWorldLabel = new Label
        {
            Text = "Hello, World from C#!",
            FontSize = 32,
            HorizontalOptions = LayoutOptions.Center,
        };

        SemanticProperties.SetHeadingLevel(helloWorldLabel, SemanticHeadingLevel.Level1);
        verticalStackLayout.Children.Add(helloWorldLabel);

        var welcomeLabel = new Label
        {
            Text = "Welcome to .NET Multi-platform App UI",
            FontSize = 18,
            HorizontalOptions = LayoutOptions.Center,
        };

        SemanticProperties.SetHeadingLevel(welcomeLabel, SemanticHeadingLevel.Level1);
        SemanticProperties.SetDescription(welcomeLabel, "Welcome to dot net Multi platform App U I");

        verticalStackLayout.Children.Add(welcomeLabel);

        var countLabel = new Label
        {
            Text = "Current count: 0",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };

        verticalStackLayout.Children.Add(countLabel);

        var button = new Button
        {
            Text = "Click me",
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };

        SemanticProperties.SetHint(button, "Counts the number of times you click");
        button.Clicked += (sender, args) =>
        {
            count++;
            countLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(countLabel.Text);
        };

        verticalStackLayout.Children.Add(button);

        var image = new Image
        {
            Source = new FileImageSource
            {
                File = "dotnet_bot.png",
            },
            WidthRequest = 250,
            HeightRequest = 310,
            HorizontalOptions = LayoutOptions.Center,
        };

        SemanticProperties.SetDescription(image, "Cute dot net bot waving hi to you!");

        verticalStackLayout.Children.Add(image);

        Content = scrollView;
    }
}
