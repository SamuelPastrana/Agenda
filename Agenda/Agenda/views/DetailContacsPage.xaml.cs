using Agenda.Domain;
using Agenda.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailContacsPage : ContentPage
	{
		public DetailContacsPage (Contact contact)
		{
			InitializeComponent ();
            LoadData(contact);
		}

        private void LoadData(Contact contact)
        {
            gridDatos.BindingContext = contact;

        }
	}
}