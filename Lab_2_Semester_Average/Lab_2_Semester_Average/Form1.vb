'Title: Lab 2 - Semester Average
'For: NETD2202
'By: Joshua Morand(100662245)
'Date : Feb.8th 2018
'Description: Takes user input For 6 different course grades. sequentialy validates input as well as calculates the letter grade for valid inputs.
'             After clicking on the calculate button, if there are 6 valid inputs, it will calculate the average grade as well as the letter grade.
Option Strict On 'ristricts implicit data type conversions
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click 'event for when the exit button is clicked
        Application.Exit()                                                            'closes the application
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click 'event for when the calculate button is clicked
        Dim allGrades(5) As Double                                                              'array that can hold 6 double values
        Dim sum As Double                                                                       'double variable that will hold the total sum of all 6 courses as well as be manipulated to display the average
        If (String.IsNullOrWhiteSpace(txtInput1.Text) Or String.IsNullOrWhiteSpace(txtInput2.Text) Or String.IsNullOrWhiteSpace(txtInput3.Text) Or String.IsNullOrWhiteSpace(txtInput4.Text) Or String.IsNullOrWhiteSpace(txtInput5.Text) Or String.IsNullOrWhiteSpace(txtInput6.Text)) Then 'if statement that will not allow the calculate function to proceed if any of the inputs are either null, empty, or white space
            txtBigOutput.Text += "ERROR: Please Fill all Courses" & vbCrLf 'if there are any courses without an input then display an appropriate error to the Big Output box
        Else 'if there are 6 valid inputs then..
            Dim allGradesTransfer() As String = {txtInput1.Text, txtInput2.Text, txtInput3.Text, txtInput4.Text, txtInput5.Text, txtInput6.Text} 'create a string array to temporarily hold the validated values in every input
            For i = 0 To 5 'for loop that will loop from 0 - 5
                Debug.Write("transfering index " & i) 'debug info to show what index is being transfered
                allGrades(i) = Convert.ToDouble(allGradesTransfer(i)) 'converts the string value in the transfer array to the grades array that holds double data types
                sum += allGrades(i)                                   'after converting datatypes, add the value into a running total
            Next i                                                    'move on to the next index in the for loop unless i = 5
            lblOutputAverage.Text = Math.Round((sum / 6), 2).ToString 'output the average rounded grade to 2 decimals
            lblLetterOutput.Text = letterGrade(lblOutputAverage.Text) 'call the letterGrade function to calculate the letter grade for the average grade
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click      'event for when the reset button is clicked
        'fill all inputs with a valid input so it does not refocus to the current selected input box upon clicking reset button
        txtInput1.Text = "0"
        txtInput2.Text = "0"
        txtInput3.Text = "0"
        txtInput4.Text = "0"
        txtInput5.Text = "0"
        txtInput6.Text = "0"
        'set the focus to the first input box
        txtInput1.Focus()
        'now we can reset every all input and output labels and boxes
        txtInput1.Text = ""
        txtInput2.Text = ""
        txtInput3.Text = ""
        txtInput4.Text = ""
        txtInput5.Text = ""
        txtInput6.Text = ""
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
        lblOutput4.Text = ""
        lblOutput5.Text = ""
        lblOutput6.Text = ""
        txtBigOutput.Text = ""
        lblOutputAverage.Text = ""
        lblLetterOutput.Text = ""
    End Sub
    Private Sub txtInput1_Leave(sender As Object, e As EventArgs) Handles txtInput1.Leave    'event for when the focus leaves input box 1
        Dim success As Boolean = validate(txtInput1.Text)                                    'creates a boolean named success that is equal to either true or false depending on the input parameter sent to the validation function 
        If success Then                                                                      'if the input has validated successfully then..
            Debug.Write("Validated Successfully" & vbCrLf)                                   'output to the debug that the input validated successfully
            lblOutput1.Text = letterGrade(txtInput1.Text)                                    'output the letter grade by calling the lettergrade function using the validated input as a parameter
        Else                                                                                 'if the input did not validate
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)                   'output to the debug that the input did not validate successfully
            txtInput1.Focus()                                                                'set the focus on the current input box
            txtInput1.Text = ""                                                              'clear the current input box
        End If
    End Sub                                                                                  'all focus leave events that are uncommented following this will be the same logic as txtInput1_Leave

    Private Sub txtInput2_Leave(sender As Object, e As EventArgs) Handles txtInput2.Leave
        Dim success As Boolean = validate(txtInput2.Text)
        If success Then
            Debug.Write("Validated Successfully" & vbCrLf)
            lblOutput2.Text = letterGrade(txtInput2.Text)
        Else
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)
            txtInput2.Focus()
            txtInput2.Text = ""
        End If
    End Sub

    Private Sub txtInput3_Leave(sender As Object, e As EventArgs) Handles txtInput3.Leave
        Dim success As Boolean = validate(txtInput3.Text)
        If success Then
            Debug.Write("Validated Successfully" & vbCrLf)
            lblOutput3.Text = letterGrade(txtInput3.Text)
        Else
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)
            txtInput3.Focus()
            txtInput3.Text = ""
        End If
    End Sub

    Private Sub txtInput4_Leave(sender As Object, e As EventArgs) Handles txtInput4.Leave
        Dim success As Boolean = validate(txtInput4.Text)
        If success Then
            Debug.Write("Validated Successfully" & vbCrLf)
            lblOutput4.Text = letterGrade(txtInput4.Text)
        Else
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)
            txtInput4.Focus()
            txtInput4.Text = ""
        End If
    End Sub

    Private Sub txtInput5_Leave(sender As Object, e As EventArgs) Handles txtInput5.Leave
        Dim success As Boolean = validate(txtInput5.Text)
        If success Then
            Debug.Write("Validated Successfully" & vbCrLf)
            lblOutput5.Text = letterGrade(txtInput5.Text)
        Else
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)
            txtInput5.Focus()
            txtInput5.Text = ""
        End If
    End Sub

    Private Sub txtInput6_Leave(sender As Object, e As EventArgs) Handles txtInput6.Leave
        Dim success As Boolean = validate(txtInput6.Text)
        If success Then
            Debug.Write("Validated Successfully" & vbCrLf)
            lblOutput6.Text = letterGrade(txtInput6.Text)
        Else
            Debug.Write("Did not Validate Successfully" & vbCrLf & vbCrLf)
            txtInput6.Focus()
            txtInput6.Text = ""
        End If
    End Sub
    Public Function letterGrade(ByRef validGrade As String) As String 'letter grade function that will determine the letter grade value for a validated input
        Debug.Write("Checking Letter Grade Value" & vbCrLf & vbCrLf)  'output to the debug to ensure that the function has been called
        Dim doubleValidGrade As Double = Convert.ToDouble(validGrade) 'convert the valid user input from a string to a new variable saved as a double so that it can be used in comparing itself within a range
        letterGrade = "" 'default return value so the function is happy
        Select Case doubleValidGrade 'switch statement which will compare the doubleValidGrade variable to a range and will set the return value of the function to its respective letter grade
            Case 0 To 49
                letterGrade = "F"
            Case 50 To 52
                letterGrade = "D-"
            Case 53 To 56
                letterGrade = "D"
            Case 57 To 59
                letterGrade = "D+"
            Case 60 To 62
                letterGrade = "C-"
            Case 63 To 66
                letterGrade = "C"
            Case 67 To 69
                letterGrade = "C+"
            Case 70 To 72
                letterGrade = "B-"
            Case 73 To 76
                letterGrade = "B"
            Case 77 To 79
                letterGrade = "B+"
            Case 80 To 84
                letterGrade = "A-"
            Case 85 To 89
                letterGrade = "A"
            Case 90 To 100
                letterGrade = "A+"
        End Select
        Return letterGrade ' returns the letter grade
    End Function
    Public Overloads Function validate(ByVal userInput As String) As Boolean                'function used to validate user input
        If btnReset.Focused = False Then                                                    'stops error msg when clicking on the reset button (if the focus is not on the reset button then validate)
            Dim doubleUserInput As Double                                                   'creates a variable named doubleUserInput as a double so that the user input string can be converted into it.
            If Double.TryParse(userInput, doubleUserInput) Then                             'attempts to parse the user input String into doubleUserInput saved as a double, if successful then..
                Debug.Write("Parsed Successfully" & vbCrLf)                                        'output to the debug that the parse was successful
                If doubleUserInput > 100 Or doubleUserInput < 0 Then                        'if the parsed input if greater then 100 or less then 0 then..
                    'out of range                                                                  
                    Debug.Write("Out Of Range" & vbCrLf)                                    'output to the debug that the parsed input is out of range                
                    txtBigOutput.Text += "ERROR: " & ControlChars.Quote & doubleUserInput & ControlChars.Quote & " Out of Range- input between 0-100" & vbCrLf 'output an appropriate error message to the Big Output box
                    validate = False                                                        'update the return value to false
                Else                                                                        'if the parsed input is within range then..
                    'valid
                    Debug.Write("In Range" & vbCrLf)                                        'output to the debug that the parsed input is in range       
                    txtBigOutput.Text += doubleUserInput.ToString & "%" & vbCrLf            'output the valid input to the big box output
                    validate = True                                                         'update the return value to true
                End If
            Else                                                                            'if the input failed to parse then..
                Debug.Write("Parse failed" & vbCrLf)                                        'output to the debug that the parse failed  
                txtBigOutput.Text += "ERROR: " & ControlChars.Quote & userInput & ControlChars.Quote & " Failed to Parse - input a number please" & vbCrLf 'output an appropriate error message to the Big Output box
                validate = False                                                            'update the return value to false
            End If
        End If
        Return validate                                                                     'return either a true or false
    End Function
End Class
