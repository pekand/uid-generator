using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UidApp
{
    public partial class UidForm : Form
    {
        public UidForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Guid.NewGuid().ToString("N").Substring(0, 10);
            Clipboard.SetText(textBox1.Text);
        }
    }
}
