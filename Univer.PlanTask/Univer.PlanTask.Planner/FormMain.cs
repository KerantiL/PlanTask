using System.Windows.Forms;
using Univer.PlanTask.Core;
using Univer.PlanTask.Core.Store;
using Univer.PlanTask.Core.Store.Impl;

namespace Univer.PlanTask.Planner
{
    public partial class FormMain : Form
    {
        private IBaseStore store = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbTasks.Items.Clear();
            strartTimeList.Items.Clear();
            finishTimeList.Items.Clear();
            var objs = store.GetAll();
            foreach (Task task in objs)
            {
                if (task.StartDate.Day <= e.Start.Day && task.Deadline.Day >= e.Start.Day)
                    AddTask(task);
            }
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            store = new FileStore<Task>();

            var objs = store.GetAll();
            

            foreach (Task task in objs)
            {
                if (task.StartDate.Day <= calendar.TodayDate.Day && task.Deadline.Day >= calendar.TodayDate.Day)
                    AddTask(task);
            }

        }

        public void AddTask(Task item)
        {
            cbTasks.Items.Add(item.Name);
            strartTimeList.Items.Add(item.StartDate);
            finishTimeList.Items.Add(item.Deadline);
            
        }

        public void AddTaskToStore(Task item)
        {
            store.Create(item);
        }

        private void FlowMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            InputBox inputBox = new InputBox(this);
            inputBox.Show();
        }

        private void FormMain_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void FlowLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CbTasks_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
