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
    public partial class PopUpExportation : Form
    {
        public List<int> valeurs = new List<int> { };

        public PopUpExportation()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            foreach (int item in checkedListBoxGraph.CheckedIndices)
            {
                valeurs.Add(item);
            }

            this.DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
