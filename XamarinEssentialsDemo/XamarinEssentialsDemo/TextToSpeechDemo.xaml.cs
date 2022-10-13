using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechDemo : ContentPage
    {
        public TextToSpeechDemo()
        {
            InitializeComponent();

            btnSpeak.Clicked += async (sender, e) =>
            {
                await TextToSpeech.SpeakAsync(entryText.Text);
            };
        }
    }
}