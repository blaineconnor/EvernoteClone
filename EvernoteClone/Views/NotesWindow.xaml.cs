using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


namespace EvernoteClone.Views
{
    /// <summary>
    /// Interaction logic for NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : ThemedWindow
    {
        public NotesWindow()
        {
            InitializeComponent();
        }

        private void Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void contentRichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int ammountChars = (new TextRange(contentRichTextBox.Document.ContentStart, contentRichTextBox.Document.ContentEnd)).Text.Length;

            statusTextBlock.Text = $"Document length: {ammountChars} characters";
        }


        private void Bold_ItemClick(object sender, RoutedEventArgs e)
        {
            contentRichTextBox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
        }

        private async void SpeechButton_Click(object sender, RoutedEventArgs e)
        {
            string region = "uaenorth";
            string key = "b987649d4ff2448f9843c4f22eac4f9c";

            var speechConfig = SpeechConfig.FromSubscription(key, region);
            speechConfig.SpeechRecognitionLanguage = "tr-TR";

            using (var audioConfig = AudioConfig.FromDefaultMicrophoneInput())
            {
                using (var recognizer = new SpeechRecognizer(speechConfig, audioConfig))
                {
                    var result = await recognizer.RecognizeOnceAsync();

                    if (result.Reason == ResultReason.RecognizedSpeech)
                    {
                        contentRichTextBox.Document.Blocks.Add(new Paragraph(new Run(result.Text)));
                    }
                }
            }
        }

    }
}
