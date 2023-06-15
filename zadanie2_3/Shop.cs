using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    class Shop
    {
        private Dictionary<Product, int> products;
        public string Name { get; set; }
        public decimal Profite { get; set; }
        Product toSell;

        public Shop (string _name)
        {
            products = new Dictionary<Product,int>();
            Name = _name;
            Profite = 0;
        }
        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        public void Sell(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                }
                else if (products[product] < count)
                {
                    MessageBox.Show("Такого количества товара нет в наличии");
                }
                else
                {
                    products[product] -= count;
                    Profite += toSell.Price * count;
                }
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
        public void WriteAllProducts (ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Key.GetInfo()}; Количество: {product.Value}");
            }
        }
        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
        public void Sell(string ProductName, int count)
        {
            toSell = FindByName(ProductName);
            if (toSell != null)
            {
                this.Sell(toSell, count);
            }
            else
            {
                MessageBox.Show("Товар не найден!");
            }
        }

    }
}
