namespace Fasr_n_Furious
{
    partial class LeaderForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.CarsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.carsDataSet = new Fasr_n_Furious.CarsDataSet();
            this.carsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.show_players_top_scoresTableAdapter = new Fasr_n_Furious.CarsDataSetTableAdapters.show_players_top_scoresTableAdapter();
            this.show_players_top_scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_players_top_scoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.Location = new System.Drawing.Point(107, 402);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(129, 22);
            this.HomeLabel.TabIndex = 16;
            this.HomeLabel.Text = "Back to Home";
            this.HomeLabel.Click += new System.EventHandler(this.HomeLabel_Click);
            // 
            // CarsReportViewer
            // 
            this.CarsReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CarsReportViewer.DocumentMapWidth = 33;
            reportDataSource1.Name = "TopScores";
            reportDataSource1.Value = this.show_players_top_scoresBindingSource;
            this.CarsReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.CarsReportViewer.LocalReport.ReportEmbeddedResource = "Fasr_n_Furious.LeaderFormReport.rdlc";
            this.CarsReportViewer.Location = new System.Drawing.Point(42, 1);
            this.CarsReportViewer.Name = "CarsReportViewer";
            this.CarsReportViewer.ServerReport.BearerToken = null;
            this.CarsReportViewer.Size = new System.Drawing.Size(254, 377);
            this.CarsReportViewer.TabIndex = 17;
            // 
            // carsDataSet
            // 
            this.carsDataSet.DataSetName = "CarsDataSet";
            this.carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsDataSetBindingSource
            // 
            this.carsDataSetBindingSource.DataSource = this.carsDataSet;
            this.carsDataSetBindingSource.Position = 0;
            // 
            // show_players_top_scoresTableAdapter
            // 
            this.show_players_top_scoresTableAdapter.ClearBeforeFill = true;
            // 
            // show_players_top_scoresBindingSource
            // 
            this.show_players_top_scoresBindingSource.DataMember = "show_players_top_scores";
            this.show_players_top_scoresBindingSource.DataSource = this.carsDataSet;
            // 
            // LeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 443);
            this.Controls.Add(this.CarsReportViewer);
            this.Controls.Add(this.HomeLabel);
            this.Name = "LeaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LeaderForm_FormClosing);
            this.Load += new System.EventHandler(this.LeaderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.show_players_top_scoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeLabel;
        private Microsoft.Reporting.WinForms.ReportViewer CarsReportViewer;
        private System.Windows.Forms.BindingSource carsDataSetBindingSource;
        private CarsDataSet carsDataSet;
        private CarsDataSetTableAdapters.show_players_top_scoresTableAdapter show_players_top_scoresTableAdapter;
        private System.Windows.Forms.BindingSource show_players_top_scoresBindingSource;
    }
}