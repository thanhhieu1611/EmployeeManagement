using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class FormEMS : Form
    {
        #region Global Variables
        //Create a list of employee based on 3 seperate list
        //to use LINQ function
        List<Employee> employeeList;

        #endregion

        #region Initialization
        public FormEMS()
        {
            //Try-Catch errors for all methods
            try
            {
                InitializeComponent();
                createItemsForComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region Events
        //OnLoad event: Show the employee data from SQL database
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create 3 seperate list of Staff obj, Manager Obj, Intern obj
            //which have better performance than a long single Employeee list
            //when we work with big data
            List<Staff> staffList;
            List<Manager> managerList;
            List<Intern> internList;
            try
            {
                #region Getting Staff from DB
                //Create a new empty staff list
                staffList = new List<Staff>();

                //Get staffs from DB DataAdapter
                staffList = DataAdapter.GetStaffs();

                #endregion

                #region Getting Manager from DB
                //Create a new empty manager list
                managerList = new List<Manager>();

                //Get staffs from DB DataAdapter
                managerList = DataAdapter.GetManagers();

                #endregion

                #region Getting Intern from DB
                //Create a new empty intern list
                internList = new List<Intern>();

                //Get staffs from DB DataAdapter
                internList = DataAdapter.GetInterns();

                #region Update employeeList data
                //Create a new empty employee list
                employeeList = new List<Employee>();

                //Add data from staff, manager and intern lists
                employeeList.AddRange(staffList);
                employeeList.AddRange(managerList);
                employeeList.AddRange(internList);

                //Show on Employee listbox
                foreach (var emp in employeeList)
                {
                    listBoxEmployee.Items.Add(emp);
                }

                #endregion
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void comBoxEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get the employee type to show in Employee TextBox
                string empType = comBoxEmployeeType.SelectedItem.ToString();

                //Clear the Employee TextBox
                listBoxEmployee.Items.Clear();

                //Show the list of selected employee type
                //addEmployeeIntoEmployeeTextBox(empType);
                useLINQtoAddEmployeeIntoEmployeeListBox(empType);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void listBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Declare a string variable to get employee type
                string empType = null;

                //Check if the listbox have an selectedItem
                if(listBoxEmployee.SelectedItem != null) { 
                    empType = listBoxEmployee.SelectedItem.GetType().ToString().Substring(listBoxEmployee.SelectedItem.GetType().ToString().IndexOf('.') + 1);
                    //Clear the current employee Info
                    txtBoxEmpInfo.Clear();

                    //Show suitable employee infos based on its type
                    switch (empType)
                    {
                        case "Staff":
                            Staff myStaff = listBoxEmployee.SelectedItem as Staff;
                            txtBoxEmpInfo.AppendText(myStaff.ShowInfos());
                            break;
                        case "Manager":
                            Manager myManager = listBoxEmployee.SelectedItem as Manager;
                            txtBoxEmpInfo.AppendText(myManager.ShowInfos());
                            break;
                        case "Intern":
                            Intern myIntern = listBoxEmployee.SelectedItem as Intern;
                            txtBoxEmpInfo.AppendText(myIntern.ShowInfos());
                            break;
                        default:
                            MessageBox.Show("Employee Type is not listed!");
                            break;
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxEmployee.SelectedItem == null)
                {
                    MessageBox.Show("Please select an employee to remove!");
                }
                else
                {
                    //Get selected employee ID
                    Employee myEmp = listBoxEmployee.SelectedItem as Employee;
                    string empID = myEmp.employeeID.ToString();

                    //Get selected employee type
                    string empType = listBoxEmployee.SelectedItem.GetType().ToString().Substring(listBoxEmployee.SelectedItem.GetType().ToString().IndexOf('.') + 1);

                    //Declare a Message Dialog Box
                    DialogResult result = MessageBox.Show("Do you want to delete the selected employee?", caption: "DELETE OBJECT FROM DATABASE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.Yes)
                    {
                        //Delete the selected employee from listBox Employee
                        //This command create a warning 
                        //"object reference not set to an instance of an object"
                        listBoxEmployee.Items.Remove(myEmp);

                        //Delete the selected employee's info in Emp Info Text Box
                        txtBoxEmpInfo.Clear();

                        ////Delete selected employee from DB
                        //string message = DataAdapter.DeleteAnEmployee(empID, empType);
                        //MessageBox.Show(message);

                        //Delete the selected employee from its list
                        deleteEmployeeFromListBoxOfEmployee(empType, empID);

                    }
                }
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Methods
        //Create a list of items for combobox
        private void createItemsForComboBox()
        {
            //Declare a list of employee type in comboxBox
            string[] comboBoxItems = { "All", "Staff", "Manager", "Intern" };

            //Add into the combobox
            comBoxEmployeeType.Items.AddRange(comboBoxItems);
        }

        ////Add list of staffs only into the employee textbox
        //private void addEmployeeIntoEmployeeTextBox(string empType)
        //{
        //    switch (empType)
        //    {
        //        case "Staff":
        //            //Add staffs into the Employee TextBox
        //            foreach (var emp in staffList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            break;
        //        case "Manager":
        //            //Add managers into the Employee TextBox
        //            foreach (var emp in managerList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            break;
        //        case "Intern":
        //            //Add intern into the Employee TextBox
        //            foreach (var emp in internList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            break;
        //        case "All":
        //            //Add all employees into the Employee TextBox
        //            foreach (var emp in staffList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            foreach (var emp in managerList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            foreach (var emp in internList)
        //            {
        //                listBoxEmployee.Items.Add(emp);
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //Add list of staffs only into the employee textbox
        private void useLINQtoAddEmployeeIntoEmployeeListBox(string empType)
        {
            if(empType == "All")
            {
                //Add all employees into the Employee TextBox
                foreach (var emp in employeeList)
                {
                    listBoxEmployee.Items.Add(emp);
                }
            }
            else
            {
                //Select and Add employees with empType into the Employee ListBox
                var temList = employeeList.Where(emp => emp.position == empType);

                foreach (var emp in temList)
                {
                    listBoxEmployee.Items.Add(emp);
                }
            }
        }

        //Delete the selected employee from its list
        private void deleteEmployeeFromListBoxOfEmployee(string empType, string empID) 
        {
            foreach (Employee emp in employeeList)
            {
                if (emp.employeeID.ToString() == empID)
                {
                    employeeList.Remove(emp);
                    break;
                }
            }
        }
        #endregion


    }
}
