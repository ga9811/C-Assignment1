using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Media.Media3D;

namespace Fruits_System
{
    /// <summary>
    /// Interaction logic for Sale.xaml
    /// </summary>
    public partial class Sale : Window
    {
        
        Fruits fruit = new Fruits();
        public Sale()
        {
            InitializeComponent();
            populate();
            
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-d9vvup6;Initial Catalog=FruitsSystem;Integrated Security=True");

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

               
                IdText.Text = ((DataRowView)dataGridView1.SelectedItems[0]).Row["ProductID"].ToString();
                

            }

        }

        private void SaleBtn_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(IdText.Text) || string.IsNullOrEmpty(WeightText.Text))
            {
                MessageBox.Show("Please fill in all the TextBoxes");
                return;
            }
            else {
                     decimal weight = decimal.Parse(WeightText.Text);
                
                int id = int.Parse(IdText.Text);
                try
                {
                   
                    Con.Open();
                    string selectQuery = "SELECT Amount, Price FROM Fruits WHERE ProductID=@id";
                    SqlCommand selectCmd = new SqlCommand(selectQuery, Con);
                    selectCmd.Parameters.AddWithValue("@id", id);
                    decimal originalAmount = 0;
                    decimal price = 0;

                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            originalAmount = (decimal)reader["Amount"];
                            price = (decimal)reader["Price"];
                        }
                    }

                    decimal updatedAmount = originalAmount - weight;

                    string query = "UPDATE Fruits SET  Amount=@updatedAmount WHERE ProductID=@id";
                    SqlCommand cmd = new SqlCommand(query, Con);
                   
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@updatedAmount", updatedAmount);
               
                    cmd.ExecuteNonQuery();
                    Fruits fruit = new Fruits(id, weight, price);
                    decimal itemSale = fruit.ItemSale(weight, price);
                    Fruits.AddToTotalSale(itemSale);


                    TextBlock.Inlines.Add(new Run("ID: " + id));
                    TextBlock.Inlines.Add(new LineBreak());
                    TextBlock.Inlines.Add(new Run("The Weight is: " + weight));
                    TextBlock.Inlines.Add(new LineBreak());
                    TextBlock.Inlines.Add(new Run("The Price is: " + price));
                    TextBlock.Inlines.Add(new LineBreak());
                    TextBlock.Inlines.Add(new Run("The ItemSale is: " + itemSale));
                    TextBlock.Inlines.Add(new LineBreak());
                    

                    MessageBox.Show("Sale successful!");
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
        

        }   
        private void Reset()
            {
                IdText.Text = "";
                
                WeightText.Text = "";
              

            }

        private void TotalBtn_Click(object sender, RoutedEventArgs e)
        {
            decimal totalSale = Fruits.GetTotalSale();
            TextBlock.Inlines.Add(new Run("The TotalSale is: " + totalSale));
            TextBlock.Inlines.Add(new LineBreak());
        }
    }
}
