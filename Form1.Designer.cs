namespace Assignment_5_3_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStraw = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnApple = new System.Windows.Forms.Button();
            this.btnPine = new System.Windows.Forms.Button();
            this.btnPassion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridBasket = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStraw
            // 
            this.btnStraw.BackColor = System.Drawing.Color.Salmon;
            this.btnStraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStraw.BackgroundImage")));
            this.btnStraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStraw.Location = new System.Drawing.Point(620, 306);
            this.btnStraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStraw.Name = "btnStraw";
            this.btnStraw.Size = new System.Drawing.Size(113, 112);
            this.btnStraw.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnStraw, "Add strawberries to the basket");
            this.btnStraw.UseVisualStyleBackColor = false;
            this.btnStraw.Click += new System.EventHandler(this.btnStraw_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.LightCoral;
            this.btnCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCart.BackgroundImage")));
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.Location = new System.Drawing.Point(963, 13);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(45, 43);
            this.btnCart.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnCart, "Proceed to checkout");
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnApple
            // 
            this.btnApple.BackColor = System.Drawing.Color.Salmon;
            this.btnApple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApple.BackgroundImage")));
            this.btnApple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApple.Location = new System.Drawing.Point(739, 306);
            this.btnApple.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApple.Name = "btnApple";
            this.btnApple.Size = new System.Drawing.Size(113, 112);
            this.btnApple.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnApple, "Add apples to the basket");
            this.btnApple.UseVisualStyleBackColor = false;
            this.btnApple.Click += new System.EventHandler(this.btnApple_Click);
            // 
            // btnPine
            // 
            this.btnPine.BackColor = System.Drawing.Color.Salmon;
            this.btnPine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPine.BackgroundImage")));
            this.btnPine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPine.Location = new System.Drawing.Point(620, 123);
            this.btnPine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPine.Name = "btnPine";
            this.btnPine.Size = new System.Drawing.Size(113, 112);
            this.btnPine.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnPine, "Add pineapples to the basket");
            this.btnPine.UseVisualStyleBackColor = false;
            this.btnPine.Click += new System.EventHandler(this.btnPine_Click);
            // 
            // btnPassion
            // 
            this.btnPassion.BackColor = System.Drawing.Color.Salmon;
            this.btnPassion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassion.BackgroundImage")));
            this.btnPassion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPassion.Location = new System.Drawing.Point(739, 123);
            this.btnPassion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPassion.Name = "btnPassion";
            this.btnPassion.Size = new System.Drawing.Size(113, 112);
            this.btnPassion.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnPassion, "Add passion fruits to the basket");
            this.btnPassion.UseVisualStyleBackColor = false;
            this.btnPassion.Click += new System.EventHandler(this.btnPassion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(620, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pineapples";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(736, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Passion Fruits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(620, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Strawberries";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(736, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Apples";
            // 
            // gridBasket
            // 
            this.gridBasket.BackgroundColor = System.Drawing.Color.MistyRose;
            this.gridBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBasket.GridColor = System.Drawing.Color.MistyRose;
            this.gridBasket.Location = new System.Drawing.Point(111, 123);
            this.gridBasket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBasket.Name = "gridBasket";
            this.gridBasket.Size = new System.Drawing.Size(503, 387);
            this.gridBasket.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(635, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "$2.49 (ea)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(754, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "$1.29 (ea)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(635, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "$4.99 (12 oz)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Snow;
            this.label8.Location = new System.Drawing.Point(754, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "$1.99 (ea)";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(43, 123);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(62, 54);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.toolTip1.SetToolTip(this.btnRemove, "Do you have a coupon? Click to add.");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.Color.Snow;
            this.txtSubtotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(163, 517);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 42);
            this.txtSubtotal.TabIndex = 18;
            this.txtSubtotal.Text = "$";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(108, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Subtotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 632);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPassion);
            this.Controls.Add(this.btnPine);
            this.Controls.Add(this.btnApple);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnStraw);
            this.Controls.Add(this.gridBasket);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Dotnetville Foods";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBasket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStraw;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnApple;
        private System.Windows.Forms.Button btnPine;
        private System.Windows.Forms.Button btnPassion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gridBasket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label9;
    }
}

