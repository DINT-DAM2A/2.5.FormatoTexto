using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Marcamos opcion por defecto de RadioButtom
            ColorAzulRadioButton.IsChecked = true;
        }

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoSalidaTextBlock.Text = TextoEntradaTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.FontWeight = FontWeights.Bold;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.FontStyle = FontStyles.Italic;
        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.FontStyle = FontStyles.Normal;
        }

        private void ColorAzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.Foreground = new SolidColorBrush(Colors.Blue);
        }

        private void ColorRojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.Foreground = new SolidColorBrush(Colors.Red);
        }

        private void ColorVerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            TextoSalidaTextBlock.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}
