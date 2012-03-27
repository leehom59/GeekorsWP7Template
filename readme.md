Geekors WP7 Template v.1.0.0
==========================

##Feature

1.Providing the groundwork of windows phone 7 project quickly.

##Usage

1.Clone git project.
	
	git clone git@github.com:leehom59/GeekorsWP7Template.git
	
2.Open the JZ001.sln file on the root of project folder.
	
3.Press F5 to run this project.

4.You will see this sample on your device or emulator named "Geekors WP7".

##Usage 2

1.Your view(xaml file) must has one viewmodel that inherit from BaseViewModel.

2.This viewmodel must declare PageDefinition Attribute with the view(xaml file) path.
	
	[PageDefinition("/DetailPage.xaml")]
    public class DetailPageViewModel : BaseViewModel
	{
		//your model fields.
	}
	
