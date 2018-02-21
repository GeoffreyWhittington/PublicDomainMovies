namespace RentalDBApp
{
    partial class MainMenuForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.mainMenuDataGridView = new System.Windows.Forms.DataGridView();
            this.movietitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieyearmadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teamaDataSet1 = new RentalDBApp.teamaDataSet1();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter = new RentalDBApp.teamaDataSet1TableAdapters.MOVIETableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Image = global::RentalDBApp.Properties.Resources.clapboard__1_;
            this.loginButton.Location = new System.Drawing.Point(827, 113);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(176, 158);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "   Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Image = global::RentalDBApp.Properties.Resources.greenlight__1_;
            this.signUpButton.Location = new System.Drawing.Point(78, 113);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(176, 158);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // mainMenuDataGridView
            // 
            this.mainMenuDataGridView.AllowUserToOrderColumns = true;
            this.mainMenuDataGridView.AutoGenerateColumns = false;
            this.mainMenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainMenuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movietitleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.movieyearmadeDataGridViewTextBoxColumn,
            this.movieratingDataGridViewTextBoxColumn});
            this.mainMenuDataGridView.DataSource = this.mOVIEBindingSource1;
            this.mainMenuDataGridView.Location = new System.Drawing.Point(311, 56);
            this.mainMenuDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.mainMenuDataGridView.Name = "mainMenuDataGridView";
            this.mainMenuDataGridView.ReadOnly = true;
            this.mainMenuDataGridView.Size = new System.Drawing.Size(460, 247);
            this.mainMenuDataGridView.TabIndex = 3;
            this.mainMenuDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainMenuDataGridView_CellContentClick);
            // 
            // movietitleDataGridViewTextBoxColumn
            // 
            this.movietitleDataGridViewTextBoxColumn.DataPropertyName = "movie_title";
            this.movietitleDataGridViewTextBoxColumn.HeaderText = "movie_title";
            this.movietitleDataGridViewTextBoxColumn.Name = "movietitleDataGridViewTextBoxColumn";
            this.movietitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieyearmadeDataGridViewTextBoxColumn
            // 
            this.movieyearmadeDataGridViewTextBoxColumn.DataPropertyName = "movie_year_made";
            this.movieyearmadeDataGridViewTextBoxColumn.HeaderText = "movie_year_made";
            this.movieyearmadeDataGridViewTextBoxColumn.Name = "movieyearmadeDataGridViewTextBoxColumn";
            this.movieyearmadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieratingDataGridViewTextBoxColumn
            // 
            this.movieratingDataGridViewTextBoxColumn.DataPropertyName = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.HeaderText = "movie_rating";
            this.movieratingDataGridViewTextBoxColumn.Name = "movieratingDataGridViewTextBoxColumn";
            this.movieratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mOVIEBindingSource1
            // 
            this.mOVIEBindingSource1.DataMember = "MOVIE";
            this.mOVIEBindingSource1.DataSource = this.teamaDataSet1;
            // 
            // teamaDataSet1
            // 
            this.teamaDataSet1.DataSetName = "teamaDataSet1";
            this.teamaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.teamaDataSet1;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 405);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainMenuDataGridView);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.signUpButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "PUBLIC DOMAIN MOVIES";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.DataGridView mainMenuDataGridView;
        private teamaDataSet1 teamaDataSet1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private teamaDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movietitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieyearmadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mOVIEBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}

