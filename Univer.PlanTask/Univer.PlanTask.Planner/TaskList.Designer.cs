namespace Univer.PlanTask.Planner
{
    partial class TaskList
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.taskBox1 = new Univer.PlanTask.Planner.TaskBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.taskBox1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(516, 377);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // taskBox1
            // 
            this.taskBox1.DateFinish = new System.DateTime(((long)(0)));
            this.taskBox1.DateStart = new System.DateTime(((long)(0)));
            this.taskBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.taskBox1.Location = new System.Drawing.Point(0, 0);
            this.taskBox1.Name = "taskBox1";
            this.taskBox1.Size = new System.Drawing.Size(516, 34);
            this.taskBox1.TabIndex = 0;
            this.taskBox1.TaskName = null;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(516, 377);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private TaskBox taskBox1;
    }
}
