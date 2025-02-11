﻿using System;
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
        private DatabaseHelper databaseHelper;

        public Form1()
        {
            InitializeComponent();
            // 设置 AutoScaleMode
            this.AutoScaleMode = AutoScaleMode.Dpi;  // 根据DPI缩放

            // 初始化数据库连接
            databaseHelper = new DatabaseHelper("localhost", "TaskManager", "root", "970109");
            // 初始时禁用checkbox
            checkBoxCompleted.Enabled = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 加载任务并显示
            UpdateTaskList();
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

            // 创建新任务
            var newTask = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsCompleted = false
            };

            // 保存任务到数据库
            databaseHelper.AddTask(newTask);

            // 更新任务列表显示
            UpdateTaskList();

            // 清空输入框
            txtTitle.Clear();
            txtDescription.Clear();
        }

        // 更新任务列表显示
        private void UpdateTaskList()
        {
            int selectedIndex = listBoxTasks.SelectedIndex; // 保存当前选中项的位置

            listBoxTasks.Items.Clear();
            var tasks = databaseHelper.GetAllTasks();
            foreach (var task in tasks)
            {
                string taskInfo = $"[{task.Id}] {task.Title} - {task.DueDate.ToShortDateString()} {(task.IsCompleted ? "(已完成)" : "")}";
                listBoxTasks.Items.Add(taskInfo);
            }

            // 恢复选中项的位置
            if (selectedIndex >= 0 && selectedIndex < listBoxTasks.Items.Count)
            {
                listBoxTasks.SelectedIndex = selectedIndex;
            }
        }
        // 标记任务为已完成复选框点击事件
        private void checkBoxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择一个任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 获取选中任务的ID
            var tasks = databaseHelper.GetAllTasks();
            TaskItem selectedTask = tasks[listBoxTasks.SelectedIndex];

            // 更新任务状态
            selectedTask.IsCompleted = checkBoxCompleted.Checked;
            databaseHelper.UpdateTaskStatus(selectedTask.Id, selectedTask.IsCompleted);

            // 刷新任务列表显示
            UpdateTaskList();
            
        }

        // 删除任务按钮点击事件
        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择一个任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // 获取选中任务的ID
            int selectedIndex = listBoxTasks.SelectedIndex;
            var tasks = databaseHelper.GetAllTasks();
            TaskItem selectedTask = tasks[selectedIndex];
            databaseHelper.DeleteTask(selectedTask.Id);
            UpdateTaskList();
        }

        // 任务列表双击事件（编辑任务）
        private void listBoxTasks_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择一个任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 获取选中任务的ID
            int selectedIndex = listBoxTasks.SelectedIndex;
            var tasks = databaseHelper.GetAllTasks();
            TaskItem selectedTask = tasks[selectedIndex];

            // 打开编辑窗体
            using (var editForm = new EditTaskForm(selectedTask))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 更新任务的ID（确保传递原始ID）
                    editForm.EditedTask.Id = selectedTask.Id;

                    // 保存到数据库
                    databaseHelper.UpdateTask(editForm.EditedTask);

                    // 刷新任务列表
                    UpdateTaskList();
                }
            }
        }

        // 任务列表选中事件
        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex == -1)
            {
                // 未选中任务时，禁用 CheckBox
                checkBoxCompleted.Enabled = false;
                checkBoxCompleted.Checked = false;
                return;
            }

            // 获取选中任务的完成状态
            var tasks = databaseHelper.GetAllTasks();
            TaskItem selectedTask = tasks[listBoxTasks.SelectedIndex];

            // 更新 CheckBox 状态（暂时禁用事件触发）
            checkBoxCompleted.CheckedChanged -= checkBoxCompleted_CheckedChanged; // 临时解绑事件
            checkBoxCompleted.Checked = selectedTask.IsCompleted;
            checkBoxCompleted.Enabled = true;
            checkBoxCompleted.CheckedChanged += checkBoxCompleted_CheckedChanged; // 重新绑定事件
        }
    }
}
