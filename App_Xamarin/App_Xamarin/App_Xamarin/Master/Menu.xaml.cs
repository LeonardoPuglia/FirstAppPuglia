using App_Xamarin.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoToPerfilPage(object sender , EventArgs args)
        {
            Detail = new NavigationPage(new Perfil());
            IsPresented = false;
        }
        private void GotToAboutXamarin(object sender, EventArgs args)
        {
            Detail = new NavigationPage( new XamarinAbout() );
            IsPresented = false;
        }



    }
}