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
                string str = textBox1.Text;
                DateTime date = DateTime.Now;
                date.AddHours(Convert.ToInt64(textBox2.Text));
                date.AddMinutes(Convert.ToInt64(textBox3.Text));
                Core.Task task = new Core.Task(3, textBox1.Text, date);
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
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
