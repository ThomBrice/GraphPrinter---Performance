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

        private void SupprClientButton_Click(object sender, EventArgs e)
        {
            var result = MessageBoxCustom.Show("Etes-vous sûr de vouloir supprimer DEFINITIVEMENT ?", "MSG", "Annuler!", "Oui");
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

        private void AddGraphButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            int id = 0;
            foreach(int i in gridView1.GetSelectedRows())
            {
                DataRow dataRow = SqlHelper.DataSetEntete.Tables["Entête"].Rows[i];
                id = Int32.Parse(dataRow["ID"].ToString());
                SqlHelper.UpdateDataSetDonnee(id);

                DataTable data = SqlHelper.DataSetDonnee.Tables[id.ToString()];
                // create series
                Series serie1 = new Series(id.ToString(), ViewType.ScatterLine);
                Series serie2 = new Series(id.ToString(), ViewType.ScatterLine);
                forceVitesseChart.Series.Add(serie1);
                forceVitesseMChart.Series.Add(serie2);

                // datatables
                serie1.DataSource = Constructor.ForceVitesse(data);
                serie2.DataSource = Constructor.ForceVitesseMiroir(data);
                // specify data members to bind series
                serie1.ArgumentScaleType = ScaleType.Numerical;
                serie1.ArgumentDataMember = "vitesse";
                serie1.ValueScaleType = ScaleType.Numerical;
                serie1.ValueDataMembers.AddRange(new string[] { "force" });
                forceVitesseChart.Series[id.ToString()].LegendText = dataRow["Client"].ToString() + " "+ id;

                // Remplissage du graphique force(Vitesse) Miroir
                
                serie2.ArgumentScaleType = ScaleType.Numerical;
                serie2.ArgumentDataMember = "vitesse";
                serie2.ValueScaleType = ScaleType.Numerical;
                serie2.ValueDataMembers.AddRange(new string[] { "force" });
                forceVitesseMChart.Series[id.ToString()].LegendText = dataRow["Client"].ToString() + " " + id;

                //remplissage du SourceBox pour l'offset
                SourceBox.Items.Add(dataRow["ID"].ToString());
            }
            
            Constructor.SetLegend(forceVitesseChart,"Vitesse m/s", "Force");
            Constructor.SetLegend(forceVitesseMChart, "|Vitesse| m/s", "Force");

            Cursor.Current = Cursors.Default;

            MessageBox.Show("Les graphiques sont chargés", "Graphiques");

        }

        /// <summary>
        /// Ajoute un Offset aux courbes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Offset_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (e.KeyChar == (char)13)
            {
                if(SourceBox.SelectedItem != null)
                {
                    String ID = SourceBox.SelectedItem.ToString();
                    forceVitesseChart.Series[ID].DataSource = Constructor.Offset(SqlHelper.DataSetDonnee.Tables[ID],Int32.Parse(Offset.Text),"normal");
                    forceVitesseMChart.Series[ID].DataSource = Constructor.Offset(SqlHelper.DataSetDonnee.Tables[ID], Int32.Parse(Offset.Text),"miroir");
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forceVitesseChart.Series.Clear();
            forceVitesseMChart.Series.Clear();
            Cursor.Current = Cursors.Default;
        }
    }
}
