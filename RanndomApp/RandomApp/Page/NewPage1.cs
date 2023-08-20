namespace RandomApp.Page;

public class NewPage1 : ContentPage
{
    public NewPage1()
    {
        CollectionView collectionView = new CollectionView();
        collectionView.ItemTemplate = new DataTemplate
        {
            LoadTemplate = TempaleCreation,
        };
        Content = new VerticalStackLayout
        {
            collectionView
            };
        this.Navigation.PushAsync();
    }
    public Frame TempaleCreation()
    {
        Frame frame = new Frame();

        return frame;
    }
}
