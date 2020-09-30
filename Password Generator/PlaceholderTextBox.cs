using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeremieLauncher
{
    public class PlaceholderTextBox : TextBox
    {
        public string Placeholder;

        public PlaceholderTextBox() : base()
        {
            GotFocus += RemoveText;
            LostFocus += AddText;
        }

        void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
                Text = Placeholder;
        }

        void RemoveText(object sender, EventArgs e)
        {
            if (Text == Placeholder)
            {
                Text = "";
            }
        }
    }
}
