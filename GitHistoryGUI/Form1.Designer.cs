namespace GitHistoryGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsersCsv = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPaths = new System.Windows.Forms.ComboBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.listPaths = new System.Windows.Forms.ListBox();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(52, 15);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(105, 20);
            this.dtPicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Users (CSV):";
            // 
            // txtUsersCsv
            // 
            this.txtUsersCsv.Location = new System.Drawing.Point(382, 18);
            this.txtUsersCsv.Name = "txtUsersCsv";
            this.txtUsersCsv.Size = new System.Drawing.Size(190, 20);
            this.txtUsersCsv.TabIndex = 1;
            this.txtUsersCsv.TextChanged += new System.EventHandler(this.txtUsersCsv_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 163);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(789, 416);
            this.txtResult.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "History Result:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(726, 16);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Working Directory:";
            // 
            // comboPaths
            // 
            this.comboPaths.FormattingEnabled = true;
            this.comboPaths.Location = new System.Drawing.Point(113, 45);
            this.comboPaths.Name = "comboPaths";
            this.comboPaths.Size = new System.Drawing.Size(88, 21);
            this.comboPaths.TabIndex = 8;
            // 
            // btnToday
            // 
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.Location = new System.Drawing.Point(163, 13);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(38, 23);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // listPaths
            // 
            this.listPaths.FormattingEnabled = true;
            this.listPaths.Location = new System.Drawing.Point(16, 72);
            this.listPaths.Name = "listPaths";
            this.listPaths.Size = new System.Drawing.Size(556, 69);
            this.listPaths.TabIndex = 10;
            this.listPaths.SelectedIndexChanged += new System.EventHandler(this.listPaths_SelectedIndexChanged);
            // 
            // btnYesterday
            // 
            this.btnYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesterday.Location = new System.Drawing.Point(207, 13);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(60, 23);
            this.btnYesterday.TabIndex = 11;
            this.btnYesterday.Text = "yesterday";
            this.btnYesterday.UseVisualStyleBackColor = true;
            this.btnYesterday.Click += new System.EventHandler(this.btnYesterday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 591);
            this.Controls.Add(this.btnYesterday);
            this.Controls.Add(this.listPaths);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.comboPaths);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtUsersCsv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPicker);
            this.Name = "Form1";
            this.Text = "Git History GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsersCsv;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPaths;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.ListBox listPaths;
        private System.Windows.Forms.Button btnYesterday;
    }
}

