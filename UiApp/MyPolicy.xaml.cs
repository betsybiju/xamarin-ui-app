using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPolicy : ContentPage
    {
        public MyPolicy()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as ModelView;
            var policy = e.Item as Policy;
            vm.ShowOrHidePolicy(policy);
        }
    }
}