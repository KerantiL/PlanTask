namespace Univer.PlanTask.Planner
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
            this.finishTimeList = new System.Windows.Forms.ListBox();
            this.strartTimeList = new System.Windows.Forms.ListBox();
            this.flowMain.SuspendLayout();
            this.flowLeft.SuspendLayout();
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
            this.flowLeft.Controls.Add(this.strartTimeList);
            this.flowLeft.Controls.Add(this.finishTimeList);
            this.flowLeft.Controls.Add(this.AddButton);
            resources.ApplyResources(this.flowLeft, "flowLeft");
            this.flowLeft.Name = "flowLeft";
            this.flowLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLeft_Paint);
            // 
            // cbTasks
            // 
            resources.ApplyResources(this.cbTasks, "cbTasks");
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.MultiColumn = true;
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.CbTasks_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // finishTimeList
            // 
            resources.ApplyResources(this.finishTimeList, "finishTimeList");
            this.finishTimeList.FormattingEnabled = true;
            this.finishTimeList.Name = "finishTimeList";
            this.finishTimeList.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // strartTimeList
            // 
            resources.ApplyResources(this.strartTimeList, "strartTimeList");
            this.strartTimeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.strartTimeList.FormattingEnabled = true;
            this.strartTimeList.Name = "strartTimeList";
            this.strartTimeList.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
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
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FormMain_ControlAdded);
            this.flowMain.ResumeLayout(false);
            this.flowLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowTop;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.FlowLayoutPanel flowLeft;
        private System.Windows.Forms.CheckedListBox cbTasks;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox strartTimeList;
        private System.Windows.Forms.ListBox finishTimeList;
    }
}

