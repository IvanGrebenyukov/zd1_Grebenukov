
namespace zadanie2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GroupBoxShops = new System.Windows.Forms.GroupBox();
            this.numericUpDownAddCountProducts = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAddPriceProducts = new System.Windows.Forms.NumericUpDown();
            this.LabelProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCountProduct = new System.Windows.Forms.NumericUpDown();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddNewProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxAddNameProducts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNameProduct = new System.Windows.Forms.TextBox();
            this.ButtonBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxShops = new System.Windows.Forms.ComboBox();
            this.GroupBoxAddShop = new System.Windows.Forms.GroupBox();
            this.addMarketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.marketNameTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonAddButton = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonGoToStartPlaylist = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelNameSong = new System.Windows.Forms.Label();
            this.buttonClearPlaylist = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GroupBoxShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCountProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPriceProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountProduct)).BeginInit();
            this.GroupBoxAddShop.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 626);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.GroupBoxShops);
            this.tabPage1.Controls.Add(this.GroupBoxAddShop);
            this.tabPage1.Controls.Add(this.comboBoxMenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GroupBoxShops
            // 
            this.GroupBoxShops.Controls.Add(this.numericUpDownAddCountProducts);
            this.GroupBoxShops.Controls.Add(this.numericUpDownAddPriceProducts);
            this.GroupBoxShops.Controls.Add(this.LabelProfit);
            this.GroupBoxShops.Controls.Add(this.label4);
            this.GroupBoxShops.Controls.Add(this.numericUpDownCountProduct);
            this.GroupBoxShops.Controls.Add(this.listBoxProducts);
            this.GroupBoxShops.Controls.Add(this.label7);
            this.GroupBoxShops.Controls.Add(this.buttonAddNewProduct);
            this.GroupBoxShops.Controls.Add(this.label6);
            this.GroupBoxShops.Controls.Add(this.label5);
            this.GroupBoxShops.Controls.Add(this.TextBoxAddNameProducts);
            this.GroupBoxShops.Controls.Add(this.label9);
            this.GroupBoxShops.Controls.Add(this.label3);
            this.GroupBoxShops.Controls.Add(this.TextBoxNameProduct);
            this.GroupBoxShops.Controls.Add(this.ButtonBuy);
            this.GroupBoxShops.Controls.Add(this.label2);
            this.GroupBoxShops.Controls.Add(this.comboBoxShops);
            this.GroupBoxShops.Location = new System.Drawing.Point(0, 50);
            this.GroupBoxShops.Name = "GroupBoxShops";
            this.GroupBoxShops.Size = new System.Drawing.Size(1001, 686);
            this.GroupBoxShops.TabIndex = 2;
            this.GroupBoxShops.TabStop = false;
            this.GroupBoxShops.Text = "Магазины";
            // 
            // numericUpDownAddCountProducts
            // 
            this.numericUpDownAddCountProducts.Location = new System.Drawing.Point(517, 304);
            this.numericUpDownAddCountProducts.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAddCountProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddCountProducts.Name = "numericUpDownAddCountProducts";
            this.numericUpDownAddCountProducts.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownAddCountProducts.TabIndex = 20;
            this.numericUpDownAddCountProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownAddPriceProducts
            // 
            this.numericUpDownAddPriceProducts.DecimalPlaces = 2;
            this.numericUpDownAddPriceProducts.Location = new System.Drawing.Point(517, 253);
            this.numericUpDownAddPriceProducts.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAddPriceProducts.Name = "numericUpDownAddPriceProducts";
            this.numericUpDownAddPriceProducts.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownAddPriceProducts.TabIndex = 19;
            this.numericUpDownAddPriceProducts.ThousandsSeparator = true;
            // 
            // LabelProfit
            // 
            this.LabelProfit.AutoSize = true;
            this.LabelProfit.Location = new System.Drawing.Point(266, 46);
            this.LabelProfit.Name = "LabelProfit";
            this.LabelProfit.Size = new System.Drawing.Size(35, 13);
            this.LabelProfit.TabIndex = 18;
            this.LabelProfit.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Введите количество товара для покупки";
            // 
            // numericUpDownCountProduct
            // 
            this.numericUpDownCountProduct.Location = new System.Drawing.Point(10, 145);
            this.numericUpDownCountProduct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCountProduct.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountProduct.Name = "numericUpDownCountProduct";
            this.numericUpDownCountProduct.Size = new System.Drawing.Size(202, 20);
            this.numericUpDownCountProduct.TabIndex = 16;
            this.numericUpDownCountProduct.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(10, 200);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(488, 160);
            this.listBoxProducts.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(514, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выберите количество товара";
            // 
            // buttonAddNewProduct
            // 
            this.buttonAddNewProduct.Location = new System.Drawing.Point(517, 330);
            this.buttonAddNewProduct.Name = "buttonAddNewProduct";
            this.buttonAddNewProduct.Size = new System.Drawing.Size(208, 22);
            this.buttonAddNewProduct.TabIndex = 12;
            this.buttonAddNewProduct.Text = "Добавить товар";
            this.buttonAddNewProduct.UseVisualStyleBackColor = true;
            this.buttonAddNewProduct.Click += new System.EventHandler(this.buttonAddNewProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Выберите цену товара";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите название товара";
            // 
            // TextBoxAddNameProducts
            // 
            this.TextBoxAddNameProducts.Location = new System.Drawing.Point(517, 203);
            this.TextBoxAddNameProducts.Name = "TextBoxAddNameProducts";
            this.TextBoxAddNameProducts.Size = new System.Drawing.Size(208, 20);
            this.TextBoxAddNameProducts.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Прибыль магазина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите название товара для покупки";
            // 
            // TextBoxNameProduct
            // 
            this.TextBoxNameProduct.Location = new System.Drawing.Point(10, 102);
            this.TextBoxNameProduct.Name = "TextBoxNameProduct";
            this.TextBoxNameProduct.Size = new System.Drawing.Size(202, 20);
            this.TextBoxNameProduct.TabIndex = 3;
            // 
            // ButtonBuy
            // 
            this.ButtonBuy.Location = new System.Drawing.Point(9, 171);
            this.ButtonBuy.Name = "ButtonBuy";
            this.ButtonBuy.Size = new System.Drawing.Size(203, 23);
            this.ButtonBuy.TabIndex = 2;
            this.ButtonBuy.Text = "Купить";
            this.ButtonBuy.UseVisualStyleBackColor = true;
            this.ButtonBuy.Click += new System.EventHandler(this.ButtonBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите магазин";
            // 
            // comboBoxShops
            // 
            this.comboBoxShops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShops.FormattingEnabled = true;
            this.comboBoxShops.Location = new System.Drawing.Point(10, 43);
            this.comboBoxShops.Name = "comboBoxShops";
            this.comboBoxShops.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShops.TabIndex = 0;
            this.comboBoxShops.SelectedIndexChanged += new System.EventHandler(this.comboBoxShops_SelectedIndexChanged);
            // 
            // GroupBoxAddShop
            // 
            this.GroupBoxAddShop.Controls.Add(this.addMarketButton);
            this.GroupBoxAddShop.Controls.Add(this.label1);
            this.GroupBoxAddShop.Controls.Add(this.marketNameTextBox);
            this.GroupBoxAddShop.Location = new System.Drawing.Point(257, 50);
            this.GroupBoxAddShop.Name = "GroupBoxAddShop";
            this.GroupBoxAddShop.Size = new System.Drawing.Size(478, 223);
            this.GroupBoxAddShop.TabIndex = 1;
            this.GroupBoxAddShop.TabStop = false;
            this.GroupBoxAddShop.Text = "Добавление магазина";
            // 
            // addMarketButton
            // 
            this.addMarketButton.Location = new System.Drawing.Point(125, 58);
            this.addMarketButton.Name = "addMarketButton";
            this.addMarketButton.Size = new System.Drawing.Size(214, 23);
            this.addMarketButton.TabIndex = 2;
            this.addMarketButton.Text = "Добавить";
            this.addMarketButton.UseVisualStyleBackColor = true;
            this.addMarketButton.Click += new System.EventHandler(this.addMarketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите название магазина";
            // 
            // marketNameTextBox
            // 
            this.marketNameTextBox.Location = new System.Drawing.Point(160, 32);
            this.marketNameTextBox.Name = "marketNameTextBox";
            this.marketNameTextBox.Size = new System.Drawing.Size(149, 20);
            this.marketNameTextBox.TabIndex = 0;
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Items.AddRange(new object[] {
            "Добавить магазин",
            "Магазин"});
            this.comboBoxMenu.Location = new System.Drawing.Point(367, 23);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(210, 21);
            this.comboBoxMenu.TabIndex = 0;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonClearPlaylist);
            this.tabPage2.Controls.Add(this.labelNameSong);
            this.tabPage2.Controls.Add(this.buttonPlay);
            this.tabPage2.Controls.Add(this.buttonStop);
            this.tabPage2.Controls.Add(this.buttonGoToStartPlaylist);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonAddButton);
            this.tabPage2.Controls.Add(this.buttonNext);
            this.tabPage2.Controls.Add(this.buttonBack);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.listBoxPlaylist);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.Location = new System.Drawing.Point(26, 45);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.Size = new System.Drawing.Size(347, 303);
            this.listBoxPlaylist.TabIndex = 0;
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Список песен в плейлисте";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(26, 404);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(54, 48);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(319, 404);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(54, 48);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonAddButton
            // 
            this.buttonAddButton.Location = new System.Drawing.Point(379, 45);
            this.buttonAddButton.Name = "buttonAddButton";
            this.buttonAddButton.Size = new System.Drawing.Size(119, 30);
            this.buttonAddButton.TabIndex = 4;
            this.buttonAddButton.Text = "Добавить песню";
            this.buttonAddButton.UseVisualStyleBackColor = true;
            this.buttonAddButton.Click += new System.EventHandler(this.buttonAddButton_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(379, 90);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 30);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Удалить песню";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonGoToStartPlaylist
            // 
            this.buttonGoToStartPlaylist.Location = new System.Drawing.Point(137, 458);
            this.buttonGoToStartPlaylist.Name = "buttonGoToStartPlaylist";
            this.buttonGoToStartPlaylist.Size = new System.Drawing.Size(119, 30);
            this.buttonGoToStartPlaylist.TabIndex = 6;
            this.buttonGoToStartPlaylist.Text = "Вернуться к началу";
            this.buttonGoToStartPlaylist.UseVisualStyleBackColor = true;
            this.buttonGoToStartPlaylist.Click += new System.EventHandler(this.buttonGoToStartPlaylist_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(137, 404);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(54, 48);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "||";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(202, 404);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(54, 48);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "->";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelNameSong
            // 
            this.labelNameSong.AutoSize = true;
            this.labelNameSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSong.Location = new System.Drawing.Point(25, 363);
            this.labelNameSong.Name = "labelNameSong";
            this.labelNameSong.Size = new System.Drawing.Size(70, 24);
            this.labelNameSong.TabIndex = 9;
            this.labelNameSong.Text = "label10";
            this.labelNameSong.Visible = false;
            // 
            // buttonClearPlaylist
            // 
            this.buttonClearPlaylist.Location = new System.Drawing.Point(379, 136);
            this.buttonClearPlaylist.Name = "buttonClearPlaylist";
            this.buttonClearPlaylist.Size = new System.Drawing.Size(119, 30);
            this.buttonClearPlaylist.TabIndex = 10;
            this.buttonClearPlaylist.Text = "Очистить плейлист";
            this.buttonClearPlaylist.UseVisualStyleBackColor = true;
            this.buttonClearPlaylist.Click += new System.EventHandler(this.buttonClearPlaylist_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Выберите действие";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GroupBoxShops.ResumeLayout(false);
            this.GroupBoxShops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddCountProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddPriceProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountProduct)).EndInit();
            this.GroupBoxAddShop.ResumeLayout(false);
            this.GroupBoxAddShop.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.GroupBox GroupBoxShops;
        private System.Windows.Forms.GroupBox GroupBoxAddShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marketNameTextBox;
        private System.Windows.Forms.Button addMarketButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxShops;
        private System.Windows.Forms.TextBox TextBoxNameProduct;
        private System.Windows.Forms.Button ButtonBuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxAddNameProducts;
        private System.Windows.Forms.Button buttonAddNewProduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCountProduct;
        private System.Windows.Forms.Label LabelProfit;
        private System.Windows.Forms.NumericUpDown numericUpDownAddCountProducts;
        private System.Windows.Forms.NumericUpDown numericUpDownAddPriceProducts;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Label labelNameSong;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonGoToStartPlaylist;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddButton;
        private System.Windows.Forms.Button buttonClearPlaylist;
        private System.Windows.Forms.Label label10;
    }
}

