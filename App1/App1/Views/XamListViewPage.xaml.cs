using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;
using ReactiveUI.XamForms;
using App1.ViewModels;
using ReactiveUI;

namespace App1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XamListViewPage : ContentPage, IBasePage<XamListViewPageModel>, IViewFor<XamListViewPageModel>
    {
		public XamListViewPage ()
		{
			InitializeComponent ();

            ViewModel = new XamListViewPageModel();
            // We'll add the bindings
            this.ItemList.ItemsSource = ViewModel.ItemViewModelList;

        }

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(XamListViewPageModel), typeof(XamListViewPageModel), null, BindingMode.OneWay);

        public XamListViewPageModel ViewModel
        {
            get { return (XamListViewPageModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (XamListViewPageModel)value; }
        }
    }
}