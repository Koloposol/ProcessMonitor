using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic;
using ProcessMonitor.Properties;

namespace ProcessMonitor
{
    public partial class Form1 : Form
    {
        ProcessesManagement processManager = new ProcessesManagement();
        ListViewItemComparer comparer = new ListViewItemComparer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processManager.GetProcesses();
            processManager.RefreshProcessesList(listViewProcesses);
            comparer.ColumnIndex = 0;
            Icon = Resources.mainIcon;
            toolStripButtonSearch.Image = Resources.searchPNG;
        }

        private void button_refreshList_Click(object sender, EventArgs e)
        {
            processManager.GetProcesses();
            processManager.RefreshProcessesList(listViewProcesses);
        }

        private void button_closeProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProcesses.SelectedItems[0] != null)
                {
                    Process processToClose = processManager.processes.Where((x) => x.ProcessName ==
                    listViewProcesses.SelectedItems[0].SubItems[0].Text).ToList()[0];

                    processManager.CloseProcess(processToClose);
                    processManager.GetProcesses();
                    processManager.RefreshProcessesList(listViewProcesses);
                }
            }
            catch (Exception) { }
        }

        private void завершитьДеревоПроцессовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProcesses.SelectedItems[0] != null)
                {
                    Process processToClose = processManager.processes.Where((x) => x.ProcessName ==
                    listViewProcesses.SelectedItems[0].SubItems[0].Text).ToList()[0];

                    processManager.CloseProcessAndSubprocesses(processManager.GetParentProcessId(processToClose));
                    processManager.GetProcesses();
                    processManager.RefreshProcessesList(listViewProcesses);
                }
            }
            catch (Exception) { }
        }

        private void снятьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewProcesses.SelectedItems[0] != null)
                {
                    Process processToClose = processManager.processes.Where((x) => x.ProcessName ==
                    listViewProcesses.SelectedItems[0].SubItems[0].Text).ToList()[0];

                    processManager.CloseProcess(processToClose);
                    processManager.GetProcesses();
                    processManager.RefreshProcessesList(listViewProcesses);
                }
            }
            catch (Exception) { }
        }

        private void запуститьНовыйПроцессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Interaction.InputBox("Введите имя программы: ", "Запуск нового процесса");

            try
            {
                Process process = Process.Start(new ProcessStartInfo
                {
                    Arguments = $"/C \"{path}\"",
                    FileName = "cmd",
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            catch (Exception) { }
        }
        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            processManager.RefreshProcessesList(listViewProcesses, toolStripTextBox1.Text);
        }

        private void listViewProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            comparer.ColumnIndex = e.Column;
            comparer.SortDirection = comparer.SortDirection == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            listViewProcesses.ListViewItemSorter = comparer;
            listViewProcesses.Sort();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
