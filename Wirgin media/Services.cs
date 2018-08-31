using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirgin_media
{
    class Services
    {
        //Variables
        private int id;
        private string description,notes;
        private DateTime startDate, dateLastContacted;

        //Default constructor
        public Services()
        {

        }

        //Main constructor
        public Services(int inputId,string inputDescription,DateTime inputStartDate,DateTime inputDateLastContacted,string inputNotes)
        {
            id = inputId;
            description = inputDescription;
            startDate = inputStartDate;
            dateLastContacted = inputDateLastContacted;
            notes = inputNotes;
        }

        //Display
        public string[] Display()
        {
            string sId = string.Format("{0}",id);
            string sDescription = string.Format("{0}",description);
            string sStartDate = startDate.ToString("dd/MM/yyyy");
            string sDateLastContacted = dateLastContacted.ToString("dd/MM/yyyy");
            string sNotes = string.Format("{0}",notes);
            
            string[] output = new string[] {sId,sDescription,sStartDate,sDateLastContacted,sNotes};
            
            return output;
        }

        //Getters
        public int GetId()
        {
            return id;
        }
        public string GetDescription()
        {
            return description;
        }
        public DateTime GetStartDate()
        {
            return startDate;
        }
        public DateTime GetDateLastContacted()
        {
            return dateLastContacted;
        }
        public string GetNotes()
        {
            return notes;
        }

        //Setters
        public void SetId(int inputId)
        {
            id = inputId;
        }
        public void SetDescription(string inputDescription)
        {
            description = inputDescription;
        }
        public void SetStartDate(DateTime inputStartDate)
        {
            startDate = inputStartDate;
        }
        public void SetDateLastContacted(DateTime inputDateLastContacted)
        {
            dateLastContacted = inputDateLastContacted;
        }
        public void SetNotes(string inputNotes)
        {
            notes = inputNotes;
        }
    }
}
