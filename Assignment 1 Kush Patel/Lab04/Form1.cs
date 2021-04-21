using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Cake_Classes;

namespace Lab03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbCharacterCake.Text = "Minion Cake $40";
        }

        Cake c;
        Customer cus;
        Order o;
        CustomCake cc;
        CharacterCake characterc;

        


        private void btnOrder_Click(object sender, EventArgs e) {
            

            //to determine flavour
            string flav = "";
            if (radChocolate.Checked) {
                flav = radChocolate.Text;
            }else if (radVanilla.Checked) {
                flav = radVanilla.Text;
            }else if (radBanana.Checked) {
                flav = radBanana.Text;
            }
            else if (radLemonBerry.Checked) {
                flav = radLemonBerry.Text;
            }
            

            //to determine layers
            int lay = 0;
            if (radLayers2.Checked) {
                lay = 2;
            }else if (radLayers3.Checked) {
                lay = 3;
            }else if (radLayers4.Checked) {
                lay = 4;
            }
            else if (radLayers1.Checked){
                lay = 1;
            }


            //to determine occasion
            string occ = "";
            if (radAnniversary.Checked) {
                occ = radAnniversary.Text;
            }else if (radBirthday.Checked){
                occ = radBirthday.Text;
            }else if (radRetirement.Checked) {
                occ = radRetirement.Text;
            }else if (radWedding.Checked) {
                occ = radWedding.Text;
            }


            //to determine design
            string des = "";
            int designCost = 0;
            if (radPolkaDots.Checked) {
                des = radPolkaDots.Text;
                designCost = 5;
            }else if (radEdibleImages.Checked) {
                des = radEdibleImages.Text;
                designCost = 12;
            }else if (radFondantBow.Checked) {
                des = radFondantBow.Text;
                designCost = 10;
            }else if (rad3DFigures.Checked) {
                des = rad3DFigures.Text;
                designCost = 15;
            }


            //to determine size
            int s = 0;
            if (radSize6.Checked) {
                s = 6;
            }else if (radSize8.Checked) {
                s = 8;
            }else if (radSize10.Checked) {
                s = 10;
            }else if (radSize12.Checked) {
                s = 12;
            }

            cus = new Customer(txtFirstName.Text, txtLastName.Text);
            //o = new Order(c.calculateCakeCost(lay).ToString());


            //to check which type of cake it is
            /*
            if (occ != "" && des != "" && s != 0)
            {
                cc = new CustomCake(flav, lay, occ, des, s);
                o = new Order((cc.calculateCakeCost(lay, designCost, s).ToString()));
                lblThankYouMessage.Text = "Thank You" + cus.ToString() + "\n"
                    + cc.ToString() + "\n" 
                    + "Total Cost: $" + o.TotalCost;
            }
            else
            {
                c = new Cake(flav, lay);
                o = new Order(c.calculateCakeCost(lay).ToString());
                lblThankYouMessage.Text = "Thank You" + cus.ToString() + "\n"
                    + c.ToString() + "\n"
                    + "Total Cost: $" + o.TotalCost;
            }
            */

            //to check what cake it is
            if (radCustomCake.Checked) {
                cc = new CustomCake(flav, lay, occ, des, s);
                o = new Order((cc.calculateCakeCost(lay, designCost, s).ToString()));
                MessageBox.Show("Thank You" + cus.ToString() + "\n"
                    + cc.ToString() + "\n"
                    + "Total Cost: $" + o.TotalCost);
                
            }else
            {
                int cakeCost = 0;
                string cakeName = "";
                if(cmbCharacterCake.Text == "Minion Cake $40") {
                    cakeCost = 40;
                    cakeName = "Minion Cake";
                }else if(cmbCharacterCake.Text == "SuperHero Cake $35") {
                    cakeCost = 35;
                    cakeName = "SuperHero Cake";
                }else if(cmbCharacterCake.Text == "SuperGirl Cake $35") {
                    cakeCost = 35;
                    cakeName = "SuperGirl Cake";
                }else if(cmbCharacterCake.Text == "MotherGoose Cake $30") {
                    cakeCost = 30;
                    cakeName = "MotherGoose Cake";
                }
                characterc = new CharacterCake(flav, lay, cakeName, cakeCost);
                o = new Order((characterc.calculateCakeCost(cakeCost, lay)).ToString());
                MessageBox.Show("Thank you " + cus.ToString() + "\n" + characterc.ToString() + "\n" + "Total Cost: $" + o.TotalCost);
            }
            



            //lblThankYouMessage.Text = "Thank You " + txtFirstName.Text + " " + txtLastName.Text;



            /*lblThankYouMessage.Text = "Thank You \n" + cus.ToString()
                + "\nFlavour: " + c.Flavour
                + "\nLayers: " + c.Layers
                + "\nTotal Cost: $" + o.TotalCost;*/
            
            
            
            
            /* txtShowFlavour.Text = c.Flavour;
            txtShowQuantity.Text = o.Quantity.ToString();
            txtShowLayers.Text = c.Layers.ToString();
            txtTotal.Text = o.TotalCost; */

            //txtTotal.Text = ((((double)nudQnty.Value * 25) + ((double)nudLayers.Value * 5)) * 1.13).ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e) {
            
            txtFirstName.Text = "";
            txtLastName.Text = "";

            rad3DFigures.Checked = false;
            radAnniversary.Checked = false;
            radBanana.Checked = false;
            radBirthday.Checked = false;
            radChocolate.Checked = false;
            radEdibleImages.Checked = false;
            radFondantBow.Checked = false;
            radLayers1.Checked = false;
            radLayers2.Checked = false;
            radLayers3.Checked = false;
            radLayers4.Checked = false;
            radLemonBerry.Checked = false;
            radPolkaDots.Checked = false;
            radRetirement.Checked = false;
            radSize10.Checked = false;
            radSize12.Checked = false;
            radSize6.Checked = false;
            radSize8.Checked = false;
            radVanilla.Checked = false;
            radWedding.Checked = false;

            radCustomCake.Checked = false;
            radCharacterCake.Checked = false;
            cmbCharacterCake.Text = "";

            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void radCustomCake_CheckedChanged(object sender, EventArgs e)
        {
            grpCustomCake.Enabled = true;
            cmbCharacterCake.Enabled = false;
        }

        private void radCharacterCake_CheckedChanged(object sender, EventArgs e)
        {
            cmbCharacterCake.Enabled = true;
            grpCustomCake.Enabled = false;
        }
    }
}
