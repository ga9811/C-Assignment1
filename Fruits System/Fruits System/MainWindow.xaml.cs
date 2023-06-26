using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace Fruits_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-d9vvup6;Initial Catalog=FruitsSystem;Integrated Security=True");
        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NameText.Text == "" || IdText.Text == "" || AmountText.Text == "" || PriceText.Text == "")
            {
                MessageBox.Show("Not Complete Info!!");
            }
            else {
                try
                {
                    Con.Open();
                    string query = "insert into Fruits values('" + NameText.Text + "','" + IdText.Text + "','" + AmountText.Text + "','" + PriceText.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The new item stored");
                    Con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from Fruits";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.ItemsSource = ds.Tables[0].DefaultView;
            Con.Close();
        }
        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dataGridView1.SelectedItems.Count > 0)
            {
                
                NameText.Text = ((DataRowView)dataGridView1.SelectedItems[0]).Row["ProductName"].ToString();
                IdText.Text = ((DataRowView)dataGridView1.SelectedItems[0]).Row["ProductID"].ToString();
                AmountText.Text = ((DataRowView)dataGridView1.SelectedItems[0]).Row["Amount"].ToString();
                PriceText.Text = ((DataRowView)dataGridView1.SelectedItems[0]).Row["Price"].ToString();
            }

        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            
           
            if (IdText.Text == null)
            {
                MessageBox.Show("please set id");
            }
            else
            {       
                Con.Open();
                    int id = int.Parse(IdText.Text);
                 string query = "select * from Fruits where ProductID=@id";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.Parameters.AddWithValue("@id", id);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.ItemsSource = ds.Tables[0].DefaultView;
                Con.Close();
            }





        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(IdText.Text) || string.IsNullOrEmpty(NameText.Text) || string.IsNullOrEmpty(AmountText.Text) || string.IsNullOrEmpty(PriceText.Text))
            {
                MessageBox.Show("Please fill in all the TextBoxes");
                return;
            }

            int id = int.Parse(IdText.Text);
            string name = NameText.Text;
            decimal amount = decimal.Parse(AmountText.Text);
            decimal price = decimal.Parse(PriceText.Text);

            try
            {
                Con.Open();

                string query = "UPDATE Fruits SET ProductName=@name, Amount=@amount, Price=@price WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Update successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
                Reset();
            }
        }

        private void Reset()
        {           
            IdText.Text = "";
            NameText.Text = "";
            AmountText.Text = "";
            PriceText.Text = "";

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(IdText.Text) )
            {
                MessageBox.Show("Please fill ID TextBoxe");
                return;
            }
            int id = int.Parse(IdText.Text);
            try
            {
                Con.Open();

                string query = "delete * from Fruits WHERE ProductID=@id";
                SqlCommand cmd = new SqlCommand(query, Con);
               
                cmd.Parameters.AddWithValue("@id", id);
            
                cmd.ExecuteNonQuery();

                MessageBox.Show("Delete successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
                Reset();
            }
        }

        private void SaleBtn_Click(object sender, RoutedEventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Close();
        }
    }
}
