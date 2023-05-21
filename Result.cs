using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITE1112_assignment_1
{
  public partial class Result : Form
  {
    public Result()
    {
      InitializeComponent();
    }

    public void updateData(FormData data)
    {
      if (data == null) { return; }

      lblNameValue.Text = data.name.ToString();
      lblRegNumberValue.Text = data.regNumber.ToString();
      lblModuleCodeValue.Text = data.moduleCode.ToString();
      lblModuleNameValue.Text = data.moduleName.ToString();
      lblCaWeightageValue.Text = data.caWeightage.ToString();
      lblCaMarksValue.Text = data.caMarks.ToString();
      lblFeMarksValue.Text = data.feMarks.ToString();
      lblAttendanceValue.Text = data.attendance.ToString();

      double marks = (
        data.caMarks * ((double)data.caWeightage) / 100.0
        ) + (
        data.feMarks * (1.0 - ((double)data.caWeightage) / 100.0)
        );

      char initialGrade = '-';
      char finalGrade = '-';

      if (marks >= 85)
      {
        initialGrade = 'A';
      } else if (marks >= 65)
      {
        initialGrade = 'B';
      } else if (marks >= 50)
      {
        initialGrade = 'C';
      } else if (marks >= 40)
      {
        initialGrade = 'D';
      } else
      {
        initialGrade = 'F';
      }

      if (data.attendance < 60)
      {
        finalGrade = 'F';
      } else if (data.attendance < 80)
      {
        finalGrade = (char) Math.Max(initialGrade, 'C');
      } else
      {
        finalGrade = initialGrade;
      }

      lblGradeValue.Text = finalGrade.ToString();
      lblAttendanceFlag.Visible = (initialGrade != finalGrade);
      lblAttendanceFlag.Text = $"The grade is less then calculatd (which is {initialGrade}) due to poor attendance.";

  }

    private void Result_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (e.CloseReason == CloseReason.UserClosing)
      {
        e.Cancel = true; // Cancel the closing event.
        Hide(); // Hide the form instead of closing.
      }
    }
  }
}
