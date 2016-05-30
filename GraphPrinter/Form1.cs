using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraCharts;
using System.Drawing;

namespace GraphPrinter
{
    public partial class Form1 : XtraForm
    {
        #region variables
        SqlHelper SqlHelper = new SqlHelper();
        ChartConstructor Constructor = new ChartConstructor();
        #endregion


        public Form1()
        {
            InitializeComponent();
            acquisitionTab.Show();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = 0;
            foreach(int i in gridView1.GetSelectedRows())
            {
                DataRow dataRow = SqlHelper.DataSetEntete.Tables["Entête"].Rows[i];
                id = Int32.Parse(dataRow["ID"].ToString());
                SqlHelper.UpdateDataSetDonnee(id);

                DataTable data = SqlHelper.DataSetDonnee.Tables[id.ToString()];
                // create serie
                Series series = new Series(id.ToString(), ViewType.ScatterLine);
                chartControl1.Series.Add(series);
                // datatable
                series.DataSource = Constructor.ForceVitesse(data);
                // specify data members to bind series
                series.ArgumentScaleType = ScaleType.Numerical;
                series.ArgumentDataMember = "vitesse";
                series.ValueScaleType = ScaleType.Numerical;
                series.ValueDataMembers.AddRange(new string[] { "force" });
                chartControl1.Series[id.ToString()].LegendText = dataRow["Client"].ToString();
            }
            
            Constructor.SetLegend(chartControl1,"Vitesse m/s", "Force");

            MessageBox.Show("graphiques OK!", "MSG", "ok", "ok");

        }
    }
}
