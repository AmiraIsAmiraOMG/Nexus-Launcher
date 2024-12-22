using System.Windows.Forms;

namespace Nexus_Launcher.Screens
{
    public partial class LoadingPage : UserControl
    {
        public LoadingPage()
        {
            InitializeComponent();

            // Optional: Add a progress bar or other loading indicators.
        }

        // Update progress method that will be called from the main window
        public void UpdateProgress(int progress)
        {
            // Update the progress bar (assuming you have one) or label
            // For simplicity, updating the label with progress value.
            Label lblLoading = (Label)this.Controls[0]; // Assuming the label is the first control
            lblLoading.Text = $"Loading... {progress}%";

            // If you have a progress bar, you can update it here instead:
            // progressBar.Value = progress;
        }

        private void cuiSpinner1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
