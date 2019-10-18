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
    public partial class TaskList : UserControl
    {
        private List<TaskBox> taskBoxes = null;
        public TaskList()
        {
            taskBoxes = new List<TaskBox>();
            InitializeComponent();
        }

        public void AddTaskBox(Task task)
        {
            //panel.Controls.Clear();
            taskBoxes.Add(new TaskBox(task));
            foreach (var item in taskBoxes)
            { 
                panel.Controls.Add(item);
            }
        }

        public void Clear()
        {
            panel.Controls.Clear();
            taskBoxes.Clear();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
