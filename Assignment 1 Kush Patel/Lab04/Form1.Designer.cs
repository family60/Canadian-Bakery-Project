namespace Lab03
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radLemonBerry = new System.Windows.Forms.RadioButton();
            this.grpFlavour = new System.Windows.Forms.GroupBox();
            this.radLayers1 = new System.Windows.Forms.RadioButton();
            this.radLayers2 = new System.Windows.Forms.RadioButton();
            this.radLayers3 = new System.Windows.Forms.RadioButton();
            this.radLayers4 = new System.Windows.Forms.RadioButton();
            this.grpLayers = new System.Windows.Forms.GroupBox();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.radAnniversary = new System.Windows.Forms.RadioButton();
            this.radBirthday = new System.Windows.Forms.RadioButton();
            this.radRetirement = new System.Windows.Forms.RadioButton();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.grpOccasion = new System.Windows.Forms.GroupBox();
            this.radSize6 = new System.Windows.Forms.RadioButton();
            this.radSize8 = new System.Windows.Forms.RadioButton();
            this.radSize10 = new System.Windows.Forms.RadioButton();
            this.radSize12 = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radPolkaDots = new System.Windows.Forms.RadioButton();
            this.radEdibleImages = new System.Windows.Forms.RadioButton();
            this.radFondantBow = new System.Windows.Forms.RadioButton();
            this.rad3DFigures = new System.Windows.Forms.RadioButton();
            this.grpDesign = new System.Windows.Forms.GroupBox();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.grpCakeType = new System.Windows.Forms.GroupBox();
            this.radCustomCake = new System.Windows.Forms.RadioButton();
            this.radCharacterCake = new System.Windows.Forms.RadioButton();
            this.cmbCharacterCake = new System.Windows.Forms.ComboBox();
            this.lblChooseCharacterCake = new System.Windows.Forms.Label();
            this.grpFlavour.SuspendLayout();
            this.grpLayers.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpOccasion.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.grpDesign.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpCakeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(222, 415);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(141, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(60, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(2, 32);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(1, 63);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(71, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(71, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitle.Location = new System.Drawing.Point(270, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(179, 26);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Canadian Bakery";
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Location = new System.Drawing.Point(6, 31);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(73, 17);
            this.radChocolate.TabIndex = 17;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(6, 54);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(56, 17);
            this.radVanilla.TabIndex = 18;
            this.radVanilla.TabStop = true;
            this.radVanilla.Text = "Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(6, 77);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(62, 17);
            this.radBanana.TabIndex = 19;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radLemonBerry
            // 
            this.radLemonBerry.AutoSize = true;
            this.radLemonBerry.Location = new System.Drawing.Point(6, 100);
            this.radLemonBerry.Name = "radLemonBerry";
            this.radLemonBerry.Size = new System.Drawing.Size(81, 17);
            this.radLemonBerry.TabIndex = 20;
            this.radLemonBerry.TabStop = true;
            this.radLemonBerry.Text = "LemonBerry";
            this.radLemonBerry.UseVisualStyleBackColor = true;
            // 
            // grpFlavour
            // 
            this.grpFlavour.Controls.Add(this.radLemonBerry);
            this.grpFlavour.Controls.Add(this.radChocolate);
            this.grpFlavour.Controls.Add(this.radBanana);
            this.grpFlavour.Controls.Add(this.radVanilla);
            this.grpFlavour.Location = new System.Drawing.Point(16, 122);
            this.grpFlavour.Name = "grpFlavour";
            this.grpFlavour.Size = new System.Drawing.Size(102, 122);
            this.grpFlavour.TabIndex = 21;
            this.grpFlavour.TabStop = false;
            this.grpFlavour.Text = "Flavour";
            // 
            // radLayers1
            // 
            this.radLayers1.AutoSize = true;
            this.radLayers1.Location = new System.Drawing.Point(6, 31);
            this.radLayers1.Name = "radLayers1";
            this.radLayers1.Size = new System.Drawing.Size(60, 17);
            this.radLayers1.TabIndex = 22;
            this.radLayers1.TabStop = true;
            this.radLayers1.Text = "1 Layer";
            this.radLayers1.UseVisualStyleBackColor = true;
            // 
            // radLayers2
            // 
            this.radLayers2.AutoSize = true;
            this.radLayers2.Location = new System.Drawing.Point(6, 54);
            this.radLayers2.Name = "radLayers2";
            this.radLayers2.Size = new System.Drawing.Size(65, 17);
            this.radLayers2.TabIndex = 23;
            this.radLayers2.TabStop = true;
            this.radLayers2.Text = "2 Layers";
            this.radLayers2.UseVisualStyleBackColor = true;
            // 
            // radLayers3
            // 
            this.radLayers3.AutoSize = true;
            this.radLayers3.Location = new System.Drawing.Point(6, 77);
            this.radLayers3.Name = "radLayers3";
            this.radLayers3.Size = new System.Drawing.Size(65, 17);
            this.radLayers3.TabIndex = 24;
            this.radLayers3.TabStop = true;
            this.radLayers3.Text = "3 Layers";
            this.radLayers3.UseVisualStyleBackColor = true;
            // 
            // radLayers4
            // 
            this.radLayers4.AutoSize = true;
            this.radLayers4.Location = new System.Drawing.Point(6, 100);
            this.radLayers4.Name = "radLayers4";
            this.radLayers4.Size = new System.Drawing.Size(65, 17);
            this.radLayers4.TabIndex = 25;
            this.radLayers4.TabStop = true;
            this.radLayers4.Text = "4 Layers";
            this.radLayers4.UseVisualStyleBackColor = true;
            // 
            // grpLayers
            // 
            this.grpLayers.Controls.Add(this.radLayers1);
            this.grpLayers.Controls.Add(this.radLayers4);
            this.grpLayers.Controls.Add(this.radLayers2);
            this.grpLayers.Controls.Add(this.radLayers3);
            this.grpLayers.Location = new System.Drawing.Point(16, 250);
            this.grpLayers.Name = "grpLayers";
            this.grpLayers.Size = new System.Drawing.Size(119, 128);
            this.grpLayers.TabIndex = 26;
            this.grpLayers.TabStop = false;
            this.grpLayers.Text = "Number of Layers";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblFirstName);
            this.grpCustomerInfo.Controls.Add(this.txtFirstName);
            this.grpCustomerInfo.Controls.Add(this.lblLastName);
            this.grpCustomerInfo.Controls.Add(this.txtLastName);
            this.grpCustomerInfo.Location = new System.Drawing.Point(22, 16);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(188, 84);
            this.grpCustomerInfo.TabIndex = 27;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // radAnniversary
            // 
            this.radAnniversary.AutoSize = true;
            this.radAnniversary.Location = new System.Drawing.Point(6, 31);
            this.radAnniversary.Name = "radAnniversary";
            this.radAnniversary.Size = new System.Drawing.Size(80, 17);
            this.radAnniversary.TabIndex = 28;
            this.radAnniversary.TabStop = true;
            this.radAnniversary.Text = "Anniversary";
            this.radAnniversary.UseVisualStyleBackColor = true;
            // 
            // radBirthday
            // 
            this.radBirthday.AutoSize = true;
            this.radBirthday.Location = new System.Drawing.Point(6, 54);
            this.radBirthday.Name = "radBirthday";
            this.radBirthday.Size = new System.Drawing.Size(63, 17);
            this.radBirthday.TabIndex = 29;
            this.radBirthday.TabStop = true;
            this.radBirthday.Text = "Birthday";
            this.radBirthday.UseVisualStyleBackColor = true;
            // 
            // radRetirement
            // 
            this.radRetirement.AutoSize = true;
            this.radRetirement.Location = new System.Drawing.Point(92, 31);
            this.radRetirement.Name = "radRetirement";
            this.radRetirement.Size = new System.Drawing.Size(76, 17);
            this.radRetirement.TabIndex = 30;
            this.radRetirement.TabStop = true;
            this.radRetirement.Text = "Retirement";
            this.radRetirement.UseVisualStyleBackColor = true;
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(92, 54);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(68, 17);
            this.radWedding.TabIndex = 31;
            this.radWedding.TabStop = true;
            this.radWedding.Text = "Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // grpOccasion
            // 
            this.grpOccasion.Controls.Add(this.radAnniversary);
            this.grpOccasion.Controls.Add(this.radWedding);
            this.grpOccasion.Controls.Add(this.radBirthday);
            this.grpOccasion.Controls.Add(this.radRetirement);
            this.grpOccasion.Location = new System.Drawing.Point(16, 23);
            this.grpOccasion.Name = "grpOccasion";
            this.grpOccasion.Size = new System.Drawing.Size(200, 100);
            this.grpOccasion.TabIndex = 32;
            this.grpOccasion.TabStop = false;
            this.grpOccasion.Text = "Occasion";
            // 
            // radSize6
            // 
            this.radSize6.AutoSize = true;
            this.radSize6.Location = new System.Drawing.Point(15, 20);
            this.radSize6.Name = "radSize6";
            this.radSize6.Size = new System.Drawing.Size(36, 17);
            this.radSize6.TabIndex = 33;
            this.radSize6.TabStop = true;
            this.radSize6.Text = "6\"";
            this.radSize6.UseVisualStyleBackColor = true;
            // 
            // radSize8
            // 
            this.radSize8.AutoSize = true;
            this.radSize8.Location = new System.Drawing.Point(15, 43);
            this.radSize8.Name = "radSize8";
            this.radSize8.Size = new System.Drawing.Size(36, 17);
            this.radSize8.TabIndex = 34;
            this.radSize8.TabStop = true;
            this.radSize8.Text = "8\"";
            this.radSize8.UseVisualStyleBackColor = true;
            // 
            // radSize10
            // 
            this.radSize10.AutoSize = true;
            this.radSize10.Location = new System.Drawing.Point(15, 66);
            this.radSize10.Name = "radSize10";
            this.radSize10.Size = new System.Drawing.Size(42, 17);
            this.radSize10.TabIndex = 35;
            this.radSize10.TabStop = true;
            this.radSize10.Text = "10\"";
            this.radSize10.UseVisualStyleBackColor = true;
            // 
            // radSize12
            // 
            this.radSize12.AutoSize = true;
            this.radSize12.Location = new System.Drawing.Point(15, 89);
            this.radSize12.Name = "radSize12";
            this.radSize12.Size = new System.Drawing.Size(42, 17);
            this.radSize12.TabIndex = 36;
            this.radSize12.TabStop = true;
            this.radSize12.Text = "12\"";
            this.radSize12.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radSize6);
            this.grpSize.Controls.Add(this.radSize12);
            this.grpSize.Controls.Add(this.radSize8);
            this.grpSize.Controls.Add(this.radSize10);
            this.grpSize.Location = new System.Drawing.Point(16, 129);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(65, 114);
            this.grpSize.TabIndex = 37;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radPolkaDots
            // 
            this.radPolkaDots.AutoSize = true;
            this.radPolkaDots.Location = new System.Drawing.Point(6, 23);
            this.radPolkaDots.Name = "radPolkaDots";
            this.radPolkaDots.Size = new System.Drawing.Size(77, 17);
            this.radPolkaDots.TabIndex = 38;
            this.radPolkaDots.TabStop = true;
            this.radPolkaDots.Text = "Polka Dots";
            this.radPolkaDots.UseVisualStyleBackColor = true;
            // 
            // radEdibleImages
            // 
            this.radEdibleImages.AutoSize = true;
            this.radEdibleImages.Location = new System.Drawing.Point(6, 46);
            this.radEdibleImages.Name = "radEdibleImages";
            this.radEdibleImages.Size = new System.Drawing.Size(91, 17);
            this.radEdibleImages.TabIndex = 39;
            this.radEdibleImages.TabStop = true;
            this.radEdibleImages.Text = "Edible Images";
            this.radEdibleImages.UseVisualStyleBackColor = true;
            // 
            // radFondantBow
            // 
            this.radFondantBow.AutoSize = true;
            this.radFondantBow.Location = new System.Drawing.Point(6, 69);
            this.radFondantBow.Name = "radFondantBow";
            this.radFondantBow.Size = new System.Drawing.Size(88, 17);
            this.radFondantBow.TabIndex = 40;
            this.radFondantBow.TabStop = true;
            this.radFondantBow.Text = "Fondant Bow";
            this.radFondantBow.UseVisualStyleBackColor = true;
            // 
            // rad3DFigures
            // 
            this.rad3DFigures.AutoSize = true;
            this.rad3DFigures.Location = new System.Drawing.Point(6, 92);
            this.rad3DFigures.Name = "rad3DFigures";
            this.rad3DFigures.Size = new System.Drawing.Size(76, 17);
            this.rad3DFigures.TabIndex = 41;
            this.rad3DFigures.TabStop = true;
            this.rad3DFigures.Text = "3D Figures";
            this.rad3DFigures.UseVisualStyleBackColor = true;
            // 
            // grpDesign
            // 
            this.grpDesign.Controls.Add(this.radPolkaDots);
            this.grpDesign.Controls.Add(this.rad3DFigures);
            this.grpDesign.Controls.Add(this.radEdibleImages);
            this.grpDesign.Controls.Add(this.radFondantBow);
            this.grpDesign.Location = new System.Drawing.Point(92, 129);
            this.grpDesign.Name = "grpDesign";
            this.grpDesign.Size = new System.Drawing.Size(103, 128);
            this.grpDesign.TabIndex = 42;
            this.grpDesign.TabStop = false;
            this.grpDesign.Text = "Design";
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpOccasion);
            this.grpCustomCake.Controls.Add(this.grpDesign);
            this.grpCustomCake.Controls.Add(this.grpSize);
            this.grpCustomCake.Enabled = false;
            this.grpCustomCake.Location = new System.Drawing.Point(228, 54);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(245, 267);
            this.grpCustomCake.TabIndex = 43;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpCakeType
            // 
            this.grpCakeType.Controls.Add(this.radCharacterCake);
            this.grpCakeType.Controls.Add(this.radCustomCake);
            this.grpCakeType.Location = new System.Drawing.Point(507, 252);
            this.grpCakeType.Name = "grpCakeType";
            this.grpCakeType.Size = new System.Drawing.Size(270, 100);
            this.grpCakeType.TabIndex = 44;
            this.grpCakeType.TabStop = false;
            this.grpCakeType.Text = "Type of Cake";
            // 
            // radCustomCake
            // 
            this.radCustomCake.AutoSize = true;
            this.radCustomCake.Location = new System.Drawing.Point(12, 46);
            this.radCustomCake.Name = "radCustomCake";
            this.radCustomCake.Size = new System.Drawing.Size(88, 17);
            this.radCustomCake.TabIndex = 0;
            this.radCustomCake.TabStop = true;
            this.radCustomCake.Text = "Custom Cake";
            this.radCustomCake.UseVisualStyleBackColor = true;
            this.radCustomCake.CheckedChanged += new System.EventHandler(this.radCustomCake_CheckedChanged);
            // 
            // radCharacterCake
            // 
            this.radCharacterCake.AutoSize = true;
            this.radCharacterCake.Location = new System.Drawing.Point(144, 46);
            this.radCharacterCake.Name = "radCharacterCake";
            this.radCharacterCake.Size = new System.Drawing.Size(99, 17);
            this.radCharacterCake.TabIndex = 1;
            this.radCharacterCake.TabStop = true;
            this.radCharacterCake.Text = "Character Cake";
            this.radCharacterCake.UseVisualStyleBackColor = true;
            this.radCharacterCake.CheckedChanged += new System.EventHandler(this.radCharacterCake_CheckedChanged);
            // 
            // cmbCharacterCake
            // 
            this.cmbCharacterCake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCharacterCake.Enabled = false;
            this.cmbCharacterCake.FormattingEnabled = true;
            this.cmbCharacterCake.Items.AddRange(new object[] {
            "Minion Cake $40",
            "SuperHero Cake $35",
            "SuperGirl Cake $35",
            "MotherGoose Cake $30"});
            this.cmbCharacterCake.Location = new System.Drawing.Point(566, 397);
            this.cmbCharacterCake.Name = "cmbCharacterCake";
            this.cmbCharacterCake.Size = new System.Drawing.Size(121, 21);
            this.cmbCharacterCake.TabIndex = 45;
            // 
            // lblChooseCharacterCake
            // 
            this.lblChooseCharacterCake.AutoSize = true;
            this.lblChooseCharacterCake.Location = new System.Drawing.Point(564, 365);
            this.lblChooseCharacterCake.Name = "lblChooseCharacterCake";
            this.lblChooseCharacterCake.Size = new System.Drawing.Size(123, 13);
            this.lblChooseCharacterCake.TabIndex = 46;
            this.lblChooseCharacterCake.Text = "Choose Character Cake:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChooseCharacterCake);
            this.Controls.Add(this.cmbCharacterCake);
            this.Controls.Add(this.grpCakeType);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.grpLayers);
            this.Controls.Add(this.grpFlavour);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Name = "Form1";
            this.Text = "Kush Patel n01350301";
            this.grpFlavour.ResumeLayout(false);
            this.grpFlavour.PerformLayout();
            this.grpLayers.ResumeLayout(false);
            this.grpLayers.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpOccasion.ResumeLayout(false);
            this.grpOccasion.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpDesign.ResumeLayout(false);
            this.grpDesign.PerformLayout();
            this.grpCustomCake.ResumeLayout(false);
            this.grpCakeType.ResumeLayout(false);
            this.grpCakeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radLemonBerry;
        private System.Windows.Forms.GroupBox grpFlavour;
        private System.Windows.Forms.RadioButton radLayers1;
        private System.Windows.Forms.RadioButton radLayers2;
        private System.Windows.Forms.RadioButton radLayers3;
        private System.Windows.Forms.RadioButton radLayers4;
        private System.Windows.Forms.GroupBox grpLayers;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.RadioButton radAnniversary;
        private System.Windows.Forms.RadioButton radBirthday;
        private System.Windows.Forms.RadioButton radRetirement;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.GroupBox grpOccasion;
        private System.Windows.Forms.RadioButton radSize6;
        private System.Windows.Forms.RadioButton radSize8;
        private System.Windows.Forms.RadioButton radSize10;
        private System.Windows.Forms.RadioButton radSize12;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radPolkaDots;
        private System.Windows.Forms.RadioButton radEdibleImages;
        private System.Windows.Forms.RadioButton radFondantBow;
        private System.Windows.Forms.RadioButton rad3DFigures;
        private System.Windows.Forms.GroupBox grpDesign;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.GroupBox grpCakeType;
        private System.Windows.Forms.RadioButton radCharacterCake;
        private System.Windows.Forms.RadioButton radCustomCake;
        private System.Windows.Forms.ComboBox cmbCharacterCake;
        private System.Windows.Forms.Label lblChooseCharacterCake;
    }
}

