namespace HospitalDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataSet1 = new HospitalDatabase.DataSet1();
            this.worker1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worker1TableAdapter = new HospitalDatabase.DataSet1TableAdapters.Worker1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-1, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(-1, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FloralWhite;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Century Gothic", 26.2F, System.Drawing.FontStyle.Bold);
            this.tbLogin.Location = new System.Drawing.Point(139, 134);
            this.tbLogin.Multiline = true;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(649, 41);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPas
            // 
            this.tbPas.BackColor = System.Drawing.Color.FloralWhite;
            this.tbPas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPas.Font = new System.Drawing.Font("Century Gothic", 26.2F, System.Drawing.FontStyle.Bold);
            this.tbPas.Location = new System.Drawing.Point(139, 191);
            this.tbPas.Multiline = true;
            this.tbPas.Name = "tbPas";
            this.tbPas.Size = new System.Drawing.Size(649, 41);
            this.tbPas.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.FlatAppearance.BorderSize = 2;
            this.btnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.DimGray;
            this.btnEnter.Location = new System.Drawing.Point(6, 276);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(782, 56);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(6, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(782, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.LemonChiffon;
            this.checkBox1.FlatAppearance.BorderSize = 2;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(587, 243);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 27);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // worker1BindingSource
            // 
            this.worker1BindingSource.DataMember = "Worker1";
            this.worker1BindingSource.DataSource = this.dataSet1;
            // 
            // worker1TableAdapter
            // 
            this.worker1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbPas);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Больница \"Груша\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worker1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource worker1BindingSource;
        private DataSet1TableAdapters.Worker1TableAdapter worker1TableAdapter;
    }
}

