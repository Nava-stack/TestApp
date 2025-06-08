using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Models;

namespace TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EventClass ev = new EventClass();

        private void Form1_Load(object sender, EventArgs e)
        {
            ev.dgvEvents = dgvEvents;
            LoadEventTypes();
            ev.GetAllEvents();
        }

        private void LoadEventTypes()
        {
            cmbEventType.Items.Clear();
            cmbEventType.Items.Add("Tournament");
            cmbEventType.Items.Add("Practice");
            cmbEventType.Items.Add("Seminar");
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                ev.EventName = txtName.Text;
                ev.EventDate = dtpEventDate.Value;
                ev.Location = txtLocation.Text;
                ev.EventType = cmbEventType.SelectedItem?.ToString() ?? "";
                ev.IsIndoor = chkIsIndoor.Checked;
                ev.MaxParticipants = (int)numMaxParticipants.Value;

                ev.AddEvent();
                ClearInputs();
            }
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEventID.Text, out int id) && ValidateInputs())
            {
                ev.EventID = id;
                ev.EventName = txtName.Text;
                ev.EventDate = dtpEventDate.Value;
                ev.Location = txtLocation.Text;
                ev.EventType = cmbEventType.SelectedItem?.ToString() ?? "";
                ev.IsIndoor = chkIsIndoor.Checked;
                ev.MaxParticipants = (int)numMaxParticipants.Value;

                ev.UpdateEvent();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select an event from the table.");
            }
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtEventID.Text, out int id))
            {
                ev.EventID = id;
                ev.DeleteEvent();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select an event to delete.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtEventID.Clear();
            txtName.Clear();
            txtLocation.Clear();
            cmbEventType.SelectedIndex = -1;
            chkIsIndoor.Checked = false;
            numMaxParticipants.Value = 0;
            dtpEventDate.Value = DateTime.Today;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbEventType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            return true;
        }

        private void dgvEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = dgvEvents.Rows[rowIndex];
                txtEventID.Text = row.Cells["EventID"].Value.ToString();
                txtName.Text = row.Cells["EventName"].Value.ToString();
                dtpEventDate.Value = Convert.ToDateTime(row.Cells["EventDate"].Value);
                txtLocation.Text = row.Cells["Location"].Value.ToString();
                cmbEventType.SelectedItem = row.Cells["EventType"].Value.ToString();
                chkIsIndoor.Checked = Convert.ToBoolean(row.Cells["IsIndoor"].Value);
                
                int maxParticipants = Convert.ToInt32(row.Cells["MaxParticipants"].Value);
                if (maxParticipants < numMaxParticipants.Minimum)
                {
                    numMaxParticipants.Value = numMaxParticipants.Minimum;
                }
                else if (maxParticipants > numMaxParticipants.Maximum)
                {
                    numMaxParticipants.Value = numMaxParticipants.Maximum;
                }
                else
                {
                    numMaxParticipants.Value = maxParticipants;
                }
            }
        }
    }
}
