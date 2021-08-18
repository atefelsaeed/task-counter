namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addTask = new System.Windows.Forms.Button();
            this.deleteTask = new System.Windows.Forms.Button();
            this.numberTask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearTask = new System.Windows.Forms.Button();
            this.taskLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearHoure = new System.Windows.Forms.Button();
            this.houres = new System.Windows.Forms.Label();
            this.deleteHoure = new System.Windows.Forms.Button();
            this.addHoure = new System.Windows.Forms.Button();
            this.houreLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.calcLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.addTask.FlatAppearance.BorderSize = 0;
            this.addTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTask.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.addTask.ForeColor = System.Drawing.Color.White;
            this.addTask.Location = new System.Drawing.Point(28, 82);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(40, 40);
            this.addTask.TabIndex = 0;
            this.addTask.Text = "+";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // deleteTask
            // 
            this.deleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.deleteTask.FlatAppearance.BorderSize = 0;
            this.deleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTask.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.deleteTask.ForeColor = System.Drawing.Color.White;
            this.deleteTask.Location = new System.Drawing.Point(104, 82);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(40, 40);
            this.deleteTask.TabIndex = 1;
            this.deleteTask.Text = "-";
            this.deleteTask.UseVisualStyleBackColor = false;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // numberTask
            // 
            this.numberTask.AutoSize = true;
            this.numberTask.BackColor = System.Drawing.Color.NavajoWhite;
            this.numberTask.Font = new System.Drawing.Font("Tahoma", 16F);
            this.numberTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numberTask.Location = new System.Drawing.Point(72, 35);
            this.numberTask.Name = "numberTask";
            this.numberTask.Size = new System.Drawing.Size(24, 27);
            this.numberTask.TabIndex = 2;
            this.numberTask.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.clearTask);
            this.panel1.Controls.Add(this.numberTask);
            this.panel1.Controls.Add(this.deleteTask);
            this.panel1.Controls.Add(this.addTask);
            this.panel1.Location = new System.Drawing.Point(52, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 210);
            this.panel1.TabIndex = 3;
            // 
            // clearTask
            // 
            this.clearTask.BackColor = System.Drawing.Color.Firebrick;
            this.clearTask.FlatAppearance.BorderSize = 0;
            this.clearTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTask.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearTask.ForeColor = System.Drawing.Color.White;
            this.clearTask.Location = new System.Drawing.Point(46, 149);
            this.clearTask.Name = "clearTask";
            this.clearTask.Size = new System.Drawing.Size(70, 30);
            this.clearTask.TabIndex = 3;
            this.clearTask.Text = "Clear";
            this.clearTask.UseVisualStyleBackColor = false;
            this.clearTask.Click += new System.EventHandler(this.clearTask_Click);
            // 
            // taskLable
            // 
            this.taskLable.AutoSize = true;
            this.taskLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskLable.Font = new System.Drawing.Font("Tahoma", 16F);
            this.taskLable.ForeColor = System.Drawing.Color.White;
            this.taskLable.Location = new System.Drawing.Point(99, 107);
            this.taskLable.Name = "taskLable";
            this.taskLable.Size = new System.Drawing.Size(70, 29);
            this.taskLable.TabIndex = 4;
            this.taskLable.Text = "Tasks";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.clearHoure);
            this.panel2.Controls.Add(this.houres);
            this.panel2.Controls.Add(this.deleteHoure);
            this.panel2.Controls.Add(this.addHoure);
            this.panel2.Location = new System.Drawing.Point(344, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 210);
            this.panel2.TabIndex = 4;
            // 
            // clearHoure
            // 
            this.clearHoure.BackColor = System.Drawing.Color.Firebrick;
            this.clearHoure.FlatAppearance.BorderSize = 0;
            this.clearHoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearHoure.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.clearHoure.ForeColor = System.Drawing.Color.White;
            this.clearHoure.Location = new System.Drawing.Point(51, 149);
            this.clearHoure.Name = "clearHoure";
            this.clearHoure.Size = new System.Drawing.Size(70, 30);
            this.clearHoure.TabIndex = 3;
            this.clearHoure.Text = "Clear";
            this.clearHoure.UseVisualStyleBackColor = false;
            this.clearHoure.Click += new System.EventHandler(this.clearHoure_Click);
            // 
            // houres
            // 
            this.houres.AutoSize = true;
            this.houres.Font = new System.Drawing.Font("Tahoma", 16F);
            this.houres.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.houres.Location = new System.Drawing.Point(72, 35);
            this.houres.Name = "houres";
            this.houres.Size = new System.Drawing.Size(24, 27);
            this.houres.TabIndex = 2;
            this.houres.Text = "0";
            this.houres.Click += new System.EventHandler(this.houres_Click);
            // 
            // deleteHoure
            // 
            this.deleteHoure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.deleteHoure.FlatAppearance.BorderSize = 0;
            this.deleteHoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteHoure.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.deleteHoure.ForeColor = System.Drawing.Color.White;
            this.deleteHoure.Location = new System.Drawing.Point(109, 82);
            this.deleteHoure.Name = "deleteHoure";
            this.deleteHoure.Size = new System.Drawing.Size(40, 40);
            this.deleteHoure.TabIndex = 1;
            this.deleteHoure.Text = "-";
            this.deleteHoure.UseVisualStyleBackColor = false;
            this.deleteHoure.Click += new System.EventHandler(this.deleteHoure_Click);
            // 
            // addHoure
            // 
            this.addHoure.BackColor = System.Drawing.Color.DodgerBlue;
            this.addHoure.FlatAppearance.BorderSize = 0;
            this.addHoure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addHoure.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.addHoure.ForeColor = System.Drawing.Color.White;
            this.addHoure.Location = new System.Drawing.Point(23, 82);
            this.addHoure.Name = "addHoure";
            this.addHoure.Size = new System.Drawing.Size(40, 40);
            this.addHoure.TabIndex = 0;
            this.addHoure.Text = "+";
            this.addHoure.UseVisualStyleBackColor = false;
            this.addHoure.Click += new System.EventHandler(this.addHoure_Click);
            // 
            // houreLable
            // 
            this.houreLable.AutoSize = true;
            this.houreLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.houreLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.houreLable.Font = new System.Drawing.Font("Tahoma", 16F);
            this.houreLable.ForeColor = System.Drawing.Color.White;
            this.houreLable.Location = new System.Drawing.Point(385, 107);
            this.houreLable.Name = "houreLable";
            this.houreLable.Size = new System.Drawing.Size(83, 29);
            this.houreLable.TabIndex = 5;
            this.houreLable.Text = "Houres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica World", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Task Counter";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.calcLable);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(170, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 103);
            this.panel3.TabIndex = 7;
            // 
            // calcLable
            // 
            this.calcLable.AutoSize = true;
            this.calcLable.Font = new System.Drawing.Font("Tahoma", 16F);
            this.calcLable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.calcLable.Location = new System.Drawing.Point(142, 44);
            this.calcLable.Name = "calcLable";
            this.calcLable.Size = new System.Drawing.Size(24, 27);
            this.calcLable.TabIndex = 4;
            this.calcLable.Text = "0";
            this.calcLable.Click += new System.EventHandler(this.calcLable_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(18, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "If your task less than 56";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(30)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(573, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.houreLable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.taskLable);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Task Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.Label numberTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearTask;
        private System.Windows.Forms.Label taskLable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearHoure;
        private System.Windows.Forms.Label houres;
        private System.Windows.Forms.Button deleteHoure;
        private System.Windows.Forms.Button addHoure;
        private System.Windows.Forms.Label houreLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label calcLable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

