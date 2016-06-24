namespace GraphPrinter
{
    partial class PopUpExportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpExportation));
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxGraph = new System.Windows.Forms.CheckedListBox();
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez les courbes que vous voulez exporter :";
            // 
            // checkedListBoxGraph
            // 
            this.checkedListBoxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxGraph.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxGraph.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxGraph.FormattingEnabled = true;
            this.checkedListBoxGraph.Items.AddRange(new object[] {
            "Force(Position)",
            "Force(Vitesse)",
            "Force(Vitesse) Miroir"});
            this.checkedListBoxGraph.Location = new System.Drawing.Point(19, 33);
            this.checkedListBoxGraph.Name = "checkedListBoxGraph";
            this.checkedListBoxGraph.Size = new System.Drawing.Size(185, 73);
            this.checkedListBoxGraph.TabIndex = 1;
            // 
            // OkButton
            // 
            this.OkButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.OkButton.Image = ((System.Drawing.Image)(resources.GetObject("OkButton.Image")));
            this.OkButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.OkButton.Location = new System.Drawing.Point(264, 33);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(91, 73);
            this.OkButton.TabIndex = 2;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // PopUpExportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 110);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.checkedListBoxGraph);
            this.Controls.Add(this.label1);
            this.Name = "PopUpExportation";
            this.Text = "PopUpExportation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxGraph;
        private DevExpress.XtraEditors.SimpleButton OkButton;
    }
}