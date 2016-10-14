'POSTHOC - Program to compute pairwise posthoc comparisons.
' Version 1.0 - September 1995
'R.C. Gardner and P.D. Macintyre, 
'Department of Psychology, Western University, London, Ontario, Canada, N6A 5C2

'Version 2.0 - Marh 16, 2016.
'Update by Bradley Hamelin.

Imports System.IO

Public Class Form1

    Dim saveLocation As String = ""
    Dim totalRuns As Integer = 0
    Dim savedRun As Integer = 0

    Dim aboutForm As New Form

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMeans.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstSizes.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles pooledYes.CheckedChanged
        txtDegreesFree2.Show()
        txtMeanSquared2.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles radF.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radT.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnMeans_Click(sender As Object, e As EventArgs) Handles btnMeans.Click
        If (IsNumeric(txtMeans.Text)) Then
            lstMeans.Items.Add(txtMeans.Text)
            txtMeans.Clear()
            txtMeans.Select()
        Else
            MessageBox.Show("Entered means must only contain numbers and decimals.", "Error")
            txtMeans.Clear()
            txtMeans.Select()
        End If

    End Sub

    Private Sub btnSizes_Click(sender As Object, e As EventArgs) Handles btnSizes.Click
        If (IsNumeric(txtSizes.Text)) Then
            lstSizes.Items.Add(txtSizes.Text)
            txtSizes.Clear()
            txtSizes.Select()
        Else
            MessageBox.Show("Entered sizes must only contain numbers and decimals.", "Error")
            txtSizes.Clear()
            txtSizes.Select()
        End If
    End Sub

    Private Sub PooledNo_CheckedChanged(sender As Object, e As EventArgs) Handles PooledNo.CheckedChanged
        txtDegreesFree2.Hide()
        txtMeanSquared2.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMeans.TextChanged

    End Sub

    Private Sub btnRMeans_Click(sender As Object, e As EventArgs) Handles btnRMeans.Click
        Dim index As Integer = lstMeans.SelectedIndex

        If (lstMeans.SelectedIndex < 0) Then
            Exit Sub
        End If

        lstMeans.Items.RemoveAt(lstMeans.SelectedIndex)

        If lstMeans.Items.Count = 0 Then
            'Select nothing
        ElseIf lstMeans.Items.Count = index Then
            lstMeans.SetSelected(index - 1, True)
        Else
            lstMeans.SetSelected(index, True)
        End If
    End Sub

    Private Sub btnRSize_Click(sender As Object, e As EventArgs) Handles btnRSize.Click
        Dim index As Integer = lstSizes.SelectedIndex

        If (lstSizes.SelectedIndex < 0) Then
            Exit Sub
        End If

        lstSizes.Items.RemoveAt(lstSizes.SelectedIndex)

        If lstSizes.Items.Count = 0 Then
            'Select nothing
        ElseIf lstSizes.Items.Count = index Then
            lstSizes.SetSelected(index - 1, True)
        Else
            lstSizes.SetSelected(index, True)
        End If
    End Sub

    'Subroutine that handles the generation of the ouput to the output field.
    Private Sub btnGenerateOutput_Click(sender As Object, e As EventArgs) Handles btnGenerateOutput.Click
        'Check for valid data
        If checkValidInput() = 0 Then
            Exit Sub
        End If

        'Write the title
        totalRuns += 1

        If (totalRuns = 1) Then
            txtOutput.AppendText("Results of POSTHOC analysis of means" + Environment.NewLine)
        End If

        txtOutput.AppendText("Analysis #  " + totalRuns.ToString + Environment.NewLine)

        Dim MS As Double
        Dim DFE As Double

        'Get if we have to solve for a pooled error term or a normal error term.
        If (PooledNo.Checked) Then
            MS = Convert.ToDouble(txtMeanSquared1.Text)
            DFE = Convert.ToDouble(txtDegreesFree1.Text)
            txtOutput.AppendText("Mean Square Error Input: " + MS.ToString() + " DF Error: " + DFE.ToString() + Environment.NewLine)
        ElseIf pooledYes.Checked Then
            Dim MSE1 As Double = Convert.ToDouble(txtMeanSquared1.Text)
            Dim MSE2 As Double = Convert.ToDouble(txtMeanSquared2.Text)
            Dim DFE1 As Double = Convert.ToDouble(txtDegreesFree1.Text)
            Dim DFE2 As Double = Convert.ToDouble(txtDegreesFree2.Text)

            Dim NUM1 As Double = MSE1 * DFE1
            Dim NUM2 As Double = MSE2 * DFE2
            MS = (NUM1 + NUM2) / (DFE1 + DFE2)
            DFE = (NUM1 + NUM2) ^ 2 / ((NUM1 ^ 2) / DFE1 + (NUM2 ^ 2) / DFE2)

            txtOutput.AppendText("POOLED MEAN SQUARE ERROR = " + MS.ToString() + " POOLED DF ERROR = " + DFE.ToString("F") + Environment.NewLine)
        End If

        'Get number of means
        Dim P = lstMeans.Items.Count
        Dim N(P + 1) As Double
        Dim AV(P + 1) As Double
        For K = 1 To P
            N(K) = Convert.ToDouble(CStr(lstSizes.Items.Item(K - 1)))
            AV(K) = Convert.ToDouble(CStr(lstMeans.Items.Item(K - 1)))
        Next

        'Sort the two arrays
        sortBoth(AV, N)

        'Print info regarding the selected statistic type
        If (radQ.Checked) Then
            txtOutput.AppendText(addSpaces("CONTRASTED MEANS", 24) + addSpaces("Q-STATISTIC", 20) + addSpaces("NO. STEPS", 14) + "MAX STEPS" + Environment.NewLine)
        ElseIf (radT.Checked) Then
            txtOutput.AppendText(addSpaces("CONTRASTED MEANS", 24) + addSpaces("T-STATISTIC", 20) + Environment.NewLine)
        ElseIf (radF.Checked) Then
            txtOutput.AppendText(addSpaces("CONTRASTED MEANS", 24) + addSpaces("F-STATISTIC", 20) + Environment.NewLine)
        End If

        'Perform calculations
        Dim P1 = P - 1
        For K = 1 To P1
            For M = K + 1 To P
                Dim DEN As Double = MS / N(K) + MS / N(M)
                Dim DEN1 As Double = MS / (2 * N(K)) + MS / (2 * N(M))

                'Q STATISTIC
                If (radQ.Checked) Then
                    Dim Q As Double = (AV(K) - AV(M)) / Math.Sqrt(DEN1)
                    Dim ST As Double = M - K + 1


                    Dim AVK As String = AV(K).ToString
                    AVK = addSpaces(AVK, 11)

                    Dim AVM As String = AV(M).ToString
                    AVM = addSpaces(AVM, 13)


                    Dim FormatQ As String = Format(Q, "0000.0000")
                    FormatQ = addSpaces(FormatQ, 20)

                    Dim STstring As String = ST.ToString
                    STstring = addSpaces(STstring, 14)

                    txtOutput.AppendText(AVK + AVM + FormatQ + STstring + P.ToString + Environment.NewLine)

                    'T Statistic
                ElseIf (radT.Checked) Then
                    Dim T = ((AV(K) - AV(M)) / Math.Sqrt(DEN))

                    Dim AVK As String = AV(K).ToString
                    AVK = addSpaces(AVK, 11)

                    Dim AVM As String = AV(M).ToString
                    AVM = addSpaces(AVM, 13)


                    Dim FormatT As String = Format(T, "0000.0000")

                    txtOutput.AppendText(AVK + AVM + FormatT + Environment.NewLine)

                ElseIf (radF.Checked) Then
                    Dim F = (AV(K) - AV(M)) ^ 2 / (MS * (1.0! / N(K) + 1.0! / N(M)))
                    Dim AVK As String = AV(K).ToString
                    AVK = addSpaces(AVK, 11)

                    Dim AVM As String = AV(M).ToString
                    AVM = addSpaces(AVM, 13)

                    Dim FormatF As String = Format(F, "0000.0000")

                    txtOutput.AppendText(AVK + AVM + FormatF + Environment.NewLine)

                End If

            Next
        Next

        txtOutput.AppendText("--------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine)


    End Sub

    Function sortBoth(AV As Double(), N As Double())
        For I As Integer = 2 To AV.Length - 2 Step 1
            Dim X As Double = AV(I)
            Dim Y As Double = N(I)
            Dim J = I - 1
            While (J >= 0) And (AV(J) > X) 'j>=0?
                AV(J + 1) = AV(J)
                N(J + 1) = N(J)
                J = J - 1
            End While
            AV(J + 1) = X
            N(J + 1) = Y
        Next

        Array.Reverse(AV)
        Array.Reverse(N)

        'Print both sorted arrays
        For K = 1 To AV.Length - 2 Step 1
            'Print these to the text file
            Dim mean As String = addSpaces("Mean(" + K.ToString + ") = " + AV(K).ToString, 15)
            txtOutput.AppendText(mean + "N(" + K.ToString + ") = " + N(K).ToString + Environment.NewLine)
        Next
        Return Nothing
    End Function

    'Add spaces until string is set length
    Function addSpaces(InputString As String, numChars As Integer)
        While (InputString.Length < numChars)
            InputString = InputString + " "
        End While
        Return InputString
    End Function

    'Reads all variables and determines if they are filled out properly or not. If not, informs user.
    Function checkValidInput()
        'Means and sizes
        If (lstMeans.Items.Count < 1) Then
            MessageBox.Show("Please enter at least one mean.", "Error")
            txtMeans.Select()
            Return 0
        ElseIf (lstSizes.Items.Count > lstMeans.Items.Count) Then
            MessageBox.Show("You have entered more sample sizes than means. Please remove extra sample sizes.", "Error")
            txtSizes.Select()
            Return 0
        ElseIf (lstSizes.Items.Count < lstMeans.Items.Count) Then
            MessageBox.Show("Please enter one sample size for each mean.", "Error")
            txtSizes.Select()
            Return 0

            'Errors
        ElseIf (txtMeanSquared1.Text.Length < 1) Then
            MessageBox.Show("Please enter the means squared error.", "Error")
            txtMeanSquared1.Select()
            Return 0
        ElseIf (txtDegreesFree1.Text.Length < 1) Then
            MessageBox.Show("Please enter the degrees of freedom error.", "Error")
            txtDegreesFree1.Select()
            Return 0
        ElseIf (txtMeanSquared2.Text.Length < 1 And pooledYes.Checked) Then
            MessageBox.Show("Please enter the second means squared error for the pooled error.", "Error")
            txtMeanSquared2.Select()
            Return 0
        ElseIf (txtDegreesFree2.Text.Length < 1 And pooledYes.Checked) Then
            MessageBox.Show("Please enter the second degrees of freedom error for the pooled error.", "Error")
            txtDegreesFree2.Select()
            Return 0

            'Check for valid input on errors
        ElseIf Not (IsNumeric(txtMeanSquared1.Text)) Then
            MessageBox.Show("Entered mean squared error must only contain numbers and decimals.", "Error")
            txtMeanSquared1.Select()
            Return 0
        ElseIf Not (IsNumeric(txtDegreesFree1.Text)) Then
            MessageBox.Show("Entered degrees of freedom error must only contain numbers and decimals.", "Error")
            txtDegreesFree1.Select()
            Return 0
        ElseIf (Not (IsNumeric(txtMeanSquared2.Text)) And pooledYes.Checked) Then
            MessageBox.Show("Entered second means squared error must only contain numbers and decimals.", "Error")
            txtMeanSquared2.Select()
            Return 0
        ElseIf (Not (IsNumeric(txtDegreesFree2.Text)) And pooledYes.Checked) Then
            MessageBox.Show("Entered second degrees of freedom must only contain numbers and decimals.", "Error")
            txtDegreesFree2.Select()
            Return 0
        End If
        Return 1
    End Function

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs) Handles txtOutput.TextChanged

    End Sub

    Private Sub SaveOutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveOutputToolStripMenuItem.Click
        handleSaving()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveLocation = ""
        handleSaving()
    End Sub

    Function handleSaving()
        If String.IsNullOrEmpty(saveLocation) Then
            Dim sd As New SaveFileDialog()
            sd.ShowDialog()

            If sd.FileName <> "" Then
                saveLocation = sd.FileName
            End If
        End If

        If saveLocation <> "" Then
            Dim sw As StreamWriter = New StreamWriter(saveLocation + ".txt")
            sw.Write(txtOutput.Text)
            sw.Close()
            savedRun = totalRuns
        End If

        Return Nothing
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim result As DialogResult
        If (savedRun < totalRuns) Then
            result = MessageBox.Show("You have unsaved work. Do you want to save before closing?", "Save And exit?", MessageBoxButtons.YesNoCancel)

            If result = Windows.Forms.DialogResult.Yes Then
                handleSaving()
                e.Cancel = False
            ElseIf result = Windows.Forms.DialogResult.No Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Dim myPdf As String =
        IO.Path.Combine(IO.Directory.GetParent(Application.ExecutablePath).FullName, "POSTHOC Manual.pdf")

        If My.Computer.FileSystem.FileExists(myPdf) Then
            System.Diagnostics.Process.Start(myPdf)
        End If

    End Sub
End Class
