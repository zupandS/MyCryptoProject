﻿namespace CryptoProject
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
            dataGridView1 = new DataGridView();
            СurrencyPair = new DataGridViewTextBoxColumn();
            Binance = new DataGridViewTextBoxColumn();
            Bybit = new DataGridViewTextBoxColumn();
            Kucoin = new DataGridViewTextBoxColumn();
            Bitget = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { СurrencyPair, Binance, Bybit, Kucoin, Bitget });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            // 
            // СurrencyPair
            // 
            СurrencyPair.HeaderText = "Сurrency Pair";
            СurrencyPair.Name = "СurrencyPair";
            СurrencyPair.ReadOnly = true;
            // 
            // Binance
            // 
            Binance.HeaderText = "Binance";
            Binance.Name = "Binance";
            Binance.ReadOnly = true;
            // 
            // Bybit
            // 
            Bybit.HeaderText = "Bybit";
            Bybit.Name = "Bybit";
            Bybit.ReadOnly = true;
            // 
            // Kucoin
            // 
            Kucoin.HeaderText = "Kucoin";
            Kucoin.Name = "Kucoin";
            Kucoin.ReadOnly = true;
            // 
            // Bitget
            // 
            Bitget.HeaderText = "Bitget";
            Bitget.Name = "Bitget";
            Bitget.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn СurrencyPair;
        private DataGridViewTextBoxColumn Binance;
        private DataGridViewTextBoxColumn Bybit;
        private DataGridViewTextBoxColumn Kucoin;
        private DataGridViewTextBoxColumn Bitget;
    }
}
