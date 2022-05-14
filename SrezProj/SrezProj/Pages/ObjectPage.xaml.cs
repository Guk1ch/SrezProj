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
    public partial class ObjectPage : ContentPage
    {
        public ObjectPage()
        {
            InitializeComponent();
        }

         async private void Save_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        async private void Del_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}