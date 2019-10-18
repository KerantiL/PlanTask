namespace Univer.PlanTask.Planner
{
    partial class ToolBar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.infoButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.completeButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.editButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(56, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoButton.BackgroundImage = global::Univer.PlanTask.Planner.Properties.Resources.Info_i_yellow_svg;
            this.infoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoButton.Location = new System.Drawing.Point(3, 303);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(50, 73);
            this.infoButton.TabIndex = 3;
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // completeButton
            // 
            this.completeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.completeButton.BackgroundImage = global::Univer.PlanTask.Planner.Properties.Resources._768px_Yes_Check_Circle_svg_;
            this.completeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.completeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completeButton.Location = new System.Drawing.Point(3, 78);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(50, 69);
            this.completeButton.TabIndex = 1;
            this.completeButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.BackgroundImage = global::Univer.PlanTask.Planner.Properties.Resources.No_Symbol;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(3, 153);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 69);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.BackgroundImage = global::Univer.PlanTask.Planner.Properties.Resources.edit_icon;
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(3, 228);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 69);
            this.editButton.TabIndex = 0;
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.BackgroundImage = global::Univer.PlanTask.Planner.Properties.Resources.plus_PNG38;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(50, 69);
            this.addButton.TabIndex = 4;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ToolBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ToolBar";
            this.Size = new System.Drawing.Size(56, 379);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button addButton;
    }
}
