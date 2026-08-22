using System;
using System.Windows.Forms;

namespace gymmanagementsystem_2.FORMS
{
    public partial class StaffDashboardForm : Form
    {
        // =========================================================
        // STAFF INFORMATION
        // =========================================================

        private readonly string _staffName;
        private readonly string _staffRole;


        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public StaffDashboardForm(string staffName, string staffRole)
        {
            InitializeComponent();

            _staffName = staffName ?? "";
            _staffRole = staffRole ?? "";

            // IMPORTANT:
            // Do NOT write any:
            //
            // btnMember.Click += ...
            // btnQuickMember.Click += ...
            //
            // here.
            //
            // Designer.cs already connects all button events.
        }


        // =========================================================
        // FORM LOAD
        // =========================================================

        private void StaffDashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblStaffName.Text =
                    "Staff Name: " + _staffName;

                lblStaffRole.Text =
                    "Role: " + _staffRole;

                lblCurrentDate.Text =
                    "Date: " +
                    DateTime.Now.ToString("dd MMMM yyyy");

                lblStatus.Text =
                    "System Status: Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load Staff Dashboard.\n\n" +
                    ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =========================================================
        // COMMON FORM OPENER
        // =========================================================

        private void OpenForm(Form form)
        {
            if (form == null)
                return;

            try
            {
                form.StartPosition =
                    FormStartPosition.CenterScreen;

                /*
                 * ShowDialog() means:
                 *
                 * Staff Dashboard remains open.
                 * Selected Staff Form opens on top.
                 * When selected form closes,
                 * Staff Dashboard becomes active again.
                 */
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open module.\n\n" +
                    ex.Message,
                    "Navigation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                form.Dispose();
            }
        }


        // =========================================================
        // MEMBER
        // =========================================================

        private void btnMember_Click(object sender, EventArgs e)
        {
            OpenForm(
                new StaffMemberForm()
            );
        }


        // =========================================================
        // QUICK MEMBER
        // =========================================================

        private void btnQuickMember_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffMemberForm()
            );
        }


        // =========================================================
        // ATTENDANCE
        // =========================================================

        private void btnAttendance_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffAttendanceForm()
            );
        }


        // =========================================================
        // QUICK ATTENDANCE
        // =========================================================

        private void btnQuickAttendance_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffAttendanceForm()
            );
        }


        // =========================================================
        // PAYMENT
        // =========================================================

        private void btnPayment_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffPaymentForm()
            );
        }


        // =========================================================
        // QUICK PAYMENT
        // =========================================================

        private void btnQuickPayment_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffPaymentForm()
            );
        }


        // =========================================================
        // INVOICE
        // =========================================================

        private void btnInvoice_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffInvoiceForm()
            );
        }


        // =========================================================
        // QUICK INVOICE
        // =========================================================

        private void btnQuickInvoice_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffInvoiceForm()
            );
        }


        // =========================================================
        // TRAINER
        // =========================================================

        private void btnTrainer_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffTrainerForm(
                    _staffName,
                    _staffRole
                )
            );
        }


        // =========================================================
        // QUICK TRAINER
        // =========================================================

        private void btnQuickTrainer_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffTrainerForm(
                    _staffName,
                    _staffRole
                )
            );
        }


        // =========================================================
        // WORKOUT
        // =========================================================

        private void btnWorkout_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffWorkoutForm()
            );
        }


        // =========================================================
        // QUICK WORKOUT
        // =========================================================

        private void btnQuickWorkout_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffWorkoutForm()
            );
        }


        // =========================================================
        // HEALTH
        // =========================================================

        private void btnHealth_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffHealthForm(
                    _staffName,
                    _staffRole
                )
            );
        }


        // =========================================================
        // QUICK HEALTH
        // =========================================================

        private void btnQuickHealth_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffHealthForm(
                    _staffName,
                    _staffRole
                )
            );
        }


        // =========================================================
        // BASIC REPORT
        // =========================================================

        private void btnReport_Click(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffBasicReportForm()
            );
        }


        // =========================================================
        // QUICK REPORT
        // =========================================================

        private void btnQuickReport_Click_1(
            object sender,
            EventArgs e)
        {
            OpenForm(
                new StaffBasicReportForm()
            );
        }


        // =========================================================
        // LOGOUT
        // =========================================================

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result != DialogResult.Yes)
                return;

            /*
             * Close only the Staff Dashboard.
             *
             * LoginForm should handle showing itself again
             * if your login system is designed that way.
             */
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}