using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace _1CCC
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void DefineDesign()
        {
            switch (GeneralTheme.MainTheme)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    this.Refresh();
                    break;

                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    this.Refresh();
                    break;
            }

            switch (GeneralTheme.AddTheme)
            {
                case 0:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
                    this.Refresh();
                    break;

                case 1:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
                    this.Refresh();
                    break;

                case 2:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
                    this.Refresh();
                    break;

                case 3:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    this.Refresh();
                    break;

                case 4:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
                    this.Refresh();
                    break;

                case 5:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
                    this.Refresh();
                    break;

                case 6:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
                    this.Refresh();
                    break;

                case 7:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
                    this.Refresh();
                    break;

                case 8:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown;
                    this.Refresh();
                    break;

                case 9:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
                    this.Refresh();
                    break;

                case 10:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
                    this.Refresh();
                    break;

                case 11:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
                    this.Refresh();
                    break;

                case 12:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
                    this.Refresh();
                    break;

                case 13:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
                    this.Refresh();
                    break;

                default:
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    this.Refresh();
                    break;
            }
        }

        private List<string> paths = new List<string>();
        string[,] bases = new string[100, 2];
        string rcp = "";
        int selectedbase = 0;

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

                DialogResult dr = MessageBox.Show("В данный момент на компьютере запущены следующие процессы 1С:\n" + err + "Закрыть данные процессы? ВНИМАНИЕ! Сохраните все данные 1С (закройте документы, печатные формы и пр.), иначе возможна частитчная потеря данных!", "1C Service Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

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

                    Thread.Sleep(1000);
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
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти из программы?", "1C Service Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
            MessageBox.Show("Кэш или кеш (англ. cache, от фр. cacher — «прятать»; произносится [kæʃ] — «кэш») — промежуточный буфер с быстрым доступом, содержащий информацию, которая может быть запрошена с наибольшей вероятностью. Доступ к данным в кэше осуществляется быстрее, чем выборка исходных данных из более медленной памяти или удаленного источника, однако её объём существенно ограничен по сравнению с хранилищем исходных данных.", "1C Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            int lastVer = 0;
            string lastVerPath = "";
            string[,] app = new string[100,2];

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
                int i = 0;
                RegistryKey subkey = key.OpenSubKey(keyName);
                if (subkey.GetValue("DisplayName") != null)
                {
                    if (subkey.GetValue("DisplayName").ToString().Contains("1C:Предприятие") || subkey.GetValue("DisplayName").ToString().Contains("1С:Предприятие"))
                    {
                        app[i, 0] = subkey.GetValue("DisplayVersion").ToString().Replace(".", string.Empty);
                        app[i, 1] = subkey.GetValue("InstallLocation").ToString();
                        i++;
                    }
                }
            }

            for (int i = 0; i < app.Length /2; i++)
            {
                if (app[i, 0] != null)
                {
                    if (Convert.ToInt32(app[i, 0]) > lastVer)
                    {
                        lastVer = Convert.ToInt32(app[i, 0]);
                        lastVerPath = app[i, 1];
                    }
                }
            }

            if (lastVerPath != null || lastVerPath != "")
            {
                try
                {
                    Process.Start(lastVerPath + "/bin/chdbfl.exe");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Произошла катастрофическая ошибка. Обратитесь к системному администратору.\nРасшифровка:\n" + ex, "1C Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SetStyle()
        {
            this.StyleManager = metroStyleManager1;
            metroLabel1.StyleManager = metroStyleManager1;
            metroLabel2.StyleManager = metroStyleManager1;
            metroLabel3.StyleManager = metroStyleManager1;
            metroLabel4.StyleManager = metroStyleManager1;
            metroLabel5.StyleManager = metroStyleManager1;
            metroLabel6.StyleManager = metroStyleManager1;
            metroLabel7.StyleManager = metroStyleManager1;
            metroLabel8.StyleManager = metroStyleManager1;
            metroLabel9.StyleManager = metroStyleManager1;
            metroButton1.StyleManager = metroStyleManager1;
            metroButton2.StyleManager = metroStyleManager1;
            metroButton3.StyleManager = metroStyleManager1;
            metroButton4.StyleManager = metroStyleManager1;
            metroButton5.StyleManager = metroStyleManager1;
            metroButton6.StyleManager = metroStyleManager1;
            metroButton7.StyleManager = metroStyleManager1;
            metroButton8.StyleManager = metroStyleManager1;
            metroButton9.StyleManager = metroStyleManager1;
            metroButton10.StyleManager = metroStyleManager1;
            metroButton11.StyleManager = metroStyleManager1;
            metroProgressSpinner1.StyleManager = metroStyleManager1;
            metroProgressSpinner2.StyleManager = metroStyleManager1;
            metroProgressSpinner3.StyleManager = metroStyleManager1;
            metroTabControl1.StyleManager = metroStyleManager1;
            metroComboBox1.StyleManager = metroStyleManager1;
            metroTabPage1.StyleManager = metroStyleManager1;
            metroTabPage2.StyleManager = metroStyleManager1;
            metroTabPage3.StyleManager = metroStyleManager1;
            pictureBox1.BackColor = Color.FromArgb(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (GeneralTheme.MainTheme == 0 && GeneralTheme.AddTheme == 0)
            {
                GeneralTheme.MainTheme = 0;
                GeneralTheme.AddTheme = 7;
            }

            SetStyle();
            DefineDesign();

            backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            metroProgressSpinner2.Invoke(new Action(() => metroProgressSpinner2.Visible = true));
            metroLabel8.Invoke(new Action(() => metroLabel8.Visible = true));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/1C/1CEStart/ibases.v8i";

            try
            {
                StreamReader rdr = new StreamReader(path);
                int i = 0;

                while (!rdr.EndOfStream)
                {
                    string st = rdr.ReadLine();

                    if (st.Contains("["))
                    {
                        st = st.Replace("[", string.Empty);
                        st = st.Replace("]", string.Empty);

                        bases[i, 0] = st;

                        st = rdr.ReadLine();

                        st = st.Replace("Connect=File=", string.Empty);
                        st = st.Replace("\"", string.Empty);
                        st = st.Replace(";", string.Empty);

                        bases[i, 1] = st;

                        i++;
                    }
                }

                for (int j = 0; j < bases.Length /2 -1; j++)
                {
                    if (bases[j, 0] != null)
                    {
                        metroComboBox1.Invoke(new Action(() => metroComboBox1.Items.Add(bases[j, 0])));
                    }
                }

                metroProgressSpinner2.Invoke(new Action(() => metroProgressSpinner2.Spinning = false));
                metroLabel8.Invoke(new Action(() => metroLabel8.Text = "Данные получены"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка. Обратитесь к системному администратору.\nРасшифровка:\n" + ex, "1C Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.Text != "" || metroComboBox1.Text != null)
            {
                metroButton10.Enabled = true;
            }
            else
            {
                MessageBox.Show("нет");
            }
            selectedbase = metroComboBox1.SelectedIndex;
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            string path = bases[metroComboBox1.SelectedIndex, 1];
            
            if (path != "")
            {
                long dirSize = SafeEnumerateFiles(path, "*.*", SearchOption.AllDirectories).Sum(n => new FileInfo(n).Length);
                metroLabel9.Visible = true;
                metroProgressSpinner3.Visible = true;

                DialogResult dr = folderBrowserDialog1.ShowDialog();

                if (dr == DialogResult.OK && folderBrowserDialog1.SelectedPath != "")
                {
                    rcp = folderBrowserDialog1.SelectedPath;
                    metroLabel9.Visible = true;
                    metroProgressSpinner3.Visible = true;
                    backgroundWorker2.RunWorkerAsync();
                }
                else
                {
                    metroLabel9.Visible = false;
                    metroProgressSpinner3.Visible = false;
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = bases[selectedbase, 1];

            Copy(path, rcp);

            if (File.Exists(rcp + "/DoNotCopy.txt"))
                File.Delete(rcp + "/DoNotCopy.txt");

            if (File.Exists(rcp + "/1Cv8.cdn"))
                File.Delete(rcp + "/1Cv8.cdn");
        }

        private void Copy(string begin_dir, string end_dir)
        {
            //Берём нашу исходную папку
            DirectoryInfo dir_inf = new DirectoryInfo(begin_dir);
            //Перебираем все внутренние папки
            foreach (DirectoryInfo dir in dir_inf.GetDirectories())
            {
                //Проверяем - если директории не существует, то создаём;
                if (Directory.Exists(end_dir + "\\" + dir.Name) != true)
                {
                    Directory.CreateDirectory(end_dir + "\\" + dir.Name);
                }

                //Рекурсия (перебираем вложенные папки и делаем для них то-же самое).
                Copy(dir.FullName, end_dir + "\\" + dir.Name);
            }

            //Перебираем файлики в папке источнике.
            foreach (string file in Directory.GetFiles(begin_dir))
            {
                //Определяем (отделяем) имя файла с расширением - без пути (но с слешем "\").
                string filik = file.Substring(file.LastIndexOf('\\'), file.Length - file.LastIndexOf('\\'));
                //Копируем файлик с перезаписью из источника в приёмник.
                File.Copy(file, end_dir + "\\" + filik, true);
            }
        }

        private static IEnumerable<string> SafeEnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            Stack<string> dirs = new Stack<string>();
            dirs.Push(path);

            while (dirs.Count > 0)
            {
                string currentDirPath = dirs.Pop();
                if (searchOption == SearchOption.AllDirectories)
                {
                    try
                    {
                        string[] subDirs = Directory.GetDirectories(currentDirPath);
                        foreach (string subDirPath in subDirs)
                        {
                            dirs.Push(subDirPath);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        continue;
                    }
                    catch (DirectoryNotFoundException)
                    {
                        continue;
                    }
                }

                string[] files = null;
                try
                {
                    files = Directory.GetFiles(currentDirPath, searchPattern);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                catch (DirectoryNotFoundException)
                {
                    continue;
                }

                foreach (string filePath in files)
                {
                    yield return filePath;
                }
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Резервное копирование завершено!", "1C Service Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            metroLabel9.Visible = false;
            metroProgressSpinner3.Visible = false;
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            ChangeColor cc = new ChangeColor();
            this.Hide();
            cc.ShowDialog();
            DefineDesign();
            this.Show();
            this.Refresh();
        }
    }
}
