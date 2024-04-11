namespace _7het
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ButtonOpen = new Button();
            ButtonSave = new Button();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            countryDataBindingSource1 = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ButtonOpen
            // 
            ButtonOpen.Location = new Point(713, 12);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(75, 23);
            ButtonOpen.TabIndex = 0;
            ButtonOpen.Text = "Megnyitás";
            ButtonOpen.UseVisualStyleBackColor = true;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(632, 12);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Mentés";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(37, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(377, 332);
            dataGridView1.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, populationDataGridViewTextBoxColumn1, areaInSquareKmDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = countryDataBindingSource1;
            dataGridView2.Location = new Point(434, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(354, 332);
            dataGridView2.TabIndex = 3;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // populationDataGridViewTextBoxColumn1
            // 
            populationDataGridViewTextBoxColumn1.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn1.HeaderText = "Population";
            populationDataGridViewTextBoxColumn1.Name = "populationDataGridViewTextBoxColumn1";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn1
            // 
            areaInSquareKmDataGridViewTextBoxColumn1.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn1.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn1.Name = "areaInSquareKmDataGridViewTextBoxColumn1";
            // 
            // countryDataBindingSource1
            // 
            countryDataBindingSource1.DataSource = typeof(CountryData);
            // 
            // button1
            // 
            button1.Location = new Point(37, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Szerkesztés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonOpen;
        private Button ButtonSave;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn1;
        private BindingSource countryDataBindingSource1;
        private Button button1;
    }
}