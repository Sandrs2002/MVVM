using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using MVVM.ViewModels;

namespace MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsListPage : ContentPage
	{	
		public FriendsListPage ()
		{
			InitializeComponent ();
			BindingContext = new FriendListViewModel() { Navigation = this.Navigation };
		}
	}
}

