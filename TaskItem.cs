using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class TaskItem
    {
        // 任务标题
        public string Title { get; set; }

        // 任务描述
        public string Description { get; set; }

        // 任务截止日期
        public DateTime DueDate { get; set; }

        // 任务是否完成
        public bool IsCompleted { get; set; }

        // 构造函数，用于初始化任务
        public TaskItem(string title, string description, DateTime dueDate)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = false; // 默认任务未完成
        }
    }
}
