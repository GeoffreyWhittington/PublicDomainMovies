namespace RentalDBApp
{
    partial class MovieAccessForm
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
            this.movieAccessFormDataGridView = new System.Windows.Forms.DataGridView();
            this.movieratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieyearmadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamaDataSet1 = new RentalDBApp.teamaDataSet1();
            this.mOVIETableAdapter = new RentalDBApp.teamaDataSet1TableAdapters.MOVIETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieAccessFormDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // movieAccessFormDataGridView
            // 
            this.movieAccessFormDataGridView.AllowUserToOrderColumns = true;
            this.movieAccessFormDataGridView.AutoGenerateColumns = false;
            this.movieAccessFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieAccessFormDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieratingDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.movieyearmadeDataGridViewTextBoxColumn});
            this.movieAccessFormDataGridView.DataSource = this.mOVIEBindingSource;
            this.movieAccessFormDataGridView.Location = new System.Drawing.Point(101, 26);
            this.movieAccessFormDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.movieAccessFormDataGridView.Name = "movieAccessFormDataGridView";
            this.movieAccessFormDataGridView.Size = new System.Drawing.Size(597, 251);
            this.movieAccessFormDataGridView.TabIndex = 4;
            this.movieAccessFormDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieAccessFormDataGridView_CellContentClick);
            // 
            // movieratingDataGridViewTextBoxColumn
            // 
            this.movieratingDataGridViewTextBoxColumn.DataPropertyName = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.HeaderText = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.Name = "movieratingDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // movieyearmadeDataGridViewTextBoxColumn
            // 
            this.movieyearmadeDataGridViewTextBoxColumn.DataPropertyName = "movie_year_made";
            this.movieyearmadeDataGridViewTextBoxColumn.HeaderText = "movie_year_made";
            this.movieyearmadeDataGridViewTextBoxColumn.Name = "movieyearmadeDataGridViewTextBoxColumn";
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.teamaDataSet1;
            // 
            // teamaDataSet1
            // 
            this.teamaDataSet1.DataSetName = "teamaDataSet1";
            this.teamaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 126);
            this.button1.TabIndex = 5;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MovieAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 508);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.movieAccessFormDataGridView);
            this.Name = "MovieAccessForm";
            this.Text = "MovieAccessForm";
            this.Load += new System.EventHandler(this.MovieAccessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieAccessFormDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamaDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView movieAccessFormDataGridView;
        private teamaDataSet1 teamaDataSet1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private teamaDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieyearmadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}