using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class EditTaskForm : Form
    {
        public TaskItem EditedTask { get; private set; }

        // 构造函数：接收要编辑的任务
        public EditTaskForm(TaskItem task)
        {
            InitializeComponent();

            // 初始化控件显示原有任务数据
            txtEditTitle.Text = task.Title;
            txtEditDescription.Text = task.Description;
            dateTimeEditDueDate.Value = task.DueDate;
            checkBoxEditCompleted.Checked = task.IsCompleted;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 验证输入
            if (string.IsNullOrEmpty(txtEditTitle.Text))
            {
                MessageBox.Show("任务标题不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 更新任务对象
            EditedTask = new TaskItem
            {
                Title = txtEditTitle.Text,
                Description = txtEditDescription.Text,
                DueDate = dateTimeEditDueDate.Value,
                IsCompleted = checkBoxEditCompleted.Checked
            };

            // 关闭窗体并返回 DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
