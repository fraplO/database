namespace HospitalDatabase
{
    partial class form2
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
            this.userName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ApGrid2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.patients2Grid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.workerGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.worker1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTable = new HospitalDatabase.WorkerTable();
            this.worker1TableAdapter = new HospitalDatabase.WorkerTableTableAdapters.Worker1TableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApGrid2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patients2Grid)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.worker1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.userName.Location = new System.Drawing.Point(12, 5);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 25);
            this.userName.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.ApGrid2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1228, 470);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ApGrid2
            // 
            this.ApGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApGrid2.Location = new System.Drawing.Point(0, 0);
            this.ApGrid2.Name = "ApGrid2";
            this.ApGrid2.Size = new System.Drawing.Size(1222, 296);
            this.ApGrid2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.patients2Grid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1228, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(0, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1228, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(0, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1228, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Удалить прием";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(0, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1228, 51);
            this.button3.TabIndex = 9;
            this.button3.Text = "Назначить прием";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // patients2Grid
            // 
            this.patients2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patients2Grid.Location = new System.Drawing.Point(0, 3);
            this.patients2Grid.Name = "patients2Grid";
            this.patients2Grid.Size = new System.Drawing.Size(1232, 292);
            this.patients2Grid.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnDeleteWorker);
            this.tabPage1.Controls.Add(this.btnAddWorker);
            this.tabPage1.Controls.Add(this.workerGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1228, 470);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.Location = new System.Drawing.Point(3, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(1222, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.FlatAppearance.BorderSize = 2;
            this.btnDeleteWorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnDeleteWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDeleteWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteWorker.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.btnDeleteWorker.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteWorker.Location = new System.Drawing.Point(3, 360);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(1222, 51);
            this.btnDeleteWorker.TabIndex = 7;
            this.btnDeleteWorker.Text = "Удалить сотрудника";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.FlatAppearance.BorderSize = 2;
            this.btnAddWorker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnAddWorker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorker.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.btnAddWorker.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddWorker.Location = new System.Drawing.Point(3, 303);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(1222, 51);
            this.btnAddWorker.TabIndex = 6;
            this.btnAddWorker.Text = "Добавить сотрудника";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // workerGrid
            // 
            this.workerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerGrid.Location = new System.Drawing.Point(3, 6);
            this.workerGrid.Name = "workerGrid";
            this.workerGrid.Size = new System.Drawing.Size(1225, 291);
            this.workerGrid.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1236, 496);
            this.tabControl1.TabIndex = 3;
            // 
            // worker1BindingSource
            // 
            this.worker1BindingSource.DataMember = "Worker1";
            this.worker1BindingSource.DataSource = this.workerTable;
            // 
            // workerTable
            // 
            this.workerTable.DataSetName = "WorkerTable";
            this.workerTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker1TableAdapter
            // 
            this.worker1TableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.DimGray;
            this.button4.Location = new System.Drawing.Point(3, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1219, 51);
            this.button4.TabIndex = 11;
            this.button4.Text = "Сохранить изменения";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(3, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1219, 51);
            this.button5.TabIndex = 10;
            this.button5.Text = "Удалить сотрудника";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.DimGray;
            this.button6.Location = new System.Drawing.Point(3, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1219, 51);
            this.button6.TabIndex = 9;
            this.button6.Text = "Добавить сотрудника";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.userName);
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApGrid2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patients2Grid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.worker1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userName;
        private WorkerTable workerTable;
        private System.Windows.Forms.BindingSource worker1BindingSource;
        private WorkerTableTableAdapters.Worker1TableAdapter worker1TableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ApGrid2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView patients2Grid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView workerGrid;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}