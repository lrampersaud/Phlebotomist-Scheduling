using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phlebotomist_Scheduling
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnComute_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int PatientCount = Convert.ToInt32(txtPatients.Text);
            int PhlebotomistsCount = Convert.ToInt32(txtPhlebotomists.Text);
            int minimumTime = Convert.ToInt32(txtMimimumTime.Text);
            int maximumTime = Convert.ToInt32(txtMaximumTime.Text);
            int restarts = Convert.ToInt32(txtRestarts.Text);
            float coolRate = (float)Convert.ToDouble(txtCoolRate.Text);
            int initialTemperature = Convert.ToInt32(txtInitialTemperature.Text);
            int startHour = Convert.ToInt32(txtStartHour.Text);
            int endHour = Convert.ToInt32(txtEndHour.Text);

            List<Patient> Patients = new List<Patient>();
            DateTime begin;
            DateTime end;
            int hour;
            int minute;
            int duration;
            for (int i = 0; i < PatientCount; i++)
            {
                hour = rand.Next(endHour-startHour) + startHour;
                minute = rand.Next(60);
                duration = rand.Next(maximumTime - minimumTime) + minimumTime;
                begin = new DateTime(1900, 1, 1, hour, minute, 0);
                end = begin.AddMinutes(duration);
                Patients.Add(new Patient { BeginTime=begin, EndTime=end, Name = "P"+i.ToString() });
            }


            PhlebotomistScheduler scheduler = new PhlebotomistScheduler(Patients, PhlebotomistsCount, initialTemperature, coolRate, restarts);
            Solution bestSolution = scheduler.GRASP();

            dgSchedule.Rows.Clear();
            dgSchedule.Columns.Clear();

            for (int i=0; i<bestSolution.PhlebotomistsList.Count; i++)
            {
                dgSchedule.Columns.Add("Phlebotomist_" + i, "Phlebotomist " + (i + 1).ToString());
            }

            int rowCount = bestSolution.PhlebotomistsList.Max(p => p.Count)*4;
            dgSchedule.Rows.Add(rowCount);

            int colIndex = 0;
            foreach (var patients in bestSolution.PhlebotomistsList)
            {
                int rowIndex = 0;
                foreach (var p in patients)
                {
                    dgSchedule[colIndex, rowIndex].Value = p.Name;
                    rowIndex++;
                    dgSchedule[colIndex, rowIndex].Value = p.BeginTime.ToShortTimeString();
                    rowIndex++;
                    dgSchedule[colIndex, rowIndex].Value = p.EndTime.ToShortTimeString();
                    rowIndex++;
                    rowIndex++;
                }
                colIndex++;
            }

            lblCost.Text = bestSolution.Cost.ToString();

        }
    }
}
