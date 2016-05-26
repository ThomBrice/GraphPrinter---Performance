using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;


namespace GraphPrinter
{
    public partial class Form1 : XtraForm
    {
        #region variables
        SqlHelper SqlHelper = new SqlHelper();
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // remplissage du DataSet
            SqlHelper.UpdateDataSetEntete();

            // remplissage du gridControl
            gridControl1.DataSource = SqlHelper.DataSetEntete.Tables["Entête"];
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Etes-vous sûr de vouloir supprimer DEFINITIVEMENT ?", "MSG", "Annuler!", "Oui");
            if (result == DialogResult.OK)
            {
                int[] index = gridView1.GetSelectedRows();
                for (int i = index.Length - 1; i >= 0; i--)
                {
                    gridView1.DeleteRow(index[i]);
                }
                SqlHelper.UpdateBDDEntete();
            }
        }
    }
}
