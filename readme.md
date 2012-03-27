Geekors WP7 Template v.1.0.0
==========================

Entire template project base on <a href="http://www.novanet.no/blog/yngve-bakken-nilsen/dates/2012/3/wp7-boilerplate/" target="_blank">this post</a>

##Feature

1.Providing the groundwork of windows phone 7 project quickly.

##Usage

1.Clone git project.
	
	git clone git@github.com:leehom59/GeekorsWP7Template.git
	
2.Open the JZ001.sln file on the root of project folder.
	
3.Press F5 to run this project.

4.You will see this sample application on your device or emulator named "Geekors WP7".

##Development

1.Your view(xaml file) must has one viewmodel that inherit from BaseViewModel.

2.This viewmodel must declare PageDefinition Attribute with the view(xaml file) path.
	
	[PageDefinition("/DetailPage.xaml")]
    public class DetailPageViewModel : BaseViewModel
	{
		//your model fields.
	}
	
3.Navigation function : if you want to navigate to DetailPage.xaml from MainPage.xaml, put the following code on MainPage.xaml.cs.
	
	App.ViewModel.GoTo<DetailPageViewModel>();

4.Navigating to DetailPage.xaml with parameters.

	var p = new ResourceDictionary() { { "ID", 007 } };
    App.ViewModel.GoToWithParameters<DetailPageViewModel>(p);

4.1 Then you can get the parameters at DtailPage by using NavigationContext object.

	string id = NavigationContext.QueryString["ID"];
	
