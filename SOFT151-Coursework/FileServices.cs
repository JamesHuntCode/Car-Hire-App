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
        public bool readFile(string filePath, List<Company> companies)
        {
            using (StreamReader mySR = new StreamReader(filePath))
            {
                while (mySR.Peek() > -1)
                {
                    try
                    {
                        // Load company data
                        int companyID = Convert.ToInt32(mySR.ReadLine());
                        string companyName = mySR.ReadLine();
                        string companyAddress = mySR.ReadLine();
                        string companyPostcode = mySR.ReadLine();
                        int numberOfCars = Convert.ToInt32(mySR.ReadLine());

                        Company newCompany = new Company(companyID, companyName, companyAddress, companyPostcode);

                        // Load car data
                        for (int i = 0; i < numberOfCars; i++)
                        {
                            int carID = Convert.ToInt32(mySR.ReadLine());
                            string[] carMakeAndModel = mySR.ReadLine().Split(null); // Split the car make from the model 
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
                    catch (Exception err)
                    {
                        MessageBox.Show("Error detected! Error Code: " + err.Message + "\nSorry for any inconvenience caused.");
                        return false;
                    }
                }
                return true;
            }
        }

        // Method used to write to file
        public bool writeFile(string filePath, List<Company> companies)
        {
            using (StreamWriter mySW = new StreamWriter(filePath))
            {
                for (int i = 0; i < companies.Count; i++)
                {
                    try
                    {
                        // Write all company based information:
                        mySW.WriteLine(companies[i].GetId());
                        mySW.WriteLine(companies[i].GetName());
                        mySW.WriteLine(companies[i].GetAddress());
                        mySW.WriteLine(companies[i].GetPostcode());
                        mySW.WriteLine(companies[i].GetNumberOfCars());

                        for (int j = 0; j < companies[i].GetAllCars().Count; j++)
                        {
                            // Write all car based information:
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetId());
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetMake() + " " + companies[i].GetAllCars()[j].GetModel());
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetReg());
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetFuelType());
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetDateLastServiced());
                            mySW.WriteLine(companies[i].GetAllCars()[j].GetComments());
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Error Detected! Error Code: " + err.Message + "\nSorry for any inconvenience cased.");
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
