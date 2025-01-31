namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.checkBoxCompleted = new System.Windows.Forms.CheckBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "任务描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "截止日期";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(107, 46);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(241, 25);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 77);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(241, 106);
            this.txtDescription.TabIndex = 4;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(107, 189);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(241, 25);
            this.dateTimePickerDueDate.TabIndex = 5;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(373, 183);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(112, 31);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "添加任务";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 15;
            this.listBoxTasks.Location = new System.Drawing.Point(37, 241);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(564, 94);
            this.listBoxTasks.TabIndex = 7;
            // 
            // checkBoxCompleted
            // 
            this.checkBoxCompleted.AutoSize = true;
            this.checkBoxCompleted.Location = new System.Drawing.Point(37, 341);
            this.checkBoxCompleted.Name = "checkBoxCompleted";
            this.checkBoxCompleted.Size = new System.Drawing.Size(74, 19);
            this.checkBoxCompleted.TabIndex = 8;
            this.checkBoxCompleted.Text = "已完成";
            this.checkBoxCompleted.UseVisualStyleBackColor = true;
            this.checkBoxCompleted.CheckedChanged += new System.EventHandler(this.checkBoxCompleted_CheckedChanged);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveTask.Location = new System.Drawing.Point(491, 183);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(110, 31);
            this.btnRemoveTask.TabIndex = 9;
            this.btnRemoveTask.Text = "删除任务";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 425);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.checkBoxCompleted);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.dateTimePickerDueDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.CheckBox checkBoxCompleted;
        private System.Windows.Forms.Button btnRemoveTask;
    }
}

