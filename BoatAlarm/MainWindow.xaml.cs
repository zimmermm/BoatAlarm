using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Microsoft.VisualBasic;


namespace BoatAlarm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// selectLogFile();
        }

        private void btnSelectLog_Click(object sender, RoutedEventArgs e)
        {
            selectLogFile();
        }

        private void btnFastBoat_Click(object sender, RoutedEventArgs e)
        {
            appendTimestamp("fast boat", false);
        }

        private void btnSlowBoat_Click(object sender, RoutedEventArgs e)
        {
            appendTimestamp("slow boat", false);
        }

        private void btnBigBoat_Click(object sender, RoutedEventArgs e)
        {
            appendTimestamp("big boat", false);
        }

        private void btnCustomMsg_Click(object sender, RoutedEventArgs e)
        {
            appendTimestamp("", true);
        }

        public void selectLogFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Select a log file...";
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.Filter = "Log file (*.log)|*.log";
            if (saveFileDialog.ShowDialog() == true)
            {
                logFilePath_txtBox.Text = System.IO.Path.GetFullPath(saveFileDialog.FileName);
                eventListBox.Items.Clear();
                if (File.Exists(saveFileDialog.FileName))
                {
                    foreach (string line in File.ReadAllLines(saveFileDialog.FileName))
                    {
                        eventListBox.Items.Add(line);
                    }
                }
            }

        }

        public static String getTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss.ffff");
        }

        public void appendTimestamp(string msg, bool askCustomMsg)
        {
            string path = logFilePath_txtBox.Text;
            String timestamp = getTimestamp(DateTime.Now);
            if (path == "Select a log file...")
            {
                MessageBox.Show("Select a log file first!");
                return;
            }
            if (askCustomMsg)
            {
                InputDialog inputDialog = new InputDialog("Custom Comment:", "--");
                if (inputDialog.ShowDialog() == true)
                    msg = inputDialog.Answer;

            }
            String lineItem = timestamp + " " + msg;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(lineItem);
            }
            eventListBox.Items.Add(lineItem);
        }

        private void saveEventListToLog()
        {
            string path = logFilePath_txtBox.Text;
            using (StreamWriter sw = File.CreateText(path))
            {
                
                foreach (var item in eventListBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
        }

        private void editEvent(object sender, MouseButtonEventArgs e)
        {
            if (eventListBox.SelectedItems.Count > 0)
            {
                string event_line = eventListBox.SelectedItem.ToString();
                string timestamp = event_line.Substring(0, 24);
                string msg = event_line.Substring(25);
                InputDialog inputDialog = new InputDialog(timestamp, msg);
                if (inputDialog.ShowDialog() == true)
                {
                    msg = inputDialog.Answer;
                    int idx = eventListBox.SelectedIndex;
                    eventListBox.Items.RemoveAt(idx);
                    eventListBox.Items.Insert(idx, timestamp + " " + msg);
                    saveEventListToLog();
                }
                    
            }
        }
    }
}
