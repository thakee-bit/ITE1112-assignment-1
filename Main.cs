using System.Windows.Forms;

namespace ITE1112_assignment_1
{
  public partial class Main : Form
  {

    // The result window.
    Result formResult = new Result();

    // A dictionary where the key is the module code and the values are the module name.
    Dictionary<string, string> modules = new Dictionary<string, string>();


    public Main()
    {
      // Construct the modules dictionary.
      modules["ITE 1112"] = "Visual Application Programming";
      modules["ITE 1712"] = "Web Design";
      modules["ITE 1812"] = "Mathematics for IT";
      modules["ITE 1912"] = "Communication Skills Development";
      modules["ITE 1922"] = "ICT Applications";

      InitializeComponent();

      // Build the modules drop down.
      foreach (string module_code in modules.Keys)
      {
        string module_name = modules[module_code];
        drpModule.Items.Add(new drpItemModule(module_code, module_name));
      }

    }

    // This validate if the text box value is integer and 0 <= value <= 100.
    private void validateTxtBoxInt100(object sender, System.ComponentModel.CancelEventArgs e)
    {
      TextBox txtBox = (TextBox)sender;
      errorProvider.SetError(txtBox, ""); // Clear the error.
      if (!int.TryParse(txtBox.Text, out int value) || value < 0 || value > 100)
      {
        errorProvider.SetError(txtBox, "Enter a valid integer between 0 and 100 inclusive.");
      }
    }

    private void validateTxtBoxNonEmpyt(object sender, System.ComponentModel.CancelEventArgs e)
    {
      TextBox txtBox = (TextBox)sender;
      errorProvider.SetError(txtBox, ""); // Clear the error.
      if (txtBox.Text.Trim() == "")
      {
        errorProvider.SetError(txtBox, "Enter a valid string.");
      }
    }

    private void drpModule_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      errorProvider.SetError(drpModule, ""); // Clear the error.
      if (drpModule.SelectedItem == null)
      {
        errorProvider.SetError(drpModule, "Select a module.");
      }
    }


    private bool hasAnyError()
    {
      foreach (Control control in errorProvider.ContainerControl.Controls)
      {
        string errorMessage = errorProvider.GetError(control);
        if (!string.IsNullOrEmpty(errorMessage))
        {
          return true;
        }
      }
      return false;
    }

    private void btnCalculate_Click(object sender, EventArgs e)
    {

      // This will trigger a validation in case if the text box are not touched by the user and
      // no validation ran before.
      this.validateTxtBoxNonEmpyt(txtName, new System.ComponentModel.CancelEventArgs());
      this.validateTxtBoxNonEmpyt(txtRegNumber, new System.ComponentModel.CancelEventArgs());

      if (!hasAnyError())
      {
        formResult.updateData(new FormData(
          txtName.Text,
          txtRegNumber.Text,
          ((drpItemModule)drpModule.SelectedItem).moduleCode,
          ((drpItemModule)drpModule.SelectedItem).moduleName,
          int.Parse(txtCaWeightage.Text),
          int.Parse(txtCaMarks.Text),
          int.Parse(txtFeMarks.Text),
          int.Parse(txtAttendance.Text)));

        formResult.Show();
      }
    }
  }
}