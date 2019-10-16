using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Univer.PlanTask.Planner
{
    public partial class InputBox : Form
    {
        FormMain formMain;

        public InputBox()
        {
            InitializeComponent();
        }

        public InputBox(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string str = textBox.Text;
                Core.Task task = new Core.Task(3, textBox.Text, startDateTimePicker.Value, finishDateTimePicker.Value);
                formMain.AddTaskToStore(task);
                formMain.AddTask(task);
                
            }
            catch
            {
                    MessageBox.Show("Некоректно введено время");
            }
            finally
            {
                this.Close();
            }
            this.Close();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            startDateTimePicker.Value = DateTime.Now;
            finishDateTimePicker.Value = DateTime.Now.AddHours(1);
            dateStart.Text = String.Format("{0}.{1}.{2}",
                startDateTimePicker.Value.Day,
                startDateTimePicker.Value.Month,
                startDateTimePicker.Value.Year);
            dateFinish.Text = String.Format("{0}.{1}.{2}",
                finishDateTimePicker.Value.Day,
                finishDateTimePicker.Value.Month,
                finishDateTimePicker.Value.Year);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateStart.Text = String.Format("{0}.{1}.{2}",
                startDateTimePicker.Value.Day,
                startDateTimePicker.Value.Month,
                startDateTimePicker.Value.Year);
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void FinishDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateFinish.Text = String.Format("{0}.{1}.{2}",
                finishDateTimePicker.Value.Day,
                finishDateTimePicker.Value.Month,
                finishDateTimePicker.Value.Year);
        }
    }
}
