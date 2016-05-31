using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphPrinter
{
    public partial class MessageBoxCustom : Form
    {
        public MessageBoxCustom()
        {
            InitializeComponent();
        }

        static MessageBoxCustom MsgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string Caption, string btnAnnul, string btnSuppr)
        {
            MsgBox = new MessageBoxCustom();
            MsgBox.label1.Text = Text;
            MsgBox.simpleButton1.Text = btnAnnul;
            MsgBox.simpleButton2.Text = btnSuppr;
            MsgBox.ShowDialog();
            return result;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
            MsgBox.Close();
        }
    }
}
