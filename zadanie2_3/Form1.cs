using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace zadanie2
{
    public partial class Form1 :Form
    {
        List<Shop> listShops = new List<Shop>();
        Shop selectedShop;
        int index;
        Playlist playlist = new Playlist();
        public Form1 ()
        {
            InitializeComponent();
            GroupBoxShops.Visible = GroupBoxAddShop.Visible = false;
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMenu.SelectedIndex)
            {
                case 0:
                    GroupBoxAddShop.Visible = true;
                    GroupBoxShops.Visible = false;
                    break;
                case 1:
                    GroupBoxAddShop.Visible = false;
                    GroupBoxShops.Visible = true;
                    break;
            }
        }
        private void addMarketButton_Click (object sender, EventArgs e)
        {
            if (checkName(marketNameTextBox.Text))
            {
                AddNewShopInComboBoxAndList();
            }
        }
        private bool checkName (string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Введите название магазина");
                return false;
            }
                
            foreach(char i in name)
            {
                if (!Char.IsLetter(i))
                {
                    MessageBox.Show("Название магазина может содержать только буквы");
                    return false;                   
                }
            }
            return true;
        }


        private void comboBoxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBoxShops.SelectedIndex;
            Update(index);
        }
        private void ButtonBuy_Click (object sender, EventArgs e)
        {
            int countProduct = Convert.ToInt32(numericUpDownCountProduct.Value);
            if (checkMarket())
            {
                selectedShop.Sell(TextBoxNameProduct.Text, countProduct);
                Update(index);
            }
        }

        

        private void Update (int index)
        {
            selectedShop = listShops[index];
            LabelProfit.Text = $"{selectedShop.Profite} рублей";
            selectedShop.WriteAllProducts(listBoxProducts);
        }
        private void AddNewShopInComboBoxAndList ()
        {
            listShops.Add(new Shop(marketNameTextBox.Text));
            comboBoxShops.Items.Add(listShops[listShops.Count - 1].Name);
        }
        private bool CheckAddProduct ()
        {
                if (TextBoxAddNameProducts.Text.Length == 0)
                {
                    MessageBox.Show("Введите название товара");
                    return false;
                }
                return true;
        }

        private bool checkMarket ()
        {
            if (selectedShop == null)
            {
                MessageBox.Show("Выберите магазин");
                return false;
            }
            return true;
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            if (CheckAddProduct() && checkMarket())
            {
                if (selectedShop.FindByName(TextBoxAddNameProducts.Text) == null)
                {
                    selectedShop.CreateProduct(TextBoxAddNameProducts.Text,
                        numericUpDownAddPriceProducts.Value,
                        Convert.ToInt32(numericUpDownAddCountProducts.Value));
                    Update(index);
                }
                else
                    MessageBox.Show("Такой товар уже существует");
            }
        }

        private void buttonAddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            openFileDialog.Title = "Выберите файл с аудиозаписью";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                try
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    if (lines.Length == 2)
                    {
                        string author = lines[0];
                        string title = lines[1];
                        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filename); ;

                        playlist.AddSong(author, title, filename);
                        UpdatePlaylistListBox();

                        MessageBox.Show("Аудиозапись добавлена в плейлист.");
                    }
                    else
                    {
                        MessageBox.Show("Некорректный формат файла. Файл должен содержать две строки: Имя автора и название песни.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }



        public void UpdateCurrentSongLabel()
        {
            try
            {
                labelNameSong.Text = playlist.CurrentSong().Title + " - " + playlist.CurrentSong().Author;
            }
            catch (InvalidOperationException ex)
            {
                labelNameSong.Text = "";
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdatePlaylistListBox()
        {
            listBoxPlaylist.Items.Clear();
            foreach (Song song in playlist.GetSongs())
            {
                listBoxPlaylist.Items.Add(song.Title + " - " + song.Author);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

                int selectedIndex = listBoxPlaylist.SelectedIndex;
                if (selectedIndex >= 0)
                {
                    try
                    {
                        if (listBoxPlaylist.Items.Count == 1)
                        {
                            labelNameSong.Visible = false;
                        }
                        playlist.RemoveSong(selectedIndex);
                        UpdatePlaylistListBox();
                        MessageBox.Show("Аудиозапись удалена из плейлиста.");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите аудиозапись для удаления.");
                }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            try
            {
                labelNameSong.Visible = true;
                playlist.StopSong(listBoxPlaylist, labelNameSong);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            try
            {
                labelNameSong.Visible = true;
                playlist.PlaySong(listBoxPlaylist, labelNameSong);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                labelNameSong.Visible = true;
                playlist.NextSong();
                UpdateCurrentSongLabel();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                labelNameSong.Visible = true;
                playlist.PreviousSong();
                UpdateCurrentSongLabel();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGoToStartPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                labelNameSong.Visible = true;
                playlist.GoToStart();
                UpdateCurrentSongLabel();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClearPlaylist_Click(object sender, EventArgs e)
        {
            try
            {
                playlist.ClearPlaylist();
                UpdatePlaylistListBox();
                labelNameSong.Visible = false;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlaylist.Items.Count == 0)
            {
                labelNameSong.Visible = false;
            }
        }
    }
}
