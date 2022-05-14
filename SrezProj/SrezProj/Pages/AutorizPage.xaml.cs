using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrezProj.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AutorizPage : ContentPage
    {
        public AutorizPage()
        {
            
            InitializeComponent();
        }

         async private void enter_btn_Clicked(object sender, EventArgs e)
        {
            await  Navigation.PushAsync(new ListPage());
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }
    }
}