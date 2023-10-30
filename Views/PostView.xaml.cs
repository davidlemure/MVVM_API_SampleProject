using MVVM_API_SampleProject.Models;

namespace MVVM_API_SampleProject.Views;

public partial class PostView : ContentPage
{
	public PostView()
	{
		InitializeComponent();
		var post = new Post
		{
			Id = 1,
			UserId = 1,
			Title = "Test",
			Body = "Test"
		};
		BindingContext = post;
	}
}