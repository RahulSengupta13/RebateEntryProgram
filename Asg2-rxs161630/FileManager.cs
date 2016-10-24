using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Asg2_rxs161630
{
    //File manager for the application
    class FileManager
    {
        FileStream rebateEntry;
        //Function to check for the file on application execution
        public FileStream createOrOpenFile()
        {
            if (!File.Exists("CS6326Asg2.txt"))
            {
                rebateEntry = File.Create("CS6326Asg2.txt");
                return null;
            }
            else
            {
                rebateEntry = File.Open("CS6326Asg2.txt",FileMode.Open);
                return rebateEntry;
            }
        }
        //Function to write back into file on Application exit
        public void writeIntoFile(List<Record> list)
        {
            rebateEntry.Close();
            rebateEntry = File.Open("CS6326Asg2.txt", FileMode.Truncate);
            TextWriter writer = new StreamWriter(rebateEntry);
            foreach(Record entry in list)
            {
                writer.WriteLine(entry.firstName + "\t" +entry.middleInitial + "\t" +entry.lastName + "\t" +entry.AddressLine1 + "\t" +entry.AddressLine2 + "\t" +entry.city + "\t" +entry.state + "\t" +entry.zipcode + "\t" +entry.phone + "\t" +entry.dateReceived + "\t" +entry.timeEntryStarted + "\t" +entry.timeSaved + "\t" +entry.email + "\t" +entry.proofOfPurchase + "\t" + entry.onIdle.ToString() + "\t" +entry.onStart.ToString());
            }
            writer.Close();
        }

        //Function to release the file object
        public void closeFile()
        {
            rebateEntry.Close();
        }
    }
}
