using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Wirgin_media
{
    class Customers
    {
        //Variables 
        private int id,noOfServices;
        private string firstName, surname, address, postcode;
        private Services[] servicesArray;

        //Default constructor
        public Customers()
        {

        }

        //Main constructor
        public Customers(int inputId, string inputFirstName,string inputSurname,string inputAddress,string inputPostcode,int inputNoOfServices,Services[] inputServices)
        {
            id = inputId;
            firstName = inputFirstName;
            surname = inputSurname;
            address = inputAddress;
            postcode = inputPostcode;
            noOfServices = inputNoOfServices;
            servicesArray = inputServices; 
        }

        //Display 
        public string[] Display()
        {
            //Format customer details then add to an array for easy listbox adding
            string sId = string.Format("{0}",id); 
            string sFirstName = string.Format("{0}", firstName);
            string sSurname = string.Format("{0}", surname); 
            string sAddress = string.Format("{0}", address);
            string sPostcode = string.Format("{0}", postcode);
            string sNoOfServices = string.Format("{0}", noOfServices);

            string[] output = new string[] {sId,sFirstName,sSurname,sAddress,sPostcode,sNoOfServices};
    
            return output; 
        }

        //Getters
        public int GetId()
        {
            return id;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetAddress()
        {
            return address;
        }
        public string GetPostcode()
        {
            return postcode;
        }
        public int GetNoOfServices()
        {
            return noOfServices;
        }
        public Services[] GetServices()
        {
            return servicesArray;
        }

        //Setters
        public void SetId(int inputId)
        {
            id = inputId;
        }
        public void SetFirstName(string inputFirstName)
        {
            firstName = inputFirstName;
        }
        public void SetSurname(string inputSurname)
        {
            surname = inputSurname;
        }
        public void SetAddress(string inputAddress)
        {
            address = inputAddress;
        }
        public void SetPostcode(string inputPostcode)
        {
            postcode = inputPostcode;
        }
        public void SetNoOfServices(int inputNoOfServices)
        {
            noOfServices = inputNoOfServices;
        }
        public void SetServices(Services[] inputServices)
        {
            servicesArray = inputServices;
        }
    }
    
}
