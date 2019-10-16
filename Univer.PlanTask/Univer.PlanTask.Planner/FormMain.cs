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
            var even = e.Start.Day % 2;
            for (int i = 0; i < cbTasks.Items.Count; i++)
            {
                var state = (i + 1) % 2 == even ? CheckState.Checked : CheckState.Unchecked;
                cbTasks.SetItemCheckState(i, state);
            }
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            store = new FileStore<Task>();

            var objs = store.GetAll();

            foreach (Task item in objs)
            {
                AddTask(item);
            }

        }

        public void AddTask(Task item)
        {
            cbTasks.Items.Add(item.Name);
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
    }
}
