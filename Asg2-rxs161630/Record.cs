using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_rxs161630
{
    //Class for maintaining of individual records
    class Record
    {
        //Details of a customer
        public String firstName, lastName, middleInitial, AddressLine1, AddressLine2, city, state, phone, email, zipcode, dateReceived;
        public bool proofOfPurchase;
        public String timeEntryStarted, timeSaved;
        public DateTime onIdle, onStart;

        //Logic to check duplicacy while saving new entry
        public static bool checkDuplicacy(Record incomingRecord, List<Record> entryList)
        {
            foreach(Record entry in entryList)
            {
                if (entry.firstName.Equals(incomingRecord.firstName) && entry.lastName.Equals(incomingRecord.lastName) && entry.middleInitial.Equals(incomingRecord.middleInitial))
                    return true;
            }
            return false;
        }
        //Logic to check duplicacy while updating saved entry
        public static bool checkDuplicacyForUpdate(Record incomingRecord, List<Record> entryList,int index)
        {
            foreach (Record entry in entryList)
            {
                if (entry.firstName.Equals(incomingRecord.firstName) && entry.lastName.Equals(incomingRecord.lastName) && entry.middleInitial.Equals(incomingRecord.middleInitial) && entryList.IndexOf(entry)!=index)
                    return true;
            }
            return false;
        }
    }
}
