using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SOFT151_Coursework
{
    class FileServices
    {
        // Method used to error handle files
        public bool checkFile(string filePath, string action)
        {
            try
            {
                if (action == "read")
                {
                    StreamReader tstRead = new StreamReader(filePath);
                    tstRead.Close();
                }
                else
                {
                    StreamWriter tstWrite = new StreamWriter(filePath);
                    tstWrite.Close();
                }
            }
            catch (FileNotFoundException err)
            {
                MessageBox.Show("Your file has not been found! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (DirectoryNotFoundException err)
            {
                MessageBox.Show("Your directory has not been found! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (PathTooLongException err)
            {
                MessageBox.Show("Your specified file path is too long! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("There has been an error! Error Message: " + err.Message + "\nSorry for any inconvenience caused.");
                return false;
            }
            return true;
        }

        // Method used to read from file
        public void readFile(string filePath, List<Company> companies)
        {
            using (StreamReader mySR = new StreamReader(filePath))
            {
                while (mySR.Peek() > -1)
                {
                    // Load company data: MOVE TO SUB FUNCTION BELOW
                    int companyID = Convert.ToInt32(mySR.ReadLine());
                    string companyName = mySR.ReadLine();
                    string companyAddress = mySR.ReadLine();
                    string companyPostcode = mySR.ReadLine();
                    int numberOfCars = Convert.ToInt32(mySR.ReadLine());

                    Company newCompany = new Company(companyID, companyName, companyAddress, companyPostcode);

                    // Load car data: MOVE TO SUB FUNCTION BELOW
                    for (int i = 0; i < numberOfCars; i++)
                    {
                        int carID = Convert.ToInt32(mySR.ReadLine());

                        // Split the car make from the model 
                        string[] carMakeAndModel = mySR.ReadLine().Split(null);
                        string carMake = carMakeAndModel[0];
                        string carModel = carMakeAndModel[1];

                        string carReg = mySR.ReadLine();
                        string fuelType = mySR.ReadLine();
                        DateTime lastServiced = Convert.ToDateTime(mySR.ReadLine());
                        string comments = mySR.ReadLine();

                        // Add new car to company 
                        Car newCar = new Car(carID, carMake, carModel, carReg, fuelType, lastServiced, comments);
                        newCompany.AddNewCar(newCar);
                    }
                    companies.Add(newCompany);
                }
            }
        }

        // Subset of readFile (used to read company data)
        private void readCompanyData()
        {

        }

        // Subset of readFile (used to read a company's car data)
        private void readCarData()
        {

        }

        // Method used to write to file
        public void writeFile(string path)
        {

        }

        // Method called when the program closes due to unknown reason
        public void invokeAutoSave(string path)
        {

        }

        // Method used to autosave user data (called every 5 minutes if active)
        public void autoSave(string path)
        {

        }
    }
}
