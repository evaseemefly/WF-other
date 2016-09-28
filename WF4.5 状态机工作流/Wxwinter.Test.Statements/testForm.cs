using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wxwinter.Test.Statements
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();

        }

        void workflowCompleted(WorkflowApplicationCompletedEventArgs e)
        {
            instance = null;
            System.Console.WriteLine("workflowCompleted:{0}", e.CompletionState.ToString());
        }

        void aborted(WorkflowApplicationAbortedEventArgs e)
        {
            instance = null;
            System.Console.WriteLine("aborted ,Reason:{0}", e.Reason.Message);
        }

        UnhandledExceptionAction unhandledExceptionl(WorkflowApplicationUnhandledExceptionEventArgs e)
        {
            System.Console.WriteLine("unhandledException:{0}", e.UnhandledException.Message);
            return UnhandledExceptionAction.Cancel;
        }
        void workflowIdel(WorkflowApplicationIdleEventArgs e)
        {
            System.Console.WriteLine("Idle:{0}", e.InstanceId);

            System.Console.WriteLine("--------BookmarkName---------------------------");
            foreach (var item in e.Bookmarks)
            {
                System.Console.WriteLine("{0}", item.BookmarkName);
            }
            System.Console.WriteLine("================================");
        }
        WorkflowApplication instance = null;

        private void startButton_Click(object sender, EventArgs e)
        {
            valueComboBox.Items.Clear();

            valueComboBox.Items.Add("A");
            valueComboBox.Items.Add("B");
            valueComboBox.Items.Add("C");
            valueComboBox.Items.Add("E");
            valueComboBox.SelectedItem = "B";

            instance = new WorkflowApplication(new myWorkflow());

            instance.Completed = new Action<WorkflowApplicationCompletedEventArgs>(workflowCompleted);

            instance.OnUnhandledException = unhandledExceptionl;
            instance.Aborted = aborted;
            instance.Idle = workflowIdel;
            instance.Run();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string bookName =bookmarkTextBox.Text;
            string inputValue = valueComboBox.SelectedItem.ToString();

            if (instance != null)
            {
                if (instance.GetBookmarks().Count(p => p.BookmarkName == bookName) == 1)
                {
                    instance.ResumeBookmark(bookName, inputValue);
                }
                else
                {
                    foreach (var v in instance.GetBookmarks())
                    {
                        System.Console.WriteLine("--------请从下面选项中选择一个BookmarkName---------------------------");
                        System.Console.WriteLine("BookmarkName:{0}:,OwnerDisplayName:{1}", v.BookmarkName, v.OwnerDisplayName);
                        System.Console.WriteLine("================================");
                    }
                }
            }
            else
            {
                MessageBox.Show("没有创建实例");
            }
        }
    }
}
