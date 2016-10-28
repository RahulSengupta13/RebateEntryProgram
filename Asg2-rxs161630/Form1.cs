/*=============================================================================
 |   Assignment:  CS6326 Assignment 2
 |       Author:  Rahul Sengupta 
 |     Language:  C#
 |        Class:  Human Computer Interaction
 |
 +-----------------------------------------------------------------------------
 |
 |  Description:  A record entry application to be used by a data entry specialist.
 |
 |        Input:  The program takes in the First Name, Last Name, Middle Initials, Address[Line1, Line2, City, State, ZipCode], Phone Number,
 |                Email-ID, Proof-of-Purchase[Y/N] and Date Received of a customer as inputs.
 |
 |       Output:  The programs maintains the records by allowsing the clerk to view, update and delete the record, and also stores the data in a text file.
 |
 |    Algorithm:  -
 |
 |   Required Features Not Included:  -
 |
 |   Known Bugs:  -
 |
 *===========================================================================*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg2_rxs161630
{
    public partial class Form1 : Form
    {
        //Class Variables
        FileManager fm = new FileManager();
        //Decleration of In-Memory List
        List<Record> entryList = new List<Record>();
        FileStream previousEntries;
        static string startTimeOfEntry;
        //Used for sorting the columns
        private ListViewColumnSorter lvwColumnSorter;

        private DateTime onIdle;
        private DateTime onStart;
        public Form1()
        {
            InitializeComponent();
            //assign the sorter
            lvwColumnSorter = new ListViewColumnSorter();
            this.list_display.ListViewItemSorter = lvwColumnSorter;
            btn_newEntry.Select();

            //prepare onIdle
            onIdle = DateTime.Now;
            
            //Prepare the application with data from the file
            disableControls();
            previousEntries = fm.createOrOpenFile();
            if(previousEntries!=null)
            {
                TextReader reader = new StreamReader(previousEntries);
                String entry;
                while ((entry = reader.ReadLine()) != null)
                {
                    String[] fields = entry.Split('\t');
                    String fullName = fields[0] + " " + fields[1] + " " + fields[2];
                    String phone = fields[8];
                    ListViewItem lvi = new ListViewItem(fullName);
                    lvi.SubItems.Add(phone);
                    list_display.Items.Add(lvi);
                    bool pop;
                    Boolean.TryParse(fields[13], out pop);
                    //Updating the in-memory list
                    entryList.Add(new Record
                    {
                        firstName = fields[0],
                        middleInitial = fields[1],
                        lastName = fields[2],
                        AddressLine1 = fields[3],
                        AddressLine2 = fields[4],
                        city = fields[5],
                        state = fields[6],
                        zipcode = fields[7],
                        phone = fields[8],
                        dateReceived = fields[9],
                        timeEntryStarted = fields[10],
                        timeSaved = fields[11],
                        email = fields[12],
                        proofOfPurchase = pop
                    });
                    changeStatus(Color.OrangeRed, "Updating Entries");
                }
                changeStatus(Color.Green, "Ready");
                updateNumberOfEntries();
            }
        }
        
        //Adjusting the Form based on resolution
        private void Form1_Load(object sender, EventArgs e)
        {
            int iHeight = Screen.PrimaryScreen.WorkingArea.Height - this.Height;
            this.Height += iHeight;
            this.CenterToScreen();
        }

        //Functionality of Save/Update Records Button
        private void btn_save_Click(object sender, EventArgs e)
        {
            changeStatus(Color.Green, "Ready");
            //If updating record
            if (btn_save.Text.Equals("Update Record"))
            {
                if (list_display.SelectedItems.Count > 0)
                {
                    //prepare onIdle
                    onIdle = DateTime.Now;

                    String[] name = list_display.SelectedItems[0].SubItems[0].Text.Split(' ');
                    int index = returnIndex(name);
                    //Check for duplicacy while updating
                    Record record = new Record
                    {
                        firstName = txt_fname.Text,
                        middleInitial = txt_mi.Text,
                        lastName = txt_lname.Text
                    };
                    if (Record.checkDuplicacyForUpdate(record, entryList, index))
                    {
                        MessageBox.Show("There is an existing entry with the same name.", "Error updating details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //Update the record
                    entryList[index].firstName = txt_fname.Text;
                    entryList[index].lastName = txt_lname.Text;
                    entryList[index].middleInitial = txt_mi.Text;
                    entryList[index].AddressLine1 = txt_addline1.Text;
                    entryList[index].AddressLine2 = txt_addline2.Text;
                    entryList[index].city = txt_city.Text;
                    entryList[index].email = txt_email.Text;
                    entryList[index].zipcode = txt_zipcode.Text;
                    entryList[index].state = txt_state.Text;
                    entryList[index].phone = txt_phone.Text;
                    entryList[index].proofOfPurchase = rd_no.Checked ? false : true;
                    list_display.SelectedItems[0].SubItems[0].Text = txt_fname.Text + " " + txt_mi.Text + " " + txt_lname.Text;
                    list_display.SelectedItems[0].SubItems[1].Text = txt_phone.Text;
                    //House Keeping Function calls
                    clearControls();
                    btn_save.Text = "Save";
                    btn_newEntry.Text = "New Entry";
                    disableControls();
                    list_display.Select();
                    btn_delete.Enabled = false;
                    if (this.list_display.SelectedIndices.Count > 0)
                        foreach (ListViewItem item in list_display.SelectedItems)
                        {
                            item.Selected = false;
                        }
                    return;
                }
            }
            //If creating new record
            Record newRecord = new Record();
            newRecord.firstName = txt_fname.Text;
            newRecord.lastName = txt_lname.Text;
            newRecord.middleInitial = txt_mi.Text;
            newRecord.AddressLine1 = txt_addline1.Text;
            newRecord.AddressLine2 = txt_addline2.Text;
            newRecord.city = txt_city.Text;
            newRecord.email = txt_email.Text;
            newRecord.zipcode = txt_zipcode.Text;
            newRecord.state = txt_state.Text;
            newRecord.phone = txt_phone.Text;
            newRecord.dateReceived = txt_date.Text;
            newRecord.proofOfPurchase = rd_no.Checked ? false : true;
            newRecord.timeSaved = DateTime.Now.ToString();
            newRecord.timeEntryStarted = startTimeOfEntry;

            newRecord.onIdle = onIdle;
            newRecord.onStart = onStart;
            //Check for duplicacy or invalidity
            bool duplicate = Record.checkDuplicacy(newRecord,entryList);
            if(duplicate)
            {
                MessageBox.Show("There is an existing entry with the same name.","Error saving details",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            //Adding record to the in-memory list
            entryList.Add(newRecord);
            //Adding to listview
            ListViewItem lvi = new ListViewItem(newRecord.firstName + " " + newRecord.middleInitial + " " +newRecord.lastName);
            lvi.SubItems.Add(newRecord.phone);
            list_display.Items.Add(lvi);
            //prepare onIdle
            onIdle = DateTime.Now;
            //House Keeping Function calls
            clearControls();
            list_display.Enabled = true;
            btn_newEntry.Text = "New Entry";
            disableControls();
            updateNumberOfEntries();
        }

        //Button for New Entry
        private void btn_newEntry_Click(object sender, EventArgs e)
        {
            //If New Entry was clicked
            if (btn_newEntry.Text.Equals("New Entry"))
            {
                changeStatus(Color.Yellow, "Entering record");
                btn_newEntry.Text = "Discard";
                clearControls();
                enableControls();
                list_display.Enabled = false;
                DateTime date = DateTime.Today;
                txt_date.Text = date.ToShortDateString();
                txt_fname.Focus();
                startTimeOfEntry = DateTime.Now.ToString();
                onStart = DateTime.Now;
                return;
            }
            //If Discard was Clicked
            else
            {
                //Update the status
                changeStatus(Color.Green, "Ready");
                clearControls();
                disableControls();
                btn_delete.Enabled = false;
                if (this.list_display.SelectedIndices.Count > 0)
                    foreach (ListViewItem item in list_display.SelectedItems)
                    {
                        item.Selected = false;
                    }
                list_display.Enabled = true;
                btn_newEntry.Text = "New Entry";
                btn_save.Text = "Save";
                //prepare onIdle
                onIdle = DateTime.Now;
            }
        }
        
        //Functionality for Delete Button
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(list_display.SelectedItems.Count>0)
            {
                //prepare onIdle
                onIdle = DateTime.Now;
                String[] name = list_display.SelectedItems[0].SubItems[0].Text.Split(' ');
                int indexForList = returnIndex(name);
                entryList.RemoveAt(indexForList);
                int index = list_display.SelectedIndices[0];
                list_display.SelectedItems[0].Remove();
                clearControls();
                disableControls();
                updateNumberOfEntries();
            }
        }

        //Functionality for clicking on a row in the list view
        private void list_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_display.SelectedItems.Count > 0)
            {
                changeStatus(Color.OrangeRed, "Updating record");
                String[] name = list_display.SelectedItems[0].SubItems[0].Text.Split(' ');
                int index = returnIndex(name);
                Record selectedRecord = entryList[index];
                txt_fname.Text = selectedRecord.firstName;
                txt_mi.Text = selectedRecord.middleInitial;
                txt_lname.Text = selectedRecord.lastName;
                txt_addline1.Text = selectedRecord.AddressLine1;
                txt_addline2.Text = selectedRecord.AddressLine2;
                txt_city.Text = selectedRecord.city;
                txt_state.Text = selectedRecord.state;
                txt_date.Text = selectedRecord.dateReceived;
                txt_email.Text = selectedRecord.email;
                txt_phone.Text = selectedRecord.phone;
                txt_zipcode.Text = selectedRecord.zipcode;
                if (selectedRecord.proofOfPurchase == false)
                {
                    rd_no.Checked = true;
                    rd_yes.Checked = false;
                }
                else
                {
                    rd_no.Checked = false;
                    rd_yes.Checked = true;
                }
                btn_save.Text = "Update Record";
                btn_newEntry.Text = "Discard";
                btn_delete.Enabled = true;
                //btn_newEntry.Enabled = false;
                enableControls();
            }
            else
            {
                //update the status
                changeStatus(Color.Green, "Ready");
                clearControls();
                disableControls();
                btn_delete.Enabled = false;
                btn_newEntry.Text = "New Entry";
                //btn_newEntry.Enabled = true;
                btn_save.Text = "Save";
                //btn_newEntry.PerformClick();
                btn_newEntry.Focus();
                return;
            }
        }
        
        private void errorStatus(Label label, Color color, String text)
        {
            var timer = new Timer();
            label.ForeColor = color;
            label.Text = text;
            label.Show();
            timer.Interval = 900;
            timer.Tick += (start, end) =>
            {
                label.Hide();
                timer.Stop();
            };
            timer.Start();
        }

        //Validator function for the different text input fields
        private void onTextChanged(object sender, EventArgs e)
        {
            bool enableSave = true;
            DateTime dt;
            var regexPhone = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            var regexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var regexZipcode = new Regex(@"\d{5}-?(\d{4})?$");
            if (txt_fname.Text.Length < 1 && txt_fname.Focused)
            {
                enableSave = false;
                errorStatus(label_fname, Color.Red, "Enter a valid First Name");
            }
            else if (txt_lname.Text.Length < 1 && txt_lname.Focused)
            {
                enableSave = false;
                errorStatus(label_lname, Color.Red, "Enter a valid Last Name");
            }
            else if (txt_addline1.Text.Length < 5 && txt_addline1.Focused)
            {
                enableSave = false;
                errorStatus(label_add1, Color.Red, "Enter a valid Address");
            }
            else if (txt_city.Text.Length < 2 && txt_city.Focused)
            {
                enableSave = false;
                errorStatus(label_city, Color.Red, "Enter City Name");
            }
            else if (txt_state.Text.Length < 1 && txt_state.Focused)
            {
                enableSave = false;
                errorStatus(label_state, Color.Red, "Enter State Name");
            }
            else if ((txt_zipcode.Text.Length < 1 || !regexZipcode.IsMatch(txt_zipcode.Text)) && txt_zipcode.Focused)
            {
                enableSave = false;
                errorStatus(label_zipcode, Color.Red, "Enter a valid Zipcode");
            }
            else if ((txt_phone.Text == string.Empty || !regexPhone.IsMatch(txt_phone.Text)) && txt_phone.Focused)
            {
                enableSave = false;
                errorStatus(label_phone, Color.Red, "Enter a valid phone number");
            }
            else if ((txt_email.Text == string.Empty || !regexEmail.IsMatch(txt_email.Text)) && txt_email.Focused)
            {
                enableSave = false;
                errorStatus(label_email, Color.Red, "Enter a valid Email-Id");
            }
            else if (rd_yes.Checked == false && rd_no.Checked == false )
            {
                enableSave = false;
            }
            else
            {
                if (!DateTime.TryParse(txt_date.Text, out dt))
                {
                    enableSave = false;
                }
                else if (DateTime.Now.CompareTo(dt) < 0)
                {
                        enableSave = false;
                        errorStatus(label_date, Color.Red, "Date cannot be in the future");
                }
            }
            if (enableSave == false )
            {
                btn_save.Enabled = false;
            }
            else
            {
                btn_save.Enabled = true;
                startTick(Color.Green, "All enterered fields are valid.");
            }
        }

        //Sorting Fucntionality on click of column header
        private void list_display_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.list_display.Sort();
        }

       

        //Saving on form close & memory clean-up
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //writing back to file on exiting application
            fm.writeIntoFile(entryList);
            //closing file
            fm.closeFile();
        }

        //House Keeping Functions
        private int returnIndex(String[] name)
        {
            int indexForList;
            if (name.Length > 2)
                indexForList = entryList.FindIndex(item => item.firstName == name[0] && item.middleInitial == name[1] && item.lastName == name[2]);
            else
                indexForList = entryList.FindIndex(item => item.firstName == name[0] && item.lastName == name[1]);
            return indexForList;
        }

        private void startTick(Color color, String message)
        {
            var timer = new Timer();
            lbl_result.ForeColor = color;
            lbl_result.Text = message;
            lbl_result.Show();
            timer.Interval = 1800;
            timer.Tick += (start, end) =>
            {
                lbl_result.Hide();
                timer.Stop();
            };
            timer.Start();
        }

        private void clearControls()
        {
            txt_fname.Clear();
            txt_mi.Clear();
            txt_lname.Clear();
            txt_addline1.Clear();
            txt_addline2.Clear();
            txt_city.Clear();
            txt_state.Clear();
            txt_date.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_zipcode.Clear();
            rd_no.Checked = false;
            rd_yes.Checked = false;
        }
        private void disableControls()
        {
            txt_fname.Enabled = false;
            txt_mi.Enabled = false;
            txt_lname.Enabled = false;
            txt_addline1.Enabled = false;
            txt_addline2.Enabled = false;
            txt_city.Enabled = false;
            txt_state.Enabled = false;
            txt_date.Enabled = false;
            txt_email.Enabled = false;
            txt_phone.Enabled = false;
            txt_zipcode.Enabled = false;
            btn_save.Enabled = false;
            rd_no.Enabled = false;
            rd_yes.Enabled = false;

        }
        private void enableControls()
        {
            txt_fname.Enabled = true;
            txt_mi.Enabled = true;
            txt_lname.Enabled = true;
            txt_addline1.Enabled = true;
            txt_addline2.Enabled = true;
            txt_city.Enabled = true;
            txt_state.Enabled = true;
            txt_date.Enabled = true;
            txt_email.Enabled = true;
            txt_phone.Enabled = true;
            txt_zipcode.Enabled = true;
            rd_no.Enabled = true;
            rd_yes.Enabled = true;
        }
        private void changeStatus(Color color, String text)
        {
            toolStripStatus_status.Text = text;
            toolStripStatus_indicator.ForeColor = color;
        }

        private void updateNumberOfEntries()
        {
                toolStripStatus_entries.Text = entryList.Count().ToString();
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
