﻿using System;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraCharts;
using System.Drawing;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using System.IO;

namespace GraphPrinter
{
    public partial class PagePrincipale : XtraForm
    {
        #region variables
        SqlHelper SqlHelper = new SqlHelper();
        ChartConstructor Constructor = new ChartConstructor();
        #endregion

        public PagePrincipale()
        {
            InitializeComponent();
            acquisitionTab.Show();
            MiroirTab.Show();
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
                Series serie3 = new Series(id.ToString(), ViewType.ScatterLine);
                forceVitesseChart.Series.Add(serie1);
                forceVitesseMChart.Series.Add(serie2);
                forcePositionChart.Series.Add(serie3);

                // datatables
                serie1.DataSource = Constructor.ForceVitesse(data);
                serie2.DataSource = Constructor.ForceVitesseMiroir(data);
                serie3.DataSource = Constructor.ForcePosition(data);

                // Remplissage du graphique force(vitesse) Normal
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

                // Remplissage du graphique force(position)
                serie3.ArgumentScaleType = ScaleType.Numerical;
                serie3.ArgumentDataMember = "position";
                serie3.ValueScaleType = ScaleType.Numerical;
                serie3.ValueDataMembers.AddRange(new string[] { "force" });
                forcePositionChart.Series[id.ToString()].LegendText = dataRow["Client"].ToString() + " " + id;

                //remplissage du SourceBox pour l'offset
                SourceBox.Items.Add(dataRow["ID"].ToString());
            }
            
            Constructor.SetLegend(forceVitesseChart,"Vitesse (m/s)", "Force (N)");
            Constructor.SetLegend(forceVitesseMChart, "|Vitesse| (m/s)", "Force (N)");
            Constructor.SetLegend(forcePositionChart, "Déplacement (mm) ", "Force(N)");

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
                    forcePositionChart.Series[ID].DataSource = Constructor.Offset(SqlHelper.DataSetDonnee.Tables[ID], Int32.Parse(Offset.Text), "patate");
                }
            }
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Suppression des courbes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearGraphButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            forceVitesseChart.Series.Clear();
            forceVitesseMChart.Series.Clear();
            forcePositionChart.Series.Clear();
            SourceBox.Items.Clear();
            Cursor.Current = Cursors.Default;
        }

        private void BigGridButton_Click(object sender, EventArgs e)
        {
            Constructor.SetBigGrid(forceVitesseChart);
            Constructor.SetBigGrid(forceVitesseMChart);
            Constructor.SetBigGrid(forcePositionChart);
        }

        private void CompleteGridButton_Click(object sender, EventArgs e)
        {
            Constructor.SetGridComplete(forceVitesseChart);
            Constructor.SetGridComplete(forceVitesseMChart);
            Constructor.SetGridComplete(forcePositionChart);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            // Obtain the current export options.
            PdfExportOptions options = new PdfExportOptions();
            // Set Print Preview options.
            options.Compressed = false;
            options.ImageQuality = PdfJpegImageQuality.Highest;
            options.PdfACompatible = true;

            forceVitesseChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;
            forceVitesseMChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;
            forcePositionChart.OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;

            PrintableComponentLink link1 = new PrintableComponentLink();
            PrintableComponentLink link2 = new PrintableComponentLink();
            PrintableComponentLink link3 = new PrintableComponentLink();
            var composentlink = new DevExpress.XtraPrintingLinks.CompositeLink(new PrintingSystem());
            link1.Component = forcePositionChart;
            link2.Component = forceVitesseChart;
            link3.Component = forceVitesseMChart;
            composentlink.Links.Add(link1);
            composentlink.Links.Add(link2);
            composentlink.Links.Add(link3);
            composentlink.Landscape = true;

            //page permettant de choisir l'emplacement et le nom du fichier pour l'enregistrement
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                composentlink.ExportToPdf(saveFileDialog1.FileName + ".pdf", options);
                MessageBox.Show("Exportation réussie", "PDF");
            }

            Cursor.Current = Cursors.Default;
        }

    }
}
