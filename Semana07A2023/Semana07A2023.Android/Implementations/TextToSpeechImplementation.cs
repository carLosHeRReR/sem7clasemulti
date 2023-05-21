using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;

using Semana07A2023.Interfaces;
using System;
using Android.Speech.Tts;
using Xamarin.Forms;
using Semana07A2023.Droid.Implementations;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace Semana07A2023.Droid.Implementations
{
    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
            {

                speaker = new TextToSpeech(Forms.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
        #endregion
    }

}