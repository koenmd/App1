using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.ViewModels;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage, IViewFor<LoginViewModel>
	{
		public LoginPage ()
		{
			InitializeComponent ();
			// We'll initialize our viewmodel
			ViewModel = new LoginViewModel();
			// We'll add the bindings
			this.Bind(ViewModel, vm => vm.Email, v => v.Email.Text);
			this.Bind(ViewModel, vm => vm.Password, v => v.Password.Text);
			this.Bind(ViewModel, vm => vm.IsLoading, v => v.Loading.IsVisible );
			this.BindCommand(ViewModel, vm => vm.Login, v => v.Login);
			//this.BindCommand(ViewModel, vm => vm.ListViewPage, v => v.ListViewPage);
		}

		//The rest of the code below is plumbing:

		public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(LoginViewModel), typeof(LoginPage), null, BindingMode.OneWay);

		public LoginViewModel ViewModel
		{
			get { return (LoginViewModel)GetValue(ViewModelProperty); }
			set { SetValue(ViewModelProperty, value); }
		}

		object IViewFor.ViewModel
		{
			get { return ViewModel; }
			set { ViewModel = (LoginViewModel)value; }
		}

        private void ListViewPage_Clicked(object sender, EventArgs e)
        {
            //ListViewPage lvp = 
            this.Navigation.PushAsync(new Views.ListViewPage());
        }

        private void XamListViewPage_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Views.XamListViewPage());
        }
    }
}