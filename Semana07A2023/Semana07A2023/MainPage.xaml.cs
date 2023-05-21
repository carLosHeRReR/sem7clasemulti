using Semana07A2023.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana07A2023
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSpeak_Clicked(object sender, EventArgs e)
        {

            DependencyService.Get<ITextToSpeech>().Speak(txtMessage.Text);

        }
    }
}
