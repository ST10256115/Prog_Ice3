using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prog_Ice3
{
    public partial class Form1 : Form
    {
      
        class OrderItem
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal PricePerItem { get; set; }

            public OrderItem(string name, int quantity, decimal price)
            {
                Name = name;
                Quantity = quantity;
                PricePerItem = price;
            }

            public decimal CalculateTotal()
            {
                return Quantity * PricePerItem;
            }

            public override string ToString()
            {
                return $"{Name} ({Quantity} x {PricePerItem:C})";
            }
        }

    
        List<OrderItem> order = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();

            
            comboBoxItems.Items.AddRange(new object[] { "Coffee", "Tea", "Cake", "Sandwich" });
        }

        
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem?.ToString();
            if (selectedItem != null)
            {
                int quantity = (int)numericUpDownQuantity.Value;
                decimal pricePerItem = GetPrice(selectedItem);
                OrderItem newItem = new OrderItem(selectedItem, quantity, pricePerItem);
                order.Add(newItem);
                listBoxOrder.Items.Add(newItem);
            }
        }
      
        private void buttonDisplayReceipt_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            string receipt = "Receipt:\n";
            foreach (var item in order)
            {
                decimal itemTotal = item.CalculateTotal();
                receipt += $"{item.Name} ({item.Quantity} x {item.PricePerItem:C}): {itemTotal:C}\n";
                total += itemTotal;
            }
            receipt += $"Total: {total:C}";
            MessageBox.Show(receipt, "Order Receipt");
        }


    
        private decimal GetPrice(string item)
        {
            switch (item)
            {
                case "Coffee":
                    return 2.5m;
                case "Tea":
                    return 1.5m;
                case "Cake":
                    return 3.0m;
                case "Sandwich":
                    return 5.0m;
                default:
                    return 0;
            }
        }
    }
}