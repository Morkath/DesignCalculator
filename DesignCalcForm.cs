namespace DesignCalculator
{
    public partial class DesignCalcForm : Form
    {
        public Program myProgram;
        public bool update = true;

        public int UnitType
        {
            get { return combo_unitType.SelectedIndex; }
            set { combo_unitType.SelectedIndex = value; }
        }
        public int Techlevel
        {
            get { return combo_techLevel.SelectedIndex; }
            set { combo_techLevel.SelectedIndex = value; }
        }
        public int ProjectType
        {
            get { return combo_projectType.SelectedIndex; }
            set { combo_projectType.SelectedIndex = value; }
        }
        public int Plans
        {
            get { return combo_plans.SelectedIndex; }
            set { combo_plans.SelectedIndex = value; }
        }

        public double SimulationCount
        {
            get { return decimal.ToDouble(num_runSimsCount.Value); }
        }
        public double CompileCount
        {
            get { return decimal.ToDouble(num_compileDesignCount.Value); }
        }
        public double ResearchTakeSevenCount
        {
            get { return decimal.ToDouble(num_researchTakeSevenCount.Value); }
        }
        public double ResearchCriticalFailCount
        {
            get { return decimal.ToDouble(num_researchCriticalFailCount.Value); }
        }
        public double BuildPrototypeCount
        {
            get { return decimal.ToDouble(num_buildPrototypeCount.Value); }
        }
        public double FieldTestCount
        {
            get { return decimal.ToDouble(num_fieldTestCount.Value); }
        }
        public double WorkOutIssuesCount
        {
            get { return decimal.ToDouble(num_workOutIssuesCount.Value); }
        }
        public double DevelopTakeSevenCount
        {
            get { return decimal.ToDouble(num_developTakeSevenCount.Value); }
        }
        public double DevelopCriticalFailCount
        {
            get { return decimal.ToDouble(num_developCriticalFailCount.Value); }
        }

        public string BaseTN
        {
            get { return tb_baseTN.Text; }
            set { tb_baseTN.Text = value; }
        }
        public string BaseTP
        {
            get { return tb_baseTP.Text; }
            set { tb_baseTP.Text = value; }
        }
        public string SPCost
        {
            get { return tb_spCost.Text; }
            set { tb_spCost.Text = value; }
        }
        public string TotalTP
        {
            get { return tb_totalTP.Text; }
            set { tb_totalTP.Text = value; }
        }
        public string MonthsTaken
        {
            get { return tb_monthsTaken.Text; }
            set { tb_monthsTaken.Text = value; }
        }
        public string SortiesTaken
        {
            get { return tb_sorties.Text; }
            set { tb_sorties.Text = value; }
        }
        public string ResearchTN
        {
            get { return tb_researchTN.Text; }
            set { tb_researchTN.Text = value; }
        }
        public string ResearchTP
        {
            get { return tb_researchExtraTP.Text; }
            set { tb_researchExtraTP.Text = value; }
        }
        public string DevelopTN
        {
            get { return tb_developmentTN.Text; }
            set { tb_developmentTN.Text = value; }
        }
        public string DevelopTP
        {
            get { return tb_developmentExtraTP.Text; }
            set { tb_developmentExtraTP.Text = value; }
        }
        public string QuirkTN
        {
            get { return tb_quirkTN.Text; }
            set { tb_quirkTN.Text = value; }
        }
        public string PrototypeCost
        {
            get { return tb_prototypeCost.Text; }
            set { tb_prototypeCost.Text = value; }
        }

        public bool PrototypeBay
        {
            get { return cb_noPrototypeBay.Checked; }
            set { cb_noPrototypeBay.Checked = value; }
        }
        public bool RunSims
        {
            get { return cb_runSims.Checked; }
            set { cb_runSims.Checked = value; }
        }
        public bool CompileDesigns
        {
            get { return cb_compileDesign.Checked; }
            set { cb_compileDesign.Checked = value; }
        }
        public bool ResearchTakeSeven
        {
            get { return cb_researchTakeSeven.Checked; }
            set { cb_researchTakeSeven.Checked = value; }
        }
        public bool ResearchCriticalFail
        {
            get { return cb_researchCriticalFail.Checked; }
            set { cb_researchCriticalFail.Checked = value; }
        }
        public bool BuildPrototypes
        {
            get { return cb_buildPrototypes.Checked; }
            set { cb_buildPrototypes.Checked = value; }
        }
        public bool FieldTest
        {
            get { return cb_fieldTest.Checked; }
            set { cb_fieldTest.Checked = value; }
        }
        public bool WorkOutIssues
        {
            get { return cb_workOutIssues.Checked; }
            set { cb_workOutIssues.Checked = value; }
        }
        public bool DevelopTakeSeven
        {
            get { return cb_developTakeSeven.Checked; }
            set { cb_developTakeSeven.Checked = value; }
        }
        public bool DevelopCriticalFail
        {
            get { return cb_developCriticalFail.Checked; }
            set { cb_developCriticalFail.Checked = value; }
        }

        public CheckedListBox.CheckedItemCollection OriginalPosQuirks
        {
            get { return clb_originalPosQuirks.CheckedItems; }
        }
        public CheckedListBox.CheckedItemCollection OriginalNegQuirks
        {
            get { return clb_originalNegQuirks.CheckedItems; }
        }
        public CheckedListBox.CheckedItemCollection NewPosQuirks
        {
            get { return clb_newPosQuirks.CheckedItems; }
        }
        public CheckedListBox.CheckedItemCollection NewNegQuirks
        {
            get { return clb_newNegQuirks.CheckedItems; }
        }

        public DesignCalcForm(Program myClass)
        {
            myProgram = myClass;
            InitializeComponent();
        }
        public void SetFieldValues()
        {
            UpdateTechField(myProgram.techLevels);
            UpdateTypeField(myProgram.unitTypes);
            UpdateProjectField(myProgram.projectTypes);
            UpdatePlansField(myProgram.planTypes);
            UpdateOldPosQuirks(myProgram.positiveQuirks);
            UpdateOldNegQuirks(myProgram.negativeQuirks);
            UpdateNewPosQuirks(myProgram.positiveQuirks);
            UpdateNewNegQuirks(myProgram.negativeQuirks);
        }
        public void SetInitialValues()
        {
            update = false;
            combo_unitType.SelectedIndex = 0;
            combo_techLevel.SelectedIndex = 0;
            combo_projectType.SelectedIndex = 0;
            combo_plans.SelectedIndex = 0;
            update = true;
        }

        private void DesignCalc_Load(object sender, EventArgs e)
        {
            SetFieldValues();
            SetInitialValues();
            myProgram.UpdateValues();
        }

        // Form Updates
        private void UpdateTechField(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { combo_techLevel.Items.Add(s); });
        }
        private void UpdateTypeField(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { combo_unitType.Items.Add(s); });
        }
        private void UpdateProjectField(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { combo_projectType.Items.Add(s); });
        }
        private void UpdatePlansField(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { combo_plans.Items.Add(s); });
        }

        private void UpdateOldPosQuirks(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { clb_originalPosQuirks.Items.Add(s); });
        }
        private void UpdateOldNegQuirks(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { clb_originalNegQuirks.Items.Add(s); });
        }
        private void UpdateNewPosQuirks(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { clb_newPosQuirks.Items.Add(s); });
        }
        private void UpdateNewNegQuirks(List<string> incomingList)
        {
            incomingList.ForEach(delegate (string s) { clb_newNegQuirks.Items.Add(s); });
        }

        // Event Handlers
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myProgram.SaveDesignFile();
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myProgram.LoadDesignFile();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myProgram.AboutDialog();
        }

        private void comb_unitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void comb_techLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void comb_projectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void comb_plans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }

        private void tb_prototypeCost_TextChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }

        private void cb_noPrototypeBay_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_runSims_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_compileDesign_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_researchTakeSeven_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_researchCriticalFail_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_buildPrototypes_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_fieldTest_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_workOutIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_developTakeSeven_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void cb_developCriticalFail_CheckedChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }

        private void num_runSimsCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_compileDesignCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_researchTakeSevenCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_researchCriticalFailCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_buildPrototypeCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_fieldTestCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_workOutIssuesCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_developTakeSevenCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void num_developCriticalFailCount_ValueChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }

        private void clb_originalPosQuirks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void clb_originalNegQuirks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void clb_newPosQuirks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }
        private void clb_newNegQuirks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update) { myProgram.UpdateValues(); };
        }

    }
}