
namespace PostAPI
{
    partial class DeliveryMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this._cbDeliveryType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this._dgvCategory = new System.Windows.Forms.DataGridView();
            this._btAddCargo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this._rtbDescription = new System.Windows.Forms.RichTextBox();
            this._tbName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this._tbPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this._btCreateShipment = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._cbWarehouse2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._cbArea2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._cbRegion2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this._cbWarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbArea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbRegion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._bLogOut = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1288, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this._cbDeliveryType);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this._dgvCategory);
            this.tabPage1.Controls.Add(this._btAddCargo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this._rtbDescription);
            this.tabPage1.Controls.Add(this._tbName);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this._tbPhone);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this._btCreateShipment);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this._cbWarehouse2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this._cbArea2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this._cbRegion2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this._cbWarehouse);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this._cbArea);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this._cbRegion);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1280, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Створити відправлення";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1026, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 42);
            this.button1.TabIndex = 79;
            this.button1.Text = "Отримати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // _cbDeliveryType
            // 
            this._cbDeliveryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbDeliveryType.FormattingEnabled = true;
            this._cbDeliveryType.Location = new System.Drawing.Point(307, 253);
            this._cbDeliveryType.Name = "_cbDeliveryType";
            this._cbDeliveryType.Size = new System.Drawing.Size(335, 28);
            this._cbDeliveryType.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(172, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "Тип доставки:";
            // 
            // _dgvCategory
            // 
            this._dgvCategory.Location = new System.Drawing.Point(6, 501);
            this._dgvCategory.Name = "_dgvCategory";
            this._dgvCategory.ReadOnly = true;
            this._dgvCategory.RowHeadersWidth = 8;
            this._dgvCategory.Size = new System.Drawing.Size(1268, 100);
            this._dgvCategory.TabIndex = 76;
            // 
            // _btAddCargo
            // 
            this._btAddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btAddCargo.Location = new System.Drawing.Point(215, 607);
            this._btAddCargo.Name = "_btAddCargo";
            this._btAddCargo.Size = new System.Drawing.Size(238, 42);
            this._btAddCargo.TabIndex = 75;
            this._btAddCargo.Text = "Додати місце";
            this._btAddCargo.UseVisualStyleBackColor = true;
            this._btAddCargo.Click += new System.EventHandler(this._btAddCargo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(644, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Коментар:";
            // 
            // _rtbDescription
            // 
            this._rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._rtbDescription.Location = new System.Drawing.Point(648, 184);
            this._rtbDescription.Name = "_rtbDescription";
            this._rtbDescription.Size = new System.Drawing.Size(626, 89);
            this._rtbDescription.TabIndex = 73;
            this._rtbDescription.Text = "";
            // 
            // _tbName
            // 
            this._tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this._tbName.Location = new System.Drawing.Point(307, 170);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(210, 26);
            this._tbName.TabIndex = 31;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(130, 173);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(171, 20);
            this.label25.TabIndex = 30;
            this.label25.Text = "Одержувач(Ф.І.П.):";
            // 
            // _tbPhone
            // 
            this._tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this._tbPhone.Location = new System.Drawing.Point(307, 211);
            this._tbPhone.Name = "_tbPhone";
            this._tbPhone.Size = new System.Drawing.Size(210, 26);
            this._tbPhone.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(142, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Номер телефону:";
            // 
            // _btCreateShipment
            // 
            this._btCreateShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btCreateShipment.Location = new System.Drawing.Point(809, 607);
            this._btCreateShipment.Name = "_btCreateShipment";
            this._btCreateShipment.Size = new System.Drawing.Size(238, 42);
            this._btCreateShipment.TabIndex = 25;
            this._btCreateShipment.Text = "Створити відправлення";
            this._btCreateShipment.UseVisualStyleBackColor = true;
            this._btCreateShipment.Click += new System.EventHandler(this._btCreateShipment_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(627, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Адреса доставки:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(75, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Адреса відправлення:";
            // 
            // _cbWarehouse2
            // 
            this._cbWarehouse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbWarehouse2.FormattingEnabled = true;
            this._cbWarehouse2.Location = new System.Drawing.Point(661, 124);
            this._cbWarehouse2.Name = "_cbWarehouse2";
            this._cbWarehouse2.Size = new System.Drawing.Size(251, 28);
            this._cbWarehouse2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(546, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Відділення:";
            // 
            // _cbArea2
            // 
            this._cbArea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbArea2.FormattingEnabled = true;
            this._cbArea2.Location = new System.Drawing.Point(661, 81);
            this._cbArea2.Name = "_cbArea2";
            this._cbArea2.Size = new System.Drawing.Size(251, 28);
            this._cbArea2.TabIndex = 18;
            this._cbArea2.SelectedIndexChanged += new System.EventHandler(this.CbArea2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(549, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Місто/село:";
            // 
            // _cbRegion2
            // 
            this._cbRegion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbRegion2.FormattingEnabled = true;
            this._cbRegion2.Location = new System.Drawing.Point(661, 38);
            this._cbRegion2.Name = "_cbRegion2";
            this._cbRegion2.Size = new System.Drawing.Size(251, 28);
            this._cbRegion2.TabIndex = 16;
            this._cbRegion2.SelectedIndexChanged += new System.EventHandler(this.CbRegion2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(568, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Область:";
            // 
            // _cbWarehouse
            // 
            this._cbWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbWarehouse.FormattingEnabled = true;
            this._cbWarehouse.Location = new System.Drawing.Point(133, 124);
            this._cbWarehouse.Name = "_cbWarehouse";
            this._cbWarehouse.Size = new System.Drawing.Size(251, 28);
            this._cbWarehouse.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Відділення:";
            // 
            // _cbArea
            // 
            this._cbArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbArea.FormattingEnabled = true;
            this._cbArea.Location = new System.Drawing.Point(133, 81);
            this._cbArea.Name = "_cbArea";
            this._cbArea.Size = new System.Drawing.Size(251, 28);
            this._cbArea.TabIndex = 11;
            this._cbArea.SelectedIndexChanged += new System.EventHandler(this.CbArea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Місто/село:";
            // 
            // _cbRegion
            // 
            this._cbRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbRegion.FormattingEnabled = true;
            this._cbRegion.Location = new System.Drawing.Point(133, 38);
            this._cbRegion.Name = "_cbRegion";
            this._cbRegion.Size = new System.Drawing.Size(251, 28);
            this._cbRegion.TabIndex = 9;
            this._cbRegion.SelectedIndexChanged += new System.EventHandler(this.CbRegion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Область:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1280, 655);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Клієнти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _bLogOut
            // 
            this._bLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._bLogOut.Location = new System.Drawing.Point(1297, 24);
            this._bLogOut.Name = "_bLogOut";
            this._bLogOut.Size = new System.Drawing.Size(157, 42);
            this._bLogOut.TabIndex = 1;
            this._bLogOut.Text = "LogOut";
            this._bLogOut.UseVisualStyleBackColor = true;
            this._bLogOut.Click += new System.EventHandler(this.BLogOut_Click);
            // 
            // DeliveryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 686);
            this.Controls.Add(this._bLogOut);
            this.Controls.Add(this.tabControl1);
            this.Name = "DeliveryMain";
            this.Text = "DeliveryMain";
            this.Load += new System.EventHandler(this.DeliveryMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button _bLogOut;
        private System.Windows.Forms.ComboBox _cbArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbWarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox _cbWarehouse2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cbArea2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbRegion2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button _btCreateShipment;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox _tbPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox _rtbDescription;
        private System.Windows.Forms.Button _btAddCargo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _cbDeliveryType;
        private System.Windows.Forms.DataGridView _dgvCategory;
        private System.Windows.Forms.Button button1;
    }
}