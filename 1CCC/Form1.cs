using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace _1CCC
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> paths = new List<string>();

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroLabel3.Visible = false;


            int i = 0;
            string pattern = @"[a-z A-Z 0-9]{8}-[a-z A-Z 0-9]{4}-[a-z A-Z 0-9]{4}-[a-z A-Z 0-9]{4}-[a-z A-Z 0-9]{12}";

            DirectoryInfo roam8 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/1C/1Cv8");
            DirectoryInfo roam81 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/1C/1Cv81");
            DirectoryInfo roam82 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/1C/1Cv82");
            DirectoryInfo roam83 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/1C/1Cv83");
            DirectoryInfo local8 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/1C/1Cv8");
            DirectoryInfo local81 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/1C/1Cv81");
            DirectoryInfo local82 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/1C/1Cv82");
            DirectoryInfo local83 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/1C/1Cv83");


            if (roam8.Exists)
            {
                foreach (var item in roam8.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (roam81.Exists)
            {
                foreach (var item in roam81.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (roam82.Exists)
            {
                foreach (var item in roam82.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (roam83.Exists)
            {
                foreach (var item in roam83.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (local8.Exists)
            {
                foreach (var item in local8.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (local81.Exists)
            {
                foreach (var item in local81.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (local82.Exists)
            {
                foreach (var item in local82.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (local83.Exists)
            {
                foreach (var item in local83.GetDirectories())
                {
                    Match m = Regex.Match(item.Name, pattern);
                    if (m.Success)
                    {
                        paths.Add(item.FullName);
                        i++;
                    }
                }
            }

            if (paths.Count == 0)
            {
                metroLabel2.Visible = true;
                metroLabel2.Text = "Временных файлов 1С не найдено";
                metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                metroLabel2.Visible = true;
                metroLabel2.Text = "Найдено " + paths.Count + " папок с временными файлами 1С!";
                metroLabel2.Style = MetroFramework.MetroColorStyle.Red;
                metroButton5.Visible = true;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            metroProgressSpinner1.Visible = true;
            metroLabel1.Visible = true;

            List<string> startedProc = new List<string>();

            Process[] procByC = Process.GetProcessesByName("1cv8c");
            if (procByC.Length == 0)
            {
                Process[] procByS = Process.GetProcessesByName("1cv8s");
                if (procByS.Length == 0)
                {
                    
                }
                else
                {
                    startedProc.Add(procByS[0].ProcessName);
                }
            }
            else
            {
                startedProc.Add(procByC[0].ProcessName);
            }

            if (startedProc.Count > 0)
            {
                string err = "";
                foreach (var item in startedProc)
                {
                    err += "* " + item + "\n";
                }

                DialogResult dr = MessageBox.Show("В данный момент на компьютере запущены следующие процессы 1С:\n" + err + "Закрыть данные процессы? ВНИМАНИЕ! Сохраните все данные 1С (закройте документы, печатные формы и пр.), иначе возможна частитчная потеря данных!", "Запущенные программы 1С", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dr == DialogResult.Yes)
                {
                    Process[] allproc = Process.GetProcesses();

                    foreach (var item in allproc)
                    {
                        if (item.ProcessName == startedProc[0])
                        {
                            item.Kill();
                        }
                    }

                    Thread.Sleep(100);
                    metroButton5.PerformClick();
                }
                else
                {
                    metroLabel1.Visible = false;
                    metroProgressSpinner1.Visible = false;
                }
            }
            else
            {
                int i = 0;
                try
                {
                    foreach (var item in paths)
                    {
                        if (Directory.Exists(item))
                        {
                            Directory.Delete(item, true);
                            i++;
                        }
                    }
                    metroLabel3.Visible = true;
                    metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
                    metroLabel3.Text = "Временные файлы были успешны удалены!\nУдалено папок(ки): " + i.ToString();
                    metroLabel1.Visible = false;
                    metroLabel2.Visible = false;
                    metroButton5.Visible = false;
                    metroProgressSpinner1.Visible = false;
                    paths.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось удалить временные файлы из-за ошибки:\n" + ex + "\nПожалуйста, попробуйте еще раз или обратитесь к системному администратору.", "Очистка временных файлов 1С", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    metroLabel1.Visible = false;
                    metroLabel2.Visible = false;
                    metroButton5.Visible = false;
                    metroProgressSpinner1.Visible = false;
                    paths.Clear();
                }
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти из программы?", "1C Cache Cleaner", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1С Cache Cleaner, версия 1.0.0.4.\nДанная программа была разработана Дмитрием Пуршевым для удобства обслуживания программы \"1С Предприятие\".\nДанный программный продукт подпадает под категорию свободного программного обеспечения (Free Software). Дизассемблирование, а также другие формы получения исходного кода разрешены (лицензия GNU GPL).\n© Дмитрий Пуршев, " + DateTime.Now.Year.ToString() + "\nВсе права защищены®", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кэш или кеш (англ. cache, от фр. cacher — «прятать»; произносится [kæʃ] — «кэш») — промежуточный буфер с быстрым доступом, содержащий информацию, которая может быть запрошена с наибольшей вероятностью. Доступ к данным в кэше осуществляется быстрее, чем выборка исходных данных из более медленной памяти или удаленного источника, однако её объём существенно ограничен по сравнению с хранилищем исходных данных.", "1C Cache Cleaner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static int GetOSBit()
        {
            bool is64bit = Is64Bit();
            if (is64bit)
                return 64;
            else
                return 32;
        }

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWow64Process([In] IntPtr hProcess, [Out] out bool lpSystemInfo);

        public static bool Is64Bit()
        {
            bool retVal;
            IsWow64Process(Process.GetCurrentProcess().Handle, out retVal);
            return retVal;
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            RegistryKey key = null;
            List<string[]> app = new List<string[]>();
            //string[][] app;

            switch (GetOSBit())
            {
                case 32:
                    key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                    break;

                case 64:
                    key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
                    break;
            }

            foreach (String keyName in key.GetSubKeyNames())
            {
                RegistryKey subkey = key.OpenSubKey(keyName);
                if (subkey.GetValue("DisplayName") != null)
                {
                    if (subkey.GetValue("DisplayName").ToString().Contains("1C:Предприятие") || subkey.GetValue("DisplayName").ToString().Contains("1С:Предприятие"))
                    {
                        Process.Start(subkey.GetValue("InstallLocation").ToString() + @"bin\chdbfl.exe");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
            metroLabel1.StyleManager = metroStyleManager1;
            metroLabel2.StyleManager = metroStyleManager1;
            metroLabel3.StyleManager = metroStyleManager1;
            metroLabel4.StyleManager = metroStyleManager1;
            metroLabel5.StyleManager = metroStyleManager1;
            metroLabel6.StyleManager = metroStyleManager1;
            metroButton1.StyleManager = metroStyleManager1;
            metroButton2.StyleManager = metroStyleManager1;
            metroButton3.StyleManager = metroStyleManager1;
            metroButton4.StyleManager = metroStyleManager1;
            metroButton5.StyleManager = metroStyleManager1;
            metroButton6.StyleManager = metroStyleManager1;
            metroButton7.StyleManager = metroStyleManager1;
            metroButton8.StyleManager = metroStyleManager1;
            metroButton9.StyleManager = metroStyleManager1;
            metroProgressSpinner1.StyleManager = metroStyleManager1;
            metroTabControl1.StyleManager = metroStyleManager1;
            metroTabPage1.StyleManager = metroStyleManager1;
            metroTabPage2.StyleManager = metroStyleManager1;
            metroTabPage3.StyleManager = metroStyleManager1;
            pictureBox1.BackColor = Color.FromArgb(17, 17, 17);
            metroTabPage1.Select();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            Process.Start("https://releases.1c.ru");
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            Process.Start("https://portal.1c.ru");
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            Process.Start("https://its.1c.ru");
        }
    }
}
