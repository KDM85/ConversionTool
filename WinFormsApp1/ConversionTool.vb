Public Class frmMain
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If String.IsNullOrEmpty(Me.txtFromValue.Text) Then
            MsgBox("From Value is required.", vbOKOnly, "Missing Entry")
            Me.txtFromValue.Focus()
            Exit Sub
        End If
        If Not IsNumeric(Me.txtFromValue.Text) Then
            MsgBox("Only numeric entries are allowed.", vbInformation, "Invalid Entry")
            Me.txtFromValue.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.cboFromUnit.Text) Then
            MsgBox("From Unit is required.", vbOKOnly, "Missing Entry")
            Me.cboFromUnit.Focus()
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.cboToUnit.Text) Then
            MsgBox("To Unit is required.", vbOKOnly, "Missing Entry")
            Me.cboToUnit.Focus()
            Exit Sub
        End If
        Me.txtToValue.Text = ConvertDistance(Me.txtFromValue.Text, Me.cboFromUnit.Text, Me.cboToUnit.Text)
    End Sub
    Public Function ConvertDistance(dblValue As Double, strFromUnit As String, strToUnit As String) As Double
        Dim dblConversion As Double
        Dim bIsFromImperial As Boolean
        Dim bIsToImperial As Boolean

        Select Case strFromUnit
            Case "th", "bc", "in", "h", "ft", "yd", "ftm", "ch", "fur", "mi", "nmi", "lea"
                bIsFromImperial = True
            Case "mm", "cm", "dm", "m", "dam", "hm", "km"
                bIsFromImperial = False
        End Select
        Select Case strToUnit
            Case "th", "bc", "in", "h", "ft", "yd", "ftm", "ch", "fur", "mi", "nmi", "lea"
                bIsToImperial = True
            Case "mm", "cm", "dm", "m", "dam", "hm", "km"
                bIsToImperial = False
        End Select

        If bIsFromImperial And Not bIsToImperial Then
            dblConversion = 25.4
        End If
        If Not bIsFromImperial And bIsToImperial Then
            dblConversion = 1 / 25.4
        End If
        If (bIsFromImperial And bIsToImperial) Or (Not bIsFromImperial And Not bIsToImperial) Then
            dblConversion = 1
        End If

        Select Case strFromUnit
            Case "th"
                dblConversion = dblConversion / 1000
            Case "bc"
                dblConversion = dblConversion / 3
            Case "in"
                dblConversion = dblConversion
            Case "h"
                dblConversion = dblConversion * 4
            Case "ft"
                dblConversion = dblConversion * 12
            Case "yd"
                dblConversion = dblConversion * 36
            Case "ftm"
                dblConversion = dblConversion * 72.9132
            Case "ch"
                dblConversion = dblConversion * 792
            Case "fur"
                dblConversion = dblConversion * 7290
            Case "mi"
                dblConversion = dblConversion * 63360
            Case "nmi"
                dblConversion = dblConversion * 72913.2
            Case "lea"
                dblConversion = dblConversion * 190080
            Case "mm"
                dblConversion = dblConversion
            Case "cm"
                dblConversion = dblConversion * 10
            Case "dm"
                dblConversion = dblConversion * 100
            Case "m"
                dblConversion = dblConversion * 1000
            Case "dam"
                dblConversion = dblConversion * 10000
            Case "hm"
                dblConversion = dblConversion * 100000
            Case "km"
                dblConversion = dblConversion * 1000000
        End Select

        Select Case strToUnit
            Case "th"
                dblConversion = dblConversion * 1000
            Case "bc"
                dblConversion = dblConversion * 3
            Case "in"
                dblConversion = dblConversion
            Case "h"
                dblConversion = dblConversion / 4
            Case "ft"
                dblConversion = dblConversion / 12
            Case "yd"
                dblConversion = dblConversion / 36
            Case "ftm"
                dblConversion = dblConversion / 72.9132
            Case "ch"
                dblConversion = dblConversion / 792
            Case "fur"
                dblConversion = dblConversion / 7290
            Case "mi"
                dblConversion = dblConversion / 63360
            Case "nmi"
                dblConversion = dblConversion / 72913.2
            Case "lea"
                dblConversion = dblConversion / 190080
            Case "mm"
                dblConversion = dblConversion
            Case "cm"
                dblConversion = dblConversion / 10
            Case "dm"
                dblConversion = dblConversion / 100
            Case "m"
                dblConversion = dblConversion / 1000
            Case "dam"
                dblConversion = dblConversion / 10000
            Case "hm"
                dblConversion = dblConversion / 100000
            Case "km"
                dblConversion = dblConversion / 1000000
        End Select
        ConvertDistance = Math.Round(dblValue * dblConversion, 4)
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
