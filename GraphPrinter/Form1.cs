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
            }

            // create serie
            Series series = new Series("Serie", ViewType.Point);
            chartControl1.Series.Add(series);

            // datatable
            series.DataSource = CreateChartData(SqlHelper.DataSetDonnee);

            // specify data members to bind series
            series.ArgumentScaleType = ScaleType.Numerical;
            series.ArgumentDataMember = "vitesse";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "force" });
            chartControl1.Series["Serie"].LegendText = "test";

            SetLegend();

            MessageBox.Show("graphiques OK!", "MSG", "ok", "ok");

        }

        private DataTable CreateChartData(DataSet dataset)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("vitesse", typeof(float));
            table.Columns.Add("force", typeof(float));

            // Add data rows to the table.
            Random rnd = new Random();
            DataRow row = null;
            foreach (DataRow data in dataset.Tables["61"].Rows)
            {
                row = table.NewRow();
                var i = float.Parse(data["vitesse"].ToString());
                row["vitesse"] = Math.Abs(i);
                row["force"] = data["force"];
                table.Rows.Add(row);
            }

            return table;
        }

        private void SetLegend()
        {
            Legend legend = chartControl1.Legend;

            // Display the chart control's legend
            legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Define its margins and alignment relative to the diagram
            legend.Margins.All = 8;
            legend.AlignmentHorizontal = LegendAlignmentHorizontal.LeftOutside;
            legend.AlignmentVertical = LegendAlignmentVertical.Top;

            // Define the layout of items within the legend.
            legend.Direction = LegendDirection.LeftToRight;
            legend.EquallySpacedItems = true;
            legend.HorizontalIndent = 8;
            legend.VerticalIndent = 8;
            legend.TextVisible = true;
            legend.TextOffset = 8;
            legend.MarkerVisible = true;
            legend.MarkerSize = new System.Drawing.Size(20, 20);
            legend.Padding.All = 4;

            // Define the limits for the legend to occupy the chart's space
            legend.BackColor = Color.Beige;
            legend.FillStyle.FillMode = FillMode.Gradient;
            ((RectangleGradientFillOptions)legend.FillStyle.Options).Color2 = Color.Bisque;

            legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            legend.Border.Color = Color.DarkBlue;
            legend.Border.Thickness = 2;

            legend.Shadow.Visible = true;
            legend.Shadow.Color = Color.LightGray;
            legend.Shadow.Size = 2;

            // Customise the legend text properties
            legend.Font = new Font("Arial", 10, FontStyle.Bold);
            legend.TextColor = Color.DarkBlue;
        }
    }
}
