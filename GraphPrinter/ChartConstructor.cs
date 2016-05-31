using System;
using System.Data;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System.Drawing;

namespace GraphPrinter
{
    class ChartConstructor
    {
        /// <summary>
        /// creer les graphiques Froce/Vitesse
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public DataTable ForceVitesse(DataTable dataTable)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("vitesse", typeof(float));
            table.Columns.Add("force", typeof(float));

            // Add data rows to the table.
            DataRow row = null;

            foreach (DataRow data in dataTable.Rows)
            {
                row = table.NewRow();
                var i = float.Parse(data["vitesse"].ToString());
                row["vitesse"] = data["vitesse"];
                row["force"] = data["force"];
                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// creer les graphiques Froce/Vitesse(Miroir)
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public DataTable ForceVitesseMiroir(DataTable dataTable)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("vitesse", typeof(float));
            table.Columns.Add("force", typeof(float));

            // Add data rows to the table.
            DataRow row = null;

            foreach (DataRow data in dataTable.Rows)
            {
                row = table.NewRow();
                var i = float.Parse(data["vitesse"].ToString());
                row["vitesse"] = Math.Abs(float.Parse(data["vitesse"].ToString()));
                row["force"] = data["force"];
                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// ajoute une valeur d'offset à l'ordonnée
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public DataTable Offset(DataTable dataTable, int offset, string type)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add two columns to the table.
            table.Columns.Add("vitesse", typeof(float));
            table.Columns.Add("force", typeof(float));

            // Add data rows to the table.
            DataRow row = null;

            switch (type)
            {
                case "normal":
                    foreach (DataRow data in dataTable.Rows)
                    {
                        row = table.NewRow();
                        var i = float.Parse(data["vitesse"].ToString());
                        row["vitesse"] = data["vitesse"];
                        row["force"] = offset + float.Parse(data["force"].ToString());
                        table.Rows.Add(row);
                    }
                break;
                case "miroir":
                    foreach (DataRow data in dataTable.Rows)
                    {
                        row = table.NewRow();
                        var i = float.Parse(data["vitesse"].ToString());
                        row["vitesse"] = Math.Abs(float.Parse(data["vitesse"].ToString()));
                        row["force"] = offset + float.Parse(data["force"].ToString());
                        table.Rows.Add(row);
                    }
                    break;

            }
            return table;
        }

        /// <summary>
        /// paramétre la légende des graphiques
        /// </summary>
        /// <param name="chartControl1"></param>
        /// <param name="Xlabel"></param>
        /// <param name="Ylabel"></param>
        public void SetLegend(ChartControl chartControl1,String Xlabel, String Ylabel)
        {
            Legend legend = chartControl1.Legend;

            // Display the chart control's legend
            legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Define its margins and alignment relative to the diagram
            legend.Margins.All = 8;
            legend.AlignmentHorizontal = LegendAlignmentHorizontal.LeftOutside;
            legend.AlignmentVertical = LegendAlignmentVertical.Top;

            // Define the layout of items within the legend.
            legend.Direction = LegendDirection.TopToBottom;
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

            XYDiagram XYDiagram = chartControl1.Diagram as XYDiagram;
            XYDiagram.AxisX.Title.Text = Xlabel;
            XYDiagram.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;

            XYDiagram.AxisY.Title.Text = Ylabel;
            XYDiagram.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
        }
    }
}
