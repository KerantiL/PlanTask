namespace Univer.PlanTask.Planner
{
    partial class TaskBox
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.taskName = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.Label();
            this.dateFinish = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.Controls.Add(this.taskName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.dateStart, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.dateFinish, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(600, 34);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskName.Location = new System.Drawing.Point(37, 1);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(417, 32);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "taskName";
            this.taskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateStart
            // 
            this.dateStart.AutoSize = true;
            this.dateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateStart.Location = new System.Drawing.Point(461, 1);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(64, 32);
            this.dateStart.TabIndex = 1;
            this.dateStart.Text = "dateStart";
            this.dateStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateFinish
            // 
            this.dateFinish.AutoSize = true;
            this.dateFinish.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFinish.Location = new System.Drawing.Point(532, 1);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Size = new System.Drawing.Size(64, 32);
            this.dateFinish.TabIndex = 2;
            this.dateFinish.Text = "dateFinish";
            this.dateFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::Univer.PlanTask.Planner.Properties.Resources.Koala;
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(26, 26);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // TaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "TaskBox";
            this.Size = new System.Drawing.Size(600, 36);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label dateStart;
        private System.Windows.Forms.Label dateFinish;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
