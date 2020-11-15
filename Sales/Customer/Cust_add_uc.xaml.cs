using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Cash_prg.Sales.Customer
{
    /// <summary>
    /// Interaction logic for Cust_add_uc.xaml
    /// </summary>
    public partial class Cust_add_uc : UserControl
    {
        CashDbEntities context = new CashDbEntities();
        CollectionViewSource Cust_source;
        int pop_flag = 0;
        public Cust_add_uc()
        {
            InitializeComponent();
            Cust_source = (CollectionViewSource)FindResource("customer_tblViewSource");
            DataContext = this;

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            context.Customer_tbl.Load();
            Cust_source.Source = context.Customer_tbl.Local;
            currency_idCBox.ItemsSource = (from em in context.Currency_tbl select new { em.Currency_name, em.Id }).ToList();
            country_idCBox.ItemsSource = (from em in context.Country_tbl select new { em.Contry_name, em.Id }).ToList();
            project_nameCBox.ItemsSource = (from em in context.Project_tbl select new { em.Project_name, em.Id }).ToList();
            payment_preferredCBox.ItemsSource = (from em in context.Payment_method_tbl select new { em.Payment_name, em.Id }).ToList();
            customer_activCBox.ItemsSource = (from em in context.Status_tbl select new { em.Status_name, em.Id }).ToList();

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
            if (Class1_Cash .lang_prefared == 1)
            {
                Eng_lbl();
            }
            else
            {
                Aran_lbl();
            }
        }
        private void Eng_lbl()
        {
            button_add.Content = "Add Customer";
            customer_display_name.Content = " Customer_display_name : ";
            customer_activ.Content  = " Customer_activ : ";
            customer_first_name.Content = "Customer_first_name : ";
            customer_last_name.Content = "customer_last_name";
            customer_Email.Content = "customer_Email";
            customer_Phone.Content = "customer_Phone";
            customer_Mobile.Content = "customer_Mobile";
            customer_payment_terms.Content = "customer_payment_terms";
            currency_id.Content = "currency";
            customer_Notes.Content = "customer_Notes : ";
            customer_Website.Content = "customer_Website : ";
            country_id.Content = "country";
            city_id.Content = "city";
            town_id.Content = "village";
            street_name.Content = "street";
            Fax.Content = "Fax";
            Facebook.Content = "Facebook";
            project_name.Content = "project_name";
            twitter.Content = "twitter";
            opining_balance.Content = "opining_balance";
            payment_preferred.Content = "payment_preferred";
        }
        private void Aran_lbl()
        {
            button_add.Content = "اضافة زبون";
            customer_display_name.Content = " اسم الزبون : ";
            customer_activ.Content = " حالة الزبون : ";
            customer_first_name.Content = "الاسم الاول : ";
            customer_last_name.Content = "الاسم الاخير";
            customer_Email.Content = "البريد الالكتروني";
            customer_Phone.Content = "رقم التيليفون";
            customer_Mobile.Content = "رقم الجوال";
            customer_payment_terms.Content = "شروط الاتفاقية";
            currency_id.Content = "العملة";
            customer_Notes.Content = "ملاحظات : ";
            customer_Website.Content = "الموقع الالكتروني : ";
            country_id.Content = "الدولة";
            city_id.Content = "المدينة";
            town_id.Content = "القرية";
            street_name.Content = "الشارع";
            Fax.Content = "فاكس";
            Facebook.Content = "فيسبوك";
            project_name.Content = "اسم المشروع";
            twitter.Content = "تويتر";
            opining_balance.Content = "الرصيد الافتتاحي";
            payment_preferred.Content = "الدفع المفضل";
        }

        private void country_idCBox_DropDownClosed(object sender, EventArgs e)
        {
            city_idCBox.ItemsSource = (from em in context.City_tbl where em.City_Belong == (int?)country_idCBox.SelectedValue select new { em.City_name, em.Id }).ToList();
        }

        private void city_idCBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void city_idCBox_DropDownClosed(object sender, EventArgs e)
        {
            town_idCBox.ItemsSource = (from em in context.Town_tbl where em.Town_belong == (int?)city_idCBox.SelectedValue select new { em.Town_name, em.Id }).ToList();
        }

        private void button_add_Click(object sender, RoutedEventArgs e)
        {
            
           if(customer_first_nameTextBox.Text == "") 
            {
                MessageBox.Show("name is empty");
                return;
            }
            
            int curpos;
            Cust_source.View.MoveCurrentToLast();
            curpos = Cust_source.View.CurrentPosition;
            int pos = curpos + 1;
            Customer_tbl new_cust = new Customer_tbl()
            {
                Id = pos + 1,
                Currency_id = (int?)currency_idCBox.SelectedValue,
                //Purchase_order_date = purchase_order_dateDatePicker.SelectedDate.Value,
                     Customer_display_name = customer_display_nameTextBox.Text,
                Customer_activ_id = (int?)customer_activCBox.SelectedValue,
                Customer_first_name = customer_first_nameTextBox.Text,
                Customer_last_name = customer_last_nameTextBox.Text,
                Customer_Email = customer_EmailTextBox.Text,
                Customer_Phone = customer_PhoneTextBox.Text,
                Customer_Mobile = customer_MobileTextBox.Text,
                Customer_payment_terms = customer_payment_termsTextBox.Text,
                Customer_Notes = customer_NotesTextBox.Text,
                Customer_Website = customer_WebsiteTextBox.Text,
                Country_id = (int?)country_idCBox.SelectedValue,
                City_id = (int?)city_idCBox.SelectedValue,
                Town_id = (int?)town_idCBox.SelectedValue,
                Street_name = street_nameTextBox.Text,
                Fax = faxTextBox.Text,
                Facebook = facebookTextBox.Text,
                project_id = (int?)project_nameCBox.SelectedValue,
                Twitter = twitterTextBox.Text,
                Opining_balance = opining_balanceTextBox.Text is "" ? 0.0 :  float.Parse(opining_balanceTextBox.Text),
                Payment_preferred_id = (int?)payment_preferredCBox.SelectedValue


            };

            //==========================================================
            if (new_cust.Id >= 1)
            {

                //int len = context.Purchase_order_tbl.Local.Count();
                
                //for (int i = 0; i < len; ++i)
                //{
                //    if (new_po.Id == context.Purchase_order_tbl.Local[i].Id)
                //    {
                //        pos = i;
                //        break;
                //    }
                //}
                context.Customer_tbl.Local.Insert(pos, new_cust);
                Cust_source.View.Refresh();
                Cust_source.View.MoveCurrentTo(new_cust);
                context.SaveChanges();
            }
            else
            {
                MessageBox.Show("CustomerID must have  characters.");
            }



        }

        private void customer_activCBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (customer_activCBox.SelectedValue is null)
            {
                if (customer_activCBox.Text == "")
                {
                    return;
                }
                else
                {
                    var fnd = (from s in context.Status_tbl where s.Status_name == customer_activCBox.Text select s).FirstOrDefault<Status_tbl>();
                    if (fnd is null)
                    {
                        //AddChild new
                        MessageBoxResult result = MessageBox.Show("Add New Element .\n\n " + customer_activCBox.Text, "Cash_Click", MessageBoxButton.YesNo);
                        switch (result)
                        {
                            case MessageBoxResult.Yes:
                               
                                int noOfRowInserted = context.Database.ExecuteSqlCommand("insert into Status_tbl(Status_name) values({0})", customer_activCBox.Text);
                                customer_activCBox.ItemsSource = (from em in context.Status_tbl select new { em.Status_name, em.Id }).ToList();
                                context.SaveChanges();
                                break;
                            case MessageBoxResult.No:
                                customer_activCBox.Text = "";
                                break;
                            case MessageBoxResult.Cancel:
                                Class1_Cash.lang_prefared = 1;
                                break;
                        }
                    }

                }

            }
                    //var cust = context.Status_tbl.Find((int?)customer_activCBox.SelectedValue);
                    //if (cust is null) { MessageBox.Show("not found"); }
                    //MessageBox.Show(cust.Status_name);
                    //MessageBox.Show(cust.);
        }

        private void button_pop_Click(object sender, RoutedEventArgs e)
        {
           if( customer_activCBox.Text == "") { return; }
            label_pop.Content = "Replace : " + customer_activCBox.Text;
            text_pop.Text = "";
            this.Cust_pop.IsOpen = true;
            pop_flag = 1;
            //this.text_pop.Visibility = Visibility.Visible;
        }

        private void pop_btn_replac(object sender, RoutedEventArgs e)
        {
           
            if (pop_flag == 1 )
            {
                var fnd = (from s in context.Status_tbl where s.Status_name == text_pop.Text select s).FirstOrDefault<Status_tbl>();
                if (fnd is null)
                {
                    int noOfRowupdated = context.Database.ExecuteSqlCommand("update Status_tbl set Status_name = {0} where Id = {1}", text_pop.Text, customer_activCBox.SelectedValue);
                    customer_activCBox.ItemsSource = (from em in context.Status_tbl select new { em.Status_name, em.Id }).ToList();
                }
                else
                {
                   MessageBox.Show("element exist");
                   return; 
                }
            }



            //==================================== 
            this.Cust_pop.IsOpen = false;
        }
        private void replace_contry(object sender, RoutedEventArgs e)
        {
            if (country_idCBox.Text == "") { return; }
            label_pop.Content = "Replace : " + country_idCBox.Text;
            text_pop.Text = "";
            this.Cust_pop.IsOpen = true;
            pop_flag = 2;
            //this.text_pop.Visibility = Visibility.Visible;
        }
        private void btn_exit_pop_Click(object sender, RoutedEventArgs e)
        {
            this.Cust_pop.IsOpen = false;
        }

        private void country_idCBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (country_idCBox.SelectedValue is null)
            {
                if (country_idCBox.Text == "")
                {
                    return;
                }
                else
                {
                    var fnd = (from s in context.Country_tbl where s.Contry_name == country_idCBox.Text select s).FirstOrDefault<Country_tbl>();
                    if (fnd is null)
                    {
                        //AddChild new
                        MessageBoxResult result = MessageBox.Show("Add New Element .\n\n " + country_idCBox.Text, "Cash_Click", MessageBoxButton.YesNo);
                        switch (result)
                        {
                            case MessageBoxResult.Yes:

                                int noOfRowInserted = context.Database.ExecuteSqlCommand("insert into Country_tbl(Contry_name) values({0})", country_idCBox.Text);
                                country_idCBox.ItemsSource = (from em in context.Country_tbl select new { em.Contry_name, em.Id }).ToList();
                                context.SaveChanges();
                                break;
                            case MessageBoxResult.No:
                                country_idCBox.Text = "";
                                break;
                           
                        }
                    }

                }

            }
        }
    }
}
