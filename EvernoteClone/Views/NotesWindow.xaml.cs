using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using System.Windows;


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

        private void SpeechButton_Click(object sender, ItemClickEventArgs e)
        {

        }
    }
}
