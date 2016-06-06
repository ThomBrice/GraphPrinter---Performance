namespace GraphPrinter
{
    partial class PagePrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePrincipale));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.graphiqueTab = new DevExpress.XtraTab.XtraTabPage();
            this.ExportButton = new DevExpress.XtraEditors.SimpleButton();
            this.CompleteGridButton = new DevExpress.XtraEditors.SimpleButton();
            this.BigGridButton = new DevExpress.XtraEditors.SimpleButton();
            this.ClearGraphButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.NormalTab = new DevExpress.XtraTab.XtraTabPage();
            this.forceVitesseChart = new DevExpress.XtraCharts.ChartControl();
            this.MiroirTab = new DevExpress.XtraTab.XtraTabPage();
            this.forceVitesseMChart = new DevExpress.XtraCharts.ChartControl();
            this.ForcePositionTab = new DevExpress.XtraTab.XtraTabPage();
            this.forcePositionChart = new DevExpress.XtraCharts.ChartControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceBox = new System.Windows.Forms.ComboBox();
            this.Offset = new DevExpress.XtraEditors.TextEdit();
            this.acquisitionTab = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AddGraphButton = new DevExpress.XtraEditors.SimpleButton();
            this.SupprClientButton = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.graphiqueTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.NormalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forceVitesseChart)).BeginInit();
            this.MiroirTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forceVitesseMChart)).BeginInit();
            this.ForcePositionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forcePositionChart)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Offset.Properties)).BeginInit();
            this.acquisitionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // graphiqueTab
            // 
            this.graphiqueTab.Controls.Add(this.ExportButton);
            this.graphiqueTab.Controls.Add(this.CompleteGridButton);
            this.graphiqueTab.Controls.Add(this.BigGridButton);
            this.graphiqueTab.Controls.Add(this.ClearGraphButton);
            this.graphiqueTab.Controls.Add(this.xtraTabControl2);
            this.graphiqueTab.Controls.Add(this.flowLayoutPanel1);
            this.graphiqueTab.Image = ((System.Drawing.Image)(resources.GetObject("graphiqueTab.Image")));
            this.graphiqueTab.Name = "graphiqueTab";
            this.graphiqueTab.Size = new System.Drawing.Size(1736, 658);
            this.graphiqueTab.Text = "Graphiques";
            // 
            // ExportButton
            // 
            this.ExportButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ExportButton.Location = new System.Drawing.Point(536, 0);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(40, 40);
            this.ExportButton.TabIndex = 7;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // CompleteGridButton
            // 
            this.CompleteGridButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.CompleteGridButton.Image = ((System.Drawing.Image)(resources.GetObject("CompleteGridButton.Image")));
            this.CompleteGridButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.CompleteGridButton.Location = new System.Drawing.Point(470, 0);
            this.CompleteGridButton.Name = "CompleteGridButton";
            this.CompleteGridButton.Size = new System.Drawing.Size(40, 40);
            this.CompleteGridButton.TabIndex = 6;
            this.CompleteGridButton.Click += new System.EventHandler(this.CompleteGridButton_Click);
            // 
            // BigGridButton
            // 
            this.BigGridButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.BigGridButton.Image = ((System.Drawing.Image)(resources.GetObject("BigGridButton.Image")));
            this.BigGridButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.BigGridButton.Location = new System.Drawing.Point(413, 0);
            this.BigGridButton.Name = "BigGridButton";
            this.BigGridButton.Size = new System.Drawing.Size(40, 40);
            this.BigGridButton.TabIndex = 5;
            this.BigGridButton.Click += new System.EventHandler(this.BigGridButton_Click);
            // 
            // ClearGraphButton
            // 
            this.ClearGraphButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ClearGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearGraphButton.Image")));
            this.ClearGraphButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.ClearGraphButton.Location = new System.Drawing.Point(209, 3);
            this.ClearGraphButton.Name = "ClearGraphButton";
            this.ClearGraphButton.Size = new System.Drawing.Size(198, 38);
            this.ClearGraphButton.TabIndex = 3;
            this.ClearGraphButton.Text = "Nettoyer les graphiques";
            this.ClearGraphButton.Click += new System.EventHandler(this.ClearGraphButton_Click);
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton()});
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 43);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.NormalTab;
            this.xtraTabControl2.Size = new System.Drawing.Size(1738, 620);
            this.xtraTabControl2.TabIndex = 2;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.MiroirTab,
            this.NormalTab,
            this.ForcePositionTab});
            // 
            // NormalTab
            // 
            this.NormalTab.Controls.Add(this.forceVitesseChart);
            this.NormalTab.Image = ((System.Drawing.Image)(resources.GetObject("NormalTab.Image")));
            this.NormalTab.Name = "NormalTab";
            this.NormalTab.Size = new System.Drawing.Size(1732, 573);
            this.NormalTab.Text = "Force(Vitesse)";
            // 
            // forceVitesseChart
            // 
            this.forceVitesseChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forceVitesseChart.Legend.UseCheckBoxes = true;
            this.forceVitesseChart.Location = new System.Drawing.Point(0, 0);
            this.forceVitesseChart.Name = "forceVitesseChart";
            this.forceVitesseChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.forceVitesseChart.Size = new System.Drawing.Size(1732, 573);
            this.forceVitesseChart.TabIndex = 0;
            // 
            // MiroirTab
            // 
            this.MiroirTab.Controls.Add(this.forceVitesseMChart);
            this.MiroirTab.Image = ((System.Drawing.Image)(resources.GetObject("MiroirTab.Image")));
            this.MiroirTab.Name = "MiroirTab";
            this.MiroirTab.Size = new System.Drawing.Size(1732, 573);
            this.MiroirTab.Text = "Force(Vitesse) Miroir";
            // 
            // forceVitesseMChart
            // 
            this.forceVitesseMChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forceVitesseMChart.Legend.UseCheckBoxes = true;
            this.forceVitesseMChart.Location = new System.Drawing.Point(0, 0);
            this.forceVitesseMChart.Name = "forceVitesseMChart";
            this.forceVitesseMChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.forceVitesseMChart.Size = new System.Drawing.Size(1732, 573);
            this.forceVitesseMChart.TabIndex = 0;
            // 
            // ForcePositionTab
            // 
            this.ForcePositionTab.Controls.Add(this.forcePositionChart);
            this.ForcePositionTab.Image = ((System.Drawing.Image)(resources.GetObject("ForcePositionTab.Image")));
            this.ForcePositionTab.Name = "ForcePositionTab";
            this.ForcePositionTab.Size = new System.Drawing.Size(1732, 573);
            this.ForcePositionTab.Text = "Force(Position)";
            // 
            // forcePositionChart
            // 
            this.forcePositionChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forcePositionChart.Legend.UseCheckBoxes = true;
            this.forcePositionChart.Location = new System.Drawing.Point(0, 0);
            this.forcePositionChart.Name = "forcePositionChart";
            this.forcePositionChart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.forcePositionChart.Size = new System.Drawing.Size(1732, 573);
            this.forcePositionChart.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.SourceBox);
            this.flowLayoutPanel1.Controls.Add(this.Offset);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Offset :";
            // 
            // SourceBox
            // 
            this.SourceBox.FormattingEnabled = true;
            this.SourceBox.Location = new System.Drawing.Point(68, 3);
            this.SourceBox.Name = "SourceBox";
            this.SourceBox.Size = new System.Drawing.Size(61, 24);
            this.SourceBox.TabIndex = 1;
            // 
            // Offset
            // 
            this.Offset.Location = new System.Drawing.Point(135, 3);
            this.Offset.Name = "Offset";
            this.Offset.Properties.Mask.BeepOnError = true;
            this.Offset.Properties.Mask.EditMask = "d";
            this.Offset.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.Offset.Size = new System.Drawing.Size(62, 22);
            this.Offset.TabIndex = 2;
            this.Offset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Offset_KeyPress);
            // 
            // acquisitionTab
            // 
            this.acquisitionTab.Controls.Add(this.gridControl1);
            this.acquisitionTab.Controls.Add(this.AddGraphButton);
            this.acquisitionTab.Controls.Add(this.SupprClientButton);
            this.acquisitionTab.Image = ((System.Drawing.Image)(resources.GetObject("acquisitionTab.Image")));
            this.acquisitionTab.Name = "acquisitionTab";
            this.acquisitionTab.Size = new System.Drawing.Size(1736, 658);
            this.acquisitionTab.Text = "Acquisitions";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1742, 527);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            // 
            // AddGraphButton
            // 
            this.AddGraphButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.AddGraphButton.Image = ((System.Drawing.Image)(resources.GetObject("AddGraphButton.Image")));
            this.AddGraphButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.AddGraphButton.Location = new System.Drawing.Point(139, -1);
            this.AddGraphButton.Name = "AddGraphButton";
            this.AddGraphButton.Size = new System.Drawing.Size(151, 58);
            this.AddGraphButton.TabIndex = 2;
            this.AddGraphButton.Text = "Ajouter au\r\nGraphique";
            this.AddGraphButton.Click += new System.EventHandler(this.AddGraphButton_Click);
            // 
            // SupprClientButton
            // 
            this.SupprClientButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.SupprClientButton.Image = ((System.Drawing.Image)(resources.GetObject("SupprClientButton.Image")));
            this.SupprClientButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.SupprClientButton.Location = new System.Drawing.Point(0, 0);
            this.SupprClientButton.Name = "SupprClientButton";
            this.SupprClientButton.Size = new System.Drawing.Size(119, 58);
            this.SupprClientButton.TabIndex = 1;
            this.SupprClientButton.Text = " Supprimer\r\nAcquisition";
            this.SupprClientButton.Click += new System.EventHandler(this.SupprClientButton_Click);
            // 
            // xtraTabControl1
            // 
            serializableAppearanceObject1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            serializableAppearanceObject1.Image = ((System.Drawing.Image)(resources.GetObject("serializableAppearanceObject1.Image")));
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseImage = true;
            this.xtraTabControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, serializableAppearanceObject1, "", null, null, true)});
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Vertical;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.LookAndFeel.SkinName = "Seven Classic";
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.acquisitionTab;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(1783, 664);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.acquisitionTab,
            this.graphiqueTab});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1783, 664);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Performance Graphiques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.graphiqueTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.NormalTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forceVitesseChart)).EndInit();
            this.MiroirTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forceVitesseMChart)).EndInit();
            this.ForcePositionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forcePositionChart)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Offset.Properties)).EndInit();
            this.acquisitionTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTab.XtraTabPage graphiqueTab;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage NormalTab;
        private DevExpress.XtraCharts.ChartControl forceVitesseChart;
        private DevExpress.XtraTab.XtraTabPage MiroirTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SourceBox;
        private DevExpress.XtraEditors.TextEdit Offset;
        private DevExpress.XtraTab.XtraTabPage acquisitionTab;
        private DevExpress.XtraGrid.GridControl gridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton AddGraphButton;
        private DevExpress.XtraEditors.SimpleButton SupprClientButton;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraCharts.ChartControl forceVitesseMChart;
        private DevExpress.XtraEditors.SimpleButton ClearGraphButton;
        private DevExpress.XtraTab.XtraTabPage ForcePositionTab;
        private DevExpress.XtraCharts.ChartControl forcePositionChart;
        private DevExpress.XtraEditors.SimpleButton CompleteGridButton;
        private DevExpress.XtraEditors.SimpleButton BigGridButton;
        private DevExpress.XtraEditors.SimpleButton ExportButton;
    }
}