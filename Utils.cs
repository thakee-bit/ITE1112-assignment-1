using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE1112_assignment_1
{
  // Create a class to represent the ComboBox item
  public class drpItemModule
  {
    public string moduleCode;
    public string moduleName;

    public drpItemModule(string code, string name)
    {
      moduleCode = code;
      moduleName = name;
    }

    public override string ToString()
    {
      return $"{moduleCode} - {moduleName}"; // Display the label in the ComboBox.
    }
  }


  public class FormData
  {
    public string name;
    public string regNumber;
    public string moduleCode;
    public string moduleName;
    public int caWeightage;
    public int caMarks;
    public int feMarks;
    public int attendance;

    public FormData(
      string name,
      string regNumber,
      string moduleCode,
      string moduleName,
      int caWeightage,
      int caMarks,
      int feMarks,
      int attendance)
    {
      this.name = name;
      this.regNumber = regNumber;
      this.moduleCode = moduleCode;
      this.moduleName = moduleName;
      this.caWeightage = caWeightage;
      this.caMarks = caMarks;
      this.feMarks = feMarks;
      this.attendance = attendance;
    }
  }
}
