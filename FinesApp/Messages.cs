using System.Windows.Forms;

namespace FinesApp
{
    public static class Messages
    {
        public static void DisplayErrorMessage(string message) {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void DisplayInfoMessage(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult DisplayQuestionMessage(string message)
        {
            DialogResult dr = MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr;
        }
    }
}
