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
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();

        public Form1()
        {
            InitializeComponent();
            // 设置 AutoScaleMode
            this.AutoScaleMode = AutoScaleMode.Dpi;  // 根据DPI缩放
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // 获取用户输入的任务信息
            string title = txtTitle.Text;
            string description = txtDescription.Text;
            DateTime dueDate = dateTimePickerDueDate.Value;

            // 验证输入是否为空
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("任务标题不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 创建新任务并添加到任务管理器
            TaskItem newTask = new TaskItem(title, description, dueDate);
            taskManager.AddTask(newTask);

            // 更新任务列表显示
            UpdateTaskList();

            // 清空输入框
            txtTitle.Clear();
            txtDescription.Clear();
        }

        // 更新任务列表显示
        private void UpdateTaskList()
        {
            // 清空当前列表
            listBoxTasks.Items.Clear();

            // 获取所有任务并添加到列表框中
            foreach (var task in taskManager.GetAllTasks())
            {
                string taskInfo = $"{task.Title} - {task.DueDate.ToShortDateString()} {(task.IsCompleted ? "(已完成)" : "")}";
                listBoxTasks.Items.Add(taskInfo);
            }
        }

        // 标记任务为已完成复选框点击事件
        private void checkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                taskManager.MarkTaskAsCompleted(listBoxTasks.SelectedIndex);
                UpdateTaskList();
            }
        }

        // 删除任务按钮点击事件
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                taskManager.RemoveTask(listBoxTasks.SelectedIndex);
                UpdateTaskList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
