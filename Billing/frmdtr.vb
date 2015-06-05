Imports System.Globalization

Public Class frmdtr
    Dim days As Integer
    Dim mydate As Integer = Date.DaysInMonth(Date.Now.Year, Date.Now.Month)
    Dim first As Date = New Date(Date.Now.Year, Date.Now.Month, 1)
    Dim second As Date = New Date(Date.Now.Year, Date.Now.Month, 15)
    Dim third As Date = New Date(Date.Now.Year, Date.Now.Month, mydate)

    Private Sub cmbshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbshift.SelectedIndexChanged
        'checkbox 1
        If chckbx1.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay1TimeIn.Value = dtpDay1.Value.ToShortDateString & " 7:30 AM"
                dtpDay1TimeOut.Value = " 4:30 PM" & dtpDay1.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay1TimeIn.Value = dtpDay1.Value.ToShortDateString & " 8:00 AM"
                dtpDay1TimeOut.Value = " 5:00 PM" & dtpDay1.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay1TimeIn.Value = dtpDay1.Value.ToShortDateString & " 2:00 AM"
                dtpDay1TimeOut.Value = " 10:00 PM" & dtpDay1.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay1TimeIn.Value = dtpDay1.Value.ToShortDateString & " 6:00 AM"
                dtpDay1TimeOut.Value = " 2:00 PM" & dtpDay1.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay1TimeIn.Value = dtpDay1.Value.ToShortDateString & " 10:00 AM"
                dtpDay1TimeOut.Value = " 6:00 PM" & dtpDay1.Value.ToShortDateString
            End If


        End If

        'checkbox 2
        If chckbx2.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay2TimeIn.Value = dtpDay2.Value.ToShortDateString & " 7:30 AM"
                dtpDay2TimeOut.Value = " 4:30 PM" & dtpDay2.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay2TimeIn.Value = dtpDay2.Value.ToShortDateString & " 8:00 AM"
                dtpDay2TimeOut.Value = " 5:00 PM" & dtpDay2.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay2TimeIn.Value = dtpDay2.Value.ToShortDateString & " 2:00 AM"
                dtpDay2TimeOut.Value = " 10:00 PM" & dtpDay2.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay2TimeIn.Value = dtpDay2.Value.ToShortDateString & " 6:00 AM"
                dtpDay2TimeOut.Value = " 2:00 PM" & dtpDay2.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay2TimeIn.Value = dtpDay2.Value.ToShortDateString & " 10:00 AM"
                dtpDay2TimeOut.Value = " 6:00 PM" & dtpDay2.Value.ToShortDateString
            End If
        End If

        'checkbox 3
        If chckbx3.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay3TimeIn.Value = dtpDay3.Value.ToShortDateString & " 7:30 AM"
                dtpDay3TimeOut.Value = " 4:30 PM" & dtpDay3.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay3TimeIn.Value = dtpDay3.Value.ToShortDateString & " 8:00 AM"
                dtpDay3TimeOut.Value = " 5:00 PM" & dtpDay3.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay3TimeIn.Value = dtpDay3.Value.ToShortDateString & " 2:00 AM"
                dtpDay3TimeOut.Value = " 10:00 PM" & dtpDay3.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay3TimeIn.Value = dtpDay3.Value.ToShortDateString & " 6:00 AM"
                dtpDay3TimeOut.Value = " 2:00 PM" & dtpDay3.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay3TimeIn.Value = dtpDay3.Value.ToShortDateString & " 10:00 AM"
                dtpDay3TimeOut.Value = " 6:00 PM" & dtpDay3.Value.ToShortDateString
            End If
        End If

        'checkbox 4
        If chckbx4.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay4TimeIn.Value = dtpDay4.Value.ToShortDateString & " 7:30 AM"
                dtpDay4TimeOut.Value = " 4:30 PM" & dtpDay4.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay4TimeIn.Value = dtpDay4.Value.ToShortDateString & " 8:00 AM"
                dtpDay4TimeOut.Value = " 5:00 PM" & dtpDay4.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay4TimeIn.Value = dtpDay4.Value.ToShortDateString & " 2:00 AM"
                dtpDay4TimeOut.Value = " 10:00 PM" & dtpDay4.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay4TimeIn.Value = dtpDay4.Value.ToShortDateString & " 6:00 AM"
                dtpDay4TimeOut.Value = " 2:00 PM" & dtpDay4.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay4TimeIn.Value = dtpDay4.Value.ToShortDateString & " 10:00 AM"
                dtpDay4TimeOut.Value = " 6:00 PM" & dtpDay4.Value.ToShortDateString
            End If
        End If

        'checkbox 5
        If chckbx5.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay5TimeIn.Value = dtpDay5.Value.ToShortDateString & " 7:30 AM"
                dtpDay5TimeOut.Value = " 4:30 PM" & dtpDay5.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay5TimeIn.Value = dtpDay5.Value.ToShortDateString & " 8:00 AM"
                dtpDay5TimeOut.Value = " 5:00 PM" & dtpDay5.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay5TimeIn.Value = dtpDay5.Value.ToShortDateString & " 2:00 AM"
                dtpDay5TimeOut.Value = " 10:00 PM" & dtpDay5.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay5TimeIn.Value = dtpDay5.Value.ToShortDateString & " 6:00 AM"
                dtpDay5TimeOut.Value = " 2:00 PM" & dtpDay5.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay5TimeIn.Value = dtpDay5.Value.ToShortDateString & " 10:00 AM"
                dtpDay5TimeOut.Value = " 6:00 PM" & dtpDay5.Value.ToShortDateString
            End If
        End If

        'checkbox 6
        If chckbx6.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay6TimeIn.Value = dtpDay6.Value.ToShortDateString & " 7:30 AM"
                dtpDay6TimeOut.Value = " 4:30 PM" & dtpDay6.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay6TimeIn.Value = dtpDay6.Value.ToShortDateString & " 8:00 AM"
                dtpDay6TimeOut.Value = " 5:00 PM" & dtpDay6.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay6TimeIn.Value = dtpDay6.Value.ToShortDateString & " 2:00 AM"
                dtpDay6TimeOut.Value = " 10:00 PM" & dtpDay6.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay6TimeIn.Value = dtpDay6.Value.ToShortDateString & " 6:00 AM"
                dtpDay6TimeOut.Value = " 2:00 PM" & dtpDay6.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay6TimeIn.Value = dtpDay6.Value.ToShortDateString & " 10:00 AM"
                dtpDay6TimeOut.Value = " 6:00 PM" & dtpDay6.Value.ToShortDateString
            End If
        End If

        'checkbox 7
        If chckbx7.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay7TimeIn.Value = dtpDay7.Value.ToShortDateString & " 7:30 AM"
                dtpDay7TimeOut.Value = " 4:30 PM" & dtpDay7.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay7TimeIn.Value = dtpDay7.Value.ToShortDateString & " 8:00 AM"
                dtpDay7TimeOut.Value = " 5:00 PM" & dtpDay7.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay7TimeIn.Value = dtpDay7.Value.ToShortDateString & " 2:00 AM"
                dtpDay7TimeOut.Value = " 10:00 PM" & dtpDay7.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay7TimeIn.Value = dtpDay7.Value.ToShortDateString & " 6:00 AM"
                dtpDay7TimeOut.Value = " 2:00 PM" & dtpDay7.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay7TimeIn.Value = dtpDay7.Value.ToShortDateString & " 10:00 AM"
                dtpDay7TimeOut.Value = " 6:00 PM" & dtpDay7.Value.ToShortDateString
            End If
        End If

        'checkbox 8
        If chckbx8.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay8TimeIn.Value = dtpDay8.Value.ToShortDateString & " 7:30 AM"
                dtpDay8TimeOut.Value = " 4:30 PM" & dtpDay8.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay8TimeIn.Value = dtpDay8.Value.ToShortDateString & " 8:00 AM"
                dtpDay8TimeOut.Value = " 5:00 PM" & dtpDay8.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay8TimeIn.Value = dtpDay8.Value.ToShortDateString & " 2:00 AM"
                dtpDay8TimeOut.Value = " 10:00 PM" & dtpDay8.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay8TimeIn.Value = dtpDay8.Value.ToShortDateString & " 6:00 AM"
                dtpDay8TimeOut.Value = " 2:00 PM" & dtpDay8.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay8TimeIn.Value = dtpDay8.Value.ToShortDateString & " 10:00 AM"
                dtpDay8TimeOut.Value = " 6:00 PM" & dtpDay8.Value.ToShortDateString
            End If
        End If

        'checkbox 9
        If chckbx9.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay9TimeIn.Value = dtpDay9.Value.ToShortDateString & " 7:30 AM"
                dtpDay9TimeOut.Value = " 4:30 PM" & dtpDay9.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay9TimeIn.Value = dtpDay9.Value.ToShortDateString & " 8:00 AM"
                dtpDay9TimeOut.Value = " 5:00 PM" & dtpDay9.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay9TimeIn.Value = dtpDay9.Value.ToShortDateString & " 2:00 AM"
                dtpDay9TimeOut.Value = " 10:00 PM" & dtpDay9.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay9TimeIn.Value = dtpDay9.Value.ToShortDateString & " 6:00 AM"
                dtpDay9TimeOut.Value = " 2:00 PM" & dtpDay9.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay9TimeIn.Value = dtpDay9.Value.ToShortDateString & " 10:00 AM"
                dtpDay9TimeOut.Value = " 6:00 PM" & dtpDay9.Value.ToShortDateString
            End If
        End If

        'checkbox 10
        If chckbx10.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay10TimeIn.Value = dtpDay10.Value.ToShortDateString & " 7:30 AM"
                dtpDay10TimeOut.Value = " 4:30 PM" & dtpDay10.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay10TimeIn.Value = dtpDay10.Value.ToShortDateString & " 8:00 AM"
                dtpDay10TimeOut.Value = " 5:00 PM" & dtpDay10.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay10TimeIn.Value = dtpDay10.Value.ToShortDateString & " 2:00 AM"
                dtpDay10TimeOut.Value = " 10:00 PM" & dtpDay10.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay10TimeIn.Value = dtpDay10.Value.ToShortDateString & " 6:00 AM"
                dtpDay10TimeOut.Value = " 2:00 PM" & dtpDay10.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay10TimeIn.Value = dtpDay10.Value.ToShortDateString & " 10:00 AM"
                dtpDay10TimeOut.Value = " 6:00 PM" & dtpDay10.Value.ToShortDateString
            End If
        End If

        'checkbox 11
        If chckbx11.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay11TimeIn.Value = dtpDay11.Value.ToShortDateString & " 7:30 AM"
                dtpDay11TimeOut.Value = " 4:30 PM" & dtpDay11.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay11TimeIn.Value = dtpDay11.Value.ToShortDateString & " 8:00 AM"
                dtpDay11TimeOut.Value = " 5:00 PM" & dtpDay11.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay11TimeIn.Value = dtpDay11.Value.ToShortDateString & " 2:00 AM"
                dtpDay11TimeOut.Value = " 10:00 PM" & dtpDay11.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay11TimeIn.Value = dtpDay11.Value.ToShortDateString & " 6:00 AM"
                dtpDay11TimeOut.Value = " 2:00 PM" & dtpDay11.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay11TimeIn.Value = dtpDay11.Value.ToShortDateString & " 10:00 AM"
                dtpDay11TimeOut.Value = " 6:00 PM" & dtpDay11.Value.ToShortDateString
            End If
        End If

        'checkbox 12
        If chckbx12.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay12TimeIn.Value = dtpDay12.Value.ToShortDateString & " 7:30 AM"
                dtpDay12TimeOut.Value = " 4:30 PM" & dtpDay12.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay12TimeIn.Value = dtpDay12.Value.ToShortDateString & " 8:00 AM"
                dtpDay12TimeOut.Value = " 5:00 PM" & dtpDay12.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay12TimeIn.Value = dtpDay12.Value.ToShortDateString & " 2:00 AM"
                dtpDay12TimeOut.Value = " 10:00 PM" & dtpDay12.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay12TimeIn.Value = dtpDay12.Value.ToShortDateString & " 6:00 AM"
                dtpDay12TimeOut.Value = " 2:00 PM" & dtpDay12.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay12TimeIn.Value = dtpDay12.Value.ToShortDateString & " 10:00 AM"
                dtpDay12TimeOut.Value = " 6:00 PM" & dtpDay12.Value.ToShortDateString
            End If
        End If

        'checkbox 13
        If chckbx13.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay13TimeIn.Value = dtpDay13.Value.ToShortDateString & " 7:30 AM"
                dtpDay13TimeOut.Value = " 4:30 PM" & dtpDay13.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay13TimeIn.Value = dtpDay13.Value.ToShortDateString & " 8:00 AM"
                dtpDay13TimeOut.Value = " 5:00 PM" & dtpDay13.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay13TimeIn.Value = dtpDay13.Value.ToShortDateString & " 2:00 AM"
                dtpDay13TimeOut.Value = " 10:00 PM" & dtpDay13.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay13TimeIn.Value = dtpDay13.Value.ToShortDateString & " 6:00 AM"
                dtpDay13TimeOut.Value = " 2:00 PM" & dtpDay13.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay13TimeIn.Value = dtpDay13.Value.ToShortDateString & " 10:00 AM"
                dtpDay13TimeOut.Value = " 6:00 PM" & dtpDay13.Value.ToShortDateString
            End If
        End If

        'checkbox 14
        If chckbx14.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay14TimeIn.Value = dtpDay14.Value.ToShortDateString & " 7:30 AM"
                dtpDay14TimeOut.Value = " 4:30 PM" & dtpDay14.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay14TimeIn.Value = dtpDay14.Value.ToShortDateString & " 8:00 AM"
                dtpDay14TimeOut.Value = " 5:00 PM" & dtpDay14.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay14TimeIn.Value = dtpDay14.Value.ToShortDateString & " 2:00 AM"
                dtpDay14TimeOut.Value = " 10:00 PM" & dtpDay14.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay14TimeIn.Value = dtpDay14.Value.ToShortDateString & " 6:00 AM"
                dtpDay14TimeOut.Value = " 2:00 PM" & dtpDay14.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay14TimeIn.Value = dtpDay14.Value.ToShortDateString & " 10:00 AM"
                dtpDay14TimeOut.Value = " 6:00 PM" & dtpDay14.Value.ToShortDateString
            End If
        End If

        'checkbox 15
        If chckbx15.Checked Then
            If cmbshift.SelectedIndex = 0 Then

                dtpDay15TimeIn.Value = dtpDay15.Value.ToShortDateString & " 7:30 AM"
                dtpDay15TimeOut.Value = " 4:30 PM" & dtpDay15.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 1 Then
                dtpDay15TimeIn.Value = dtpDay15.Value.ToShortDateString & " 8:00 AM"
                dtpDay15TimeOut.Value = " 5:00 PM" & dtpDay15.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 2 Then
                dtpDay15TimeIn.Value = dtpDay15.Value.ToShortDateString & " 2:00 AM"
                dtpDay15TimeOut.Value = " 10:00 PM" & dtpDay15.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 3 Then
                dtpDay15TimeIn.Value = dtpDay15.Value.ToShortDateString & " 6:00 AM"
                dtpDay15TimeOut.Value = " 2:00 PM" & dtpDay15.Value.ToShortDateString

            ElseIf cmbshift.SelectedIndex = 4 Then
                dtpDay15TimeIn.Value = dtpDay15.Value.ToShortDateString & " 10:00 AM"
                dtpDay15TimeOut.Value = " 6:00 PM" & dtpDay15.Value.ToShortDateString
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Date.Now.Day >= 16 Then
            lblcutoffdate.Text = "From: " + second.ToShortDateString + " To : " + third.ToShortDateString
            dtpDay1.Value = New Date(Date.Now.Year, Date.Now.Month, 16)
            dtpDay2.Value = New Date(Date.Now.Year, Date.Now.Month, 17)
            dtpDay3.Value = New Date(Date.Now.Year, Date.Now.Month, 18)
            dtpDay4.Value = New Date(Date.Now.Year, Date.Now.Month, 19)
            dtpDay5.Value = New Date(Date.Now.Year, Date.Now.Month, 20)
            dtpDay6.Value = New Date(Date.Now.Year, Date.Now.Month, 21)
            dtpDay7.Value = New Date(Date.Now.Year, Date.Now.Month, 22)
            dtpDay8.Value = New Date(Date.Now.Year, Date.Now.Month, 23)
            dtpDay9.Value = New Date(Date.Now.Year, Date.Now.Month, 24)
            dtpDay10.Value = New Date(Date.Now.Year, Date.Now.Month, 25)
            dtpDay11.Value = New Date(Date.Now.Year, Date.Now.Month, 26)
            dtpDay12.Value = New Date(Date.Now.Year, Date.Now.Month, 27)
            dtpDay13.Value = New Date(Date.Now.Year, Date.Now.Month, 28)
            dtpDay14.Value = New Date(Date.Now.Year, Date.Now.Month, 29)
            dtpDay15.Value = New Date(Date.Now.Year, Date.Now.Month, 30)
            If mydate = 31 Then
                dtpDay16.Value = New Date(Date.Now.Year, Date.Now.Month, 31)
            End If
        Else
            lblcutoffdate.Text = "From: " + first.ToShortDateString + " To : " + second.ToShortDateString
            dtpDay1.Value = New Date(Date.Now.Year, Date.Now.Month, 1)
            dtpDay2.Value = New Date(Date.Now.Year, Date.Now.Month, 2)
            dtpDay3.Value = New Date(Date.Now.Year, Date.Now.Month, 3)
            dtpDay4.Value = New Date(Date.Now.Year, Date.Now.Month, 4)
            dtpDay5.Value = New Date(Date.Now.Year, Date.Now.Month, 5)
            dtpDay6.Value = New Date(Date.Now.Year, Date.Now.Month, 6)
            dtpDay7.Value = New Date(Date.Now.Year, Date.Now.Month, 7)
            dtpDay8.Value = New Date(Date.Now.Year, Date.Now.Month, 8)
            dtpDay9.Value = New Date(Date.Now.Year, Date.Now.Month, 9)
            dtpDay10.Value = New Date(Date.Now.Year, Date.Now.Month, 10)
            dtpDay11.Value = New Date(Date.Now.Year, Date.Now.Month, 11)
            dtpDay12.Value = New Date(Date.Now.Year, Date.Now.Month, 12)
            dtpDay13.Value = New Date(Date.Now.Year, Date.Now.Month, 13)
            dtpDay14.Value = New Date(Date.Now.Year, Date.Now.Month, 14)
            dtpDay15.Value = New Date(Date.Now.Year, Date.Now.Month, 15)
        End If
    End Sub
    Private Sub dtpDay1TimeOut_ValueChanged(sender As Object, e As EventArgs) Handles dtpDay1TimeOut.ValueChanged
        Dim time1 = dtpDay1TimeIn.Value
        Dim time2 = dtpDay1TimeOut.Value
        Dim result As TimeSpan = time2.Subtract(time1)
        Dim total As Double
        Dim break As Boolean = False
        Dim ot As Double
        Dim ndot As Double
        Dim excess As Double
        Dim gperiod As Integer
        Dim minus As Integer
        Dim gperiodresult As Integer




        ' For Shift A
        If cmbshift.SelectedIndex = 0 Then






            'For first 4 hrs
            If result.TotalMinutes >= 1 And result.TotalMinutes <= 300 Then
                lblhrs1.Text = result.TotalHours.ToString()
            End If


            'For -1 hr break in the first 4 hrs
            If result.TotalMinutes >= 240 And result.TotalMinutes <= 300 Then
                excess = result.TotalMinutes - 240
                total = (result.TotalMinutes - excess) / 60
                lblhrs1.Text = total.ToString
                break = True
            End If

            'For the next 4hrs after break
            If result.TotalMinutes >= 301 And result.TotalMinutes <= 540 Then
                '  minus = 60
                ' gperiodresult = minus + gperiod




                total = (result.TotalMinutes - 60) / 60
                lblhrs1.Text = total.ToString()

            End If

            'For OT until 10pm for Shift A 
            If result.TotalMinutes >= 541 And result.TotalMinutes <= 870 Then
                ot = (result.TotalMinutes - 540) / 60
                ckbOT1.Text = ot.ToString
                lblgetrot.Text = ot
            ElseIf result.TotalMinutes >= 540 Then
                ckbOT1.Text = lblgetrot.Text



            End If

            'Night Differential Over Time for Shift A 
            If result.TotalMinutes >= 871 And result.TotalMinutes <= 1350 Then
                ndot = (result.TotalMinutes - 870) / 60
                lblNDOT1.Text = ndot.ToString

            Else

            End If

            If result.TotalMinutes >= 1351 Then
                ot = ((result.TotalMinutes - 1350) + (ot * 60) / 60)
                ckbOT1.Text = ot.ToString


            End If
            If cmbshift.SelectedIndex = 0 Then

            End If
        End If

        Dim datee As Integer = dtpDay1TimeOut.Value.Hour


        If datee >= 22 And datee <= 6 Then
            MsgBox("nd ot fck u")


        End If

        Label39.Text = dtpDay1TimeOut.ToString

    End Sub

    Private Sub chckbx4_CheckedChanged(sender As Object, e As EventArgs) Handles chckbx4.CheckedChanged

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub
End Class
