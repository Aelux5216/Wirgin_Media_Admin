using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Wirgin_media
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Declare customer array
        public ArrayList CustomersArray = new ArrayList();

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadtimeMethod();
        }

        //*****START OF RUNTIME METHODS*****//

        private void populateArray()
        {
            if (CustomersArray != null)
            {
                //Clear array before re-populating
                CustomersArray.Clear();
            }

            //Set up reader for txt file
            StreamReader populate;

            //Check if the txt file exists before trying to use
            try
            {
                populate = new StreamReader(@"./WirginData.txt");
            }

            catch
            {
                File.Create(@"./WirginData.txt").Dispose();
 
                populate = new StreamReader(@"./WirginData.txt");
                
                MessageBox.Show("Please add the correct database .txt file.{0} Continuing means the database will be blank and entries will need to be adding manually.",
                    Environment.NewLine);
            }
            
            string output;

            //Loop until reaches end of file when output becomes null
            while ((output = populate.ReadLine()) != null)
            {
                int id = Convert.ToInt32(output);
                string firstName = populate.ReadLine();
                string surname = populate.ReadLine();
                string address = populate.ReadLine();
                string postcode = populate.ReadLine();
                int noOfServices = Convert.ToInt32(populate.ReadLine());

                Services[] serviceArray = new Services[noOfServices];

                for (int i = 0; i < noOfServices; i++)  //Loop until reaches number of services
                {
                    int serviceId = Convert.ToInt32(populate.ReadLine());
                    string decription = populate.ReadLine();
                    DateTime startDate = Convert.ToDateTime(populate.ReadLine());
                    DateTime dateLastContacted = Convert.ToDateTime(populate.ReadLine());
                    string notes;

                    try  //If there isn't any notes on the service this will ensure that it gets set to blank instead of ending the while loop
                    {
                        notes = populate.ReadLine();
                    }

                    catch
                    {
                        notes = "";
                    }

                    Services newService = new Services(serviceId, decription, startDate.Date, dateLastContacted.Date, notes);  //Create a instance of a services 

                    serviceArray[i] = newService; //Add all services related to the customer to an array
                }

                Customers newCustomer = new Customers(id, firstName, surname, address, postcode, noOfServices, serviceArray); //Create an instance of customers adding in the service array 

                CustomersArray.Add(newCustomer); //Add each customer to the customers arraylist
            }

            populate.Close(); //Close the streamreader since i don't need this anymore

        }  //Setup the array

        private void loadCustomers()
        {
            //Add Customer names to listbox
            lstCustomers.Enabled = true;
            for (int i = 0; i < CustomersArray.Count; i++)  //-1 so when it loops it is on the next customer instead of the last service of a previous customer 
            {
                Customers tempCustomer = (Customers)CustomersArray[i]; //Cast array item as a customer type
                string customerName = string.Format("{0} {1}", tempCustomer.GetFirstName(), tempCustomer.GetSurname());
                lstCustomers.Items.Add(customerName); //Ass customer name to listbox
                lstCustomers.SelectedItem = null;
            }
        }  //Set up customer selection 

        private void txtCustomerSearch_GotFocus(object sender, EventArgs e)
        {
            txtCustomerSearch.Text = "";
            txtCustomerSearch.ForeColor = Color.Black;
        }  //Clear text when user clicks on the textbox

        private void txtServiceSearch_GotFocus(object sender, EventArgs e)
        {
            txtServiceSearch.Text = "";
            txtServiceSearch.ForeColor = Color.Black;
        }

        private void txtCustomerSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text == "")
            {
                txtCustomerSearch.Text = "Search";
                txtCustomerSearch.ForeColor = Color.Gray;
            }
        }  //When focus is lost add default text again
        
        private void txtServiceSearch_LostFocus(object sender, EventArgs e)
        {
            if (txtServiceSearch.Text == "")
            {
                txtServiceSearch.Text = "Search";
                txtServiceSearch.ForeColor = Color.Gray;
            }
        }

        private void setupDataGrids()
        {
            dgdCustomerDetails.RowCount = 1;
            dgdCustomerDetails.ColumnCount = 1;

            dgdCustomerDetails[0, 0].Value = "Nothing will be shown until a customer has been selected.";
            dgdCustomerDetails.CurrentCell = null;

            dgdServiceDetails.RowCount = 1;
            dgdServiceDetails.ColumnCount = 1;

            dgdServiceDetails[0, 0].Value = "Nothing will be shown until a service has been selected.";
            dgdServiceDetails.CurrentCell = null;
        }  //Set up inital sizes and default display text

        private void loadtimeMethod()
        {

            populateArray();  //Get data from text file and store in array
            loadCustomers();  //Set up listbox with customers 

            txtCustomerSearch.GotFocus += txtCustomerSearch_GotFocus; //Set up events to check if user has clicked on either box
            txtCustomerSearch.LostFocus += txtCustomerSearch_LostFocus; //When focus lost gray out and set to default text again

            txtServiceSearch.GotFocus += txtServiceSearch_GotFocus;  //Same as above except for with the other search box
            txtServiceSearch.LostFocus += txtServiceSearch_LostFocus;

            setupDataGrids();  //Set inital sizes and default text displays
        }  //Contains all the methods that need to run at loadtime

        //*****START OF USEFUL METHODS*****//

        private void clearAll()
        {
            dgdCustomerDetails.Enabled = false;
            dgdCustomerDetails.Rows.Clear();
            dgdCustomerDetails.Refresh();
            dgdCustomerDetails.ColumnCount = 1;      //Disable user input,set datagrid sizes, wipe everything, disable edit mode if it was previously in use 
            dgdCustomerDetails.RowCount = 1;         //Show default message telling user to select a custoemr first
            dgdCustomerDetails.CurrentCell = null;
            dgdCustomerDetails[0, 0].Value = "Nothing will be shown until a customer has been selected.";
            dgdCustomerDetails.DefaultCellStyle.ForeColor = Color.Gray;
            dgdCustomerDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgdCustomerDetails.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgdServiceDetails.Enabled = false;
            dgdServiceDetails.Rows.Clear();
            dgdServiceDetails.Refresh();
            dgdServiceDetails.ColumnCount = 1;  //The same as above jsut for service details rather than customer details 
            dgdServiceDetails.RowCount = 1;
            dgdServiceDetails.CurrentCell = null;
            dgdServiceDetails[0, 0].Value = "Nothing will be shown until a service has been selected.";
            dgdServiceDetails.DefaultCellStyle.ForeColor = Color.Gray;
            dgdServiceDetails.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgdServiceDetails.EditMode = DataGridViewEditMode.EditProgrammatically;

            lstServices.Items.Clear();
            lstServices.Items.Add("Nothing will be shown until a customer has been selected.");
            lstServices.Enabled = false;

            txtServiceSearch.Enabled = false;  //Disable until a customer has been selected

        }  //Clear and reset listboxes

        private void updateFile()
        {
            File.WriteAllText(@"../WirginData.txt", string.Empty); //Wipe the text file 

            StreamWriter writeArray = new StreamWriter(@"../WirginData.txt");

            foreach (Customers c in CustomersArray)
            {
                writeArray.WriteLine(Convert.ToString(c.GetId())); //Add every customer to the text document with their details
                writeArray.WriteLine(c.GetFirstName());
                writeArray.WriteLine(c.GetSurname());
                writeArray.WriteLine(c.GetAddress());
                writeArray.WriteLine(c.GetPostcode());
                writeArray.WriteLine(Convert.ToString(c.GetNoOfServices()));

                Services[] tempServicesArray = c.GetServices();  //Get services associated with the customer 

                try
                {
                    foreach (Services s in tempServicesArray)
                    {
                        writeArray.WriteLine(Convert.ToInt32(s.GetId()));  //Add every service and there details 
                        writeArray.WriteLine(s.GetDescription());
                        writeArray.WriteLine(s.GetStartDate().ToShortDateString());
                        writeArray.WriteLine(s.GetDateLastContacted().ToShortDateString());
                        writeArray.WriteLine(s.GetNotes());
                    }
                }

                catch  //If it is a new customer they won't have any services so skip adding services and move onto the next customer
                {
                    continue;
                }
            }

            writeArray.Close();  //When everything is added close the streamwriter
        }

        private void setUpAddCustomer()
        {
            if (dgdServiceDetails.EditMode == DataGridViewEditMode.EditOnEnter)  //Check if the user is adding a service and if so display a message 
            {
                MessageBox.Show("Please finish adding service before trying to add a customer");
            }

            else if (btnEditServiceConfirm.Enabled == true)
            {
                MessageBox.Show("Please finish editing the customer before trying to add another");
            }

            else
            {
                btnCustomerConfirm.Enabled = true;       //Allow user to click confirm button now
                btnEditCustomerConfirm.Enabled = false;
                lstCustomers.Enabled = false;            //Disable customer and service selection 
                lstServices.Enabled = false;

                clearAll();

                dgdCustomerDetails.Enabled = true;
                dgdCustomerDetails.DataSource = null;
                dgdCustomerDetails.Rows.Clear();
                dgdCustomerDetails.Refresh();          //Enable and clear items then add borders,set size of datagrid and allow user to edit fields.
                dgdCustomerDetails.ColumnCount = 1;
                dgdCustomerDetails.RowCount = 5;
                dgdCustomerDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                dgdCustomerDetails.DefaultCellStyle.ForeColor = Color.Black;
                dgdCustomerDetails.CurrentCell = null;

                dgdCustomerDetails.EditMode = DataGridViewEditMode.EditOnEnter;

            }
        }  //Clear datagrid and allow user add or change information

        private void addCustomerProcess()
        {
            Customers newCustomer = new Customers();

            newCustomer.SetId(Convert.ToInt32(dgdCustomerDetails.Rows[0].Cells[0].Value.ToString()));   //Go through rows adding to customer details
            newCustomer.SetFirstName(dgdCustomerDetails.Rows[1].Cells[0].Value.ToString());
            newCustomer.SetSurname(dgdCustomerDetails.Rows[2].Cells[0].Value.ToString());
            newCustomer.SetAddress(dgdCustomerDetails.Rows[3].Cells[0].Value.ToString());
            newCustomer.SetPostcode(dgdCustomerDetails.Rows[4].Cells[0].Value.ToString());
            newCustomer.SetNoOfServices(0);

            CustomersArray.Add(newCustomer);  //Add the new customer into the main array 

            btnCustomerConfirm.Enabled = false; //Disable the confirm button as user has been added now 

            updateFile();  //Add user to the text file

            MessageBox.Show("Customer added sucessfully");

            //Reset everything to default state
            lstCustomers.Items.Clear();
            
            lstServices.Items.Clear();

            clearAll();

            loadCustomers(); //Load in the new customer

        }

        private void setUpEditCustomer()
        {

            if (dgdCustomerDetails.EditMode == DataGridViewEditMode.EditOnEnter)
            {
                MessageBox.Show("Please finish adding customer before trying to edit another ");
            }

            else if (lstCustomers.SelectedItem == null)  //If no customer selected show error
            {
                MessageBox.Show("Please select the customer you wish to edit first");
            }


            else
            {
                btnCustomerConfirm.Enabled = false;
                btnEditCustomerConfirm.Enabled = true;
                lstCustomers.Enabled = false;            //Disable customer and service selection 
                lstServices.Enabled = false;

                clearAll();

                dgdCustomerDetails.Enabled = true;
                dgdCustomerDetails.DataSource = null;
                dgdCustomerDetails.Rows.Clear();
                dgdCustomerDetails.Refresh();          //Enable and clear items then add borders,set size of datagrid and allow user to edit fields.
                dgdCustomerDetails.ColumnCount = 1;
                dgdCustomerDetails.RowCount = 5;
                dgdCustomerDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                dgdCustomerDetails.DefaultCellStyle.ForeColor = Color.Black;
                dgdCustomerDetails.CurrentCell = null;

                dgdCustomerDetails.EditMode = DataGridViewEditMode.EditOnEnter;

                string selectedCustomer = lstCustomers.SelectedItem.ToString();

                foreach (Customers c in CustomersArray)   //Find the selected customer in the main array 
                {
                    string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());

                    if (selectedCustomer == currentCustomer)
                    {
                        for (int i = 0; i < c.Display().Length - 1; i++)
                        {
                            dgdCustomerDetails.Rows[i].Cells[0].Value = c.Display()[i].ToString();  //Get details of customer and output it in each row
                        }
                    }
                }
            }
        }  //Clear datagrid and load in details of the customer the user wants to edit

        private void editCustomerProcess()
        {
            Customers editedCustomer = new Customers();

            editedCustomer.SetId(Convert.ToInt32(dgdCustomerDetails.Rows[0].Cells[0].Value.ToString()));   //Go through rows adding to customer details
            editedCustomer.SetFirstName(dgdCustomerDetails.Rows[1].Cells[0].Value.ToString());
            editedCustomer.SetSurname(dgdCustomerDetails.Rows[2].Cells[0].Value.ToString());
            editedCustomer.SetAddress(dgdCustomerDetails.Rows[3].Cells[0].Value.ToString());
            editedCustomer.SetPostcode(dgdCustomerDetails.Rows[4].Cells[0].Value.ToString());

            string selectedCustomer = lstCustomers.SelectedItem.ToString();

            int index = -1;

            foreach (Customers c in CustomersArray)
            {
                index = index + 1;                     //Find location of customer in the main array

                string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());  //Find customer, set the same number of services 
                                                                                                      //as i am not adding or editing these
                if (selectedCustomer == currentCustomer)
                {
                    editedCustomer.SetNoOfServices(c.GetNoOfServices());  //Copy the existing services over 
                    editedCustomer.SetServices(c.GetServices());
                    break;
                }
            }

            CustomersArray[index] = editedCustomer;  //Add the new customer into the main array 

            btnEditCustomerConfirm.Enabled = false; //Disable the confirm button as user has been added now 

            updateFile();  //Add user to the text file

            MessageBox.Show("Customer Updated sucessfully");

            clearAll();

            lstCustomers.Items.Clear();

            loadCustomers(); //Load in the new customer
        }

        private void customerDeleteProcess()
        {
            if (btnCustomerConfirm.Enabled == true || btnEditCustomerConfirm.Enabled == true)
            {
                MessageBox.Show("Please finish adding or editing before trying to delete a customer");
            }

            else if (lstCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer first"); //Make sure a customer is selected
            }

            else
            {
                int index = -1;  //Set index to -1 since array starts at 0

                string selectedCustomer = lstCustomers.SelectedItem.ToString(); //Find out which customer is selected

                foreach (Customers c in CustomersArray)
                {
                    index = index + 1;  //Keep track of which customer is at which index location

                    string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());

                    if (selectedCustomer == currentCustomer)  //Check if the current customer is the one i am looking for
                    {
                        CustomersArray.RemoveAt(index);  //Remove the selected customer
                        updateFile();  //Update text file with changes
                        MessageBox.Show("Customer deleted successfully");  //tell the user that they have been removed
                        clearAll();
                        lstCustomers.Items.Clear();
                        loadCustomers();  //Reset everything to default and load the updated customers again 
                        break;
                    }
                }
            }
        }

        private void cancelAction()
        {
            if (lstCustomers.Enabled == true) //If customer selection is still avaliable it means no editing has been done and doesn't need to be cancelled
            {
                MessageBox.Show("No action has been performed that can be cancelled");
            }

            else
            {
                clearAll();
                lstCustomers.Enabled = true;
                lstCustomers.SelectedItem = null;
                btnCustomerConfirm.Enabled = false;
                btnEditCustomerConfirm.Enabled = false;
                btnServiceConfirm.Enabled = false;
                btnEditCustomerConfirm.Enabled = false;
            }
        }

        private bool customerValidation()
        {
            string errorList = "Please correct the following:";

            bool result = true;

            try
            {
                string testId = dgdCustomerDetails.Rows[0].Cells[0].Value.ToString();
                string testFirstName = dgdCustomerDetails.Rows[1].Cells[0].Value.ToString();
                string testSurname = dgdCustomerDetails.Rows[2].Cells[0].Value.ToString();
                string testAddress = dgdCustomerDetails.Rows[3].Cells[0].Value.ToString();
                string testPostcode = dgdCustomerDetails.Rows[4].Cells[0].Value.ToString();
            }
            catch
            {
                errorList = errorList + Environment.NewLine + "Please make sure no fields are empty";
                result = false;
            }

            string id = dgdCustomerDetails.Rows[0].Cells[0].Value.ToString();
            string firstName = dgdCustomerDetails.Rows[1].Cells[0].Value.ToString();
            string surname = dgdCustomerDetails.Rows[2].Cells[0].Value.ToString();
            string address = dgdCustomerDetails.Rows[3].Cells[0].Value.ToString();
            string postcode = dgdCustomerDetails.Rows[4].Cells[0].Value.ToString();

            if (id.Contains(" ") || id.Contains("."))  //Check to make sure id doesn't contain spaces or full stops
            {
                errorList = errorList + Environment.NewLine + "Customer id cannot contain spaces or full stops";
                result = false;
            }

            else
            {
                
                if (btnEditCustomerConfirm.Enabled == true)  //If trying to edit instead of add skip id verification 
                {

                }

                else
                {
                    foreach (Customers c in CustomersArray)
                    {
                        try     //Check if id contains letters
                        {
                            if (Convert.ToInt32(id) == c.GetId())  //Check if id is a duplicate 
                            {
                                errorList = errorList + Environment.NewLine + "Customer id already exists";
                                result = false;
                            }
                        }

                        catch
                        {
                            errorList = errorList + Environment.NewLine + "Customer id can only contain numbers";
                            result = false;
                        }
                    }
                }
            }


            if (id.Length != 5) //Check id to make sure it is the correct length 
            {
                errorList = errorList + Environment.NewLine + "Customer id can only be 5 characters long";
                result = false;
            }

            for (int i = 0; i < 10; i++)  //Check first name for numbers
            {
                if (firstName.Contains(i.ToString()))
                {
                    errorList = errorList + Environment.NewLine + "First name cannot contain numbers";
                    result = false;
                    break;
                }
            }

            if (firstName.Contains(" ") || firstName.Contains(".")) //Check first name for spaces and full stops
            {
                errorList = errorList + Environment.NewLine + "First name cannot contain spaces or full stops";
                result = false;
            }

            for (int i = 0; i < 10; i++)
            {
                if (surname.Contains(i.ToString())) //Check surname for numbers
                {
                    errorList = errorList + Environment.NewLine + "Surname cannot contain numbers";
                    result = false;
                    break;
                }
            }

            if (surname.Contains(" ") || surname.Contains("."))  //Check surname for spaces and full stops
            {
                errorList = errorList + Environment.NewLine + "Surname cannot contain spaces or full stops";
                result = false;
            }
            
            if (address.Contains(","))
            {

            }

            else
            {
                errorList = errorList + Environment.NewLine + "Address must contain a city";
                result = false;
            }
            
            if(postcode.Length > 7 || postcode.Contains(" ") || postcode.Contains ("."))
            {
                errorList = errorList + Environment.NewLine + "Postcode must be 7 or 8 character long with no spaces or full stops";
                result = false;
            }

            if (result == false)
            {
                MessageBox.Show(errorList);
                return result;
            }

            else
            {
                return result;
            }
        }  //Validate customer details fields

        private void setUpAddService()
        {
            if (dgdCustomerDetails.EditMode == DataGridViewEditMode.EditOnEnter)  //Check if user is adding a custoemr and if so show a message 
            {
                MessageBox.Show("Please finish adding customer before trying to add a service");
            }

            else if (lstCustomers.SelectedItem == null)   //Check that the user has selected which customer they want to edit
            {
                MessageBox.Show("Please select a customer before trying to add a new service");
            }

            else
            {

                btnServiceConfirm.Enabled = true;
                lstCustomers.Enabled = false; //Show confirm button since the adding process has begun 
                lstServices.Enabled = false; //Hide customer and service selection

                clearAll();

                dgdServiceDetails.Enabled = true;
                dgdServiceDetails.DataSource = null;
                dgdServiceDetails.Rows.Clear();
                dgdServiceDetails.Refresh();        //Enable details datagrid clear it set new sizes,add borders and allow user to edit fields
                dgdServiceDetails.ColumnCount = 1;
                dgdServiceDetails.RowCount = 5;
                dgdServiceDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                dgdServiceDetails.DefaultCellStyle.ForeColor = Color.Black;
                dgdServiceDetails.CurrentCell = null;

                dgdServiceDetails.EditMode = DataGridViewEditMode.EditOnEnter;
            }
        }

        private void addServiceProcess()
        {
            int index = -1;   //Set index to -1 since all arrays start at 0 

            foreach (Customers c in CustomersArray)
            {
                index = index + 1;  //Add one for each customer so i know where the customer is located in the array

                string customerName = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());
                string selectedName = lstCustomers.SelectedItem.ToString();

                if (selectedName == customerName)  //Check if customer name is the same as the customer the user has selected
                {

                    int id = Convert.ToInt32(dgdServiceDetails.Rows[0].Cells[0].Value);     //Grab entered values 
                    string description = dgdServiceDetails.Rows[1].Cells[0].Value.ToString();

                    string[] inputStartDate = dgdServiceDetails.Rows[2].Cells[0].Value.ToString().Split('/');

                    DateTime startDate = new DateTime(Convert.ToInt32(inputStartDate[2]), Convert.ToInt32(inputStartDate[1]), Convert.ToInt32(inputStartDate[0]));

                    string[] inputDateLastContacted = dgdServiceDetails.Rows[3].Cells[0].Value.ToString().Split('/');

                    DateTime dateLastContacted = new DateTime(Convert.ToInt32(inputDateLastContacted[2]), Convert.ToInt32(inputDateLastContacted[1]), Convert.ToInt32(inputDateLastContacted[0]));

                    string notes;

                    if (dgdServiceDetails.Rows[4].Cells[0].Value == null)
                    {
                        notes = "";
                    }

                    else
                    {
                        notes = dgdServiceDetails.Rows[4].Cells[0].Value.ToString();
                    }

                    Services newService = new Services(id, description, startDate.Date, dateLastContacted.Date, notes); //Create a new services instance using the user entered details

                    List<Services> tempServices = new List<Services>();  //Create a service list then add the new service to the list 
                    try
                    {
                        foreach (Services s in c.GetServices())
                        {
                            tempServices.Add(s);
                        }
                    }

                    catch  //If this is a new customer they wont have any services previously so this is just to catch that error and carry on regardless 
                    {

                    }

                    finally

                    {
                        c.SetNoOfServices(c.GetNoOfServices() + 1); //Add one to the no of services the customer has 
                        tempServices.Add(newService); //Add the new service to the list 

                        Services[] newServices = new Services[tempServices.Count]; //Create an array of services to add back into the customer class

                        for (int i = 0; i < tempServices.Count; i++)
                        {
                            newServices[i] = tempServices[i];   //Add the list items to the array 
                        }

                        c.SetServices(newServices); //Add services to the customer 

                        CustomersArray[index] = c;   //Replace the customer in the main array with the new services added  

                        updateFile(); //Update the text file with the new details 

                        MessageBox.Show("Service added successfully");

                        string previouslySelectedCustomer = lstCustomers.SelectedItem.ToString();

                        clearAll();  //Reset everything to default state 

                        lstCustomers.Items.Clear(); //Clear old customers

                        loadCustomers(); //Load customers with edited service

                        lstCustomers.SelectedItem = previouslySelectedCustomer; //Set to the last selected customer so services are shown again without user input

                        btnServiceConfirm.Enabled = false;  //Disable confirm button since they are done adding now 
                        lstCustomers.Enabled = true;        //Enable customer and service choices again 
                    }

                    break;
                }
            }
        }

        private void setUpEditService()
        {
            if (dgdCustomerDetails.EditMode == DataGridViewEditMode.EditOnEnter)
            {
                MessageBox.Show("Please finish adding customer before trying to edit a service");
            }

            if (btnServiceConfirm.Enabled == true)
            {
                MessageBox.Show("Please finish adding service before trying to edit another");
            }

            else if (lstServices.SelectedItem == null)  //If no service selected show error
            {
                MessageBox.Show("Please select the service you wish to edit first");
            }


            else
            {
                btnCustomerConfirm.Enabled = false;
                btnEditServiceConfirm.Enabled = true;
                lstCustomers.Enabled = false;            //Disable customer and service selection 
                lstServices.Enabled = false;

                string selectedService = lstServices.SelectedItem.ToString();

                editSelectedService = selectedService; //Set the value since it will be cleared now 

                clearAll();

                dgdServiceDetails.Enabled = true;
                dgdServiceDetails.DataSource = null;
                dgdServiceDetails.Rows.Clear();
                dgdServiceDetails.Refresh();          //Enable and clear items then add borders,set size of datagrid and allow user to edit fields.
                dgdServiceDetails.ColumnCount = 1;
                dgdServiceDetails.RowCount = 5;
                dgdServiceDetails.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
                dgdServiceDetails.DefaultCellStyle.ForeColor = Color.Black;
                dgdServiceDetails.CurrentCell = null;

                dgdServiceDetails.EditMode = DataGridViewEditMode.EditOnEnter;

                string selectedCustomer = lstCustomers.SelectedItem.ToString();

                foreach (Customers c in CustomersArray)   //Find the selected customer in the main array 
                {
                    string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());

                    if (selectedCustomer == currentCustomer) //Find the selected service in the customer
                    {
                        foreach(Services s in c.GetServices())
                        {
                            if (selectedService == s.GetDescription())
                            {
                                for (int i = 0; i < s.Display().Length; i++)
                                {
                                    dgdServiceDetails.Rows[i].Cells[0].Value = s.Display()[i].ToString();  //Get details of services and output it in each row
                                }
                            }
                        }
                    }
                }
            }
        }

        private string editSelectedService; //Used to store selected service as it gets wiped for another method 

        private void editServiceProcess()
        {

            Services editedService = new Services();  //Create blank service 

            editedService.SetId(Convert.ToInt32(dgdServiceDetails.Rows[0].Cells[0].Value.ToString()));   //Go through rows adding to service details
            editedService.SetDescription(dgdServiceDetails.Rows[1].Cells[0].Value.ToString());

            string[] inputStartDate = dgdServiceDetails.Rows[2].Cells[0].Value.ToString().Split('/');

            DateTime startDate = new DateTime(Convert.ToInt32(inputStartDate[2]), Convert.ToInt32(inputStartDate[1]), Convert.ToInt32(inputStartDate[0]));

            editedService.SetStartDate(startDate);

            string[] inputDateLastContacted = dgdServiceDetails.Rows[3].Cells[0].Value.ToString().Split('/');

            DateTime dateLastContacted = new DateTime(Convert.ToInt32(inputDateLastContacted[2]), Convert.ToInt32(inputDateLastContacted[1]), Convert.ToInt32(inputDateLastContacted[0]));

            editedService.SetDateLastContacted(dateLastContacted);
            editedService.SetNotes(dgdServiceDetails.Rows[4].Cells[0].Value.ToString());

            string selectedCustomer = lstCustomers.SelectedItem.ToString();

            string selectedService = editSelectedService;

            int customerIndex = -1;

            int serviceIndex = -1;

            Customers[] tempCustomers = (Customers[])CustomersArray.ToArray(typeof (Customers)); //Create copy to loop through 

            foreach (Customers c in tempCustomers)
            {
                customerIndex = customerIndex + 1;                //Find location of customer in the main array

                string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());  

                if (selectedCustomer == currentCustomer)
                {
                    foreach (Services s in c.GetServices())
                    {
                        serviceIndex = serviceIndex + 1;         //Find location of service in the customer class

                        if (selectedService == s.GetDescription())  //Loop through services until the one i am editing has been found
                        {
                            Customers editedCustomer = (Customers)CustomersArray[customerIndex]; //Grab all customer details and add them to a temp customer

                            Services[] editedServices = editedCustomer.GetServices();  //Geab all services from the customer

                            editedServices[serviceIndex] = editedService;  //Replace the old service with the edited one

                            CustomersArray[customerIndex] = editedCustomer;  //Replace the customer in main array with the edited one with new service details within
                            break;
                        }
                    }
                }
            }
            
            btnEditCustomerConfirm.Enabled = false; //Disable the confirm button as user has been added now 

            updateFile();  //Add user to the text file

            MessageBox.Show("Service Updated sucessfully");

            string previouslySelectedCustomer = lstCustomers.SelectedItem.ToString();

            clearAll();

            lstCustomers.Items.Clear();

            loadCustomers(); //Load in customers again but with updated service

            lstCustomers.SelectedItem = previouslySelectedCustomer; //Select the customer that was edited to show service results 
                                                                    //without user needing to select things again
        }

        private void serviceDeleteProcess()
        {
            if (btnCustomerConfirm.Enabled == true || btnEditCustomerConfirm.Enabled == true)
            {
                MessageBox.Show("Please finish adding or editing before trying to delete a customer"); //Check if the user is editing or adding a customer
            }

            if (btnCustomerConfirm.Enabled == true || btnEditCustomerConfirm.Enabled == true)
            {
                MessageBox.Show("Please finish adding or editing before trying to delete a service"); //Check if the user is editing or adding a service
            }

            else if (lstServices.SelectedItem == null)
            {
                MessageBox.Show("Please select a service first");  //Make sure a customer is selected
            }

            else
            {
                int customerIndex = -1;  //Set customer index to -1 since array starts at 0

                int serviceIndex = -1;  //Set service index to -1 for the same reason 

                string selectedCustomer = lstCustomers.SelectedItem.ToString(); //Find out which customer is selected

                foreach (Customers c in CustomersArray)
                {
                    customerIndex = customerIndex + 1;  //Keep track of which customer is at which location

                    Customers tempCustomer = c; 

                    string currentCustomer = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname());

                    if (selectedCustomer == currentCustomer)  //Check if the current customer is the one i am looking for
                    {
                        foreach (Services s in c.GetServices())
                        {
                            serviceIndex = serviceIndex + 1;  //Keep track of which service is at which location

                            string selectedService = lstServices.SelectedItem.ToString();

                            if (selectedService == s.GetDescription())  //Check if the service is the one i'm looking for 
                            {
                                ArrayList tempServicesArrayList = new ArrayList(c.GetServices()); //Get services and make an arraylist

                                tempServicesArrayList.RemoveAt(serviceIndex); //Remove the selected service from the arraylist copy

                                Services[] tempServicesArray = (Services[]) tempServicesArrayList.ToArray(typeof(Services)); //Convert the arraylist to an array of services

                                tempCustomer.SetServices(tempServicesArray); //Update the customer services

                                tempCustomer.SetNoOfServices(c.GetNoOfServices() - 1); //Update amount of services the customer has

                                CustomersArray[customerIndex] = tempCustomer; //Replace The customer with the updated one

                                updateFile();  //Update text file with changes
                                MessageBox.Show("Service deleted successfully");  //Tell the user that they have been removed

                                string previouslySelectedCustomer = lstCustomers.SelectedItem.ToString();

                                clearAll();
                                lstServices.Items.Clear();
                                lstCustomers.Items.Clear();
                                loadCustomers();  //Reset everything to default and load the updated customers again

                                lstCustomers.SelectedItem = previouslySelectedCustomer; //Load the last selected customer so services load and reflect results immediately 
                                return;
                            }
                        }
                    }
                }
            }
        }
        
        private bool serviceValidation()
        {

            string errorList = "Please correct the following:";

            bool result = true;

            try
            {
                string testId = dgdServiceDetails.Rows[0].Cells[0].Value.ToString();
                string testDescription = dgdServiceDetails.Rows[1].Cells[0].Value.ToString();
                string testStartDate = dgdServiceDetails.Rows[2].Cells[0].Value.ToString();
                string testDateLastContacted = dgdServiceDetails.Rows[3].Cells[0].Value.ToString();
            }
            catch
            {
                errorList = errorList + Environment.NewLine + "Please make sure no fields are empty";
                result = false;
            }

            string id = dgdServiceDetails.Rows[0].Cells[0].Value.ToString();
            
            try
            {
                DateTime startDate = Convert.ToDateTime(dgdServiceDetails.Rows[2].Cells[0].Value);
                DateTime dateLastContacted = Convert.ToDateTime(dgdServiceDetails.Rows[3].Cells[0].Value);
            }

            catch
            {
                errorList = errorList + Environment.NewLine + "Please make sure dates are valid";
                result = false;
            }
      
            try
            {
                int isIdNumber = Convert.ToInt32(id);
            }

            catch
            {
                errorList = errorList + Environment.NewLine + "Service id can only contain numbers";
            }

            if(id.Length != 4)
            {
                errorList = errorList + Environment.NewLine + "Service id must be 4 characters";
                result = false;
            }

            if(id.Contains(".") || id.Contains(" "))
            {
                errorList = errorList + Environment.NewLine + "Service id cannot contain full stops or spaces";
            }

            if (result == false)
            {
                MessageBox.Show(errorList);
                return result;
            }

            else
            {
                return result;
            }
        }  //Validate service details fields

        //*****START OF INDEX CHANGE METHODS*****//

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerSelectionChanged();
        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceSelectionChanged();
        }

        private void customerSelectionChanged()
        {
            try
            {
                string selectedName = lstCustomers.SelectedItem.ToString(); //Find out which customer is selected

                clearAll(); //Clear and reset listboxes

                txtServiceSearch.Enabled = true;  //Enable service searching since a customer has been selected

                lstServices.Items.Clear(); //Since clear all adds default line which would stay displayed without this

                dgdCustomerDetails.Rows.Clear();

                foreach (Customers c in CustomersArray)
                {
                    string customerName = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname()); //Put first and second names together 

                    if (selectedName == customerName) //Check if the current customer is the one im looking for
                    {
                        dgdCustomerDetails.DefaultCellStyle.ForeColor = Color.Black;
                        dgdCustomerDetails.Enabled = true; //Show details and customer services then allow user to choose a service
                        lstServices.Enabled = true;

                        foreach (string s in c.Display()) //Display contains an array of all the details as strings so i just
                        {
                            dgdCustomerDetails.Rows.Add(s); //loop and add new rows containing the customer details
                        }

                        try                                        //Test to see if the customer has any services and if they don't then it will skip this part
                        {
                            foreach (Services s in c.GetServices())
                            {
                                lstServices.Items.Add(s.GetDescription()); //Add the name of each service to the services dropdown 
                            }
                        }

                        catch
                        {
                            continue;
                        }

                        lstServices.SelectedItem = null;
                    }

                }
            }
            catch
            {

            }
        }

        private void serviceSelectionChanged()
        {
            dgdServiceDetails.Rows.Clear();
            dgdServiceDetails.Refresh();                  //Same as clear all method but only the part for services 
            dgdServiceDetails.ColumnCount = 1;
            dgdServiceDetails.Enabled = true;
            dgdServiceDetails.DefaultCellStyle.ForeColor = Color.Black;

            foreach (Customers c in CustomersArray)
            {
                string customerName = string.Format("{0} {1}", c.GetFirstName(), c.GetSurname()); //Put first and second names together 
                string selectedName = lstCustomers.SelectedItem.ToString(); //Find out which customer is selected

                if (lstServices.SelectedItem == null)
                {
                    return;
                }

                string selectedService = lstServices.SelectedItem.ToString(); //Find out which service is selected

                if (selectedName == customerName) //Check if the current customer is the one im looking for
                {
                    foreach (Services ser in c.GetServices())  //Get the array of services from the customer
                    {
                        string serviceName = ser.GetDescription();

                        if (selectedService == serviceName)   //Compare each service name to the selected one until it matches 
                        {
                            foreach (string s in ser.Display())  //Then get the array of details and add them to the services datagrid
                            {
                                dgdServiceDetails.Rows.Add(s);
                            }
                        }
                    }
                }
            }
        }

        private void txtCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerSearch.Text == "" || txtCustomerSearch.Text == "Search")  //If search field is blank or focus is lost reset customers 
            {
                lstCustomers.Items.Clear();
                loadCustomers();
            }

            else
            {
                ArrayList searchResults = new ArrayList();  //Create list of returned results and clear as this will be used serveral times
                searchResults.Clear();
                lstCustomers.Items.Clear(); //Clear customers after last result then reload all customers ready for the next search
                loadCustomers();

                for (int i = 0; i < lstCustomers.Items.Count; i++) //Search for phrase in each item within customers regardless of upper or lower case.
                {
                    if (lstCustomers.Items[i].ToString().ToLower().Contains(txtCustomerSearch.Text.ToLower()) || lstCustomers.Items[i].ToString().ToLower() == txtCustomerSearch.Text.ToLower())
                    {
                        searchResults.Add(lstCustomers.Items[i].ToString());  //Add any items that contain the phrase to the arraylist
                    }
                }

                lstCustomers.Items.Clear();  //Clear customer box and add the search results

                foreach (string s in searchResults)
                {
                    lstCustomers.Items.Add(s);
                }
            }

            if (dgdServiceDetails.Enabled == true || dgdCustomerDetails.Enabled == true)  //If the user selected a service or customer make sure everything is reset  
            {                                                                             //when searching as editing or deleting will cause exception errors
                clearAll();
            }

        }

        private void txtServiceSearch_TextChanged(object sender, EventArgs e)
        {
            
            if (txtServiceSearch.Text == "" || txtServiceSearch.Text == "Search")  //If search field is blank or focus is lost reset services 
            {
                lstServices.Items.Clear();

                string selectedCustomer = lstCustomers.SelectedItem.ToString();

                foreach (Customers c in CustomersArray)
                {
                    string currentCustomer = c.GetFirstName() + " " + c.GetSurname();

                    if (selectedCustomer == currentCustomer)
                    {
                        foreach (Services s in c.GetServices())
                        {
                            lstServices.Items.Add(s.GetDescription());
                        }
                    }
                }
            }

            else
            {
                ArrayList searchResults = new ArrayList();  //Create list of returned results and clear as this will be used serveral times
                searchResults.Clear();
                lstServices.Items.Clear(); //Clear services after last result then reload all services ready for the next search

                string selectedCustomer = lstCustomers.SelectedItem.ToString();

                foreach (Customers c in CustomersArray)
                {
                    string currentCustomer = c.GetFirstName() + " " + c.GetSurname();

                    if (selectedCustomer == currentCustomer)
                    {
                        foreach (Services s in c.GetServices())
                        {
                            lstServices.Items.Add(s.GetDescription());
                        }
                    }
                }

                for (int i = 0; i < lstServices.Items.Count; i++) //Search for phrase in each item within services regardless of upper or lower case.
                {
                    if (lstServices.Items[i].ToString().ToLower().Contains(txtServiceSearch.Text.ToLower()) || lstServices.Items[i].ToString().ToLower() == txtServiceSearch.Text.ToLower())
                    {
                        searchResults.Add(lstServices.Items[i].ToString());  //Add any items that contain the phrase to the arraylist
                    }
                }

                lstServices.Items.Clear();  //Clear services box and add the search results

                foreach (string s in searchResults)
                {
                    lstServices.Items.Add(s);
                }
            }

            if (dgdServiceDetails.EditMode == DataGridViewEditMode.EditOnEnter || dgdCustomerDetails.EditMode == DataGridViewEditMode.EditOnEnter)  //If the user selected a service or customer make sure everything is reset  
            {                                                                                                                                       //when searching as editing or deleting will cause exception errors
                string currentCustomer = lstCustomers.SelectedItem.ToString();  //Grab previous customer selection before wiping
                
                clearAll();

                txtServiceSearch.Enabled = true; //Enable serach as it is disabled by default

                loadCustomers();  

                for (int i = 0; i < lstCustomers.Items.Count; i++)  //Reload the customers and services ready to be searched
                {
                    if (lstCustomers.Items[i].ToString() == currentCustomer)
                    {
                        lstCustomers.SelectedItem = lstCustomers.Items[i];
                    }
                }
            }

        }

        //*****START OF CUSTOMER ACTION METHODS*****//

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            setUpAddCustomer();
        }

        private void btnCustomerConfirm_Click(object sender, EventArgs e)
        {
            if (customerValidation() == true) //Run validation check and if result is true add the customer
            {
                addCustomerProcess();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            setUpEditCustomer();
        }

        private void btnEditCustomerConfirm_Click(object sender, EventArgs e)
        {
            if (customerValidation() == true) //Run validation check and if result is true edit the customer
            {
                editCustomerProcess();
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            customerDeleteProcess();
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        //*****START OF SERVICE ACTION METHODS*****//

        private void btnAddService_Click(object sender, EventArgs e)
        {
            setUpAddService();
        }

        private void btnServiceConfirm_Click(object sender, EventArgs e)
        {
            if (serviceValidation() == true) //Run validation check and if result is true add the service
            {
                addServiceProcess();
            }
            
        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            setUpEditService();
        }

        private void btnEditServiceConfirm_Click(object sender, EventArgs e)
        {
            if (serviceValidation() == true) //Run validation check and if result is true edit the service
            {
                editServiceProcess();
            } 
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            serviceDeleteProcess();
        }

        private void btnServiceCancel_Click(object sender, EventArgs e)
        {
            cancelAction();
        }

        //*****START OF MISCELLANEOUS METHODS*****//

        private void frmMain_Click(object sender, EventArgs e) //When clicking away from search boxs remove focus by disabling and enabling them
        {
            txtCustomerSearch.Text = "Search";
            txtCustomerSearch.ForeColor = Color.Gray;
            txtCustomerSearch.Enabled = false;
            txtCustomerSearch.Enabled = true;

            if (lstCustomers.SelectedItem != null)  //Service search needs to stay disabled until customer is selected  
            {
                txtServiceSearch.Text = "Search";
                txtServiceSearch.ForeColor = Color.Gray;
                txtServiceSearch.Enabled = false;
                txtServiceSearch.Enabled = true;
            }
        }
        
    }
}