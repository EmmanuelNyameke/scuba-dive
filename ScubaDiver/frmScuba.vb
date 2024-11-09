' Program Name: Scuba Expedition Application
' Date: October 31, 2024
' Author: K Bola
' Purpose: This application determines the location and scuba dives available and calculates the total dive team cost.

Option Strict On
Public Class frmScuba
    ' Class Variables
    Private _intFourHour As Integer = 4
    Private _intSixHour As Integer = 6
    Private _intEightHour As Integer = 8
    Private _strDive1 As String = "Great Barrier Reef"
    Private _strDive2 As String = "Tiger Shark"
    Private _strDive3 As String = "Fathom Chasm"
    Private _strDive4 As String = "Great Blue Chasm"
    Private _strDive5 As String = "Rainbow Reef"
    Private _strDive6 As String = "Namena Sunken Ship"
    Private Sub frmScuba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Holding the splash screen for 5 secs
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub cboLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLocation.SelectedIndexChanged
        ' This event handler allows users to enter the location choice and then calls sub procedures to place the dive types in the list.
        Dim intLocationChoice As Integer
        intLocationChoice = cboLocation.SelectedIndex
        lstDive.Items.Clear()
        Select Case intLocationChoice
            Case 0
                AustraliaTeam()
            Case 1
                BelizeTeam()
            Case 2
                FijiTeam()
        End Select
        ' Make Items Visible to the Window
        lblTeam.Visible = True
        txtTeam.Visible = True
        lblSelect.Visible = True
        lstDive.Visible = True
        btnDiveCost.Visible = True
        btnClear.Visible = True
        lblScubaDive.Visible = True
        lblCost.Visible = True
        lblLength.Visible = True
        ' Clear the labels
        lblScubaDive.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        ' Set focus on number in dive team text box
        txtTeam.Focus()
    End Sub
    Private Sub AustraliaTeam()
        ' This procedure fills in the possible dive types offered in Australia 
        lstDive.Items.Add(_strDive1)
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
    End Sub
    Private Sub BelizeTeam()
        ' This procedure fills in the possible dive types offered in Belize
        lstDive.Items.Add(_strDive4)
        lstDive.Items.Add(_strDive5)
    End Sub
    Private Sub FijiTeam()
        ' This procedure fills in the possible dive types offered in Fiji
        lstDive.Items.Add(_strDive2)
        lstDive.Items.Add(_strDive3)
        lstDive.Items.Add(_strDive6)
    End Sub

    Private Sub btnDiveCost_Click(sender As Object, e As EventArgs) Handles btnDiveCost.Click
        ' This button event handler determines the cost of scuba expeditions and display the size of the dive team, the cost, and the length of the dive
        Dim intTeamSize As Integer
        Dim blnNumberInTeamIsValid As Boolean = False
        Dim blnDiveIsSelected As Boolean = False
        Dim intDiveChoice As Integer
        Dim strSelectedTeam As String = ""
        Dim intLocationChoice As Integer
        Dim intLength As Integer = 0
        Dim decTotalCost As Decimal
        ' Calling a function to ensure the number of people in the dive team is valid
        blnNumberInTeamIsValid = ValidateNumberInTeam()
        ' Calling a function to ensure the scuba dive was selected
        intDiveChoice = ValidateDiveSelection(blnDiveIsSelected, strSelectedTeam)
        ' If number of people and the dive trip are valid, calculate the cost
        If (blnNumberInTeamIsValid And blnDiveIsSelected) Then
            intTeamSize = Convert.ToInt32(txtTeam.Text)
            intLocationChoice = cboLocation.SelectedIndex
            Select Case intLocationChoice
                Case 0
                    decTotalCost = AustraliaDiveCost(intDiveChoice, intTeamSize, intLength)
                Case 1
                    decTotalCost = BelizeDiveCost(intDiveChoice, intTeamSize, intLength)
                Case 2
                    decTotalCost = FijiDiveCost(intDiveChoice, intTeamSize, intLength)
            End Select
            ' Displaying the cost of the scuba dive
            lblScubaDive.Text = "Dive: " & strSelectedTeam
            lblCost.Text = "Cost: " & decTotalCost.ToString("C")
            lblLength.Text = "Length: " & intLength.ToString() & " hours"
        End If
    End Sub

    Private Function ValidateNumberInTeam() As Boolean
        ' This procedure validates the value entered for the dive team size
        Dim intTeamSize As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberInTeamMessage As String = "Please enter the number of people in your dive team (2-6)"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTeamSize = Convert.ToInt32(txtTeam.Text)
            If (intTeamSize >= 2 And intTeamSize <= 6) Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberInTeamMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, strMessageBoxTitle)
                txtTeam.Clear()
                txtTeam.Focus()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberInTeamMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, strMessageBoxTitle)
            txtTeam.Clear()
            txtTeam.Focus()
        Catch Exception As OverflowException
            MsgBox(strNumberInTeamMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, strMessageBoxTitle)
            txtTeam.Clear()
            txtTeam.Focus()
        Catch Exception As SystemException
            MsgBox(strNumberInTeamMessage, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, strMessageBoxTitle)
            txtTeam.Clear()
            txtTeam.Focus()
        End Try
        Return blnValidityCheck
    End Function

    Private Function ValidateDiveSelection(ByRef blnDive As Boolean, ByRef strDive As String) As Integer
        ' This function ensures the user selected a dive
        Dim intDiveType As Integer
        Try
            intDiveType = Convert.ToInt32(lstDive.SelectedIndex)
            strDive = lstDive.SelectedItem.ToString()
            blnDive = True
        Catch Exception As SystemException
            ' Detecting if a dive type is not selected
            MsgBox("Select a dive type", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Error")
            blnDive = False
        End Try
        Return intDiveType
    End Function

    Private Function AustraliaDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        ' This function calculates the cost of dive team in australia
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decAustraliaDive1 As Decimal = 359D
        Dim decAustraliaDive2 As Decimal = 200D
        Dim decAustraliaDive3 As Decimal = 125D

        Select Case intDive
            Case 0
                decTeamCost = decAustraliaDive1
                intTime = _intEightHour
            Case 1
                decTeamCost = decAustraliaDive2
                intTime = _intSixHour
            Case 2
                decTeamCost = decAustraliaDive3
                intTime = _intFourHour
        End Select
        decFinalCost = decTeamCost * intTeam
        Return decFinalCost
    End Function

    Private Function BelizeDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        ' This function calculates the cost of dive team in belize
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decBelizeDive4 As Decimal = 200D
        Dim decBelizeDive5 As Decimal = 150D

        Select Case intDive
            Case 0
                decTeamCost = decBelizeDive4
                intTime = _intEightHour
            Case 1
                decTeamCost = decBelizeDive5
                intTime = _intSixHour
        End Select
        decFinalCost = decTeamCost * intTeam
        Return decFinalCost
    End Function

    Private Function FijiDiveCost(ByVal intDive As Integer, ByVal intTeam As Integer, ByRef intTime As Integer) As Decimal
        ' This function calculates the cost of dive team in fiji
        Dim decTeamCost As Decimal
        Dim decFinalCost As Decimal
        Dim decFijiDive2 As Decimal = 280D
        Dim decFijiDive3 As Decimal = 225D
        Dim decFijiDive6 As Decimal = 200D

        Select Case intDive
            Case 0
                decTeamCost = decFijiDive2
                intTime = _intEightHour
            Case 1
                decTeamCost = decFijiDive3
                intTime = _intSixHour
            Case 2
                decTeamCost = decFijiDive6
                intTime = _intFourHour
        End Select
        decFinalCost = decTeamCost * intTeam
        Return decFinalCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the form and reset the form for reuse when the user clicks the clear button
        cboLocation.Text = "Select Location"
        txtTeam.Clear()
        lstDive.Items.Clear()
        lblScubaDive.Text = ""
        lblCost.Text = ""
        lblLength.Text = ""
        lblTeam.Visible = False
        txtTeam.Visible = False
        lblSelect.Visible = False
        lstDive.Visible = False
        btnDiveCost.Visible = False
        btnClear.Visible = False
        lblScubaDive.Visible = False
        lblCost.Visible = False
        lblLength.Visible = False
    End Sub
End Class
