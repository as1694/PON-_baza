using System;
using System.Collections.Generic;
using System.IO;
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

namespace sieci
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        string lv_out;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void buttonGo_Click(object sender, RoutedEventArgs e)
        {
            lv_out = Convert.ToInt32(t0101.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0102.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0103.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0104.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0105.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0106.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0107.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0108.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0109.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0110.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0111.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0112.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0113.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0114.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0115.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0201.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0202.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0203.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0204.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0205.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0206.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0207.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0208.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0209.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0210.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0211.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0212.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0213.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0214.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0215.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0301.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0302.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0303.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0304.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0305.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0306.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0307.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0308.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0309.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0310.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0311.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0312.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0313.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0314.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0315.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0401.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0402.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0403.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0404.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0405.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0406.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0407.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0408.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0409.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0410.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0411.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0412.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0413.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0414.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0415.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0501.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0502.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0503.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0504.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0505.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0506.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0507.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0508.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0509.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0510.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0511.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0512.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0513.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0514.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0515.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0601.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0602.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0603.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0604.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0605.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0606.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0607.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0608.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0609.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0610.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0611.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0612.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0613.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0614.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0615.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0701.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0702.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0703.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0704.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0705.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0706.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0707.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0708.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0709.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0710.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0711.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0712.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0713.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0714.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0715.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0801.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0802.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0803.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0804.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0805.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0806.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0807.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0808.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0809.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0810.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0811.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0812.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0813.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0814.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0815.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t0901.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0902.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0903.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0904.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0905.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0906.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0907.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0908.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0909.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0910.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0911.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0912.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0913.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0914.IsChecked).ToString() + " " +
                    Convert.ToInt32(t0915.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1001.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1002.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1003.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1004.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1005.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1006.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1007.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1008.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1009.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1010.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1011.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1012.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1013.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1014.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1015.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1101.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1102.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1103.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1104.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1105.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1106.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1107.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1108.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1109.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1110.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1111.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1112.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1113.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1114.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1115.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1201.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1202.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1203.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1204.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1205.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1206.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1207.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1208.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1209.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1210.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1211.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1212.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1213.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1214.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1215.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1301.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1302.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1303.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1304.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1305.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1306.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1307.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1308.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1309.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1310.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1311.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1312.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1313.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1314.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1315.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1401.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1402.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1403.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1404.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1405.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1406.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1407.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1408.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1409.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1410.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1411.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1412.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1413.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1414.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1415.IsChecked).ToString() + "   " +
                    Convert.ToInt32(t1501.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1502.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1503.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1504.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1505.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1506.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1507.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1508.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1509.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1510.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1511.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1512.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1513.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1514.IsChecked).ToString() + " " +
                    Convert.ToInt32(t1515.IsChecked).ToString();

            output.Text = lv_out;

        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            if (lv_out != null)
            {
                lv_out = (list.SelectedValue.ToString()).Replace("System.Windows.Controls.ListBoxItem: ", "") + ": " + lv_out;

                if (!File.Exists("C:\\Users\\Dominika\\OneDrive\\mgr\\2_sem\\Podstawy_obliczen_neuro\\PON-_baza\\baza.txt"))//tu zmienić ścieżke
                {
                    StreamWriter sw = File.CreateText("C:\\Users\\Dominika\\OneDrive\\mgr\\2_sem\\Podstawy_obliczen_neuro\\PON-_baza\\baza.txt");//i tu

                    sw.WriteLine(lv_out);
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = File.AppendText("C:\\Users\\Dominika\\OneDrive\\mgr\\2_sem\\Podstawy_obliczen_neuro\\PON-_baza\\baza.txt");//i tu

                    sw.WriteLine(lv_out);
                    sw.Close();
                }
            }
        }
    }
}
