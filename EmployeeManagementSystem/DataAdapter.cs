using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Connect to SQL Client library
using System.Data.SqlClient;
//Connect to Array List collection
using System.Collections;

namespace EmployeeManagementSystem
{
    /// <summary>
    /// Static Class
    /// Used to interact with SQL server
    /// </summary>
    static class DataAdapter
    {
        #region GLOBAL DECLARATION
        //Create a sqlConnection obj to connec tot DB
        //Data Source: server
        //Initial Catalog: name of the DB
        //Integrated Security is Window Authentication and no userName/password required????????
        static SqlConnection oConn = new SqlConnection("Data Source=cis.ckwia8qkgyyj.us-east-1.rds.amazonaws.com ; Initial Catalog=hd0917093 ; User ID=hd0917093 ; Password=917093 ");
        
        //Declare lists of DB objects
        static List<Intern> interns;
        static List<Manager> managers;
        static List<Staff> staffs;

        #endregion

        #region SQL SERVER FUNCTIONS
        //Methods to connect to the DB
        public static void Initialize()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //Method to disconnect from the DB
        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        #region DATABASE FUNCTIONs
        //Queries the DB and return a set of staff objects
        public static List<Staff> GetStaffs()
        {
            staffs = new List<Staff>();

            //New transaction to execute the SELECT query
            string sqlSelect = "SELECT * FROM Employee JOIN Staff ON Employee.EmpID = Staff.EmpID";

            //Create a sqlCommand object
            SqlCommand cmdSelect = new SqlCommand(sqlSelect, oConn);

            //Open connection
            Initialize();

            //Setup a sqlReader to receive the query respond from the DB
            SqlDataReader readerSelect = cmdSelect.ExecuteReader();

            //Declare a Staff object
            Staff myStaff;

            //Read() method will read the current record and advance us to the next record
            //While will be false when there is no more record
            while (readerSelect.Read())
            {
                //Get new myStaff from the readerSelect sqlReader
                myStaff = new Staff(Convert.ToInt32(readerSelect["EmpID"]),
                                    readerSelect["FirstName"].ToString(),
                                    readerSelect["LastName"].ToString(),
                                    readerSelect["StreetAddr"].ToString(),
                                    readerSelect["City"].ToString(),
                                    readerSelect["State"].ToString(),
                                    Convert.ToInt32(readerSelect["Zip"]),
                                    Convert.ToDateTime(readerSelect["DOB"]),
                                    Convert.ToDateTime(readerSelect["HireDate"]),
                                    Convert.ToDouble(readerSelect["PayRate"]),
                                    readerSelect["Position"].ToString(),
                                    Convert.ToBoolean(readerSelect["HasBenefit"]),
                                    readerSelect["OfficeLocation"].ToString(),
                                    readerSelect["Dept"].ToString(),
                                    Convert.ToDouble(readerSelect["HoursAllowed"]),
                                    Convert.ToDouble(readerSelect["VacationDays"])
                                    );
                
                //Add a new staff into staff list
                staffs.Add(myStaff);
            }

            //Disconnect to the server
            Disconnect();

            return staffs;
        }

        //Queries the DB and return a set of manager objects
        public static List<Manager> GetManagers()
        {
            managers = new List<Manager>();

            //New transaction to execute the SELECT query
            string sqlSelect = "SELECT * FROM Employee JOIN Manager ON Employee.EmpID = Manager.EmpID";

            //Create a sqlCommand object
            SqlCommand cmdSelect = new SqlCommand(sqlSelect, oConn);

            //Open connection
            Initialize();

            //Setup a sqlReader to receive the query respond from the DB
            SqlDataReader readerSelect = cmdSelect.ExecuteReader();

            //Declare a Staff object
            Manager myManager;
            //Read() method will read the current record and advance us to the next record
            //While will be false when there is no more record
            while (readerSelect.Read())
            {
                //Get new myManager from the readerSelect sqlReader
                myManager = new Manager(Convert.ToInt32(readerSelect["EmpID"]),
                                    readerSelect["FirstName"].ToString(),
                                    readerSelect["LastName"].ToString(),
                                    readerSelect["StreetAddr"].ToString(),
                                    readerSelect["City"].ToString(),
                                    readerSelect["State"].ToString(),
                                    Convert.ToInt32(readerSelect["Zip"]),
                                    Convert.ToDateTime(readerSelect["DOB"]),
                                    Convert.ToDateTime(readerSelect["HireDate"]),
                                    Convert.ToDouble(readerSelect["PayRate"]),
                                    readerSelect["Position"].ToString(),
                                    Convert.ToBoolean(readerSelect["HasBenefit"]),
                                    readerSelect["OfficeLocation"].ToString(),
                                    readerSelect["Dept"].ToString(),
                                    readerSelect["AdminAssist"].ToString(),
                                    Convert.ToDouble(readerSelect["VacationDays"]),
                                    Convert.ToInt32(readerSelect["ParkingSpot"])
                                    );

                //Add a new staff into staff list
                managers.Add(myManager);
            }

            //Disconnect to the server
            Disconnect();

            return managers;

        }

        //Queries the DB and return a set of manager objects
        public static List<Intern> GetInterns()
        {
            interns = new List<Intern>();

            //New transaction to execute the SELECT query
            string sqlSelect = "SELECT * FROM Employee JOIN Intern ON Employee.EmpID = Intern.EmpID";

            //Create a sqlCommand object
            SqlCommand cmdSelect = new SqlCommand(sqlSelect, oConn);

            //Open connection
            Initialize();

            //Setup a sqlReader to receive the query respond from the DB
            SqlDataReader readerSelect = cmdSelect.ExecuteReader();

            //Declare a Staff object
            Intern myIntern;
            //Read() method will read the current record and advance us to the next record
            //While will be false when there is no more record
            while (readerSelect.Read())
            {
                //Get new myManager from the readerSelect sqlReader
                myIntern = new Intern(Convert.ToInt32(readerSelect["EmpID"]),
                                    readerSelect["FirstName"].ToString(),
                                    readerSelect["LastName"].ToString(),
                                    readerSelect["StreetAddr"].ToString(),
                                    readerSelect["City"].ToString(),
                                    readerSelect["State"].ToString(),
                                    Convert.ToInt32(readerSelect["Zip"]),
                                    Convert.ToDateTime(readerSelect["DOB"]),
                                    Convert.ToDateTime(readerSelect["HireDate"]),
                                    Convert.ToDouble(readerSelect["PayRate"]),
                                    readerSelect["Position"].ToString(),
                                    Convert.ToBoolean(readerSelect["HasBenefit"]),
                                    Convert.ToBoolean(readerSelect["IsPaid"]),
                                    Convert.ToDateTime(readerSelect["BeginningTime"]),
                                    Convert.ToDateTime(readerSelect["EndTime"]),
                                    readerSelect["Major"].ToString(),
                                    readerSelect["School"].ToString()
                                    );

                //Add a new staff into staff list
                interns.Add(myIntern);
            }

            //Disconnect to the server
            Disconnect();

            return interns;

        }
        
        //Delete a staff from DB
        public static string DeleteAnEmployee(string empID, string empType)
        {
            string sqlDelete;
            string sqlDelete1;

            sqlDelete = "DELETE Employee FROM Employee WHERE Employee.EmpID = @id";

            //sql delete
            switch (empType)
            {
                case "Staff":              
                    sqlDelete1 = "DELETE Staff FROM Staff WHERE Staff.EmpID = @id";
                    break;
                case "Manager":
                    sqlDelete1 = "DELETE Manager FROM Manager WHERE Manager.EmpID = @id";
                    break;
                case "Intern":
                    sqlDelete1 = "DELETE Intern FROM Intern WHERE Intern.EmpID = @id";
                    break;
                default:
                    sqlDelete1 = "";
                    break;
            }
            
            if(sqlDelete1 == "")
            {
                return "Can not delete the selected employee";
            }
            else
            {
                //Create sqlCommand object
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, oConn);
                SqlCommand cmdDelete1 = new SqlCommand(sqlDelete1, oConn);

                //Add the parametter
                cmdDelete.Parameters.AddWithValue("@id", empID);
                cmdDelete1.Parameters.AddWithValue("@id", empID);

                //open connection
                Initialize();

                try
                {
                    cmdDelete.ExecuteNonQuery();
                    cmdDelete1.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                finally
                {
                    Disconnect();
                }

                return "Delete Successful";
            }
            
        }
        #endregion
    }
}
