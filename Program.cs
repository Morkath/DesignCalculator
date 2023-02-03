using System.Windows.Forms;

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
        public List<int> quirkChangeStepModifier = new();
        public List<int> quirkChangeStep = new();

        public int months = 0;
        public int spCost = 0;
        public int sorties = 0;
        public int totalTPCost = 0;
        public double baseTN = 0;
        public double baseTP = 0;
        public double researchExtraTP = 0;
        public double researchTN = 0;
        public int researchSimulationsRun = 0;
        public int researchDesignsCompiled = 0;
        public int researchSevensTaken = 0;
        public int researchCriticalFails = 0;
        public double developExtraTP = 0;
        public double developTN = 0;
        public int developPrototypesBuilt = 0;
        public int developPrototypesCost = 0;
        public int developRunFieldTests = 0;
        public int developIssuesWorkedOut = 0;
        public int developSevensTaken = 0;
        public int developCriticalFails = 0;
        public double quirksTN = 0;
        public double projectBlueprintTP = 0;

        public string techLevel = "";
        public string unitType = "";

        public double blueprintTN = 0;
        public double blueprintTP = 0;
        public double schematicsTN = 0;
        public double schematicsTP = 0;
        public double noPrototypeBayTN = 0;
        public double noPrototypeBayTP = 0;
        public double newStdChassisTN = 0;
        public double newStdChassisTP = 0;
        public double newOmniChassisTN = 0;
        public double newOmniChassisTP = 0;
        public double newComponentTN = 0;
        public double newComponentTP = 0;
        public double newMinorVarTN = 0;
        public double newMinorVarTP = 0;
        public double newModVarTN = 0;
        public double newModVarTP = 0;
        public double newMajorVarTN = 0;
        public double newMajorVarTP = 0;
        public double newOmniConfigTN = 0;
        public double newOmniConfigTP = 0;
        public double runSimulationsTN = 0;
        public double runSimulationsTP = 0;
        public double compileDesignTN = 0;
        public double compileDesignTP = 0;
        public double buildPrototypeTN = 0;
        public double buildPrototypeTP = 0;
        public double fieldTestTN = 0;
        public double fieldTestTP = 0;
        public double workOutIssuesTN = 0;
        public double workOutIssuesTP = 0;

        public double criticalFailsTN = 0;
        public double criticalFailsTP = 0;
        public double sevensTakenTN = 0;
        public double sevensTakenTP = 0;

        public double veeRetroBaseTP = 0;
        public double veeIntroBaseTP = 0;
        public double veeStdBaseTP = 0;
        public double veeAdvBaseTP = 0;
        public double veeExpBaseTP = 0;
        public double veeRetroBaseTN = 0;
        public double veeIntroBaseTN = 0;
        public double veeStdBaseTN = 0;
        public double veeAdvBaseTN = 0;
        public double veeExpBaseTN = 0;

        public double mechRetroBaseTP = 0;
        public double mechIntroBaseTP = 0;
        public double mechStdBaseTP = 0;
        public double mechAdvBaseTP = 0;
        public double mechExpBaseTP = 0;
        public double mechRetroBaseTN = 0;
        public double mechIntroBaseTN = 0;
        public double mechStdBaseTN = 0;
        public double mechAdvBaseTN = 0;
        public double mechExpBaseTN = 0;

        public double asfRetroBaseTP = 0;
        public double asfIntroBaseTP = 0;
        public double asfStdBaseTP = 0;
        public double asfAdvBaseTP = 0;
        public double asfExpBaseTP = 0;
        public double asfRetroBaseTN = 0;
        public double asfIntroBaseTN = 0;
        public double asfStdBaseTN = 0;
        public double asfAdvBaseTN = 0;
        public double asfExpBaseTN = 0;

        public double baRetroBaseTP = 0;
        public double baIntroBaseTP = 0;
        public double baStdBaseTP = 0;
        public double baAdvBaseTP = 0;
        public double baExpBaseTP = 0;
        public double baRetroBaseTN = 0;
        public double baIntroBaseTN = 0;
        public double baStdBaseTN = 0;
        public double baAdvBaseTN = 0;
        public double baExpBaseTN = 0;

        public double scRetroBaseTP = 0;
        public double scIntroBaseTP = 0;
        public double scStdBaseTP = 0;
        public double scAdvBaseTP = 0;
        public double scExpBaseTP = 0;
        public double scRetroBaseTN = 0;
        public double scIntroBaseTN = 0;
        public double scStdBaseTN = 0;
        public double scAdvBaseTN = 0;
        public double scExpBaseTN = 0;

        public double dropRetroBaseTP = 0;
        public double dropIntroBaseTP = 0;
        public double dropStdBaseTP = 0;
        public double dropAdvBaseTP = 0;
        public double dropExpBaseTP = 0;
        public double dropRetroBaseTN = 0;
        public double dropIntroBaseTN = 0;
        public double dropStdBaseTN = 0;
        public double dropAdvBaseTN = 0;
        public double dropExpBaseTN = 0;

        public bool perkSelected = false;

        private const string str_retroTechLvl = "Retro";
        private const string str_introTechLvl = "Intro";
        private const string str_stdTechLvl = "Standard";
        private const string str_advTechLvl = "Advanced";
        private const string str_expTechLvl = "Experimental";

        private const string str_asfUnitType = "ASF";
        private const string str_dropshipUnitType = "Dropship";
        private const string str_smallUnitType = "SC";
        private const string str_mechUnitType = "Mech";
        private const string str_baUnitType = "BA";
        private const string str_veeUnitType = "Vehicle";

        private const string str_none = "None";
        private const string str_blueprint = "Blueprint";
        private const string str_schematic = "Schematic";

        private const string str_newStd = "New Std";
        private const string str_newOmni = "New Omni";
        private const string str_newComp = "New Component";
        private const string str_minorVar = "Minor Var";
        private const string str_modVar = "Moderate Var";
        private const string str_majorVar = "Major Var";
        private const string str_omniConfig = "Omni Var";

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
        public void DisplayInstructions()
        {
            
            string tempString = "Project: Select your unit type and tech level. " + Environment.NewLine;
            tempString += "Project: Select if you don't have a prototype bay, what types of plans you are using, and what the project type is. " + Environment.NewLine + Environment.NewLine;
            tempString += "Research: Select how many simulations you want to run, then how many times you make an attempt to compile, take seven, or critically fail until you beat the Research TN. " + Environment.NewLine + Environment.NewLine;
            tempString += "Develop: Select how many prototypes you are building, their cost, and how many field tests you are going to run. " + Environment.NewLine;
            tempString += "Develop: Now set your original positive and negative quirks, remember to include the Prototype negative quirk " + Environment.NewLine;
            tempString += "Develop: Then set the new positive and negative quirks, but make one change that you are going to make this development attempt.  For example, add the barrel fist positive quirk. " + Environment.NewLine;
            tempString += "Develop: Toggle how many times you make an attempt to work out issues, take seven, or critically fail until you beat the Development TN. " + Environment.NewLine;
            tempString += "Develop: Finally, repeat this until your quirk list is finalized, leaving removing the Prototype quirk for last. " + Environment.NewLine;
           
            MessageBox.Show(tempString, "Instructions", MessageBoxButtons.OK);
        }
        public void SaveDesignFile()
        {
            try
            {
                

                SaveFileDialog saveFileDialog = new();
                saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + str_saveFileFolder;
                saveFileDialog.Title = "Save Design";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter wt = new(saveFileDialog.FileName))
                    {
                        wt.WriteLine(mainForm.UnitType);
                        wt.WriteLine(mainForm.Techlevel);
                        wt.WriteLine(mainForm.PrototypeBay);
                        wt.WriteLine(mainForm.Plans);
                        wt.WriteLine(mainForm.ProjectType);
                        wt.WriteLine(mainForm.RunSims);
                        wt.WriteLine(mainForm.SimulationCount);
                        wt.WriteLine(mainForm.CompileDesigns);
                        wt.WriteLine(mainForm.CompileCount);
                        wt.WriteLine(mainForm.ResearchTakeSeven);
                        wt.WriteLine(mainForm.ResearchTakeSevenCount);
                        wt.WriteLine(mainForm.ResearchCriticalFail);
                        wt.WriteLine(mainForm.ResearchCriticalFailCount);
                        wt.WriteLine(mainForm.BuildPrototypes);
                        wt.WriteLine(mainForm.BuildPrototypeCount);
                        wt.WriteLine(mainForm.PrototypeCost);
                        wt.WriteLine(mainForm.FieldTest);
                        wt.WriteLine(mainForm.FieldTestCount);
                        wt.WriteLine(mainForm.WorkOutIssues);
                        wt.WriteLine(mainForm.WorkOutIssuesCount);
                        wt.WriteLine(mainForm.DevelopTakeSeven);
                        wt.WriteLine(mainForm.DevelopTakeSevenCount);
                        wt.WriteLine(mainForm.DevelopCriticalFail);
                        wt.WriteLine(mainForm.DevelopCriticalFailCount);

                        foreach (var item in mainForm.CheckedOriginalPosQuirks)
                        {
                            wt.WriteLine(item);
                        }
                        wt.WriteLine("EndOrigPosQuirks");

                        foreach (var item in mainForm.CheckedOriginalNegQuirks)
                        {
                            wt.WriteLine(item);
                        }
                        wt.WriteLine("EndOrigNegQuirks");

                        foreach (var item in mainForm.CheckedNewPosQuirks)
                        {
                            wt.WriteLine(item);
                        }
                        wt.WriteLine("EndNewPosQuirks");

                        foreach (var item in mainForm.CheckedNewNegQuirks)
                        {
                            wt.WriteLine(item);
                        }
                        wt.WriteLine("EndNewNegQuirks");

                        wt.Close();
                    }
                }
                else
                {
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
                        mainForm.PrototypeBay = bool.Parse(rt.ReadLine());
                        mainForm.Plans = int.Parse(rt.ReadLine());
                        mainForm.ProjectType = int.Parse(rt.ReadLine());
                        mainForm.RunSims = bool.Parse(rt.ReadLine());
                        mainForm.SimulationCount = int.Parse(rt.ReadLine());
                        mainForm.CompileDesigns = bool.Parse(rt.ReadLine());
                        mainForm.CompileCount = int.Parse(rt.ReadLine());
                        mainForm.ResearchTakeSeven = bool.Parse(rt.ReadLine());
                        mainForm.ResearchTakeSevenCount = int.Parse(rt.ReadLine());
                        mainForm.ResearchCriticalFail = bool.Parse(rt.ReadLine());
                        mainForm.ResearchCriticalFailCount = int.Parse(rt.ReadLine());
                        mainForm.BuildPrototypes = bool.Parse(rt.ReadLine());
                        mainForm.BuildPrototypeCount = int.Parse(rt.ReadLine());
                        mainForm.PrototypeCost = rt.ReadLine();
                        mainForm.FieldTest = bool.Parse(rt.ReadLine());
                        mainForm.FieldTestCount =int.Parse(rt.ReadLine());
                        mainForm.WorkOutIssues = bool.Parse(rt.ReadLine());
                        mainForm.WorkOutIssuesCount =int.Parse(rt.ReadLine());
                        mainForm.DevelopTakeSeven = bool.Parse(rt.ReadLine());
                        mainForm.DevelopTakeSevenCount = int.Parse(rt.ReadLine());
                        mainForm.DevelopCriticalFail = bool.Parse(rt.ReadLine());
                        mainForm.DevelopCriticalFailCount = int.Parse(rt.ReadLine());

                        string? line = "";
                        List<string> tempStrList = new List<string>();

                        while ((line = rt.ReadLine()) != "EndOrigPosQuirks")
                        {
                            tempStrList.Add(line);
                        }

                        mainForm.CheckOriginalPosQuirks = tempStrList;

                        tempStrList.Clear();

                        while ((line = rt.ReadLine()) != "EndOrigNegQuirks")
                        {
                            tempStrList.Add(line);
                        }

                        mainForm.CheckOriginalNegQuirks = tempStrList;

                        tempStrList.Clear();

                        while ((line = rt.ReadLine()) != "EndNewPosQuirks")
                        {
                            tempStrList.Add(line);
                        }

                        mainForm.CheckNewPosQuirks = tempStrList;

                        tempStrList.Clear();

                        while ((line = rt.ReadLine()) != "EndNewNegQuirks")
                        {
                            tempStrList.Add(line);
                        }

                        mainForm.CheckNewNegQuirks = tempStrList;

                        tempStrList.Clear();

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
            try
            {
                myClass.techLevels.Add(str_retroTechLvl);
                myClass.techLevels.Add(str_introTechLvl);
                myClass.techLevels.Add(str_stdTechLvl);
                myClass.techLevels.Add(str_advTechLvl);
                myClass.techLevels.Add(str_expTechLvl);

                myClass.unitTypes.Add(str_veeUnitType);
                myClass.unitTypes.Add(str_mechUnitType);
                myClass.unitTypes.Add(str_asfUnitType);
                myClass.unitTypes.Add(str_baUnitType);
                myClass.unitTypes.Add(str_smallUnitType);
                myClass.unitTypes.Add(str_dropshipUnitType);

                myClass.planTypes.Add(str_none);
                myClass.planTypes.Add(str_blueprint);
                myClass.planTypes.Add(str_schematic);

                myClass.projectTypes.Add(str_newStd);
                myClass.projectTypes.Add(str_newOmni);
                myClass.projectTypes.Add(str_newComp);
                myClass.projectTypes.Add(str_minorVar);
                myClass.projectTypes.Add(str_modVar);
                myClass.projectTypes.Add(str_majorVar);
                myClass.projectTypes.Add(str_omniConfig);

                myClass.positiveQuirks.Add("Accurate Weapon 1");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Accurate Weapon 2");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Accurate Weapon 3");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("AA Targeting");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Barrel Fist");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Barrel Fists");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Battle Computer");
                myClass.positiveQuirksValues.Add(5);
                myClass.positiveQuirks.Add("Combat Computer");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Command Mech");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Cowl");
                myClass.positiveQuirksValues.Add(4);
                myClass.positiveQuirks.Add("Directional Torso Mount");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Easy To Maintain");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Easy To Pilot");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Extended Torso Twist");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Fast Reload");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Hyper-Extending Actuators");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Improved Cooling Jacket");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Improved Communications");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Improved Life Support");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Improved Sensors");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Improved Targeting");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Multi-Trac");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Modular Weapons");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Narrow/Low Profile");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Compact Mech");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Overhead Arms");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("Protected Actuators");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Power Reverse");
                myClass.positiveQuirksValues.Add(3);
                myClass.positiveQuirks.Add("Reinforced Legs");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Rugged 1");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Rugged 2");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Rugged 3");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Rugged 4");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Stabilized Weapon 1");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Stabilized Weapon 2");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Stabilized Weapon 3");
                myClass.positiveQuirksValues.Add(1);
                myClass.positiveQuirks.Add("Stable");
                myClass.positiveQuirksValues.Add(2);
                myClass.positiveQuirks.Add("VTOL Rotor Arrangement");
                myClass.positiveQuirksValues.Add(1);

                myClass.negativeQuirks.Add("Ammunition Feed Problems");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Atmosphere Flight Instability");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Cooling System Flaws");
                myClass.negativeQuirksValues.Add(-3);
                myClass.negativeQuirks.Add("Cramped Cockpit");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Difficult Ejection");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Difficult to Maintain");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("EM Interference");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Exposed Actuators");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Exposed Weapon Linkage");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Fragile Fuel Tank");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Hard to Pilot");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Inaccurate Weapon 1");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Inaccurate Weapon 2");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Inaccurate Weapon 3");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Low-Mounted Arms");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("No/Minimal Arms");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("No Cooling Jacket");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("No Ejection Mechanism");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Poor Cooling Jacket");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Poor Performance");
                myClass.negativeQuirksValues.Add(-3);
                myClass.negativeQuirks.Add("Poor Sealing");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Poor Workmanship");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Prototype");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Ramshackle");
                myClass.negativeQuirksValues.Add(-3);
                myClass.negativeQuirks.Add("Sensor Ghosts");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Slow Traverse");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Static Ammo Feed");
                myClass.negativeQuirksValues.Add(-2);
                myClass.negativeQuirks.Add("Unbalanced");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Weak Legs");
                myClass.negativeQuirksValues.Add(-1);
                myClass.negativeQuirks.Add("Weak Undercarriage");
                myClass.negativeQuirksValues.Add(-1);

                myClass.quirkChangeStep.Add(-6);
                myClass.quirkChangeStepModifier.Add(0);
                myClass.quirkChangeStep.Add(-5);
                myClass.quirkChangeStepModifier.Add(1);
                myClass.quirkChangeStep.Add(-4);
                myClass.quirkChangeStepModifier.Add(1);
                myClass.quirkChangeStep.Add(-3);
                myClass.quirkChangeStepModifier.Add(1);
                myClass.quirkChangeStep.Add(-2);
                myClass.quirkChangeStepModifier.Add(2);
                myClass.quirkChangeStep.Add(-1);
                myClass.quirkChangeStepModifier.Add(2);
                myClass.quirkChangeStep.Add(0);
                myClass.quirkChangeStepModifier.Add(3);
                myClass.quirkChangeStep.Add(1);
                myClass.quirkChangeStepModifier.Add(5);
                myClass.quirkChangeStep.Add(2);
                myClass.quirkChangeStepModifier.Add(8);
                myClass.quirkChangeStep.Add(3);
                myClass.quirkChangeStepModifier.Add(12);
                myClass.quirkChangeStep.Add(4);
                myClass.quirkChangeStepModifier.Add(17);
                myClass.quirkChangeStep.Add(5);
                myClass.quirkChangeStepModifier.Add(23);
                myClass.quirkChangeStep.Add(6);
                myClass.quirkChangeStepModifier.Add(30);
                myClass.quirkChangeStep.Add(7);
                myClass.quirkChangeStepModifier.Add(38);
                myClass.quirkChangeStep.Add(8);

                myClass.veeRetroBaseTP = 0;
                myClass.veeIntroBaseTP = 1;
                myClass.veeStdBaseTP = 2;
                myClass.veeAdvBaseTP = 3;
                myClass.veeExpBaseTP = 4;
                myClass.veeRetroBaseTN = 5;
                myClass.veeIntroBaseTN = 6;
                myClass.veeStdBaseTN = 7;
                myClass.veeAdvBaseTN = 8;
                myClass.veeExpBaseTN = 9;

                myClass.mechRetroBaseTP = 1;
                myClass.mechIntroBaseTP = 2;
                myClass.mechStdBaseTP = 3;
                myClass.mechAdvBaseTP = 4;
                myClass.mechExpBaseTP = 5;
                myClass.mechRetroBaseTN = 5;
                myClass.mechIntroBaseTN = 7;
                myClass.mechStdBaseTN = 9;
                myClass.mechAdvBaseTN = 11;
                myClass.mechExpBaseTN = 13;

                myClass.asfRetroBaseTP = 1;
                myClass.asfIntroBaseTP = 2;
                myClass.asfStdBaseTP = 3;
                myClass.asfAdvBaseTP = 4;
                myClass.asfExpBaseTP = 5;
                myClass.asfRetroBaseTN = 5;
                myClass.asfIntroBaseTN = 7;
                myClass.asfStdBaseTN = 9;
                myClass.asfAdvBaseTN = 11;
                myClass.asfExpBaseTN = 13;

                myClass.baRetroBaseTP = 0;
                myClass.baIntroBaseTP = 0;
                myClass.baStdBaseTP = 3;
                myClass.baAdvBaseTP = 4;
                myClass.baExpBaseTP = 5;
                myClass.baRetroBaseTN = 0;
                myClass.baIntroBaseTN = 0;
                myClass.baStdBaseTN = 9;
                myClass.baAdvBaseTN = 11;
                myClass.baExpBaseTN = 13;

                myClass.scRetroBaseTP = 2;
                myClass.scIntroBaseTP = 3;
                myClass.scStdBaseTP = 4;
                myClass.scAdvBaseTP = 5;
                myClass.scExpBaseTP = 6;
                myClass.scRetroBaseTN = 5;
                myClass.scIntroBaseTN = 8;
                myClass.scStdBaseTN = 11;
                myClass.scAdvBaseTN = 14;
                myClass.scExpBaseTN = 17;

                myClass.dropRetroBaseTP = 2;
                myClass.dropIntroBaseTP = 3;
                myClass.dropStdBaseTP = 4;
                myClass.dropAdvBaseTP = 5;
                myClass.dropExpBaseTP = 6;
                myClass.dropRetroBaseTN = 5;
                myClass.dropIntroBaseTN = 8;
                myClass.dropStdBaseTN = 11;
                myClass.dropAdvBaseTN = 14;
                myClass.dropExpBaseTN = 17;

                myClass.blueprintTN = -1;
                myClass.blueprintTP = 0;
                myClass.schematicsTN = -2;
                myClass.schematicsTP = -1;
                myClass.noPrototypeBayTN = 1;
                myClass.noPrototypeBayTP = 1;
                myClass.newStdChassisTN = 6;
                myClass.newStdChassisTP = 4;
                myClass.newOmniChassisTN = 8;
                myClass.newOmniChassisTP = 5;
                myClass.newComponentTN = 10;
                myClass.newComponentTP = 6;
                myClass.newMinorVarTN = 0;
                myClass.newMinorVarTP = -1;
                myClass.newModVarTN = 3;
                myClass.newModVarTP = 2;
                myClass.newMajorVarTN = 5;
                myClass.newMajorVarTP = 3;
                myClass.newOmniConfigTN = -1;
                myClass.newOmniConfigTP = -1;
                myClass.runSimulationsTN = -2;
                myClass.runSimulationsTP = 1;
                myClass.compileDesignTN = -1;
                myClass.compileDesignTP = 0;
                myClass.buildPrototypeTN = -1;
                myClass.buildPrototypeTP = 0;
                myClass.fieldTestTN = -2;
                myClass.fieldTestTP = 0;
                myClass.workOutIssuesTN = -1;
                myClass.workOutIssuesTP = 0;

                myClass.criticalFailsTN = -1;
                myClass.criticalFailsTP = .2;
                myClass.sevensTakenTN = -1;
                myClass.sevensTakenTP = 0;
    }
            catch(Exception ex)
            {
                MessageBox.Show("Error Message.  " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalculateValues()
        {
            // Update the forms fields based on current data.
            UpdateTechLevel();
            UpdateUnitType();
            UpdateBaseTNTP();
            UpdateResearchTNTP();
            UpdateQuirkTN();
            UpdateDevelopTNTP();
            UpdateSPCost();
            UpdateTotalTP();
            UpdateMonths();
            UpdateSorties();
        }

        // Form Updates
        private void UpdateUnitType()
        {
            try
            {
                if (mainForm.UnitType >= 0)
                {
                    unitType = unitTypes[mainForm.UnitType];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Tech Level.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTechLevel()
        {
            try
            {
                if (mainForm.Techlevel >= 0)
                {
                    techLevel = techLevels[mainForm.Techlevel];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Tech Level.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBaseTNTP()
        {
            try
            {
                switch (techLevel)
                {
                    case str_retroTechLvl:
                        if (unitType == str_mechUnitType)
                        {
                            mainForm.BaseTN = mechRetroBaseTN.ToString();
                            mainForm.BaseTP = mechRetroBaseTP.ToString();
                        }
                        else if (unitType == str_asfUnitType)
                        {
                            mainForm.BaseTN = asfRetroBaseTN.ToString();
                            mainForm.BaseTP = asfRetroBaseTP.ToString();
                        }
                        else if (unitType == str_veeUnitType)
                        {
                            mainForm.BaseTN = veeRetroBaseTN.ToString();
                            mainForm.BaseTP = veeRetroBaseTP.ToString();
                        }
                        else if (unitType == str_baUnitType)
                        {
                            mainForm.BaseTN = baRetroBaseTN.ToString();
                            mainForm.BaseTP = baRetroBaseTP.ToString();
                        }
                        else if (unitType == str_smallUnitType)
                        {
                            mainForm.BaseTN = scRetroBaseTN.ToString();
                            mainForm.BaseTP = scRetroBaseTP.ToString();
                        }
                        else if (unitType == str_dropshipUnitType)
                        {
                            mainForm.BaseTN = dropRetroBaseTN.ToString();
                            mainForm.BaseTP = dropRetroBaseTP.ToString();
                        }

                        baseTN = Convert.ToDouble(mainForm.BaseTN);
                        baseTP = Convert.ToDouble(mainForm.BaseTP);
                        break;

                    case str_introTechLvl:
                        if (unitType == str_mechUnitType)
                        {
                            mainForm.BaseTN = mechIntroBaseTN.ToString();
                            mainForm.BaseTP = mechIntroBaseTP.ToString();
                        }
                        else if (unitType == str_asfUnitType)
                        {
                            mainForm.BaseTN = asfIntroBaseTN.ToString();
                            mainForm.BaseTP = asfIntroBaseTP.ToString();
                        }
                        else if (unitType == str_veeUnitType)
                        {
                            mainForm.BaseTN = veeIntroBaseTN.ToString();
                            mainForm.BaseTP = veeIntroBaseTP.ToString();
                        }
                        else if (unitType == str_baUnitType)
                        {
                            mainForm.BaseTN = baIntroBaseTN.ToString();
                            mainForm.BaseTP = baIntroBaseTP.ToString();
                        }
                        else if (unitType == str_smallUnitType)
                        {
                            mainForm.BaseTN = scIntroBaseTN.ToString();
                            mainForm.BaseTP = scIntroBaseTP.ToString();
                        }
                        else if (unitType == str_dropshipUnitType)
                        {
                            mainForm.BaseTN = dropIntroBaseTN.ToString();
                            mainForm.BaseTP = dropIntroBaseTP.ToString();
                        }

                        baseTN = Convert.ToDouble(mainForm.BaseTN);
                        baseTP = Convert.ToDouble(mainForm.BaseTP);
                        break;

                    case str_stdTechLvl:
                        if (unitType == str_mechUnitType)
                        {
                            mainForm.BaseTN = mechStdBaseTN.ToString();
                            mainForm.BaseTP = mechStdBaseTP.ToString();
                        }
                        else if (unitType == str_asfUnitType)
                        {
                            mainForm.BaseTN = asfStdBaseTN.ToString();
                            mainForm.BaseTP = asfStdBaseTP.ToString();
                        }
                        else if (unitType == str_veeUnitType)
                        {
                            mainForm.BaseTN = veeStdBaseTN.ToString();
                            mainForm.BaseTP = veeStdBaseTP.ToString();
                        }
                        else if (unitType == str_baUnitType)
                        {
                            mainForm.BaseTN = baStdBaseTN.ToString();
                            mainForm.BaseTP = baStdBaseTP.ToString();
                        }
                        else if (unitType == str_smallUnitType)
                        {
                            mainForm.BaseTN = scStdBaseTN.ToString();
                            mainForm.BaseTP = scStdBaseTP.ToString();
                        }
                        else if (unitType == str_dropshipUnitType)
                        {
                            mainForm.BaseTN = dropStdBaseTN.ToString();
                            mainForm.BaseTP = dropStdBaseTP.ToString();
                        }

                        baseTN = Convert.ToDouble(mainForm.BaseTN);
                        baseTP = Convert.ToDouble(mainForm.BaseTP);
                        break;

                    case str_advTechLvl:
                        if (unitType == str_mechUnitType)
                        {
                            mainForm.BaseTN = mechAdvBaseTN.ToString();
                            mainForm.BaseTP = mechAdvBaseTP.ToString();
                        }
                        else if (unitType == str_asfUnitType)
                        {
                            mainForm.BaseTN = asfAdvBaseTN.ToString();
                            mainForm.BaseTP = asfAdvBaseTP.ToString();
                        }
                        else if (unitType == str_veeUnitType)
                        {
                            mainForm.BaseTN = veeAdvBaseTN.ToString();
                            mainForm.BaseTP = veeAdvBaseTP.ToString();
                        }
                        else if (unitType == str_baUnitType)
                        {
                            mainForm.BaseTN = baAdvBaseTN.ToString();
                            mainForm.BaseTP = baAdvBaseTP.ToString();
                        }
                        else if (unitType == str_smallUnitType)
                        {
                            mainForm.BaseTN = scAdvBaseTN.ToString();
                            mainForm.BaseTP = scAdvBaseTP.ToString();
                        }
                        else if (unitType == str_dropshipUnitType)
                        {
                            mainForm.BaseTN = dropAdvBaseTN.ToString();
                            mainForm.BaseTP = dropAdvBaseTP.ToString();
                        }

                        baseTN = Convert.ToDouble(mainForm.BaseTN);
                        baseTP = Convert.ToDouble(mainForm.BaseTP);
                        break;

                    case str_expTechLvl:
                        if (unitType == str_mechUnitType)
                        {
                            mainForm.BaseTN = mechExpBaseTN.ToString();
                            mainForm.BaseTP = mechExpBaseTP.ToString();
                        }
                        else if (unitType == str_asfUnitType)
                        {
                            mainForm.BaseTN = asfExpBaseTN.ToString();
                            mainForm.BaseTP = asfExpBaseTP.ToString();
                        }
                        else if (unitType == str_veeUnitType)
                        {
                            mainForm.BaseTN = veeExpBaseTN.ToString();
                            mainForm.BaseTP = veeExpBaseTP.ToString();
                        }
                        else if (unitType == str_baUnitType)
                        {
                            mainForm.BaseTN = baExpBaseTN.ToString();
                            mainForm.BaseTP = baExpBaseTP.ToString();
                        }
                        else if (unitType == str_smallUnitType)
                        {
                            mainForm.BaseTN = scExpBaseTN.ToString();
                            mainForm.BaseTP = scExpBaseTP.ToString();
                        }
                        else if (unitType == str_dropshipUnitType)
                        {
                            mainForm.BaseTN = dropExpBaseTN.ToString();
                            mainForm.BaseTP = dropExpBaseTP.ToString();
                        }

                        baseTN = Convert.ToDouble(mainForm.BaseTN);
                        baseTP = Convert.ToDouble(mainForm.BaseTP);
                        break;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating Base TN/TP.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateResearchTNTP()
        {
            try
            {
                double _runSimsTN = 0;
                double _runSimsTP = 0;
                double _compileTN = 0;
                double _compileTP = 0;
                double _takeSevenTN = 0;
                double _takeSevenTP = 0;
                double _criticalFailTN = 0;
                double _criticalFailTP = 1;
                double _protoTypeTN = 0;
                double _protoTypeTP = 0;
                double _projectTN = 0;
                double _projectTP = 0;
                var _tempTuple = Tuple.Create(0.0, 0.0);
                double _blueprintTN = 0;
                double _blueprintTP = 0;
                var _tempTuple2 = Tuple.Create(0.0, 0.0);

                if (mainForm.RunSims)
                {
                    _runSimsTN = mainForm.SimulationCount * runSimulationsTN;
                    _runSimsTP = mainForm.SimulationCount * runSimulationsTP;
                }
                if (mainForm.CompileDesigns)
                {
                    _compileTN = mainForm.CompileCount * compileDesignTN;
                    _compileTP = mainForm.CompileCount * compileDesignTP;
                }
                if (mainForm.ResearchTakeSeven)
                {
                    _takeSevenTN = mainForm.ResearchTakeSevenCount * sevensTakenTN;
                    _takeSevenTP = mainForm.ResearchTakeSevenCount * sevensTakenTP;
                }
                if (mainForm.ResearchCriticalFail)
                {
                    _criticalFailTN = mainForm.ResearchCriticalFailCount * criticalFailsTN;
                    _criticalFailTP = 1 + mainForm.ResearchCriticalFailCount * criticalFailsTP;
                }
                if (mainForm.PrototypeBay)
                {
                    _protoTypeTN = noPrototypeBayTN;
                    _protoTypeTP = noPrototypeBayTP;
                }

                _tempTuple = updateProjectTNTP();
                _projectTN = _tempTuple.Item1;
                _projectTP = _tempTuple.Item2;
                _tempTuple2 = updateBluePrintTNTP();
                _blueprintTN = _tempTuple2.Item1;
                _blueprintTP = _tempTuple2.Item2;

                projectBlueprintTP = _projectTP + blueprintTP;
                
                researchTN = (baseTN + _runSimsTN + _compileTN + _takeSevenTN + _projectTN + _blueprintTN + _protoTypeTN + _criticalFailTN);
                researchExtraTP = ((baseTP + _runSimsTP + _compileTP + _takeSevenTP + _projectTP + _blueprintTP + _protoTypeTP) * _criticalFailTP) - baseTP;

                mainForm.ResearchTN = Math.Round(researchTN, 3).ToString();
                mainForm.ResearchTP = Math.Round(researchExtraTP, 3).ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating Research TN/TP.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDevelopTNTP()
        {
            try
            {
                double _buildPrototypesTN = 0;
                double _buildPrototypesTP = 0;
                double _fieldTestTN = 0;
                double _fieldTestTP = 0;
                double _workOutIssuesTN = 0;
                double _workOutIssuesTP = 0;
                double _takeSevenTN = 0;
                double _takeSevenTP = 0;
                double _criticalFailTN = 0;
                double _criticalFailTP = 1;
                double _protoTypeTN = 0;
                double _protoTypeTP = 0;
                double _projectTN = 0;
                double _projectTP = 0;
                var _tempTuple = Tuple.Create(0.0, 0.0);
                double _blueprintTN = 0;
                double _blueprintTP = 0;
                var _tempTuple2 = Tuple.Create(0.0, 0.0);

                if (mainForm.BuildPrototypes)
                {
                    _buildPrototypesTN = mainForm.BuildPrototypeCount * buildPrototypeTN;
                    _buildPrototypesTP = mainForm.BuildPrototypeCount * buildPrototypeTP;
                }
                if (mainForm.FieldTest)
                {
                    _fieldTestTN = mainForm.FieldTestCount * fieldTestTN;
                    _fieldTestTP = mainForm.FieldTestCount * fieldTestTP;
                }
                if (mainForm.WorkOutIssues)
                {
                    _workOutIssuesTN = mainForm.WorkOutIssuesCount * workOutIssuesTN;
                    _workOutIssuesTP = mainForm.WorkOutIssuesCount * workOutIssuesTP;
                }
                if (mainForm.DevelopTakeSeven)
                {
                    _takeSevenTN = mainForm.DevelopTakeSevenCount * sevensTakenTN;
                    _takeSevenTP = mainForm.DevelopTakeSevenCount * sevensTakenTP;
                }
                if (mainForm.DevelopCriticalFail)
                {
                    _criticalFailTN = mainForm.DevelopCriticalFailCount * criticalFailsTN;
                    _criticalFailTP = 1 + mainForm.DevelopCriticalFailCount * criticalFailsTP;
                }
                if (mainForm.PrototypeBay)
                {
                    _protoTypeTN = noPrototypeBayTN;
                    _protoTypeTP = noPrototypeBayTP;
                }

                _tempTuple = updateProjectTNTP();
                _projectTN = _tempTuple.Item1;
                _projectTP = _tempTuple.Item2;
                _tempTuple2 = updateBluePrintTNTP();
                _blueprintTN = _tempTuple2.Item1;
                _blueprintTP = _tempTuple2.Item2;

                developTN = (baseTN + _buildPrototypesTN + _fieldTestTN + _workOutIssuesTN + _projectTN + _takeSevenTN + _blueprintTN + _protoTypeTN + _criticalFailTN);
                developExtraTP = ((baseTP + _buildPrototypesTP + _fieldTestTP + _workOutIssuesTP + _takeSevenTP + _projectTP + _blueprintTP + _protoTypeTP) * _criticalFailTP) - baseTP - _protoTypeTP - _projectTP - _blueprintTP;

                developTN += Convert.ToDouble(mainForm.QuirkTN);

                mainForm.DevelopTN = Math.Round(developTN, 3).ToString();
                mainForm.DevelopTP = Math.Round(developExtraTP, 3).ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating Develop TN/TP.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSPCost()
        {
            try
            {
                mainForm.SPCost = Math.Round(mainForm.BuildPrototypeCount * Convert.ToDouble(mainForm.PrototypeCost), 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating SP Cost.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTotalTP()
        {
            try
            {
                //mainForm.TotalTP = Math.Round(Convert.ToDouble(mainForm.BaseTP) + Convert.ToDouble(mainForm.ResearchTP) + Convert.ToDouble(mainForm.DevelopTP) - projectBlueprintTP - projectNoProto, 3).ToString();
                mainForm.TotalTP = Math.Round(Convert.ToDouble(mainForm.BaseTP) + Convert.ToDouble(mainForm.ResearchTP) + Convert.ToDouble(mainForm.DevelopTP), 3).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Total TP.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateMonths()
        {
            try
            {
                mainForm.MonthsTaken = (mainForm.CompileCount + mainForm.WorkOutIssuesCount + mainForm.ResearchTakeSevenCount + mainForm.DevelopTakeSevenCount 
                    + mainForm.ResearchCriticalFailCount + mainForm.DevelopCriticalFailCount).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Months.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateSorties()
        {
            try
            {
                mainForm.SortiesTaken = mainForm.FieldTestCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Sorties.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateQuirkTN()
        {
            try
            {
                int _tn = 0;
                int _iteration = 0;
                int _quirkStepOrig = 0;
                int _quirkStepNew = 0;
                int _origPosQuirkVal = 0;
                int _newPosQuirkVal = 0;
                int _origNegQuirkVal = 0;
                int _newNegQuirkVal = 0;
                int _quirkStartStep = 0;
                int _quirkEndStep = 0;

                //This adds each change step together for the final TN.  For example, going from -6 to 5, would add all 12 TN's together.  Going from 0 to 2 would add 0->1 and 1->2 TN together.

                _origPosQuirkVal = comparePosQuirks(mainForm.CheckedOriginalPosQuirks);
                _newPosQuirkVal = comparePosQuirks(mainForm.CheckedNewPosQuirks);
                _origNegQuirkVal = compareNegQuirks(mainForm.CheckedOriginalNegQuirks);
                _newNegQuirkVal = compareNegQuirks(mainForm.CheckedNewNegQuirks);

                _quirkStepOrig = (_origPosQuirkVal + _origNegQuirkVal);
                _quirkStepNew = (_newPosQuirkVal + _newNegQuirkVal);

                // Check to make sure we are within the bounds
                if (_quirkStepOrig <= quirkChangeStep.Last() && _quirkStepOrig >= quirkChangeStep.First() && _quirkStepNew <= quirkChangeStep.Last() && _quirkStepNew >= quirkChangeStep.First())
                {
                    // Find our start and end points.
                    foreach (var item in quirkChangeStep)
                    {
                        if (item == _quirkStepOrig)
                        {
                            _quirkStartStep = _iteration;
                        }

                        if (item == _quirkStepNew)
                        {
                            _quirkEndStep = _iteration;
                        }

                        _iteration++;
                    }

                    // Add up our TN from the start and end points.

                    // Handles one step.
                    if (_quirkStartStep == (_quirkEndStep - 1))
                    {
                        _tn += quirkChangeStepModifier[_quirkStartStep];
                    }
                    // Handles multiple removals.
                    else if (_quirkStartStep > _quirkEndStep)
                    {
                        int _i = _quirkStartStep - 1;

                        while(_i >= _quirkEndStep)
                        {
                            _tn += quirkChangeStepModifier[_i];
                            _i--;
                        }
                    }
                    // Handles multiple additions.
                    else
                    {
                        if (_quirkStartStep != _quirkEndStep)
                        { 
                            int _i = _quirkStartStep;

                            while (_i < _quirkEndStep)
                            {
                                _tn += quirkChangeStepModifier[_i];
                                _i++;
                            }
                        }
                        else if (perkSelected)
                        {
                            _tn += quirkChangeStepModifier[_quirkStartStep];
                        }
                    }

                    mainForm.QuirkTN = _tn.ToString();
                }
                else
                {
                    // Unselects the currently selected quirk so the user doesn't have to.
                    mainForm.UnselectCheckedListBoxItem(); 
                    MessageBox.Show("Too many quirks selected.", "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                perkSelected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Quirk TN.  " + ex.ToString(), "Form Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Functions for the form updates
        private Tuple<double, double> updateProjectTNTP()
        {
            double _projectTN = 0;
            double _projectTP = 0;

            switch (projectTypes[mainForm.ProjectType])
            {
                case str_newStd:
                    _projectTN = newStdChassisTN;
                    _projectTP = newStdChassisTP;
                    break;
                case str_newOmni:
                    _projectTN = newOmniChassisTN;
                    _projectTP = newOmniChassisTP;
                    break;
                case str_newComp:
                    _projectTN = newComponentTN;
                    _projectTP = newComponentTP;
                    break;
                case str_minorVar:
                    _projectTN = newMinorVarTN;
                    _projectTP = newMinorVarTP;
                    break;
                case str_modVar:
                    _projectTN = newModVarTN;
                    _projectTP = newModVarTP;
                    break;
                case str_majorVar:
                    _projectTN = newMajorVarTP;
                    _projectTP = newMajorVarTP;
                    break;
                case str_omniConfig:
                    _projectTN = newOmniConfigTN;
                    _projectTP = newOmniConfigTP;
                    break;
            }

            return Tuple.Create(_projectTN, _projectTP);
        }
        private Tuple<double, double> updateBluePrintTNTP()
        {
            double _blueprintTN = 0;
            double _blueprintTP = 0;

            switch(planTypes[mainForm.Plans])
            {
                case str_none:
                    _blueprintTN = 0;
                    _blueprintTP = 0;
                    break;
                case str_blueprint:
                    _blueprintTN = blueprintTN;
                    _blueprintTP = blueprintTP;
                    break;
                case str_schematic:
                    _blueprintTN = schematicsTN;
                    _blueprintTP = schematicsTP;
                    break;
            }

            return Tuple.Create(_blueprintTN, _blueprintTP);
        }

        private int comparePosQuirks(CheckedListBox.CheckedItemCollection posQuirkList)
        {
            var _tn = 0;
            var _iteration = 0;

            foreach (string item in positiveQuirks)
            {
                if (posQuirkList.Contains(item))
                {
                    _tn += positiveQuirksValues[_iteration];
                }

                _iteration++;
            }

            if (_tn != 0)
            {
                perkSelected = true;
            }

            return _tn;
        }
        private int compareNegQuirks(CheckedListBox.CheckedItemCollection negQuirKList)
        {
            var _tn = 0;
            var _iteration = 0;

            foreach (string item in negativeQuirks)
            {
                if (negQuirKList.Contains(item))
                {
                    _tn += negativeQuirksValues[_iteration];
                }

                _iteration++;
            }

            if (_tn != 0)
            {
                perkSelected = true;
            }

            return _tn;
        }
    }
}