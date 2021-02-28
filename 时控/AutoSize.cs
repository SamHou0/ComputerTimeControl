using System.Windows.Forms;

namespace TimeControl
{
    class AutoSize
    {
        public static void ProgressBarAutoSize(Form form, ProgressBar progressBar,int bottom)
        {
            progressBar.Width = form.Width - 300;
            progressBar.Left = form.Width / 2 - progressBar.Width / 2;
            progressBar.Top = form.Height - bottom;
        }
        public static void LabelAutoSize(Form form, Label label,int bottom)
        {
            label.Left = form.Width / 2 - label.Width / 2;
            label.Top = form.Height - bottom;
        }
    }
}
