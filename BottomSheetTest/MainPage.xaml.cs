namespace BottomSheetTest;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

    private void ShowBottomSheet(object sender, EventArgs e)
    {
        this.ShowBottomSheet(GetBottomSheetView(), true);
    }


    private View GetBottomSheetView()
    {
        var view = (View)BottomSheetTemplate.CreateContent();
        view.BindingContext = BindingContext;
        return view;
    }

}

