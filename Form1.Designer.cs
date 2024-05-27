namespace ProcessMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьНовыйПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_refreshList = new System.Windows.Forms.Button();
            this.button_closeProcess = new System.Windows.Forms.Button();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.снятьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершитьДеревоПроцессовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelInstalledRAM = new System.Windows.Forms.Label();
            this.labelFreeRAM = new System.Windows.Forms.Label();
            this.labelUseRAM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelCPU = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarRAM = new System.Windows.Forms.ProgressBar();
            this.progressBarCPU = new System.Windows.Forms.ProgressBar();
            this.performanceCPU = new System.Diagnostics.PerformanceCounter();
            this.performanceRAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьНовыйПроцессToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // запуститьНовыйПроцессToolStripMenuItem
            // 
            this.запуститьНовыйПроцессToolStripMenuItem.Name = "запуститьНовыйПроцессToolStripMenuItem";
            this.запуститьНовыйПроцессToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.запуститьНовыйПроцессToolStripMenuItem.Text = "Запустить новый процесс";
            this.запуститьНовыйПроцессToolStripMenuItem.Click += new System.EventHandler(this.запуститьНовыйПроцессToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 437);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.listViewProcesses);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(597, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Управление процессами";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_refreshList);
            this.panel1.Controls.Add(this.button_closeProcess);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 35);
            this.panel1.TabIndex = 2;
            // 
            // button_refreshList
            // 
            this.button_refreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refreshList.Location = new System.Drawing.Point(5, 3);
            this.button_refreshList.Name = "button_refreshList";
            this.button_refreshList.Size = new System.Drawing.Size(113, 29);
            this.button_refreshList.TabIndex = 2;
            this.button_refreshList.Text = "Обновить список";
            this.button_refreshList.UseVisualStyleBackColor = true;
            this.button_refreshList.Click += new System.EventHandler(this.button_refreshList_Click);
            // 
            // button_closeProcess
            // 
            this.button_closeProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_closeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_closeProcess.Location = new System.Drawing.Point(473, 3);
            this.button_closeProcess.Name = "button_closeProcess";
            this.button_closeProcess.Size = new System.Drawing.Size(113, 29);
            this.button_closeProcess.TabIndex = 0;
            this.button_closeProcess.Text = "Снять задачу";
            this.button_closeProcess.UseVisualStyleBackColor = true;
            this.button_closeProcess.Click += new System.EventHandler(this.button_closeProcess_Click);
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnMemory,
            this.columnCPU});
            this.listViewProcesses.ContextMenuStrip = this.contextMenuStrip1;
            this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProcesses.FullRowSelect = true;
            this.listViewProcesses.GridLines = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(3, 28);
            this.listViewProcesses.MultiSelect = false;
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(591, 380);
            this.listViewProcesses.TabIndex = 1;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcesses_ColumnClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Имя";
            this.columnName.Width = 200;
            // 
            // columnMemory
            // 
            this.columnMemory.Text = "Память";
            this.columnMemory.Width = 200;
            // 
            // columnCPU
            // 
            this.columnCPU.Text = "ЦП";
            this.columnCPU.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.снятьЗадачуToolStripMenuItem,
            this.завершитьДеревоПроцессовToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(239, 48);
            // 
            // снятьЗадачуToolStripMenuItem
            // 
            this.снятьЗадачуToolStripMenuItem.Name = "снятьЗадачуToolStripMenuItem";
            this.снятьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.снятьЗадачуToolStripMenuItem.Text = "Снять задачу";
            this.снятьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.снятьЗадачуToolStripMenuItem_Click);
            // 
            // завершитьДеревоПроцессовToolStripMenuItem
            // 
            this.завершитьДеревоПроцессовToolStripMenuItem.Name = "завершитьДеревоПроцессовToolStripMenuItem";
            this.завершитьДеревоПроцессовToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.завершитьДеревоПроцессовToolStripMenuItem.Text = "Завершить дерево процессов";
            this.завершитьДеревоПроцессовToolStripMenuItem.Click += new System.EventHandler(this.завершитьДеревоПроцессовToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(591, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Фильтрация:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = global::ProcessMonitor.Properties.Resources.searchPNG;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSearch.Text = "toolStripButton1";
            this.toolStripButtonSearch.ToolTipText = "Поиск";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelInstalledRAM);
            this.tabPage2.Controls.Add(this.labelFreeRAM);
            this.tabPage2.Controls.Add(this.labelUseRAM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.labelRAM);
            this.tabPage2.Controls.Add(this.labelCPU);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.progressBarRAM);
            this.tabPage2.Controls.Add(this.progressBarCPU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Системный монитор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelInstalledRAM
            // 
            this.labelInstalledRAM.AutoSize = true;
            this.labelInstalledRAM.Location = new System.Drawing.Point(529, 379);
            this.labelInstalledRAM.Name = "labelInstalledRAM";
            this.labelInstalledRAM.Size = new System.Drawing.Size(25, 13);
            this.labelInstalledRAM.TabIndex = 12;
            this.labelInstalledRAM.Text = "000";
            // 
            // labelFreeRAM
            // 
            this.labelFreeRAM.AutoSize = true;
            this.labelFreeRAM.Location = new System.Drawing.Point(317, 379);
            this.labelFreeRAM.Name = "labelFreeRAM";
            this.labelFreeRAM.Size = new System.Drawing.Size(25, 13);
            this.labelFreeRAM.TabIndex = 11;
            this.labelFreeRAM.Text = "000";
            // 
            // labelUseRAM
            // 
            this.labelUseRAM.AutoSize = true;
            this.labelUseRAM.Location = new System.Drawing.Point(129, 379);
            this.labelUseRAM.Name = "labelUseRAM";
            this.labelUseRAM.Size = new System.Drawing.Size(25, 13);
            this.labelUseRAM.TabIndex = 10;
            this.labelUseRAM.Text = "000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Установлено:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Доступно:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Используется:";
            // 
            // labelRAM
            // 
            this.labelRAM.AutoSize = true;
            this.labelRAM.Location = new System.Drawing.Point(541, 345);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(15, 13);
            this.labelRAM.TabIndex = 6;
            this.labelRAM.Text = "%";
            // 
            // labelCPU
            // 
            this.labelCPU.AutoSize = true;
            this.labelCPU.Location = new System.Drawing.Point(541, 316);
            this.labelCPU.Name = "labelCPU";
            this.labelCPU.Size = new System.Drawing.Size(15, 13);
            this.labelCPU.TabIndex = 5;
            this.labelCPU.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ОЗУ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ЦП";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "ЦП";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "ОЗУ";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(591, 292);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // progressBarRAM
            // 
            this.progressBarRAM.Location = new System.Drawing.Point(44, 345);
            this.progressBarRAM.Name = "progressBarRAM";
            this.progressBarRAM.Size = new System.Drawing.Size(491, 23);
            this.progressBarRAM.TabIndex = 1;
            // 
            // progressBarCPU
            // 
            this.progressBarCPU.Location = new System.Drawing.Point(44, 316);
            this.progressBarCPU.Name = "progressBarCPU";
            this.progressBarCPU.Size = new System.Drawing.Size(491, 23);
            this.progressBarCPU.TabIndex = 0;
            // 
            // performanceCPU
            // 
            this.performanceCPU.CategoryName = "Processor";
            this.performanceCPU.CounterName = "% Processor Time";
            this.performanceCPU.InstanceName = "_Total";
            // 
            // performanceRAM
            // 
            this.performanceRAM.CategoryName = "Memory";
            this.performanceRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программный монитор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьНовыйПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnMemory;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_closeProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem снятьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завершитьДеревоПроцессовToolStripMenuItem;
        private System.Windows.Forms.Button button_refreshList;
        private System.Windows.Forms.ColumnHeader columnCPU;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Diagnostics.PerformanceCounter performanceCPU;
        private System.Diagnostics.PerformanceCounter performanceRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ProgressBar progressBarRAM;
        private System.Windows.Forms.ProgressBar progressBarCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelInstalledRAM;
        private System.Windows.Forms.Label labelFreeRAM;
        private System.Windows.Forms.Label labelUseRAM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

