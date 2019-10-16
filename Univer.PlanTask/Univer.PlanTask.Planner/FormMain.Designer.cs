﻿namespace Univer.PlanTask.Planner
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowTop = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.flowLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTasks = new System.Windows.Forms.CheckedListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flowMain.SuspendLayout();
            this.flowLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowTop
            // 
            resources.ApplyResources(this.flowTop, "flowTop");
            this.flowTop.Name = "flowTop";
            // 
            // flowMain
            // 
            this.flowMain.Controls.Add(this.calendar);
            resources.ApplyResources(this.flowMain, "flowMain");
            this.flowMain.Name = "flowMain";
            this.flowMain.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowMain_Paint);
            // 
            // calendar
            // 
            resources.ApplyResources(this.calendar, "calendar");
            this.calendar.Name = "calendar";
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // flowLeft
            // 
            this.flowLeft.Controls.Add(this.cbTasks);
            this.flowLeft.Controls.Add(this.AddButton);
            this.flowLeft.Controls.Add(this.numericUpDown1);
            resources.ApplyResources(this.flowLeft, "flowLeft");
            this.flowLeft.Name = "flowLeft";
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Items.AddRange(new object[] {
            resources.GetString("cbTasks.Items"),
            resources.GetString("cbTasks.Items1"),
            resources.GetString("cbTasks.Items2"),
            resources.GetString("cbTasks.Items3")});
            resources.ApplyResources(this.cbTasks, "cbTasks");
            this.cbTasks.Name = "cbTasks";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLeft);
            this.Controls.Add(this.flowMain);
            this.Controls.Add(this.flowTop);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.flowMain.ResumeLayout(false);
            this.flowLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowTop;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.FlowLayoutPanel flowLeft;
        private System.Windows.Forms.CheckedListBox cbTasks;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
