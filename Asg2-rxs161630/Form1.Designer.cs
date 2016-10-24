namespace Asg2_rxs161630
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_addline1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_addline2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_zipcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rd_yes = new System.Windows.Forms.RadioButton();
            this.rd_no = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.list_display = new System.Windows.Forms.ListView();
            this.First_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_newEntry = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_indicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_entries = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_zipcode = new System.Windows.Forms.Label();
            this.label_state = new System.Windows.Forms.Label();
            this.label_city = new System.Windows.Forms.Label();
            this.label_add1 = new System.Windows.Forms.Label();
            this.label_lname = new System.Windows.Forms.Label();
            this.label_fname = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(248, 23);
            this.txt_fname.MaxLength = 20;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(221, 22);
            this.txt_fname.TabIndex = 0;
            this.txt_fname.TextChanged += new System.EventHandler(this.onTextChanged);
            this.txt_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fname_KeyPress);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(132, 26);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(80, 17);
            this.lbl_fname.TabIndex = 1;
            this.lbl_fname.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Middle Initial:";
            // 
            // txt_mi
            // 
            this.txt_mi.Location = new System.Drawing.Point(248, 74);
            this.txt_mi.MaxLength = 1;
            this.txt_mi.Name = "txt_mi";
            this.txt_mi.Size = new System.Drawing.Size(60, 22);
            this.txt_mi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(248, 124);
            this.txt_lname.MaxLength = 20;
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(221, 22);
            this.txt_lname.TabIndex = 4;
            this.txt_lname.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address Line1:";
            // 
            // txt_addline1
            // 
            this.txt_addline1.Location = new System.Drawing.Point(248, 175);
            this.txt_addline1.MaxLength = 35;
            this.txt_addline1.Name = "txt_addline1";
            this.txt_addline1.Size = new System.Drawing.Size(221, 22);
            this.txt_addline1.TabIndex = 6;
            this.txt_addline1.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address Line2:";
            // 
            // txt_addline2
            // 
            this.txt_addline2.Location = new System.Drawing.Point(248, 226);
            this.txt_addline2.MaxLength = 35;
            this.txt_addline2.Name = "txt_addline2";
            this.txt_addline2.Size = new System.Drawing.Size(221, 22);
            this.txt_addline2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(248, 277);
            this.txt_city.MaxLength = 25;
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(221, 22);
            this.txt_city.TabIndex = 10;
            this.txt_city.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "State:";
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(248, 329);
            this.txt_state.MaxLength = 2;
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(221, 22);
            this.txt_state.TabIndex = 12;
            this.txt_state.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Zipcode:";
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(248, 382);
            this.txt_zipcode.MaxLength = 9;
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(221, 22);
            this.txt_zipcode.TabIndex = 14;
            this.txt_zipcode.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Phone Number:";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(248, 436);
            this.txt_phone.MaxLength = 21;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(221, 22);
            this.txt_phone.TabIndex = 16;
            this.txt_phone.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email Address:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(248, 488);
            this.txt_email.MaxLength = 60;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(221, 22);
            this.txt_email.TabIndex = 18;
            this.txt_email.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 540);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Proof of purchase attached:";
            // 
            // rd_yes
            // 
            this.rd_yes.AutoSize = true;
            this.rd_yes.Location = new System.Drawing.Point(248, 538);
            this.rd_yes.Name = "rd_yes";
            this.rd_yes.Size = new System.Drawing.Size(53, 21);
            this.rd_yes.TabIndex = 21;
            this.rd_yes.Text = "Yes";
            this.rd_yes.UseVisualStyleBackColor = true;
            this.rd_yes.CheckedChanged += new System.EventHandler(this.onTextChanged);
            // 
            // rd_no
            // 
            this.rd_no.AutoSize = true;
            this.rd_no.Location = new System.Drawing.Point(316, 538);
            this.rd_no.Name = "rd_no";
            this.rd_no.Size = new System.Drawing.Size(47, 21);
            this.rd_no.TabIndex = 22;
            this.rd_no.TabStop = true;
            this.rd_no.Text = "No";
            this.rd_no.UseVisualStyleBackColor = true;
            this.rd_no.CheckedChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 592);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Date Received:";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(248, 589);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(221, 22);
            this.txt_date.TabIndex = 23;
            this.txt_date.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Phone Number:";
            // 
            // list_display
            // 
            this.list_display.CausesValidation = false;
            this.list_display.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.First_Name,
            this.Phone_Number});
            this.list_display.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_display.FullRowSelect = true;
            this.list_display.GridLines = true;
            this.list_display.HideSelection = false;
            this.list_display.Location = new System.Drawing.Point(0, 0);
            this.list_display.MultiSelect = false;
            this.list_display.Name = "list_display";
            this.list_display.Size = new System.Drawing.Size(462, 802);
            this.list_display.TabIndex = 25;
            this.list_display.UseCompatibleStateImageBehavior = false;
            this.list_display.View = System.Windows.Forms.View.Details;
            this.list_display.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_display_ColumnClick);
            this.list_display.SelectedIndexChanged += new System.EventHandler(this.list_display_SelectedIndexChanged);
            // 
            // First_Name
            // 
            this.First_Name.Text = "Name";
            this.First_Name.Width = 180;
            // 
            // Phone_Number
            // 
            this.Phone_Number.Text = "Phone Number";
            this.Phone_Number.Width = 160;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Location = new System.Drawing.Point(361, 678);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 31);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(239, 678);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 31);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_newEntry
            // 
            this.btn_newEntry.AutoSize = true;
            this.btn_newEntry.Location = new System.Drawing.Point(119, 678);
            this.btn_newEntry.Name = "btn_newEntry";
            this.btn_newEntry.Size = new System.Drawing.Size(98, 31);
            this.btn_newEntry.TabIndex = 28;
            this.btn_newEntry.Text = "New Entry";
            this.btn_newEntry.UseVisualStyleBackColor = true;
            this.btn_newEntry.Click += new System.EventHandler(this.btn_newEntry_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(263, 643);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(48, 17);
            this.lbl_result.TabIndex = 29;
            this.lbl_result.Text = "Result";
            this.lbl_result.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_indicator,
            this.toolStripStatus_status,
            this.toolStripStatus_entries,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(462, 765);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(664, 37);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus_indicator
            // 
            this.toolStripStatus_indicator.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.toolStripStatus_indicator.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripStatus_indicator.Name = "toolStripStatus_indicator";
            this.toolStripStatus_indicator.Size = new System.Drawing.Size(35, 32);
            this.toolStripStatus_indicator.Text = "⚫";
            // 
            // toolStripStatus_status
            // 
            this.toolStripStatus_status.AutoSize = false;
            this.toolStripStatus_status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatus_status.Name = "toolStripStatus_status";
            this.toolStripStatus_status.Size = new System.Drawing.Size(100, 32);
            this.toolStripStatus_status.Text = "Status";
            this.toolStripStatus_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatus_entries
            // 
            this.toolStripStatus_entries.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripStatus_entries.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatus_entries.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatus_entries.Name = "toolStripStatus_entries";
            this.toolStripStatus_entries.Size = new System.Drawing.Size(20, 32);
            this.toolStripStatus_entries.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(109, 32);
            this.toolStripStatusLabel3.Text = "records in total";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_email);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.label_zipcode);
            this.panel1.Controls.Add(this.label_state);
            this.panel1.Controls.Add(this.label_city);
            this.panel1.Controls.Add(this.label_add1);
            this.panel1.Controls.Add(this.label_lname);
            this.panel1.Controls.Add(this.label_fname);
            this.panel1.Controls.Add(this.btn_newEntry);
            this.panel1.Controls.Add(this.txt_fname);
            this.panel1.Controls.Add(this.lbl_result);
            this.panel1.Controls.Add(this.lbl_fname);
            this.panel1.Controls.Add(this.txt_mi);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_lname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_addline1);
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rd_no);
            this.panel1.Controls.Add(this.txt_addline2);
            this.panel1.Controls.Add(this.rd_yes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_city);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_email);
            this.panel1.Controls.Add(this.txt_state);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_zipcode);
            this.panel1.Controls.Add(this.txt_phone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(519, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 733);
            this.panel1.TabIndex = 31;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(251, 616);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 17);
            this.label_date.TabIndex = 38;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(251, 518);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(0, 17);
            this.label_email.TabIndex = 37;
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(251, 466);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(0, 17);
            this.label_phone.TabIndex = 33;
            // 
            // label_zipcode
            // 
            this.label_zipcode.AutoSize = true;
            this.label_zipcode.Location = new System.Drawing.Point(251, 413);
            this.label_zipcode.Name = "label_zipcode";
            this.label_zipcode.Size = new System.Drawing.Size(0, 17);
            this.label_zipcode.TabIndex = 36;
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Location = new System.Drawing.Point(251, 358);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(0, 17);
            this.label_state.TabIndex = 35;
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Location = new System.Drawing.Point(251, 305);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(0, 17);
            this.label_city.TabIndex = 34;
            // 
            // label_add1
            // 
            this.label_add1.AutoSize = true;
            this.label_add1.Location = new System.Drawing.Point(251, 204);
            this.label_add1.Name = "label_add1";
            this.label_add1.Size = new System.Drawing.Size(0, 17);
            this.label_add1.TabIndex = 33;
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Location = new System.Drawing.Point(251, 152);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(0, 17);
            this.label_lname.TabIndex = 32;
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Location = new System.Drawing.Point(251, 54);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(0, 17);
            this.label_fname.TabIndex = 30;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1126, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.list_display);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rebate Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_addline1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_addline2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_zipcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rd_yes;
        private System.Windows.Forms.RadioButton rd_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListView list_display;
        private System.Windows.Forms.ColumnHeader First_Name;
        private System.Windows.Forms.ColumnHeader Phone_Number;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_newEntry;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_indicator;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_entries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_zipcode;
        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.Label label_add1;
        private System.Windows.Forms.Label label_lname;
    }
}

