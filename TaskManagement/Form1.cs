using System.IO;
using System.Linq;
namespace TaskManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Task> Doing = new List<Task>();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTask.Text))
            {


                Task AddT = new Task(txtTask.Text);
                Doing.Add(AddT);
                // يتم إضافة المهمة إلى الـ ListBox
                listBox1.Items.Add(AddT);
                txtTask.Clear();
                SaveTasksToFile();
            }
        }

        private void BtnCompl_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Task selectedTask = (Task)listBox1.SelectedItem;
                selectedTask.IsCompleted = true;
                int index = listBox1.SelectedIndex;
                listBox1.Items[index] = selectedTask;
                SaveTasksToFile();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.");
            }

        }

        private void BtnDelet_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1) // تأكد أن هناك شيئاً مختاراً
            {
                int index = listBox1.SelectedIndex;

                // نحذف من القائمة البرمجية ومن واجهة الـ ListBox أيضاً
                Doing.RemoveAt(index);
                listBox1.Items.RemoveAt(index);
                SaveTasksToFile();
        
                }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }
       private void SaveTasksToFile()
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (var task in Doing)
                {
                    writer.WriteLine($"{task._Title}|{task.IsCompleted}");
                }
            }
           
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (File.Exists("tasks.txt"))
            {
                using (StreamReader reader = new StreamReader("tasks.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            string title = parts[0];
                            bool isCompleted = bool.Parse(parts[1]);
                            Task task = new Task(title) { IsCompleted = isCompleted };
                            Doing.Add(task);
                            listBox1.Items.Add(task);
                        }
                    }
                }
            }
        }
    }
}

