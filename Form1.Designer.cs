namespace Prog_Ice3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxOrder = new ListBox();
            numericUpDownQuantity = new NumericUpDown();
            buttonAddItem = new Button();
            buttonDisplayReceipt = new Button();
            comboBoxItems = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // listBoxOrder
            // 
            listBoxOrder.FormattingEnabled = true;
            listBoxOrder.ItemHeight = 15;
            listBoxOrder.Location = new Point(488, 142);
            listBoxOrder.Name = "listBoxOrder";
            listBoxOrder.Size = new Size(120, 94);
            listBoxOrder.TabIndex = 0;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(333, 160);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 23);
            numericUpDownQuantity.TabIndex = 1;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(361, 213);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(75, 23);
            buttonAddItem.TabIndex = 2;
            buttonAddItem.Text = "Add Item";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonDisplayReceipt
            // 
            buttonDisplayReceipt.Location = new Point(321, 297);
            buttonDisplayReceipt.Name = "buttonDisplayReceipt";
            buttonDisplayReceipt.Size = new Size(147, 23);
            buttonDisplayReceipt.TabIndex = 3;
            buttonDisplayReceipt.Text = "Display Receipt";
            buttonDisplayReceipt.UseVisualStyleBackColor = true;
            // 
            // comboBoxItems
            // 
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(341, 76);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(121, 23);
            comboBoxItems.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxItems);
            Controls.Add(buttonDisplayReceipt);
            Controls.Add(buttonAddItem);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(listBoxOrder);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxOrder;
        private NumericUpDown numericUpDownQuantity;
        private Button buttonAddItem;
        private Button buttonDisplayReceipt;
        private ComboBox comboBoxItems;
    }
}
