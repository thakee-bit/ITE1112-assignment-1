namespace ITE1112_assignment_1
{
  partial class Main
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      lblModule = new Label();
      drpModule = new ComboBox();
      lblName = new Label();
      lblRegNumber = new Label();
      txtName = new TextBox();
      txtRegNumber = new TextBox();
      lblCaMarks = new Label();
      txtCaMarks = new TextBox();
      lblFeMarks = new Label();
      txtFeMarks = new TextBox();
      lblCaWeightage = new Label();
      txtCaWeightage = new TextBox();
      btnCalculate = new Button();
      lblAttendance = new Label();
      txtAttendance = new TextBox();
      errorProvider = new ErrorProvider(components);
      ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
      SuspendLayout();
      // 
      // lblModule
      // 
      lblModule.AutoSize = true;
      lblModule.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblModule.Location = new Point(43, 123);
      lblModule.Name = "lblModule";
      lblModule.Size = new Size(86, 25);
      lblModule.TabIndex = 0;
      lblModule.Text = " Module";
      // 
      // drpModule
      // 
      drpModule.DropDownStyle = ComboBoxStyle.DropDownList;
      drpModule.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      drpModule.FormattingEnabled = true;
      drpModule.Location = new Point(243, 123);
      drpModule.Name = "drpModule";
      drpModule.Size = new Size(470, 33);
      drpModule.TabIndex = 2;
      drpModule.Validating += drpModule_Validating;
      // 
      // lblName
      // 
      lblName.AutoSize = true;
      lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblName.Location = new Point(43, 32);
      lblName.Name = "lblName";
      lblName.Size = new Size(64, 25);
      lblName.TabIndex = 3;
      lblName.Text = "Name";
      // 
      // lblRegNumber
      // 
      lblRegNumber.AutoSize = true;
      lblRegNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblRegNumber.Location = new Point(43, 74);
      lblRegNumber.Name = "lblRegNumber";
      lblRegNumber.Size = new Size(125, 25);
      lblRegNumber.TabIndex = 4;
      lblRegNumber.Text = "Reg Number";
      // 
      // txtName
      // 
      txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtName.Location = new Point(243, 32);
      txtName.Name = "txtName";
      txtName.Size = new Size(470, 33);
      txtName.TabIndex = 5;
      txtName.Validating += validateTxtBoxNonEmpyt;
      // 
      // txtRegNumber
      // 
      txtRegNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtRegNumber.Location = new Point(243, 76);
      txtRegNumber.Name = "txtRegNumber";
      txtRegNumber.Size = new Size(470, 33);
      txtRegNumber.TabIndex = 6;
      txtRegNumber.Validating += validateTxtBoxNonEmpyt;
      // 
      // lblCaMarks
      // 
      lblCaMarks.AutoSize = true;
      lblCaMarks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblCaMarks.Location = new Point(52, 222);
      lblCaMarks.Name = "lblCaMarks";
      lblCaMarks.Size = new Size(97, 25);
      lblCaMarks.TabIndex = 7;
      lblCaMarks.Text = "CA Marks";
      // 
      // txtCaMarks
      // 
      txtCaMarks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtCaMarks.Location = new Point(243, 219);
      txtCaMarks.Name = "txtCaMarks";
      txtCaMarks.Size = new Size(470, 33);
      txtCaMarks.TabIndex = 8;
      txtCaMarks.Text = "0";
      txtCaMarks.Validating += validateTxtBoxInt100;
      // 
      // lblFeMarks
      // 
      lblFeMarks.AutoSize = true;
      lblFeMarks.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblFeMarks.Location = new Point(52, 269);
      lblFeMarks.Name = "lblFeMarks";
      lblFeMarks.Size = new Size(92, 25);
      lblFeMarks.TabIndex = 9;
      lblFeMarks.Text = "FE Marks";
      // 
      // txtFeMarks
      // 
      txtFeMarks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtFeMarks.Location = new Point(243, 269);
      txtFeMarks.Name = "txtFeMarks";
      txtFeMarks.Size = new Size(470, 33);
      txtFeMarks.TabIndex = 10;
      txtFeMarks.Text = "0";
      txtFeMarks.Validating += validateTxtBoxInt100;
      // 
      // lblCaWeightage
      // 
      lblCaWeightage.AutoSize = true;
      lblCaWeightage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblCaWeightage.Location = new Point(48, 175);
      lblCaWeightage.Name = "lblCaWeightage";
      lblCaWeightage.Size = new Size(137, 25);
      lblCaWeightage.TabIndex = 11;
      lblCaWeightage.Text = "CA Weightage";
      // 
      // txtCaWeightage
      // 
      txtCaWeightage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtCaWeightage.Location = new Point(243, 172);
      txtCaWeightage.Name = "txtCaWeightage";
      txtCaWeightage.Size = new Size(470, 33);
      txtCaWeightage.TabIndex = 12;
      txtCaWeightage.Text = "0";
      txtCaWeightage.Validating += validateTxtBoxInt100;
      // 
      // btnCalculate
      // 
      btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      btnCalculate.Location = new Point(48, 384);
      btnCalculate.Name = "btnCalculate";
      btnCalculate.Size = new Size(665, 37);
      btnCalculate.TabIndex = 13;
      btnCalculate.Text = "Calculate Grade";
      btnCalculate.UseVisualStyleBackColor = true;
      btnCalculate.Click += btnCalculate_Click;
      // 
      // lblAttendance
      // 
      lblAttendance.AutoSize = true;
      lblAttendance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
      lblAttendance.Location = new Point(52, 319);
      lblAttendance.Name = "lblAttendance";
      lblAttendance.Size = new Size(114, 25);
      lblAttendance.TabIndex = 14;
      lblAttendance.Text = "Attendance";
      // 
      // txtAttendance
      // 
      txtAttendance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
      txtAttendance.Location = new Point(243, 319);
      txtAttendance.Name = "txtAttendance";
      txtAttendance.Size = new Size(470, 33);
      txtAttendance.TabIndex = 15;
      txtAttendance.Text = "0";
      txtAttendance.Validating += validateTxtBoxInt100;
      // 
      // errorProvider
      // 
      errorProvider.ContainerControl = this;
      // 
      // Main
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(776, 474);
      Controls.Add(txtAttendance);
      Controls.Add(lblAttendance);
      Controls.Add(btnCalculate);
      Controls.Add(txtCaWeightage);
      Controls.Add(lblCaWeightage);
      Controls.Add(txtFeMarks);
      Controls.Add(lblFeMarks);
      Controls.Add(txtCaMarks);
      Controls.Add(lblCaMarks);
      Controls.Add(txtRegNumber);
      Controls.Add(txtName);
      Controls.Add(lblRegNumber);
      Controls.Add(lblName);
      Controls.Add(drpModule);
      Controls.Add(lblModule);
      Name = "Main";
      Text = "Main";
      ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label lblModule;
    private ComboBox drpModule;
    private Label lblName;
    private Label lblRegNumber;
    private TextBox txtName;
    private TextBox txtRegNumber;
    private Label lblCaMarks;
    private TextBox txtCaMarks;
    private Label lblFeMarks;
    private TextBox txtFeMarks;
    private Label lblCaWeightage;
    private TextBox txtCaWeightage;
    private Button btnCalculate;
    private Label lblAttendance;
    private TextBox txtAttendance;
    private ErrorProvider errorProvider;
  }
}