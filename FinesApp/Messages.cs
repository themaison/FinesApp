using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinesApp
{
    public class Messages
    {
        public void DisplayErrorMessage(string message) {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void DisplayInfoMessage(string message)
        {
            MessageBox.Show(message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
