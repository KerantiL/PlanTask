namespace Univer.PlanTask.Planner
{
    partial class InputBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.finishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(91, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите задачу";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(299, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox.Location = new System.Drawing.Point(12, 37);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(360, 73);
            this.textBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата начала";
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.CustomFormat = "";
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startDateTimePicker.Location = new System.Drawing.Point(142, 122);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(72, 22);
            this.startDateTimePicker.TabIndex = 4;
            this.startDateTimePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата завершения";
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.finishDateTimePicker.Location = new System.Drawing.Point(142, 156);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(72, 22);
            this.finishDateTimePicker.TabIndex = 6;
            this.finishDateTimePicker.ValueChanged += new System.EventHandler(this.FinishDateTimePicker_ValueChanged);
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.Location = new System.Drawing.Point(220, 127);
            this.dateStart.Name = "dateStart";
            this.dateStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateStart.Size = new System.Drawing.Size(66, 17);
            this.dateStart.TabIndex = 7;
            this.dateStart.Text = "dateStart";
            this.dateStart.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dateFinish
            // 
            this.dateFinish.AutoSize = true;
            this.dateFinish.Location = new System.Drawing.Point(220, 161);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(73, 17);
            this.dateFinish.TabIndex = 8;
            this.dateFinish.Text = "dateFinish";
            // 
            // InputBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.dateFinish);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.finishDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputBox";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker finishDateTimePicker;
        private System.Windows.Forms.Label dateStart;
        private System.Windows.Forms.Label dateFinish;
    }
}