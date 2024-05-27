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
using System.Runtime.InteropServices;

namespace ProcessMonitor
{
    public partial class Form1 : Form
    {
        ProcessesManagement processManager = new ProcessesManagement();
        ListViewItemComparer comparer = new ListViewItemComparer();
        MEMORYSTATUSEX mEMORYSTATUSEX = new MEMORYSTATUSEX();
        private float cpu;
        private float ram;
        private ulong installedMemory;

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processManager.GetProcesses();
            processManager.RefreshProcessesList(listViewProcesses);
            comparer.ColumnIndex = 0;

            if (GlobalMemoryStatusEx(mEMORYSTATUSEX))
                installedMemory = mEMORYSTATUSEX.ullTotalPhys;

            labelInstalledRAM.Text = (installedMemory / 1000000000).ToString() + " Гб";

            timer1.Start();
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            cpu = performanceCPU.NextValue();
            ram = performanceRAM.NextValue();

            progressBarCPU.Value = (int)cpu;
            progressBarRAM.Value = (int)ram;

            labelCPU.Text = Math.Round(cpu, 1).ToString() + " %";
            labelRAM.Text = Math.Round(ram, 1).ToString() + " %";

            labelUseRAM.Text = Math.Round(ram / 100 * installedMemory / 1000000000, 1).ToString() + " Гб";
            labelFreeRAM.Text = Math.Round((installedMemory - ram / 100 * installedMemory) / 1000000000, 1).ToString() + " Гб";

            chart1.Series["ЦП"].Points.AddY(cpu);
            chart1.Series["ОЗУ"].Points.AddY(ram);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
