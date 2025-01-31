using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskManager
    {
        // 使用List来存储任务
        private List<TaskItem> tasks = new List<TaskItem>();

        // 添加任务
        public void AddTask(TaskItem task)
        {
            tasks.Add(task);
        }

        // 获取所有任务
        public List<TaskItem> GetAllTasks()
        {
            return tasks;
        }

        // 标记任务为已完成
        public void MarkTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
            }
        }

        // 删除任务
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
            }
        }
    }
}
