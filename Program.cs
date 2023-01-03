namespace DesignCalculator
{
    public class Program
    {
        // Definitions
        public List<string> techLevels = new();
        public List<string> unitTypes = new();
        public List<string> projectTypes = new();
        public List<string> planTypes = new();
        public List<string> positiveQuirks = new();
        public List<string> negativeQuirks = new();
        public List<int> positiveQuirksValues = new();
        public List<int> negativeQuirksValues = new();

        public int months = 0;
        public int spCost = 0;
        public int sorties = 0;
        public int totalTPCost = 0;
        public int baseTN = 0;
        public int baseTP = 0;
        public int researchExtraTP = 0;
        public int researchTN = 0;
        public int researchSimulationsRun = 0;
        public int researchDesignsCompiled = 0;
        public int researchSevensTaken = 0;
        public int researchCriticalFails = 0;
        public int developExtraTP = 0;
        public int developTN = 0;
        public int developPrototypesBuilt = 0;
        public int developPrototypesCost = 0;
        public int developRunFieldTests = 0;
        public int developIssuesWorkedOut = 0;
        public int developSevensTaken = 0;
        public int developCriticalFails = 0;

        public int prototypeBayTP = 0;
        public int prototypeBayTN = 0;
        public int existingPlansTP = 0;
        public int existingPlansTN = 0;
        public int projectTypeTP = 0;
        public int projectTypeTN = 0;

        public int runSimulationsTP = 0;
        public int runSimulationsTN = 0;
        public int compileDesignsTP = 0;
        public int compileDesignsTN = 0;

        public int buildPrototypesTP = 0;
        public int buildPrototypesTN = 0;
        public int runFieldTestsTP = 0;
        public int runFieldTestsTN = 0;
        public int issuesWorkedOutTP = 0;
        public int issuesWorkedOutTN = 0;

        public int criticalFailsTN = 0;
        public int criticalFailsTP = 0;
        public int sevensTakenTN = 0;
        public int sevensTakenTP = 0;

        public static string str_saveFileFolder = "designs";

        public static DesignCalcForm mainForm;

        private const string str_versionNum = "1.0";

        [STAThread]
        static void Main()
        {
            Program myClass = new();
            FindCreateFolders(myClass);
            ApplicationConfiguration.Initialize();
            Application.Run(mainForm = new DesignCalcForm(myClass));
        }

        private static void FindCreateFolders(Program myClass)
        {
            try
            {
                IEnumerable<string> folderList = Directory.GetDirectories(AppDomain.CurrentDomain.BaseDirectory).Where(s => s.Contains(Program.str_saveFileFolder));

                if (!folderList.Any())
                {
                    Directory.CreateDirectory(Program.str_saveFileFolder);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking/creating save folder.  " + ex.ToString(), "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                    SetDefaultValues(myClass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting default values.  " + ex.ToString(), "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AboutDialog()
        {
            try
            {
                MessageBox.Show("This tool was coded by Morkath.  It was designed by Sprero to calcuate the design costs for producing new units in a Battletech Campaign game.  Version: " + str_versionNum, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Showing About.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SaveDesignFile()
        {
            try
            {
                string fileName = "tempName"; // TRAP TODO Fix this to get input from user.
                string fullFileName = str_saveFileFolder + "\\" + fileName + ".txt";
                DialogResult saveFile = DialogResult.Yes;

                if (File.Exists(fullFileName))
                {
                    saveFile = MessageBox.Show("File exists, Overwrite?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (saveFile == DialogResult.Yes)
                {
                    using (StreamWriter wt = new(fullFileName))
                    {
                        wt.WriteLine(mainForm.UnitType);
                        wt.WriteLine(mainForm.Techlevel);
                        wt.WriteLine(mainForm.Plans);
                        wt.WriteLine(mainForm.ProjectType);

                        // TRAP TODO add all the other fields that need to get saved.

                        wt.Close();
                    }
                }
                else
                {
                    saveFile = DialogResult.No;
                    MessageBox.Show("File not saved.", "File Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Design.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadDesignFile()
        {
            try
            {
                OpenFileDialog openFileDialog = new();
                openFileDialog.InitialDirectory = str_saveFileFolder;
                openFileDialog.Title = "Browse Saved Designs";
                openFileDialog.DefaultExt = "txt";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.CheckFileExists = true;
                openFileDialog.CheckPathExists = true;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowReadOnly = true;

                mainForm.update = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader rt = new StreamReader(openFileDialog.FileName))
                    {
                        mainForm.UnitType = int.Parse(rt.ReadLine());
                        mainForm.Techlevel = int.Parse(rt.ReadLine());
                        mainForm.Plans = int.Parse(rt.ReadLine());
                        mainForm.ProjectType = int.Parse(rt.ReadLine());

                        // TRAP TODO add all the other fields that need to get loaded.


                        rt.Close();
                    }
                }

                mainForm.update = true;
                UpdateValues();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Design.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateValues()
        {
            CalculateValues();
        }
        private static void SetDefaultValues(Program myClass)
        {
            // TRAP TODO Set all the initial values for everything.

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Message.  " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateValues()
        {
            // Update the forms fields based on current data.
            UpdateUnitType();
        }

        private void UpdateUnitType()
        {

        }
    }
}