using Cash_prg.Sales.Customer;
using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Cash_prg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                  
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
      
        }
       

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged_1()
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string input = Microsoft.VisualBasic.Interaction.InputBox("Prompt", "Title", "Default", 0, 0);
            MessageBoxResult result = MessageBox.Show ("Chose .\n\nEnglish, Language?", "Cash_Click", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Grid_flaw.FlowDirection = FlowDirection.LeftToRight;
                    Class1_Cash.lang_prefared = 1;
                    Eng_menu();
                    InputLanguageManager.SetInputLanguage(this, CultureInfo.CreateSpecificCulture("en-US"));
                    //MyLanguageInfo = new CultureInfo("en-US");
                    //MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    Arab_menu();
                    InputLanguageManager.SetInputLanguage(this, CultureInfo.CreateSpecificCulture("ar-SA"));
                    Grid_flaw.FlowDirection = FlowDirection.RightToLeft;
                    Class1_Cash.lang_prefared = 2;
                    break;
                case MessageBoxResult.Cancel:
                    Class1_Cash.lang_prefared = 1;
                    break;
            }
            void Arab_menu()
            {
                A.Header = "المبيعات والزبائن";
                A1.Text = " الزبائن";
                A11.Text  = " الاضافة";
                A12.Header = " البحث والتعديل";
                A13.Header = " تقارير الزبائن";
                
                A2.Text = "عرض سعر";
                A3.Text = "الارسالية";
                A4.Text = "فواتير المبيعات";
                A5.Text = "فواتير المرجع";
                A6.Text = "السندات الدائنة";
                A7.Text = "ضريبة التحصيل";
                A8.Text = "تقارير المبيعات";
               
                B.Header = "المشتريات والموردين";
                C.Header = "الاصناف والمخازن";
                D.Header = "الصناديق والبنوك";
                E.Header = "قائمة المشاريع";
                F.Header = "الموظفين";
                G.Header = "قائمة التقارير";
                H.Header = "قائمة الضرائب";
                I.Header = "الاصول الثابتة";
                J.Header = "اعدادات البرنامج";
               
               
               

            }
            void Eng_menu()
            {
                A.Header = "Sales&Custumers";
                A1.Text = " Custumers";
                A11.Text = " Add";
                A12.Header = " Search&Edit";
                A13.Header = "Customer Report";
               
                A2.Text = "Sales_Estimate";
                A3.Text = "Delivery";
                A4.Text = "Sales Invoices";
                A5.Text = "Returned Invoices";
                A6.Text = "Credits";
                A7.Text = "Collection tax";
                A8.Text = "Sales Reports";
                
                B.Header = "Purchace&Vendors";
                C.Header = "Items&Stores";
                D.Header = "Boxes&Banks";
                E.Header = "Project Menu";
                F.Header = "Employee";
                G.Header = "Report Menu";
                H.Header = "Taxes Menu";
                I.Header = "Fixed assets";
                J.Header = "Program settings";
               
               
               
            }

        }
       
    }
}
