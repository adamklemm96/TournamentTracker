using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker;
using Tracker.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ICreateTeamRequester callingform;

        public CreateTeamForm(ICreateTeamRequester caller)
        {
            InitializeComponent();

            //CreateSampleData();

            WireUpLists();

            callingform = caller;
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Adam", LastName = "Klemm" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Sam", LastName = "Smith" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Janah", LastName = "Johnes" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Jim", LastName = "Corey" });

        }

        private void WireUpLists()
        {
            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMemberListBox.DataSource = null;

            teamMemberListBox.DataSource = selectedTeamMembers;
            teamMemberListBox.DisplayMember = "FullName";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teamNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);
      
                selectedTeamMembers.Add(p);
                
                WireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";

            }
        }

        private bool ValidateForm()
        {
            // TODO  Add Validation to the form 
            if(firstNameValue.Text.Length == 0 || lastNameValue.Text.Length == 0 || emailValue.Text.Length == 0 || cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void teamMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel) selectTeamMemberDropDown.SelectedItem;


            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();  
            }

        }

        private void removeSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);
                WireUpLists();  
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = teamNameTextBox.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);

            callingform.TeamComplete(t);
            this.Close();
        }

        private void selectTeamMemberDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}