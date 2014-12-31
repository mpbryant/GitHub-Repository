using System;
using System.IO;
using System.Windows.Forms;

namespace myNotes
{
    

    public partial class Form1 : Form
    {

        string path = "..\\SoftwareNotes.doc";
        string line;

        public Form1()
        {
            InitializeComponent();
            LoadLB();
        }

        #region Save Items Section

        private void saveBTN_Click(object sender, EventArgs e)
        {

            if ((tabControl1.SelectedTab.Text == "CSharp" && !csharpLB.Items.Contains(noteTitleTB.Text)) || (tabControl1.SelectedTab.Text == "Visual Basic" && !vbLB.Items.Contains(noteTitleTB.Text)) || (tabControl1.SelectedTab.Text == "General" && !genLB.Items.Contains(noteTitleTB.Text)))//restricts adding the text if it already exists
            {
                SaveToTab();//saves the listbox item
                SaveNoteText();//saves the note
                SaveCodeText();//saves the code
            }
            else
            {
                //display a warning about duplicate entries
                string messageBoxText = "Title already exists!";
                
                string caption = "Cannot Save Note";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Warning;

                MessageBox.Show(messageBoxText, caption, button, icon);


            }
            


        }

        private void SaveNoteText()
        {
             //create streamwriter
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("NOTE" + " " + tabControl1.SelectedTab.Text + " " + noteTitleTB.Text);
                sw.WriteLine(notesRTB.Text);
                sw.WriteLine("END NOTE");
                //close streamwriter
                sw.Close();

            
        }

        private void SaveCodeText()
        {
            //create streamwriter
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine("CODE" + " " + tabControl1.SelectedTab.Text + " " + noteTitleTB.Text);
            sw.WriteLine(codeRTB.Text);
            sw.WriteLine("END CODE");
            //close streamwriter
            sw.Close();


        }

        private void SaveToTab()
        {
            //check for the active tab
            if (tabControl1.SelectedTab.Text == "CSharp")
            {
                // add text from the noteTitleTB to csharpLB
                csharpLB.Items.Add(noteTitleTB.Text);


                //create streamwriter
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("BEGIN CSHARP TOC");
                sw.WriteLine(noteTitleTB.Text);
                sw.WriteLine("END CSHARP TOC");
                //close streamwriter
                sw.Close();

            }
            //check for the active tab
            if (tabControl1.SelectedTab.Text == "Visual Basic")
            {
                // add text from the noteTitleTB to csharpLB
                vbLB.Items.Add(noteTitleTB.Text);


                //create streamwriter
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("BEGIN VB TOC");
                sw.WriteLine(noteTitleTB.Text);
                sw.WriteLine("END VB TOC");
                //close streamwriter
                sw.Close();

            }
            //check for the active tab
            if (tabControl1.SelectedTab.Text == "General")
            {
                // add text from the noteTitleTB to csharpLB
                genLB.Items.Add(noteTitleTB.Text);


                //create streamwriter
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine("BEGIN GEN TOC");
                sw.WriteLine(noteTitleTB.Text);
                sw.WriteLine("END GEN TOC");
                //close streamwriter
                sw.Close();

            }

        }

        #endregion

        #region View Items Section

        private void LoadLB()// load the listbox
        {
            //check if the file exists
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);//create a streamreader
                line = sr.ReadLine();//to prevent data skipping, set the streamreader to a variable




                //determine the tab that is active
                if (tabControl1.SelectedTab.Text == "CSharp")
                {
                    //get the list of note titles
                    while (line != null)//reads until a null line (AKA end of the document)
                    {
                        if (line == "BEGIN CSHARP TOC")//begin reading the TOC
                        {
                            line = sr.ReadLine();//increments the readline value

                            while (line != "END CSHARP TOC")//stop reading TOC when end is reached
                            {
                                try
                                {
                                    if (!csharpLB.Items.Contains(line))//restricts adding the text if it already exists
                                    {
                                        csharpLB.Items.Add(line);
                                    }
                                }

                                catch
                                {
                                    break;
                                }

                                line = sr.ReadLine();//increments the readline value

                            }
                        }
                        line = sr.ReadLine();//increments the readline value
                    }
                }



                //determine the tab that is active
                if (tabControl1.SelectedTab.Text == "Visual Basic")
                {
                    //get the list of note titles
                    while (line != null)//reads until a null line (AKA end of the document)
                    {
                        if (line == "BEGIN VB TOC")//begin reading the TOC
                        {
                            line = sr.ReadLine();//increments the readline value

                            while (line != "END VB TOC")//stop reading TOC when end is reached
                            {

                                try
                                {
                                    if (!vbLB.Items.Contains(line))//restricts adding the text if it already exists
                                    {
                                        vbLB.Items.Add(line);
                                    }

                                }

                                catch
                                {
                                    break;
                                }


                                line = sr.ReadLine();//increments the readline value

                            }
                        }
                        line = sr.ReadLine();//increments the readline value
                    }
                }






                //determine the tab that is active
                if (tabControl1.SelectedTab.Text == "General")
                {
                    //get the list of note titles
                    while (line != null)//reads until a null line (AKA end of the document)
                    {
                        if (line == "BEGIN GEN TOC")//begin reading the TOC
                        {
                            line = sr.ReadLine();//increments the readline value

                            while (line != "END GEN TOC")//stop reading TOC when end is reached
                            {

                                try
                                {
                                    if (!genLB.Items.Contains(line))//restricts adding the text if it already exists
                                    {
                                        genLB.Items.Add(line);
                                    }

                                }

                                catch
                                {
                                    break;
                                }


                                line = sr.ReadLine();//increments the readline value

                            }
                        }
                        line = sr.ReadLine();//increments the readline value
                    }
                }




                sr.Close();//close the streamwriter

            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when a tab is selected, clear the contents of the form
            noteTitleTB.Text = "";
            notesRTB.Text = "";
            codeRTB.Text = "";
            //load the listbox with the appropriate data based on the selected tab
            LoadLB();
        }

        private void GetNotesRTB()
        {
            //create streamreader
            StreamReader sr = new StreamReader(path, true);
            //create a variable to hold the concatenated string
            string note = sr.ReadLine();
            //create a variable to hold the initial value of a readline
            string initialReadLine = "";

            //look for the beginning of the note
            while (note != ("NOTE" + " " + tabControl1.SelectedTab.Text + " " + noteTitleTB.Text))
            {

                note = sr.ReadLine();

            }

            
            note = "";//clears the note variable

            //create the note from the saved string
            do
            {
                note += initialReadLine;//concatenates the strings
                note += "\n";
                initialReadLine = sr.ReadLine();
                
            } while (initialReadLine != "END NOTE");

            notesRTB.Text = note;//adds the completed string to the textbox

            
            //close streamwriter
            sr.Close();
        }


        private void GetCodeRTB()
        {
            //create streamreader
            StreamReader sr = new StreamReader(path, true);
            //create a variable to hold the concatenated string
            string code = sr.ReadLine();
            //create a variable to hold the initial value of a readline
            string initialReadLine = "";

            //look for the beginning of the note
            while (code != ("CODE" + " " + tabControl1.SelectedTab.Text + " " + noteTitleTB.Text))
            {

                code = sr.ReadLine();

            }


            code = "";//clears the note variable

            //create the note from the saved string
            do
            {
                code += initialReadLine;//concatenates the strings
                code += "\n";
                initialReadLine = sr.ReadLine();

            } while (initialReadLine != "END CODE");

            codeRTB.Text = code;//adds the completed string to the textbox


            //close streamwriter
            sr.Close();
        }


        #endregion

        #region Get the info from the listboxes

        private void csharpLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteTitleTB.Text = (string)csharpLB.SelectedItem;
            GetNotesRTB();
            GetCodeRTB();
        }

        

        private void vbLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteTitleTB.Text = (string)vbLB.SelectedItem;
            GetNotesRTB();
        }

        private void genLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            noteTitleTB.Text = (string)genLB.SelectedItem;
            GetNotesRTB();
        }

        #endregion

        private void clearBTN_Click(object sender, EventArgs e)
        {
            codeRTB.Text = "";
            notesRTB.Text = "";
            noteTitleTB.Text = "";
        }

    }
}
