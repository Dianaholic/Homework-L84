using System;
using System.Collections;
using System.Collections.Generic;
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

namespace HomeWorkl842
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arraylist;
        public MainWindow()
        {
            InitializeComponent();
            arraylist = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arraylist.Add("Red");
            arraylist.Add("Black");
            arraylist.Add("Blue");
            arraylist.Add("Yellow");
            arraylist.Add("Green");

            MessageBox.Show("ระบบได้ทำการเพิ่มตัวแปรเรียบร้อยแล้ว (" + arraylist.Count.ToString() + ")", "ระบบการแจ้งเตือน");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ขณะนี้มีตัวแปรอยู่จำนวน (" + arraylist.Count.ToString() + ")", "จำนวนตัวแปร");

            arraylist.Clear();

            MessageBox.Show("ระบบได้ทำการลบตัวแปรทั้งหมดเรียบร้อยแล้ว (" + arraylist.Count.ToString() + ")", "ระบบการแจ้งเตือน");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (arraylist.Count <= 0)
            {
                MessageBox.Show("ไม่มีตัวแปรให้แสดง" , "ระบบการแจ้งเตือน");
                return;
            }
            MessageBox.Show("ตัวแปรทั้งหมดมีรายชื่อดังนี้ " + arraylist[0] + " " + arraylist[1] + " " + arraylist[2] + " " + arraylist[3] + " " + arraylist[4], "ระบบการแจ้งเตือน");
        }
    }
}
