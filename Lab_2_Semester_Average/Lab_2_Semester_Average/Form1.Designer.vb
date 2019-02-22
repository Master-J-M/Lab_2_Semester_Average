<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtBigOutput = New System.Windows.Forms.TextBox()
        Me.lblCourse1 = New System.Windows.Forms.Label()
        Me.lblCourse2 = New System.Windows.Forms.Label()
        Me.lblCourse3 = New System.Windows.Forms.Label()
        Me.lblCourse4 = New System.Windows.Forms.Label()
        Me.lblCourse5 = New System.Windows.Forms.Label()
        Me.lblCourse6 = New System.Windows.Forms.Label()
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtInput2 = New System.Windows.Forms.TextBox()
        Me.txtInput3 = New System.Windows.Forms.TextBox()
        Me.txtInput6 = New System.Windows.Forms.TextBox()
        Me.txtInput5 = New System.Windows.Forms.TextBox()
        Me.txtInput4 = New System.Windows.Forms.TextBox()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblOutput3 = New System.Windows.Forms.Label()
        Me.lblOutput4 = New System.Windows.Forms.Label()
        Me.lblOutput5 = New System.Windows.Forms.Label()
        Me.lblOutput6 = New System.Windows.Forms.Label()
        Me.lblLetterOutput = New System.Windows.Forms.Label()
        Me.lblOutputAverage = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(217, 423)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "E&xit"
        Me.toolTip.SetToolTip(Me.btnExit, "Exit the Application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(113, 423)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 25)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.toolTip.SetToolTip(Me.btnReset, "Reset the application and set the focus to input on course 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 423)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 25)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.toolTip.SetToolTip(Me.btnCalculate, "Calculate the Average course grade once you have inputed the values for all 6 cou" &
        "rses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtBigOutput
        '
        Me.txtBigOutput.Location = New System.Drawing.Point(12, 245)
        Me.txtBigOutput.Multiline = True
        Me.txtBigOutput.Name = "txtBigOutput"
        Me.txtBigOutput.ReadOnly = True
        Me.txtBigOutput.Size = New System.Drawing.Size(280, 160)
        Me.txtBigOutput.TabIndex = 1
        Me.txtBigOutput.TabStop = False
        Me.toolTip.SetToolTip(Me.txtBigOutput, "Output for all errors and correct user inputs")
        '
        'lblCourse1
        '
        Me.lblCourse1.AutoSize = True
        Me.lblCourse1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse1.Location = New System.Drawing.Point(9, 21)
        Me.lblCourse1.Name = "lblCourse1"
        Me.lblCourse1.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse1.TabIndex = 4
        Me.lblCourse1.Text = "Course &1:"
        '
        'lblCourse2
        '
        Me.lblCourse2.AutoSize = True
        Me.lblCourse2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse2.Location = New System.Drawing.Point(9, 53)
        Me.lblCourse2.Name = "lblCourse2"
        Me.lblCourse2.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse2.TabIndex = 5
        Me.lblCourse2.Text = "Course &2:"
        '
        'lblCourse3
        '
        Me.lblCourse3.AutoSize = True
        Me.lblCourse3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse3.Location = New System.Drawing.Point(9, 86)
        Me.lblCourse3.Name = "lblCourse3"
        Me.lblCourse3.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse3.TabIndex = 6
        Me.lblCourse3.Text = "Course &3:"
        '
        'lblCourse4
        '
        Me.lblCourse4.AutoSize = True
        Me.lblCourse4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse4.Location = New System.Drawing.Point(9, 118)
        Me.lblCourse4.Name = "lblCourse4"
        Me.lblCourse4.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse4.TabIndex = 7
        Me.lblCourse4.Text = "Course &4:"
        '
        'lblCourse5
        '
        Me.lblCourse5.AutoSize = True
        Me.lblCourse5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse5.Location = New System.Drawing.Point(9, 150)
        Me.lblCourse5.Name = "lblCourse5"
        Me.lblCourse5.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse5.TabIndex = 8
        Me.lblCourse5.Text = "Course &5:"
        '
        'lblCourse6
        '
        Me.lblCourse6.AutoSize = True
        Me.lblCourse6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCourse6.Location = New System.Drawing.Point(9, 182)
        Me.lblCourse6.Name = "lblCourse6"
        Me.lblCourse6.Size = New System.Drawing.Size(64, 16)
        Me.lblCourse6.TabIndex = 9
        Me.lblCourse6.Text = "Course &6:"
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(80, 19)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(100, 20)
        Me.txtInput1.TabIndex = 1
        Me.toolTip.SetToolTip(Me.txtInput1, "Input box for Course 1 grade (Between 0 and 100)")
        '
        'txtInput2
        '
        Me.txtInput2.Location = New System.Drawing.Point(79, 52)
        Me.txtInput2.Name = "txtInput2"
        Me.txtInput2.Size = New System.Drawing.Size(100, 20)
        Me.txtInput2.TabIndex = 2
        Me.toolTip.SetToolTip(Me.txtInput2, "Input box for Course 2 grade (Between 0 and 100)")
        '
        'txtInput3
        '
        Me.txtInput3.Location = New System.Drawing.Point(79, 83)
        Me.txtInput3.Name = "txtInput3"
        Me.txtInput3.Size = New System.Drawing.Size(100, 20)
        Me.txtInput3.TabIndex = 3
        Me.toolTip.SetToolTip(Me.txtInput3, "Input box for Course 3 grade (Between 0 and 100)")
        '
        'txtInput6
        '
        Me.txtInput6.Location = New System.Drawing.Point(79, 180)
        Me.txtInput6.Name = "txtInput6"
        Me.txtInput6.Size = New System.Drawing.Size(100, 20)
        Me.txtInput6.TabIndex = 6
        Me.toolTip.SetToolTip(Me.txtInput6, "Input box for Course 6 grade (Between 0 and 100)")
        '
        'txtInput5
        '
        Me.txtInput5.Location = New System.Drawing.Point(79, 148)
        Me.txtInput5.Name = "txtInput5"
        Me.txtInput5.Size = New System.Drawing.Size(100, 20)
        Me.txtInput5.TabIndex = 5
        Me.toolTip.SetToolTip(Me.txtInput5, "Input box for Course 5 grade (Between 0 and 100)")
        '
        'txtInput4
        '
        Me.txtInput4.Location = New System.Drawing.Point(80, 116)
        Me.txtInput4.Name = "txtInput4"
        Me.txtInput4.Size = New System.Drawing.Size(100, 20)
        Me.txtInput4.TabIndex = 4
        Me.toolTip.SetToolTip(Me.txtInput4, "Input box for Course 4 grade (Between 0 and 100)")
        '
        'lblOutput1
        '
        Me.lblOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput1.Location = New System.Drawing.Point(186, 19)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput1.TabIndex = 16
        Me.lblOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput1, "Letter Grade for Course 1")
        '
        'lblOutput2
        '
        Me.lblOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput2.Location = New System.Drawing.Point(185, 50)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput2.TabIndex = 17
        Me.lblOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput2, "Letter Grade for Course 2")
        '
        'lblOutput3
        '
        Me.lblOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput3.Location = New System.Drawing.Point(185, 83)
        Me.lblOutput3.Name = "lblOutput3"
        Me.lblOutput3.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput3.TabIndex = 18
        Me.lblOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput3, "Letter Grade for Course 3")
        '
        'lblOutput4
        '
        Me.lblOutput4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput4.Location = New System.Drawing.Point(185, 115)
        Me.lblOutput4.Name = "lblOutput4"
        Me.lblOutput4.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput4.TabIndex = 19
        Me.lblOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput4, "Letter Grade for Course 4")
        '
        'lblOutput5
        '
        Me.lblOutput5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput5.Location = New System.Drawing.Point(185, 148)
        Me.lblOutput5.Name = "lblOutput5"
        Me.lblOutput5.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput5.TabIndex = 20
        Me.lblOutput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput5, "Letter Grade for Course 5")
        '
        'lblOutput6
        '
        Me.lblOutput6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput6.Location = New System.Drawing.Point(185, 180)
        Me.lblOutput6.Name = "lblOutput6"
        Me.lblOutput6.Size = New System.Drawing.Size(100, 20)
        Me.lblOutput6.TabIndex = 21
        Me.lblOutput6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutput6, "Letter Grade for Course 6")
        '
        'lblLetterOutput
        '
        Me.lblLetterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLetterOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterOutput.Location = New System.Drawing.Point(185, 212)
        Me.lblLetterOutput.Name = "lblLetterOutput"
        Me.lblLetterOutput.Size = New System.Drawing.Size(100, 20)
        Me.lblLetterOutput.TabIndex = 22
        Me.lblLetterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblLetterOutput, "Letter Grade for the average of all 6 courses")
        '
        'lblOutputAverage
        '
        Me.lblOutputAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutputAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutputAverage.Location = New System.Drawing.Point(79, 212)
        Me.lblOutputAverage.Name = "lblOutputAverage"
        Me.lblOutputAverage.Size = New System.Drawing.Size(100, 20)
        Me.lblOutputAverage.TabIndex = 23
        Me.lblOutputAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.toolTip.SetToolTip(Me.lblOutputAverage, "Output for the average of all 6 courses")
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(9, 212)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(69, 16)
        Me.lblSemester.TabIndex = 24
        Me.lblSemester.Text = "Semester:"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(304, 461)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblOutputAverage)
        Me.Controls.Add(Me.lblLetterOutput)
        Me.Controls.Add(Me.lblOutput6)
        Me.Controls.Add(Me.lblOutput5)
        Me.Controls.Add(Me.lblOutput4)
        Me.Controls.Add(Me.lblOutput3)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.txtInput6)
        Me.Controls.Add(Me.txtInput5)
        Me.Controls.Add(Me.txtInput4)
        Me.Controls.Add(Me.txtInput3)
        Me.Controls.Add(Me.txtInput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.lblCourse6)
        Me.Controls.Add(Me.lblCourse5)
        Me.Controls.Add(Me.lblCourse4)
        Me.Controls.Add(Me.lblCourse3)
        Me.Controls.Add(Me.lblCourse2)
        Me.Controls.Add(Me.lblCourse1)
        Me.Controls.Add(Me.txtBigOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtBigOutput As TextBox
    Friend WithEvents lblCourse1 As Label
    Friend WithEvents lblCourse2 As Label
    Friend WithEvents lblCourse3 As Label
    Friend WithEvents lblCourse4 As Label
    Friend WithEvents lblCourse5 As Label
    Friend WithEvents lblCourse6 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtInput2 As TextBox
    Friend WithEvents txtInput3 As TextBox
    Friend WithEvents txtInput6 As TextBox
    Friend WithEvents txtInput5 As TextBox
    Friend WithEvents txtInput4 As TextBox
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents lblOutput3 As Label
    Friend WithEvents lblOutput4 As Label
    Friend WithEvents lblOutput5 As Label
    Friend WithEvents lblOutput6 As Label
    Friend WithEvents lblLetterOutput As Label
    Friend WithEvents lblOutputAverage As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents toolTip As ToolTip
End Class
