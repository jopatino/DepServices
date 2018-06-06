using AVFoundation;
using DepServices.iOS.DependencyServices;
using DepServices.DependencyServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
[assembly:Dependency(typeof(IOSTextVoz))]
namespace DepServices.iOS.DependencyServices
{
    public class IOSTextVoz : ITextVoz
    {
        public void Spek(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();
            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("es-ES"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };
            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
