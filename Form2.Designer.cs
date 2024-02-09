namespace Assignment_5_3_2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtYearExp = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.grpCoupon = new System.Windows.Forms.GroupBox();
            this.cmboMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridCheckout = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubtotal2 = new System.Windows.Forms.TextBox();
            this.grpCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCoral;
            this.txtName.Location = new System.Drawing.Point(415, 267);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtCC
            // 
            this.txtCC.BackColor = System.Drawing.Color.LightCoral;
            this.txtCC.Location = new System.Drawing.Point(415, 299);
            this.txtCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(187, 23);
            this.txtCC.TabIndex = 1;
            // 
            // txtYearExp
            // 
            this.txtYearExp.BackColor = System.Drawing.Color.LightCoral;
            this.txtYearExp.Location = new System.Drawing.Point(547, 327);
            this.txtYearExp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYearExp.Name = "txtYearExp";
            this.txtYearExp.Size = new System.Drawing.Size(54, 23);
            this.txtYearExp.TabIndex = 2;
            // 
            // txtCVC
            // 
            this.txtCVC.BackColor = System.Drawing.Color.LightCoral;
            this.txtCVC.Location = new System.Drawing.Point(386, 357);
            this.txtCVC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(54, 23);
            this.txtCVC.TabIndex = 3;
            this.txtCVC.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(330, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name On Card";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(301, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credit Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(350, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exp Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(353, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVC";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.Tomato;
            this.btnPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnPurchase.Location = new System.Drawing.Point(527, 356);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(75, 23);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.toolTip1.SetToolTip(this.btnPurchase, "Complete purchase.");
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCoupon.ForeColor = System.Drawing.Color.Black;
            this.btnCoupon.Location = new System.Drawing.Point(446, 357);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(75, 23);
            this.btnCoupon.TabIndex = 10;
            this.btnCoupon.Text = "Coupon?";
            this.toolTip1.SetToolTip(this.btnCoupon, "Do you have a coupon? Click to add.");
            this.btnCoupon.UseVisualStyleBackColor = false;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // txtCoupon
            // 
            this.txtCoupon.BackColor = System.Drawing.Color.LightCoral;
            this.txtCoupon.Location = new System.Drawing.Point(55, 15);
            this.txtCoupon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(187, 23);
            this.txtCoupon.TabIndex = 11;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.Location = new System.Drawing.Point(248, 16);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.toolTip1.SetToolTip(this.btnApply, "Apply coupon code to total.");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(12, 398);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(57, 61);
            this.btnReturn.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnReturn, "Return to basket screen to add additional items.");
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnHide.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.ForeColor = System.Drawing.Color.Black;
            this.btnHide.Location = new System.Drawing.Point(329, 16);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(39, 23);
            this.btnHide.TabIndex = 15;
            this.btnHide.Text = "Hide";
            this.toolTip1.SetToolTip(this.btnHide, "Do you have a coupon? Click to add.");
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // grpCoupon
            // 
            this.grpCoupon.BackColor = System.Drawing.Color.MistyRose;
            this.grpCoupon.Controls.Add(this.btnHide);
            this.grpCoupon.Controls.Add(this.txtCoupon);
            this.grpCoupon.Controls.Add(this.btnApply);
            this.grpCoupon.Location = new System.Drawing.Point(233, 414);
            this.grpCoupon.Name = "grpCoupon";
            this.grpCoupon.Size = new System.Drawing.Size(374, 68);
            this.grpCoupon.TabIndex = 14;
            this.grpCoupon.TabStop = false;
            this.grpCoupon.Text = "Coupon";
            // 
            // cmboMonth
            // 
            this.cmboMonth.BackColor = System.Drawing.Color.LightCoral;
            this.cmboMonth.FormattingEnabled = true;
            this.cmboMonth.Location = new System.Drawing.Point(415, 327);
            this.cmboMonth.Name = "cmboMonth";
            this.cmboMonth.Size = new System.Drawing.Size(71, 24);
            this.cmboMonth.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(492, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Exp Year";
            // 
            // gridCheckout
            // 
            this.gridCheckout.BackgroundColor = System.Drawing.Color.MistyRose;
            this.gridCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckout.GridColor = System.Drawing.Color.MistyRose;
            this.gridCheckout.Location = new System.Drawing.Point(76, 91);
            this.gridCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCheckout.Name = "gridCheckout";
            this.gridCheckout.Size = new System.Drawing.Size(525, 161);
            this.gridCheckout.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(96, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Snow;
            this.txtTotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(132, 319);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 42);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.Text = "$";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightCoral;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Includes state sales tax - 4.75%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(77, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Subtotal";
            // 
            // txtSubtotal2
            // 
            this.txtSubtotal2.BackColor = System.Drawing.Color.Snow;
            this.txtSubtotal2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal2.Location = new System.Drawing.Point(132, 267);
            this.txtSubtotal2.Multiline = true;
            this.txtSubtotal2.Name = "txtSubtotal2";
            this.txtSubtotal2.Size = new System.Drawing.Size(100, 42);
            this.txtSubtotal2.TabIndex = 25;
            this.txtSubtotal2.Text = "$";
            this.txtSubtotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 471);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubtotal2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.gridCheckout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboMonth);
            this.Controls.Add(this.grpCoupon);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCoupon);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtYearExp);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.txtName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Dotnetville Foods | Checkout";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpCoupon.ResumeLayout(false);
            this.grpCoupon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtYearExp;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpCoupon;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ComboBox cmboMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridCheckout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubtotal2;
    }
}