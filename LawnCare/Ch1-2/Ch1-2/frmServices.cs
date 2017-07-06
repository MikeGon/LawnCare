using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ch1_2
{
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
        }

        private void btnCalcBalance_Click(object sender, EventArgs e)
        {
     
            double serviceTotal = 0.0;
            double firstIndividualService = 0.0;
            double secondIndividualService = 0.0;
            double thirdIndividualService = 0.0;
            double fourthIndividualService = 0.0;
            double discount = 0.9;
            double mowHours;
            double trimHours;
            double sprayHours;
            double foliageHours;

            String[] servicesArray = new String[4];
            Double[] pricesArray = new Double[] {5, 5, 8, 10, serviceTotal};

            if (txtCustomerFirstName.Text == "" || txtCustomerLastName.Text == "")
            {
                MessageBox.Show("Please enter your name.");
            }
            else
            {
                if (chkMowLawn.Checked)
                {
                    if (double.TryParse(txtMowLawnHours.Text, out mowHours))
                    {
                        firstIndividualService = mowHours * pricesArray[0];
                        servicesArray[0] = firstIndividualService.ToString("c");

                        if (chkTrimLawn.Checked)
                        {
                            if (double.TryParse(txtTrimLawnHours.Text, out trimHours))
                            {
                                secondIndividualService = trimHours * pricesArray[1];
                                servicesArray[1] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (chkSpraying.Checked)
                                {
                                    if (double.TryParse(txtSprayingHours.Text, out sprayHours))
                                    {
                                        thirdIndividualService = sprayHours * pricesArray[2];
                                        servicesArray[2] = thirdIndividualService.ToString("c");
                                        pricesArray[4] += thirdIndividualService;
                                        if (chkTrimFoliage.Checked)
                                        {
                                            if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                                            {
                                                fourthIndividualService = foliageHours * pricesArray[3];
                                                servicesArray[3] = fourthIndividualService.ToString("c");
                                                pricesArray[4] += fourthIndividualService;
                                                if (pricesArray[4] > 200)
                                                {
                                                    
                                                    
                                                    pricesArray[4] *= discount;
                                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                                    txtCustomerLastName.Text + 
                                                    "\nMow Lawn: " + servicesArray[0] + 
                                                    "\nTrim Lawn: " + servicesArray[1] + 
                                                    "\nSpraying: " + servicesArray[2] + 
                                                    "\nTrim Trees and Shrubs: " + servicesArray[3] +
                                                    "\nBalance Due: " + pricesArray[4].ToString("c") + 
                                                    "\n\nYou got a 10% discount.");
                                                }
                                                else
                                                {
                                                    
                                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                                    txtCustomerLastName.Text +
                                                    "\nMow Lawn: " + servicesArray[0] + 
                                                    "\nTrim Lawn: " + servicesArray[1] + 
                                                    "\nSpraying: " + servicesArray[2] + 
                                                    "\nTrim Trees and Shrubs: " + servicesArray[3] +
                                                    "\nBalance Due: " + pricesArray[4].ToString("c"));
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid data entered.");
                                            }
                                        }
                                        else
                                        {
                                            if (pricesArray[4] > 200)
                                            {
                                                
                                                pricesArray[4] *= discount;
                                                MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                                txtCustomerLastName.Text + "\nMow Lawn: " +
                                                servicesArray[0] + "\nTrim Lawn: " +
                                                servicesArray[1] + "\nSpraying: " +
                                                servicesArray[2] + "\nBalance Due: " +
                                                pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                            }
                                            else
                                            {
                                                
                                                MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                                txtCustomerLastName.Text + "\nMow Lawn: " +
                                                servicesArray[0] + "\nTrim Lawn: " +
                                                servicesArray[1] + "\nSpraying: " +
                                                servicesArray[2] + "\nBalance Due: " +
                                                pricesArray[4].ToString("c"));
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid data entered.");
                                    }
                                }
                                else
                                {
                                    if (pricesArray[4] > 200)
                                    {
                                        Array.Sort(pricesArray);
                                        
                                        pricesArray[4] *= discount;
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + 
                                        "\nMow Lawn: " + servicesArray[0] + 
                                        "\nTrim Lawn: " + servicesArray[1] + 
                                        "\nBalance Due: " + pricesArray[4].ToString("c") +
                                        "\n\nYou got a 10% discount.");
                                    }
                                    else
                                    {
                                        Array.Sort(pricesArray);
                                        
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nMow Lawn: " +
                                        servicesArray[0] + "\nTrim Lawn: " +
                                        servicesArray[1] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c"));
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else if (chkSpraying.Checked)
                        {
                            if (double.TryParse(txtSprayingHours.Text, out sprayHours))
                            {
                                secondIndividualService = sprayHours * pricesArray[2];
                                servicesArray[2] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (chkTrimFoliage.Checked)
                                {
                                    if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                                    {
                                        thirdIndividualService = foliageHours * pricesArray[3];
                                        servicesArray[3] = thirdIndividualService.ToString("c");
                                        pricesArray[4] += thirdIndividualService;
                                        if (pricesArray[4] > 200)
                                        {
                                            
                                            
                                            pricesArray[4] *= discount;
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nMow Lawn: " +
                                            servicesArray[0] + "\nSpraying: " +
                                            servicesArray[2] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                        }
                                        else
                                        {
                                            
                                            
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nMow Lawn: " +
                                            servicesArray[0] + "\nSpraying: " +
                                            servicesArray[2] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c"));
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid data entered.");
                                    }
                                }
                                else
                                {
                                    if (pricesArray[4] > 200)
                                    {
                                                                                
                                        pricesArray[4] *= discount;
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nMow Lawn: " +
                                        servicesArray[0] + "\nSpraying: " +
                                        servicesArray[2] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                    }
                                    else
                                    {
                                                                                
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nMow Lawn: " +
                                        servicesArray[0] + "\nSpraying: " +
                                        servicesArray[2] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c"));
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else if (chkTrimFoliage.Checked)
                        {
                            if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                            {
                                secondIndividualService = foliageHours * pricesArray[3];
                                servicesArray[3] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (chkTrimLawn.Checked)
                                {
                                    if (double.TryParse(txtTrimLawnHours.Text, out trimHours))
                                    {
                                        thirdIndividualService = trimHours * pricesArray[1];
                                        servicesArray[2] = thirdIndividualService.ToString("c");
                                        pricesArray[4] += thirdIndividualService;
                                        if (pricesArray[4] > 200)
                                        {
                                            
                                            
                                            pricesArray[4] *= discount;
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nMow Lawn: " +
                                            servicesArray[0] + "\nTrim Lawn: " +
                                            servicesArray[1] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                        }
                                        else
                                        {
                                            
                                            
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nMow Lawn: " +
                                            servicesArray[0] + "\nTrim Lawn: " +
                                            servicesArray[1] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c"));
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid data entered.");
                                    }
                                }
                                else
                                {
                                    if (pricesArray[4] > 200)
                                    {
                                        
                                        
                                        pricesArray[4] *= discount;
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nMow Lawn: " +
                                        servicesArray[0] + "\nTrim Trees and Shrubs: " +
                                        servicesArray[3] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                    }
                                    else
                                    {
                                        
                                        
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nMow Lawn: " +
                                        servicesArray[0] + "\nTrim Trees and Shrubs: " +
                                        servicesArray[3] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c"));
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else
                        {
                            if (double.TryParse(txtMowLawnHours.Text, out mowHours))
                            {
                                firstIndividualService = mowHours * pricesArray[0];
                                servicesArray[0] = firstIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService;
                                if (firstIndividualService > 200)
                                {
                                    firstIndividualService *= discount;
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nMow Lawn: " +
                                    servicesArray[0] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                }
                                else
                                {
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nMow Lawn: " +
                                    servicesArray[0] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c"));
                                }
                            }
                        }
                    }
                        
                    

                    else
                    {
                        MessageBox.Show("Invalid data entered."); 

                    }
                }
                else if (chkTrimLawn.Checked)
                {
                    if (double.TryParse(txtTrimLawnHours.Text, out trimHours))
                    {
                        firstIndividualService = trimHours * pricesArray[1];
                        servicesArray[1] = firstIndividualService.ToString("c");
                        if (chkSpraying.Checked)
                        {
                            if (double.TryParse(txtSprayingHours.Text, out sprayHours))
                            {
                                secondIndividualService = sprayHours * pricesArray[2];
                                servicesArray[2] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (chkTrimFoliage.Checked)
                                {
                                    if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                                    {
                                        thirdIndividualService = foliageHours * pricesArray[3];
                                        servicesArray[3] = thirdIndividualService.ToString("c");
                                        pricesArray[4] += thirdIndividualService;
                                        if (pricesArray[4] > 200)
                                        {
                                            
                                            
                                            pricesArray[4] *= discount;
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nTrim Lawn: " +
                                            servicesArray[1] + "\nSpraying: " +
                                            servicesArray[2] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c") + "You got a 10% discount.");
                                        }
                                        else
                                        {
                                            
                                            
                                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                            txtCustomerLastName.Text + "\nTrim Lawn: " +
                                            servicesArray[1] + "\nSpraying: " +
                                            servicesArray[2] + "\nTrim Trees and Shrubs: " +
                                            servicesArray[3] + "\nBalance Due: " +
                                            pricesArray[4].ToString("c"));
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid data entered.");
                                    }
                                }
                                else
                                {
                                    if (pricesArray[4] > 200)
                                    {
                                        
                                        
                                        pricesArray[4] *= discount;
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nTrim Lawn: " +
                                        servicesArray[1] + "\nSpraying: " +
                                        servicesArray[2] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                    }
                                    else
                                    {
                                        
                                        
                                        MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                        txtCustomerLastName.Text + "\nTrim Lawn: " +
                                        servicesArray[1] + "\nSpraying: " +
                                        servicesArray[2] + "\nBalance Due: " +
                                        pricesArray[4].ToString("c"));
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else if (chkTrimFoliage.Checked)
                        {
                            if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                            {
                                secondIndividualService = foliageHours * pricesArray[3];
                                servicesArray[3] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (pricesArray[4] > 200)
                                {
                                    
                                    
                                    pricesArray[4] *= discount;
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nTrim Lawn: " +
                                    servicesArray[1] + "\nTrim Trees and Shrubs: " +
                                    servicesArray[3] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                }
                                else
                                {
                                    
                                    
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nTrim Lawn: " +
                                    servicesArray[1] + "\nTrim Trees and Shrubs: " +
                                    servicesArray[3] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c"));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else
                        {
                            if (double.TryParse(txtTrimLawnHours.Text, out trimHours))
                            {
                                firstIndividualService = trimHours * pricesArray[1];
                                servicesArray[1] = firstIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService;
                                if (firstIndividualService > 200)
                                {
                                    firstIndividualService *= discount;
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nTrim Lawn: " +
                                    servicesArray[1] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                }
                                else
                                {
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nTrim Lawn: " +
                                    servicesArray[1] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c"));
                                }
                            }
                        }
                    }
                    

                    else
                    {
                        MessageBox.Show("Invalid data entered.");
                    }
                }
                else if (chkSpraying.Checked)
                {
                    if (double.TryParse(txtSprayingHours.Text, out sprayHours))
                    {
                        firstIndividualService = sprayHours * pricesArray[2];
                        servicesArray[2] = firstIndividualService.ToString("c");
                        if (chkTrimFoliage.Checked)
                        {
                            if (double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                            {
                                secondIndividualService = foliageHours * pricesArray[3];
                                servicesArray[3] = secondIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService + secondIndividualService;
                                if (pricesArray[4] > 200)
                           {
                                    
                                    
                                    pricesArray[4] *= discount;
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nSpraying: " +
                                    servicesArray[2] + "\nTrim Trees and Foliage: " +
                                    servicesArray[3] + "\nBalances Due: " +
                                    pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                }
                                else
                                {
                                    
                                    
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nSpraying: " +
                                    servicesArray[2] + "\nTrim Trees and Foliage: " +
                                    servicesArray[3] + "\nBalances Due: " +
                                    pricesArray[4].ToString("c"));
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid data entered.");
                            }
                        }
                        else
                        {
                            if (double.TryParse(txtSprayingHours.Text, out sprayHours))
                            {
                                firstIndividualService = sprayHours * pricesArray[2];
                                servicesArray[2] = firstIndividualService.ToString("c");
                                pricesArray[4] = firstIndividualService;
                                if (firstIndividualService > 200)
                                {

                                    firstIndividualService *= discount;
                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nSpraying: " +
                                    servicesArray[2] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                                }
                                else
                                {


                                    MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                                    txtCustomerLastName.Text + "\nSpraying: " +
                                    servicesArray[2] + "\nBalance Due: " +
                                    pricesArray[4].ToString("c"));
                                }
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid data entered.");
                    }
                }    
                else if (chkTrimFoliage.Checked)
                {
                    if(double.TryParse(txtTrimFoliageHours.Text, out foliageHours))
                    {
                        firstIndividualService = foliageHours * pricesArray[3];
                        servicesArray[3] = firstIndividualService.ToString("c");
                        pricesArray[4] = firstIndividualService;
                        if (firstIndividualService > 200)
                        {
                                                        
                            firstIndividualService *= discount;
                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                            txtCustomerLastName.Text + "\nTrim Trees and Foliage: " +
                            servicesArray[3] + "\nBalance Due: " +
                            pricesArray[4].ToString("c") + "\n\nYou got a 10% discount.");
                        }
                        else
                        {
                                                        
                            MessageBox.Show("Customer: " + txtCustomerFirstName.Text + " " +
                            txtCustomerLastName.Text + "\nTrim Trees and Foliage: " +
                            servicesArray[3] + "\nBalance Due: " +
                            pricesArray[4].ToString("c"));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid data entered.");
                    }
                }

            }
        }

        private void frmServices_Load(object sender, EventArgs e)
        {

        }

        private void sortArrays(ref String[] servicesArray, ref Double[] pricesArray)
       {
            Array.Sort(pricesArray);
            Array.Sort(servicesArray);
        }
    }
}
