﻿using System;
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

namespace ProcessMonitor
{
    public partial class Form1 : Form
    {
        ProcessesManagement processManager = new ProcessesManagement();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            processManager.GetProcesses();
            processManager.RefreshProcessesList(listViewProcesses);
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
