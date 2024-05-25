using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProcessMonitor
{
    internal class ProcessesManagement
    {
        public List<Process> processes = new List<Process>();

        public void GetProcesses()
        {
            processes.Clear();
            processes = Process.GetProcesses().ToList<Process>();
        }

        public void RefreshProcessesList(ListView processesListView)
        {
            try
            {
                processesListView.Items.Clear();

                double memorySize;
                double cpuProc;

                foreach (Process process in processes)
                {
                    memorySize = 0;
                    cpuProc = 0;

                    PerformanceCounter memCounter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);
                    PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);

                    memorySize = (double)memCounter.NextValue() / (1000 * 1000);
                    for (int i = 0; i < 3; i++) 
                        cpuProc = (double)cpuCounter.NextValue();   

                    string[] row = new string[] { process.ProcessName, Math.Round(memorySize, 1).ToString() + " Мб", Math.Round(cpuProc / 10, 1).ToString() + " %" };
                    processesListView.Items.Add(new ListViewItem(row));

                    memCounter.Close();
                    memCounter.Dispose();
                    cpuCounter.Close();
                    cpuCounter.Dispose();
                }
            }
            catch (Exception)
            {
                Form1 main = new Form1();
                main.Show();
            }
        }

        public void RefreshProcessesList(ListView processesListView, string keyword)
        {
            try
            {
                GetProcesses();

                List<Process> filtred = processes.Where((x) =>
                x.ProcessName.ToLower().Contains(keyword.ToLower())).ToList<Process>();

                processesListView.Items.Clear();

                double memorySize;
                double cpuProc;

                foreach (Process process in filtred)
                {
                    if (process != null)
                    {
                        memorySize = 0;
                        cpuProc = 0;

                        PerformanceCounter memCounter = new PerformanceCounter("Process", "Working Set - Private", process.ProcessName);
                        PerformanceCounter cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);

                        memorySize = (double)memCounter.NextValue() / (1000 * 1000);
                        for (int i = 0; i < 3; i++)
                            cpuProc = (double)cpuCounter.NextValue();

                        string[] row = new string[] { process.ProcessName, Math.Round(memorySize, 1).ToString() + " Мб", Math.Round(cpuProc / 10, 1).ToString() + " %" };
                        processesListView.Items.Add(new ListViewItem(row));

                        memCounter.Close();
                        memCounter.Dispose();
                        cpuCounter.Close();
                        cpuCounter.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                Form1 main = new Form1();
                main.Show();
            }
        }

        public void CloseProcess(Process process)
        {
            process.Kill();
            process.WaitForExit();
        }

        public int GetParentProcessId(Process process)
        {
            int parentId = 0;

            try
            {
                ManagementObject managementObject = new ManagementObject("win32_process.handle='" + process.Id + "'");
                managementObject.Get();
                parentId = Convert.ToInt32(managementObject["ParentProcessId"]);
            }
            catch (Exception) { }

            return parentId;
        }

        public void CloseProcessAndSubprocesses(int processId)
        {
            if (processId == 0) return;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "Select * From Win32_Process Where ParentProcessID=" + processId);

            ManagementObjectCollection objectCollection = searcher.Get();

            foreach (ManagementObject _object in objectCollection)
            {
                CloseProcessAndSubprocesses(Convert.ToInt32(_object["ProcessID"]));
            }

            try
            {
                Process process = Process.GetProcessById(processId);
                process.Kill();
                process.WaitForExit();
            }
            catch (ArgumentException) { }
        }
    }
}
