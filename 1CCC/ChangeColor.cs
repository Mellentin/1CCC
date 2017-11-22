using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _1CCC
{
    public partial class ChangeColor : MetroForm
    {
        public ChangeColor()
        {
            InitializeComponent();

            this.StyleManager = metroStyleManager1;
            metroComboBox1.StyleManager = metroStyleManager1;
            metroComboBox2.StyleManager = metroStyleManager1;
            metroLabel1.StyleManager = metroStyleManager1;
            metroLabel2.StyleManager = metroStyleManager1;
            metroButton1.StyleManager = metroStyleManager1;
            metroRadioButton1.StyleManager = metroStyleManager1;
            metroRadioButton2.StyleManager = metroStyleManager1;
            metroRadioButton3.StyleManager = metroStyleManager1;
            metroTile1.StyleManager = metroStyleManager1;
            metroToggle1.StyleManager = metroStyleManager1;
            metroProgressSpinner1.StyleManager = metroStyleManager1;
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

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    GeneralTheme.MainTheme = metroComboBox1.SelectedIndex;
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    this.Refresh();
                    break;

                case 1:
                    GeneralTheme.MainTheme = metroComboBox1.SelectedIndex;
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    this.Refresh();
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox2.SelectedIndex)
            {
                case 0:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
                    this.Refresh();
                    break;

                case 1:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.White;
                    this.Refresh();
                    break;

                case 2:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Silver;
                    this.Refresh();
                    break;

                case 3:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Blue;
                    this.Refresh();
                    break;

                case 4:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Green;
                    this.Refresh();
                    break;

                case 5:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Lime;
                    this.Refresh();
                    break;

                case 6:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
                    this.Refresh();
                    break;

                case 7:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
                    this.Refresh();
                    break;

                case 8:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Brown;
                    this.Refresh();
                    break;

                case 9:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Pink;
                    this.Refresh();
                    break;

                case 10:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
                    this.Refresh();
                    break;

                case 11:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
                    this.Refresh();
                    break;

                case 12:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
                    this.Refresh();
                    break;

                case 13:
                    GeneralTheme.AddTheme = metroComboBox2.SelectedIndex;
                    metroStyleManager1.Style = MetroFramework.MetroColorStyle.Yellow;
                    this.Refresh();
                    break;
            }
        }

        private void Color_Load(object sender, EventArgs e)
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

            metroComboBox1.SelectedIndex = GeneralTheme.MainTheme;
            metroComboBox2.SelectedIndex = GeneralTheme.AddTheme;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void ChangeColor_Load(object sender, EventArgs e)
        {
            DefineDesign();

            if (GeneralTheme.MainTheme == 0 && GeneralTheme.AddTheme == 0)
            {
                GeneralTheme.MainTheme = 1;
                GeneralTheme.AddTheme = 3;
            }

            metroComboBox1.SelectedIndex = GeneralTheme.MainTheme;
            metroComboBox2.SelectedIndex = GeneralTheme.AddTheme;
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}