using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Univer.PlanTask.Core;

namespace Univer.PlanTask.Planner
{
    public partial class TaskBox : UserControl
    {
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string TaskName { get; set; }
        public TaskBox()
        {
            InitializeComponent();
        }

        public TaskBox(Task task)
        {
            InitializeComponent();
            DateStart = task.StartDate;
            DateFinish = task.Deadline;
            TaskName = task.Name;
            taskName.Text = TaskName;
            dateFinish.Text = DateFinish.ToString();
            dateStart.Text = DateStart.ToString();
            BackColor = SystemColors.ActiveCaption;
            Dock = DockStyle.Top;
            //Location = new Point(0, 60);
            Name = $"taskBoxItem{task.Id}";
            Size = new Size(477, 36);
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
