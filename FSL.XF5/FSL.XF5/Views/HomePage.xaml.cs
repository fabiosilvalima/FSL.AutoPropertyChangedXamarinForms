using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FSL.XF5.Views
{
    public partial class HomePage : ContentPage
    {
        ViewModels.HomePageViewModel vm = null;

        public HomePage()
        {
            vm = new ViewModels.HomePageViewModel()
            {
                Titulo = "Ola Mundo"
            };

            BindingContext = vm;

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            vm.Titulo += " via botão";
        }
    }
}
