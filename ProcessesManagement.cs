using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            processesListView.Items.Clear();

            double memorySize;

            foreach (Process process in processes)
            {
                //TODO: Выводить процент использования ЦП процессом 
                memorySize = 0;

                PerformanceCounter counter = new PerformanceCounter();
                counter.CategoryName = "Process";
                counter.CounterName = "Working Set - Private";
                counter.InstanceName = process.ProcessName;

                memorySize = (double)counter.NextValue() / (1000 * 1000);

                string[] row = new string[] { process.ProcessName, Math.Round(memorySize, 1).ToString() };
                processesListView.Items.Add(new ListViewItem(row));

                counter.Close();
                counter.Dispose();
            }
        }

        public void RefreshProcessesList(ListView processesListView, string keyword)
        {
            processesListView.Items.Clear();

            double memorySize;

            foreach (Process process in processes)
            {
                //TODO: Выводить процент использования ЦП процессом 
                memorySize = 0;

                PerformanceCounter counter = new PerformanceCounter();
                counter.CategoryName = "Process";
                counter.CounterName = "Working Set - Private";
                counter.InstanceName = process.ProcessName;

                memorySize = (double)counter.NextValue() / (1000 * 1000);

                string[] row = new string[] { process.ProcessName, Math.Round(memorySize, 1).ToString() };
                processesListView.Items.Add(new ListViewItem(row));

                counter.Close();
                counter.Dispose();
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
