Imports IBM.Data.DB2

Public Class Form1
    Private DbConn As Common.DbConnection

    Private Sub SbStudents_Click(sender As Object, e As EventArgs) Handles SbStudents.Click
        PanelStudents.Enabled = True
        Me.PanelStudents.BringToFront()
    End Sub

    Private Sub SbSports_Click(sender As Object, e As EventArgs) Handles SbSports.Click
        PanelSports.Enabled = True
        Me.PanelSports.BringToFront()
    End Sub

    Private Sub SbTeams_Click(sender As Object, e As EventArgs) Handles SbTeams.Click
        Pnl_Teams.Enabled = True
        Me.Pnl_Teams.BringToFront()
    End Sub

    Private Sub SbSchedule_Click(sender As Object, e As EventArgs) Handles SbSchedule.Click
        Pnl_Sched.Enabled = True
        Me.Pnl_Sched.BringToFront()
    End Sub

    Private Sub SbClose_Click(sender As Object, e As EventArgs) Handles SbClose.Click
        DbConn.Close()
        Me.Close()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you wish to close the application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Student_Populate()
        Dim SqlSelect As String
        Dim CmdSelect As DB2Command
        Dim RdrSelect As DB2DataReader
        Dim DgvRow As String()

        Try
            SqlSelect = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo order by StudID asc"
            CmdSelect = New DB2Command(SqlSelect, DbConn)
            RdrSelect = CmdSelect.ExecuteReader

            Me.DGVStudent.Rows.Clear()
            Me.DGVSportStudent.Rows.Clear()
            While RdrSelect.Read
                DgvRow = New String() {RdrSelect.GetString(0), RdrSelect.GetString(1), _
                                       RdrSelect.GetString(2), RdrSelect.GetString(3)}
                DGVStudent.Rows.Add(DgvRow)
                DGVSportStudent.Rows.Add(DgvRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Sport_Populate()
        Dim SqlSelect As String
        Dim CmdSelect As DB2Command
        Dim RdrSelect As DB2DataReader
        Dim DgvRow As String()

        Try
            SqlSelect = "select a. SportNo, a.SName, b.VName VenueNo from sport a join venue b on a.VenueNo = b.VenueNo order by SName asc"
            CmdSelect = New DB2Command(SqlSelect, DbConn)
            RdrSelect = CmdSelect.ExecuteReader

            Me.DGVSport.Rows.Clear()
            While RdrSelect.Read
                DgvRow = New String() {RdrSelect.GetString(0), RdrSelect.GetString(1), _
                                       RdrSelect.GetString(2)}

                DGVSport.Rows.Add(DgvRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Stud_Sport_Populate()
        Dim SqlSelect As String
        Dim CmdSelect As DB2Command
        Dim RdrSelect As DB2DataReader
        Dim DgvRow As String()

        Try
            SqlSelect = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo order by a.StudID asc"
            CmdSelect = New DB2Command(SqlSelect, DbConn)
            RdrSelect = CmdSelect.ExecuteReader

            Me.DGVStud_Sport.Rows.Clear()
            While RdrSelect.Read
                DgvRow = New String() {RdrSelect.GetString(0), RdrSelect.GetString(1), _
                                       RdrSelect.GetString(2), RdrSelect.GetString(3), _
                                       RdrSelect.GetString(4), RdrSelect.GetString(5)}
                DGVStud_Sport.Rows.Add(DgvRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Schedule_Populate()
        Dim SqlSelect As String
        Dim CmdSelect As DB2Command
        Dim RdrSelect As DB2DataReader
        Dim DgvRow As String()

        Try
            SqlSelect = "select a.schedno, a.date, a.time, b.TName TeamNo1, c.TName TeamNo2, d.SName SportNo, e.VName VenueNo from schedule a join team b on a.TeamNo1 = b.TeamNo join team c on a.TeamNo2 = c.TeamNo join sport d on a.SportNo = d.SportNo join venue e on a.VenueNo = e.VenueNo order by date asc"
            CmdSelect = New DB2Command(SqlSelect, DbConn)
            RdrSelect = CmdSelect.ExecuteReader

            Me.View_Sched.Rows.Clear()
            While RdrSelect.Read
                DgvRow = New String() {RdrSelect.GetString(0), RdrSelect.GetString(1), _
                                       RdrSelect.GetString(2), RdrSelect.GetString(3), _
                                       RdrSelect.GetString(4), RdrSelect.GetString(5), _
                                       RdrSelect.GetString(6)}
                View_Sched.Rows.Add(DgvRow)
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PopulateDataGrid()

        Dim StrTeam As String
        Dim row As String()
        Dim CmdTeam As DB2Command
        Dim RdrTeam As DB2DataReader
        Try

            StrTeam = "Select * from team"
            CmdTeam = New DB2Command(StrTeam, DbConn)
            RdrTeam = CmdTeam.ExecuteReader
            Me.View_Teams.Rows.Clear()
            While RdrTeam.Read
                row = New String() {RdrTeam.GetString(0), RdrTeam.GetString(1)}
                Me.View_Teams.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PopulateVenueGrid()

        Dim StrVenue As String
        Dim row As String()
        Dim CmdVenue As DB2Command
        Dim RdrVenue As DB2DataReader

        Try
            StrVenue = "Select * from venue"
            CmdVenue = New DB2Command(StrVenue, DbConn)
            RdrVenue = CmdVenue.ExecuteReader
            Me.View_Venues.Rows.Clear()
            While RdrVenue.Read
                row = New String() {RdrVenue.GetString(0), RdrVenue.GetString(1)}
                Me.View_Venues.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Pnl_Home.BringToFront()

            D_SearchColumn.SelectedItem = "Student ID"
            D_SportSearchColumnStud.SelectedItem = "Student ID"
            D_SearchColumnSS.SelectedItem = "Student ID"

            DbConn = New DB2Connection("server = localhost; database = SYSTEM;" + "uid = ACER; password = teves;")
            DbConn.Open()

            View_Sched.ColumnCount = 7
            View_Sched.Columns(0).Name = "Schedule No"
            View_Sched.Columns(1).Name = "Date"
            View_Sched.Columns(2).Name = "Time"
            View_Sched.Columns(3).Name = "Team 1"
            View_Sched.Columns(4).Name = "Team 2"
            View_Sched.Columns(5).Name = "Sport"
            View_Sched.Columns(6).Name = "Venue"

            DGVStudent.ColumnCount = 4
            DGVStudent.Columns(0).Name = "Student ID"
            DGVStudent.Columns(1).Name = "Last Name"
            DGVStudent.Columns(2).Name = "First Name"
            DGVStudent.Columns(3).Name = "Team"

            DGVSportStudent.ColumnCount = 4
            DGVSportStudent.Columns(0).Name = "Student ID"
            DGVSportStudent.Columns(1).Name = "Last Name"
            DGVSportStudent.Columns(2).Name = "First Name"
            DGVSportStudent.Columns(3).Name = "Team"
            DGVSportStudent.Columns(0).Width = 83
            DGVSportStudent.Columns(3).Width = 68

            DGVSport.ColumnCount = 3
            DGVSport.Columns(0).Name = "No."
            DGVSport.Columns(1).Name = "Sport"
            DGVSport.Columns(2).Name = "Venue"

            DGVStud_Sport.ColumnCount = 6
            DGVStud_Sport.Columns(0).Name = "No."
            DGVStud_Sport.Columns(1).Name = "Student ID"
            DGVStud_Sport.Columns(2).Name = "Last Name"
            DGVStud_Sport.Columns(3).Name = "First Name"
            DGVStud_Sport.Columns(4).Name = "Team"
            DGVStud_Sport.Columns(5).Name = "Sport"
            DGVStud_Sport.Columns(0).Width = 28
            DGVStud_Sport.Columns(1).Width = 83
            DGVStud_Sport.Columns(4).Width = 38

            Me.View_Teams.ColumnCount = 2
            Me.View_Teams.Columns(0).Name = "Team No"
            Me.View_Teams.Columns(1).Name = "Team Name"

            Me.View_Venues.ColumnCount = 2
            Me.View_Venues.Columns(0).Name = "Venue No"
            Me.View_Venues.Columns(1).Name = "Venue"


            Call Student_Populate()
            Call Sport_Populate()
            Call Stud_Sport_Populate()
            Call Schedule_Populate()
            Call PopulateDataGrid()
            Call GetTeamLastID()
            Call PopulateVenueGrid()
            Call GetVenueLastID()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ClearStudent()
        Me.T_StudID.Clear()
        Me.T_LName.Clear()
        Me.T_FName.Clear()
        Me.T_TName.Clear()
        'Me.T_Search.Clear()
    End Sub

    Private Sub ClearSport()
        Me.T_SportSportNo.Clear()
        Me.T_SportStudID.Clear()
        Me.T_SportSName.Clear()
        Me.T_SportVName.Clear()
        'Me.T_SportSearchStud.Clear()
    End Sub

    Private Sub ClearStud_Sport()
        Me.T_SSEntryNo.Clear()
        Me.T_SSStudID.Clear()
        Me.T_SSSport.Clear()
        'Me.T_SSSearch.Clear()
    End Sub

    Private Sub ClearSchedule()
        Me.T_SSEntryNo.Text = String.Empty
        Me.T_SSStudID.Text = String.Empty
        Me.T_SSSport.Text = String.Empty
        'Me.T_SSSearch.Clear()
    End Sub


    'STUDENT TAB
    Private Sub DGVStudent_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVStudent.MouseUp
        Try
            With Me.DGVStudent
                Me.T_StudID.Text = .CurrentRow.Cells(0).Value
                Me.T_LName.Text = .CurrentRow.Cells(1).Value
                Me.T_FName.Text = .CurrentRow.Cells(2).Value
                Me.T_TName.Text = .CurrentRow.Cells(3).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub B_StudSave_Click(sender As Object, e As EventArgs) Handles B_StudSave.Click
        Dim VStudId As String
        Dim VLName As String
        Dim VFName As String
        Dim VTName As String
        Dim CmdInsert As DB2Command
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim VTeamNo As Integer
        Dim RdrSearch As DB2DataReader
        Dim StrInsert As String
        Try
            VStudId = Me.T_StudID.Text
            VLName = Me.T_LName.Text
            VFName = Me.T_FName.Text
            VTName = Me.T_TName.Text

            StrSearch = "Select * from team where TName like '" & VTName & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo = RdrSearch.GetInt32(0)
            End If

            StrInsert = "insert into student values('" & VStudId & "', " _
            & " '" & VLName & "','" & VFName & "','" & VTeamNo & "')"

            CmdInsert = New DB2Command(StrInsert, DbConn)
            CmdInsert.ExecuteNonQuery()

            Call ClearStudent()
            Call Student_Populate()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Student Successfully Added!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_StudDelete_Click(sender As Object, e As EventArgs) Handles B_StudDelete.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            StrDelete = "delete from student where studid = '" & Me.T_StudID.Text & "'"
            CmdDelete = New DB2Command(StrDelete, DbConn)

            If MessageBox.Show("The current record will be deleted. Proceed deleting?", "Student Maintenance", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CmdDelete.ExecuteNonQuery()
                Call ClearStudent()
                Call Student_Populate()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MessageBox.Show("Student Data Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_StudUpdate_Click(sender As Object, e As EventArgs) Handles B_StudUpdate.Click
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim VTeamNo As Integer
        Dim RdrSearch As DB2DataReader
        Dim StrUpdate As String
        Dim CmdUpdate As DB2Command


        Try
            StrSearch = "Select * from team where TName like '" & Me.T_TName.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo = RdrSearch.GetInt32(0)
            End If

            StrUpdate = "update student set LName = '" & Me.T_LName.Text & "', " _
                & "FName = '" & Me.T_FName.Text & "', " _
                & "TeamNo = '" & VTeamNo & "' " _
                & "where StudID = '" & Me.T_StudID.Text & "'"
            CmdUpdate = New DB2Command(StrUpdate, DbConn)
            CmdUpdate.ExecuteNonQuery()

            Call ClearStudent()
            Call Student_Populate()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MessageBox.Show("Student Data Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles T_Search.TextChanged ', D_SearchColumn.SelectedIndexChanged'
        Dim VStrInput As String
        Dim StrSearch As String
        Dim row As String()
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            If D_SearchColumn.SelectedItem = "Student ID" Then
                VStrInput = Me.T_Search.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where StudID like '" & VStrInput & "' order by StudID asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVStudent.Rows.Add(row)
                End While

            ElseIf D_SearchColumn.SelectedItem = "Last Name" Then
                VStrInput = Me.T_Search.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where LName like '" & VStrInput & "' order by LName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVStudent.Rows.Add(row)
                End While

            ElseIf D_SearchColumn.SelectedItem = "First Name" Then
                VStrInput = Me.T_Search.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where FName like '" & VStrInput & "' order by FName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVStudent.Rows.Add(row)
                End While

            ElseIf D_SearchColumn.SelectedItem = "Team" Then
                VStrInput = Me.T_Search.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where TName like '" & VStrInput & "' order by TName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVStudent.Rows.Add(row)
                End While

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub StudentInputBox_TextChanged(sender As Object, e As EventArgs) Handles T_StudID.TextChanged, T_LName.TextChanged, T_FName.TextChanged, T_TName.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            If Me.T_StudID.Text.Length() = 10 Then
                StrSearch = "Select * from student where StudID like '" & Me.T_StudID.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    Me.B_StudSave.Enabled = False
                    Me.B_StudDelete.Enabled = True

                    If Me.T_LName.Text.Length() = 0 Or Me.T_FName.Text.Length() = 0 Or Me.T_FName.Text.Length() = 0 Or Me.T_TName.Text.Length() = 0 Then
                        Me.B_StudUpdate.Enabled = False
                        Me.StudError.Visible = True
                        Me.StudError.Text = "All fields must be filled."

                    Else
                        StrSearch = "Select * from team where TName like '" & Me.T_TName.Text & "' "
                        CmdSearch = New DB2Command(StrSearch, DbConn)
                        RdrSearch = CmdSearch.ExecuteReader

                        If RdrSearch.Read Then
                            Me.B_StudUpdate.Enabled = True
                            Me.StudError.Visible = False
                        Else
                            Me.B_StudUpdate.Enabled = False
                            Me.StudError.Visible = True
                            Me.StudError.Text = "Team does not exist!"
                        End If
                    End If

                ElseIf Me.T_LName.Text.Length() > 0 And Me.T_FName.Text.Length() > 0 And Me.T_FName.Text.Length() > 0 And Me.T_TName.Text.Length() > 0 Then
                    StrSearch = "Select * from team where TName like '" & Me.T_TName.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        Me.B_StudSave.Enabled = True
                        Me.StudError.Visible = False

                    Else
                        Me.StudError.Visible = True
                        Me.StudError.Text = "Team does not exist!"
                    End If

                Else
                    Me.StudError.Visible = True
                    Me.StudError.Text = "All fields must be filled."
                End If

            Else
                Me.B_StudSave.Enabled = False
                Me.B_StudUpdate.Enabled = False
                Me.B_StudDelete.Enabled = False
                Me.StudError.Visible = True
                Me.StudError.Text = "Student ID must be 10 characters."
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    'SPORT TAB
    Private Sub DGVSportStudent_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVSportStudent.MouseUp
        Try
            With Me.DGVSportStudent
                Me.T_SportStudID.Text = .CurrentRow.Cells(0).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVSport_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVSport.MouseUp
        Try
            With Me.DGVSport
                Me.T_SportSportNo().Text = .CurrentRow.Cells(0).Value
                Me.T_SportSName.Text = .CurrentRow.Cells(1).Value
                Me.T_SportVName.Text = .CurrentRow.Cells(2).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVStud_Sport_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVStud_Sport.MouseUp
        Try
            With Me.DGVStud_Sport
                Me.T_SSEntryNo.Text = .CurrentRow.Cells(0).Value
                Me.T_SSStudID.Text = .CurrentRow.Cells(1).Value
                Me.T_SSSport.Text = .CurrentRow.Cells(5).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    Private Sub B_SportAssign_Click(sender As Object, e As EventArgs) Handles B_SportAssign.Click
        Dim VSDNo As Integer
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim VSportNo As Integer
        Dim RdrSearch As DB2DataReader

        Try
            StrSearch = "Select SDNo from Stud_Sport order by SDNo desc"
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader
            If RdrSearch.HasRows Then
                RdrSearch.Read()
                VSDNo = RdrSearch.GetString(0)
                VSDNo = VSDNo + 1
            Else
                VSDNo = 1
            End If

            StrSearch = "Select * from sport where SName like '" & Me.T_SportSName.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VSportNo = RdrSearch.GetString(0)
            End If

            StrSearch = "insert into stud_sport values('" & VSDNo & "', " _
            & " '" & Me.T_SportStudID.Text & "','" & VSportNo & "')"
            CmdSearch = New DB2Command(StrSearch, DbConn)
            CmdSearch.ExecuteNonQuery()

            Call Stud_Sport_Populate()
            Call ClearSport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MessageBox.Show("Sport Successfully Assigned!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_SportSave_Click(sender As Object, e As EventArgs) Handles B_SportSave.Click
        Dim VVenueNo As Integer
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Try
            StrSearch = "Select * from venue where VName like '" & Me.T_SportVName.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VVenueNo = RdrSearch.GetString(0)
            End If

            StrSearch = "insert into sport values ('" & Me.T_SportSportNo.Text & "','" & Me.T_SportSName.Text & "','" & VVenueNo & "')"
            CmdSearch = New DB2Command(StrSearch, DbConn)
            CmdSearch.ExecuteNonQuery()

            Call Sport_Populate()
            Call ClearSport()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MessageBox.Show("Sport Successfully Added!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_SportDelete_Click(sender As Object, e As EventArgs) Handles B_SportDelete.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            StrDelete = "delete from sport where SName = '" & Me.T_SportSName.Text & "'"
            CmdDelete = New DB2Command(StrDelete, DbConn)

            If MessageBox.Show("The current record will be deleted. Proceed deleting?", "Sport Maintenance", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CmdDelete.ExecuteNonQuery()
                Call ClearSport()
                Call Sport_Populate()
                Call ClearStud_Sport()
                Call Stud_Sport_Populate()
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Sport Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_SportUpdate_Click(sender As Object, e As EventArgs) Handles B_SportUpdate.Click
        Dim VVenueNo As Integer
        Dim StrUpdate As String
        Dim CmdUpdate As DB2Command
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrUpdate = "Select * from venue where VName like '" & Me.T_SportVName.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VVenueNo = RdrSearch.GetInt32(0)
            End If

            StrUpdate = "update sport set SName = '" & Me.T_SportSName.Text & "', " _
                & "VenueNo = '" & VVenueNo & "' where SportNo = '" & Me.T_SportSportNo.Text & "'"
            CmdUpdate = New DB2Command(StrUpdate, DbConn)
            CmdUpdate.ExecuteNonQuery()

            Call Sport_Populate()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Sport Successfully Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_SSDelete_Click(sender As Object, e As EventArgs) Handles B_SSDelete.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            StrDelete = "delete from stud_sport where SDNo = '" & Me.T_SSEntryNo.Text & "'"
            CmdDelete = New DB2Command(StrDelete, DbConn)

            If MessageBox.Show("The current record will be deleted. Proceed deleting?", "Sport Maintenance", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CmdDelete.ExecuteNonQuery()
                Call ClearStud_Sport()
                Call Stud_Sport_Populate()
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Sport Data Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub B_SSUpdate_Click(sender As Object, e As EventArgs) Handles B_SSUpdate.Click
        Dim VSportNo As Integer
        Dim StrUpdate As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrUpdate = "Select * from sport where sName like '" & Me.T_SSSport.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VSportNo = RdrSearch.GetInt32(0)
            End If

            StrUpdate = "update stud_sport set StudID = '" & Me.T_SSStudID.Text & "', " _
                & "SportNo = '" & VSportNo & "' where SDNo = '" & Me.T_SSEntryNo.Text & "'"
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            CmdSearch.ExecuteNonQuery()

            Call Stud_Sport_Populate()
            Call ClearStud_Sport()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Sport Data Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub T_SportSearchStud_TextChanged(sender As Object, e As EventArgs) Handles T_SportSearchStud.TextChanged
        Dim VStrInput As String
        Dim StrSearch As String
        Dim row As String()
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            If D_SportSearchColumnStud.SelectedItem = "Student ID" Then
                VStrInput = Me.T_SportSearchStud.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where StudID like '" & VStrInput & "' order by StudID asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVSportStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVSportStudent.Rows.Add(row)
                End While

            ElseIf D_SportSearchColumnStud.SelectedItem = "Last Name" Then
                VStrInput = Me.T_SportSearchStud.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where LName like '" & VStrInput & "' order by LName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVSportStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVSportStudent.Rows.Add(row)
                End While

            ElseIf D_SportSearchColumnStud.SelectedItem = "First Name" Then
                VStrInput = Me.T_SportSearchStud.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where FName like '" & VStrInput & "' order by FName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVSportStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVSportStudent.Rows.Add(row)
                End While

            ElseIf D_SportSearchColumnStud.SelectedItem = "Team" Then
                VStrInput = Me.T_SportSearchStud.Text + "%"
                StrSearch = "select a.StudID, a.LName, a.FName, b.TName TeamNo from student a join team b on a.TeamNo = b.TeamNo where TName like '" & VStrInput & "' order by TName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVSportStudent.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3)}
                    Me.DGVSportStudent.Rows.Add(row)
                End While

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub T_SSSearch_TextChanged(sender As Object, e As EventArgs) Handles T_SSSearch.TextChanged
        Dim VStrInput As String
        Dim StrSearch As String
        Dim row As String()
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            If D_SearchColumnSS.SelectedItem = "Entry No." Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where a.SDNo like '" & VStrInput & "' order by a.SDNo asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            ElseIf D_SearchColumnSS.SelectedItem = "Student ID" Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where a.StudID like '" & VStrInput & "' order by a.StudID asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            ElseIf D_SearchColumnSS.SelectedItem = "Last Name" Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where b.LName like '" & VStrInput & "' order by b.LName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            ElseIf D_SearchColumnSS.SelectedItem = "First Name" Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where b.FName like '" & VStrInput & "' order by b.FName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            ElseIf D_SearchColumnSS.SelectedItem = "Team" Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where c.TName like '" & VStrInput & "' order by c.TName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            ElseIf D_SearchColumnSS.SelectedItem = "Sport" Then
                VStrInput = Me.T_SSSearch.Text + "%"
                StrSearch = "select a.SDNo, a.StudID, b.LName StudID, b.FName StudID, c.TName TeamNo, d.SName SportNo from stud_sport a join student b on a.StudID = b.StudID join team c on b.TeamNo = c.TeamNo join sport d on a.SportNo = d.SportNo where d.SName like '" & VStrInput & "' order by d.SName asc"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader
                Me.DGVStud_Sport.Rows.Clear()
                While RdrSearch.Read
                    row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), _
                                        RdrSearch.GetString(3), RdrSearch.GetString(4), RdrSearch.GetString(5)}
                    Me.DGVStud_Sport.Rows.Add(row)
                End While

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub StudandSportInputbox_TextChanged(sender As Object, e As EventArgs) Handles T_SportStudID.TextChanged, T_SportSportNo.TextChanged, T_SportSName.TextChanged, T_SportVName.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrSearch = "Select * from sport where SportNo like '" & Me.T_SportSportNo.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                StrSearch = "Select * from student where StudID like '" & Me.T_SportStudID.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    StrSearch = "select a. SDNo, a.StudID, b.SName SportNo from stud_sport a join sport b on a.SportNo = b.SportNo where StudID like '" & Me.T_SportStudID.Text & "' and Sname like '" & Me.T_SportSName.Text & "'"
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        B_SportAssign.Enabled = False
                    Else
                        B_SportAssign.Enabled = True
                    End If

                Else
                    B_SportAssign.Enabled = False
                End If

                StrSearch = "Select * from venue where VName like '" & Me.T_SportVName.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    StrSearch = "select a.SName, b.VName VenueNo from sport a join venue b on a.VenueNo = b.VenueNo where VName like '" & Me.T_SportVName.Text & "' and SName like  '" & Me.T_SportSName.Text & "'"
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        B_SportUpdate.Enabled = True
                    Else
                        B_SportUpdate.Enabled = True
                    End If
                Else
                    B_SportUpdate.Enabled = False
                End If

                B_SportDelete.Enabled = True
                B_SportSave.Enabled = False

            Else
                StrSearch = "Select SName from sport where SName like '" & Me.T_SportSName.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    B_SportSave.Enabled = False

                Else
                    StrSearch = "Select * from venue where VName like '" & Me.T_SportVName.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        B_SportSave.Enabled = True
                    Else
                        B_SportSave.Enabled = False
                    End If
                End If

                B_SportAssign.Enabled = False
                B_SportUpdate.Enabled = False
                B_SportDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Stud_Sport_TextChanged(sender As Object, e As EventArgs) Handles T_SSEntryNo.TextChanged, T_SSStudID.TextChanged, T_SSSport.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrSearch = "select SDNo from stud_sport where SDNo like '" & Me.T_SSEntryNo.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                StrSearch = "select a.SDNo, a.StudID, b.SName SportNo from stud_sport a join sport b on a.SportNo = b.SportNo where StudID like '" & Me.T_SSStudID.Text & "' and Sname like '" & Me.T_SSSport.Text & "'"
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    StrSearch = "select a.SDNo, a.StudID, b.SName SportNo from stud_sport a join sport b on a.SportNo = b.SportNo where SDNo like '" & Me.T_SSEntryNo.Text & "' and StudID like '" & Me.T_SSStudID.Text & "' and Sname like '" & Me.T_SSSport.Text & "'"
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        B_SSUpdate.Enabled = True
                    Else
                        B_SSUpdate.Enabled = False
                    End If

                Else
                    StrSearch = "Select StudID from student where StudID like '" & Me.T_SSStudID.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        StrSearch = "Select SName from sport where SName like '" & Me.T_SSSport.Text & "' "
                        CmdSearch = New DB2Command(StrSearch, DbConn)
                        RdrSearch = CmdSearch.ExecuteReader

                        If RdrSearch.Read Then
                            B_SSUpdate.Enabled = True
                        Else
                            B_SSUpdate.Enabled = False
                        End If
                    Else
                        B_SSUpdate.Enabled = False
                    End If
                End If

                B_SSDelete.Enabled = True

            Else
                B_SSDelete.Enabled = False
                B_SSUpdate.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    'SCHEDULE TAB
    Private Sub View_Sched_MouseUp(sender As Object, e As MouseEventArgs) Handles View_Sched.MouseUp
        Try
            With Me.View_Sched
                Me.Sched_TxtSchedNo.Text = .CurrentRow.Cells(0).Value
                Me.Sched_DatePicker.Text = .CurrentRow.Cells(1).Value
                Me.Sched_TimePicker.Text = .CurrentRow.Cells(2).Value
                Me.Sched_TxtTeam1.Text = .CurrentRow.Cells(3).Value
                Me.Sched_TxtTeam2.Text = .CurrentRow.Cells(4).Value
                Me.Sched_TxtSport.Text = .CurrentRow.Cells(5).Value
                Me.Sched_TxtVenue.Text = .CurrentRow.Cells(6).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Sched_NewButton_Click(sender As Object, e As EventArgs) Handles Sched_NewButton.Click
        Dim VTeamNo1 As Integer
        Dim VTeamNo2 As Integer
        Dim VSportNo As Integer
        Dim VVenueNo As Integer
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Try

            StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam1.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo1 = RdrSearch.GetString(0)
            End If

            StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam2.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo2 = RdrSearch.GetString(0)
            End If

            StrSearch = "Select SportNo, SName from sport where SName like '" & Me.Sched_TxtSport.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VSportNo = RdrSearch.GetString(0)
            End If

            StrSearch = "Select * from venue where VName like '" & Me.Sched_TxtVenue.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VVenueNo = RdrSearch.GetString(0)
            End If

            MessageBox.Show("'" & VTeamNo1 & "', '" & VTeamNo2 & "', '" & VSportNo & "', '" & VVenueNo & "'")

            StrSearch = "insert into schedule values ('" & Me.Sched_TxtSchedNo.Text & "','" & Me.Sched_DatePicker.Text & "','" & Me.Sched_TimePicker.Text & "', '" & VTeamNo1 & "', '" & VTeamNo2 & "', '" & VSportNo & "', '" & VVenueNo & "')"
            CmdSearch = New DB2Command(StrSearch, DbConn)
            CmdSearch.ExecuteNonQuery()

            Call Schedule_Populate()
            Call ClearSchedule()
        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
        MessageBox.Show("New Schedule Successfully Added!", "SU Inramurals Tracker System")
    End Sub


    Private Sub Sched_DeleteButton_Click(sender As Object, e As EventArgs) Handles Sched_DeleteButton.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            StrDelete = "delete from schedule where SchedNo = '" & Me.Sched_TxtSchedNo.Text & "'"
            CmdDelete = New DB2Command(StrDelete, DbConn)

            If MessageBox.Show("The current record will be deleted. Proceed deleting?", "Schedule Maintenance", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CmdDelete.ExecuteNonQuery()
                'Call ClearStud_Sport()
                Call Schedule_Populate()
            End If

        Catch ex As Exception
            MsgBox(e.ToString)
        End Try
        MessageBox.Show("Schedule Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Sched_UpdateButton_Click(sender As Object, e As EventArgs) Handles Sched_UpdateButton.Click
        Dim VTeamNo1 As Integer
        Dim VTeamNo2 As Integer
        Dim VSportNo As Integer
        Dim VVenueNo As Integer
        Dim StrUpdate As String
        Dim CmdUpdate As DB2Command
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrUpdate = "Select * from team where TName like '" & Me.Sched_TxtTeam1.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo1 = RdrSearch.GetString(0)
            End If

            StrUpdate = "Select * from team where TName like '" & Me.Sched_TxtTeam2.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VTeamNo2 = RdrSearch.GetString(0)
            End If

            StrUpdate = "Select SportNo, SName from sport where SName like '" & Me.Sched_TxtSport.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VSportNo = RdrSearch.GetString(0)
            End If

            StrUpdate = "Select * from venue where VName like '" & Me.Sched_TxtVenue.Text & "' "
            CmdSearch = New DB2Command(StrUpdate, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                VVenueNo = RdrSearch.GetString(0)
            End If

            StrUpdate = "update schedule set date = '" & Me.Sched_DatePicker.Text & "', " _
                & "time = '" & Me.Sched_TimePicker.Text & "', teamno1 = '" & VTeamNo1 & "', " _
                & "teamno2 = '" & VTeamNo2 & "', sportno = '" & VSportNo & "', " _
                & "venueno = '" & VVenueNo & "' where SchedNo = '" & Me.Sched_TxtSchedNo.Text & "' "

            CmdUpdate = New DB2Command(StrUpdate, DbConn)
            CmdUpdate.ExecuteNonQuery()

            Call Schedule_Populate()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MsgBox(Err.Description)
        MessageBox.Show("Schedule Successfully Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Sched_TextChanged(sender As Object, e As EventArgs) Handles Sched_TxtSchedNo.TextChanged, Sched_TxtTeam1.TextChanged, Sched_TxtTeam2.TextChanged, Sched_DatePicker.TextChanged, Sched_TimePicker.TextChanged, Sched_TxtSport.TextChanged, Sched_TxtVenue.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim RdrSearch2 As DB2DataReader
        Dim RdrSearch3 As DB2DataReader
        Dim RdrSearch4 As DB2DataReader

        Try

            StrSearch = "Select * from schedule where schedno like '" & Me.Sched_TxtSchedNo.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                If Me.Sched_TxtTeam1.Text <> Me.Sched_TxtTeam2.Text Then
                    StrSearch = "Select * from sport where sName like '" & Me.Sched_TxtSport.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader
                    StrSearch = "Select * from venue where vName like '" & Me.Sched_TxtVenue.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch2 = CmdSearch.ExecuteReader
                    StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam1.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch3 = CmdSearch.ExecuteReader
                    StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam2.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch4 = CmdSearch.ExecuteReader


                    If RdrSearch.Read And RdrSearch2.Read And RdrSearch3.Read And RdrSearch4.Read Then
                        Sched_UpdateButton.Enabled = True
                    Else
                        Sched_UpdateButton.Enabled = False
                    End If

                Else
                    Sched_UpdateButton.Enabled = False
                End If

                Sched_NewButton.Enabled = False
                Sched_DeleteButton.Enabled = True

            ElseIf Me.Sched_TxtSchedNo.Text.Length() > 0 Then
                If Me.Sched_TxtTeam1.Text <> Me.Sched_TxtTeam2.Text Then
                    StrSearch = "Select * from sport where sName like '" & Me.Sched_TxtSport.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader
                    StrSearch = "Select * from venue where vName like '" & Me.Sched_TxtVenue.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch2 = CmdSearch.ExecuteReader
                    StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam1.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch3 = CmdSearch.ExecuteReader
                    StrSearch = "Select * from team where TName like '" & Me.Sched_TxtTeam2.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch4 = CmdSearch.ExecuteReader


                    If RdrSearch.Read And RdrSearch2.Read And RdrSearch3.Read And RdrSearch4.Read Then
                        Sched_NewButton.Enabled = True
                    Else
                        Sched_NewButton.Enabled = False
                    End If

                Else
                    Sched_NewButton.Enabled = False
                End If
                Sched_UpdateButton.Enabled = False
                Sched_DeleteButton.Enabled = False

            Else
                Sched_NewButton.Enabled = False
                Sched_UpdateButton.Enabled = False
                Sched_DeleteButton.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


    'TEAMS AND VENUES TAB
    Private Sub View_Teams_MouseUp(sender As Object, e As MouseEventArgs) Handles View_Teams.MouseUp
        'fetch current row and place the data to the text boxes
        Try
            With Me.View_Teams
                Me.Txt_teamNo.Text = .CurrentRow.Cells(0).Value
                Me.Cb_teams.Text = .CurrentRow.Cells(1).Value
            End With

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub View_Venues_MouseUp(sender As Object, e As MouseEventArgs) Handles View_Venues.MouseUp
        'fetch current row and place the data to the text boxes
        Try
            With Me.View_Venues
                Me.Txt_VenueNo.Text = .CurrentRow.Cells(0).Value
                Me.CBVenue.Text = .CurrentRow.Cells(1).Value
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_teamSave_Click(sender As Object, e As EventArgs) Handles Btn_teamSave.Click

        Dim StrInsert As String
        Dim CmdInsert As DB2Command
        Dim VTeamId As String
        Dim VTeamName As String

        Try
            VTeamId = Me.Txt_teamNo.Text
            VTeamName = Me.Cb_teams.Text

            StrInsert = "insert into team values('" & VTeamId & "', " _
                & " '" & VTeamName & "')"

            CmdInsert = New DB2Command(StrInsert, DbConn)
            CmdInsert.ExecuteNonQuery()
            Call PopulateDataGrid()
            Call ClearTeam()
            Call GetTeamLastID()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Team Successfully Added!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Btn_saveVenue_Click(sender As Object, e As EventArgs) Handles Btn_saveVenue.Click

        Dim StrInsertVenue As String
        Dim CmdInsertVenue As DB2Command
        Dim VenueID As String
        Dim VenueName As String

        Try
            VenueID = Me.Txt_VenueNo.Text
            VenueName = Me.CBVenue.Text

            StrInsertVenue = "insert into venue values ('" & VenueID & "', " _
                & " '" & VenueName & "')"

            CmdInsertVenue = New DB2Command(StrInsertVenue, DbConn)
            CmdInsertVenue.ExecuteNonQuery()

            Call PopulateVenueGrid()
            Call ClearVenue()
            Call GetVenueLastID()
        Catch ex As Exception
            MsgBox("Err.Description")
        End Try
        MessageBox.Show("Venue Successfully Added!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Btn_deleteTeams_Click(sender As Object, e As EventArgs) Handles Btn_deleteTeams.Click

        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            StrDelete = "delete from team where teamNo = '" & Me.Txt_teamNo.Text & "'"
            CmdDelete = New DB2Command(StrDelete, DbConn)
            If MessageBox.Show("The current record will be deleted. Do you wish to proceed?", "Team Maintenance", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                CmdDelete.ExecuteNonQuery()
                Call ClearTeam()
                Call PopulateDataGrid()
            End If
            'Call GetLastID()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Team Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Btn_deleteVenue_Click(sender As Object, e As EventArgs) Handles Btn_deleteVenue.Click

        Dim StrVenueDelete As String
        Dim CmdVenueDelete As DB2Command

        Try
            StrVenueDelete = "delete from venue where venueNo = '" & Me.Txt_VenueNo.Text & "'"
            CmdVenueDelete = New DB2Command(StrVenueDelete, DbConn)
            If MessageBox.Show("The current record will be deleted. Do you wish to proceed?", "Venue Maintenance", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                CmdVenueDelete.ExecuteNonQuery()
                Call ClearVenue()
                Call PopulateVenueGrid()
            End If
            'Call GetVenueLastID()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Venue Deleted!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Btn_updateTeams_Click(sender As Object, e As EventArgs) Handles Btn_updateTeams.Click

        Dim StrUpdate As String
        Dim CmdUpdate As DB2Command

        Try
            StrUpdate = "update team set TName = '" & Me.Cb_teams.Text & "' " _
                & "where TeamNo = '" & Me.Txt_teamNo.Text & "'"
            CmdUpdate = New DB2Command(StrUpdate, DbConn)
            CmdUpdate.ExecuteNonQuery()


            Call PopulateDataGrid()
            Call ClearTeam()
            Call GetTeamLastID()
            Me.Btn_teamSave.Enabled = True
            Me.Btn_updateTeams.Enabled = False
            Me.Btn_deleteTeams.Enabled = False

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Team Successfully Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub ClearTeam()
        Me.Txt_teamNo.Text = String.Empty
        Me.Cb_teams.Text = String.Empty
    End Sub

    Private Sub ClearVenue()
        Me.Txt_VenueNo.Text = String.Empty
        Me.CBVenue.Text = String.Empty
    End Sub


    Private Sub Btn_updateVenue_Click(sender As Object, e As EventArgs) Handles Btn_updateVenue.Click
        Dim StrUpdate As String
        Dim CmdUpdate As DB2Command

        Try
            StrUpdate = "update venue set VName = '" & CBVenue.Text & "' " _
                & " where VenueNo = '" & Me.Txt_VenueNo.Text & "'"
            CmdUpdate = New DB2Command(StrUpdate, DbConn)
            CmdUpdate.ExecuteNonQuery()

            Call PopulateVenueGrid()
            Call ClearVenue()
            Call GetVenueLastID()
            Me.Btn_saveVenue.Enabled = True
            Me.Btn_updateVenue.Enabled = False
            Me.Btn_updateVenue.Enabled = False

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        MessageBox.Show("Student Successfully Updated!", "SU Inramurals Tracker System")
    End Sub

    Private Sub Txt_searchTeams_TextChanged(sender As Object, e As EventArgs) Handles Txt_searchTeams.TextChanged

        Dim VStrTeamName As String
        Dim StrSearch As String
        Dim row As String()
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            VStrTeamName = Me.Txt_searchTeams.Text + "%"
            StrSearch = "Select * from team where TName like '" & VStrTeamName & "'"
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader
            Me.View_Teams.Rows.Clear()
            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1)}
                Me.View_Teams.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged

        Dim VStrVenueName As String
        Dim StrVenueSearch As String
        Dim VenueRow As String()
        Dim CmdVenueSearch As DB2Command
        Dim RdrVenueSearch As DB2DataReader

        Try
            VStrVenueName = Me.Txt_Search.Text + "%"
            StrVenueSearch = "Select * from venue where VName like '" & VStrVenueName & "'"
            CmdVenueSearch = New DB2Command(StrVenueSearch, DbConn)
            RdrVenueSearch = CmdVenueSearch.ExecuteReader
            Me.View_Venues.Rows.Clear()
            While RdrVenueSearch.Read
                VenueRow = New String() {RdrVenueSearch.GetString(0), RdrVenueSearch.GetString(1)}
                Me.View_Venues.Rows.Add(VenueRow)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Teams_TextChanged(sender As Object, e As EventArgs) Handles Txt_teamNo.TextChanged, Cb_teams.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrSearch = "Select * from team where TeamNo like '" & Me.Txt_teamNo.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                StrSearch = "Select * from team where TName like '" & Me.Cb_teams.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    StrSearch = "Select * from team where TeamNo like '" & Me.Txt_teamNo.Text & "' and TName like '" & Me.Cb_teams.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        Btn_updateTeams.Enabled = True
                    Else
                        Btn_updateTeams.Enabled = False
                    End If

                ElseIf Me.Cb_teams.Text.Length() > 0 Then
                    Btn_updateTeams.Enabled = True
                Else
                    Btn_updateTeams.Enabled = False
                End If
                Btn_teamSave.Enabled = False
                Btn_deleteTeams.Enabled = True

            Else
                StrSearch = "Select * from team where TName like '" & Me.Cb_teams.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    Btn_teamSave.Enabled = False
                ElseIf Me.Txt_teamNo.Text.Length() > 0 And Me.Cb_teams.Text.Length() > 0 Then
                    Btn_teamSave.Enabled = True
                Else
                    Btn_teamSave.Enabled = False
                End If
                Btn_updateTeams.Enabled = False
                Btn_deleteTeams.Enabled = False
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Venue_TextChanged(sender As Object, e As EventArgs) Handles Txt_VenueNo.TextChanged, CBVenue.TextChanged
        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrSearch = "Select * from venue where VenueNo like '" & Me.Txt_VenueNo.Text & "' "
            CmdSearch = New DB2Command(StrSearch, DbConn)
            RdrSearch = CmdSearch.ExecuteReader

            If RdrSearch.Read Then
                StrSearch = "Select * from venue where VName like '" & Me.CBVenue.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    StrSearch = "Select * from venue where VenueNo like '" & Me.Txt_VenueNo.Text & "' and VName like '" & Me.CBVenue.Text & "' "
                    CmdSearch = New DB2Command(StrSearch, DbConn)
                    RdrSearch = CmdSearch.ExecuteReader

                    If RdrSearch.Read Then
                        Btn_updateVenue.Enabled = True
                    Else
                        Btn_updateVenue.Enabled = False
                    End If

                ElseIf Me.CBVenue.Text.Length() > 0 Then
                    Btn_updateVenue.Enabled = True
                Else
                    Btn_updateVenue.Enabled = False
                End If
                Btn_saveVenue.Enabled = False
                Btn_deleteVenue.Enabled = True

            Else
                StrSearch = "Select * from venue where VName like '" & Me.CBVenue.Text & "' "
                CmdSearch = New DB2Command(StrSearch, DbConn)
                RdrSearch = CmdSearch.ExecuteReader

                If RdrSearch.Read Then
                    Btn_saveVenue.Enabled = False
                ElseIf Me.Txt_VenueNo.Text.Length() > 0 And Me.CBVenue.Text.Length() > 0 Then
                    Btn_saveVenue.Enabled = True
                Else
                    Btn_saveVenue.Enabled = False
                End If
                Btn_updateVenue.Enabled = False
                Btn_deleteVenue.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetTeamLastID()

        Dim StrTeam As String
        Dim CmdTeam As DB2Command
        Dim RdrTeam As DB2DataReader
        Dim TeamID As Integer

        Try
            StrTeam = "Select TeamNo from Team order by TeamNo desc"
            CmdTeam = New DB2Command(StrTeam, DbConn)
            RdrTeam = CmdTeam.ExecuteReader

            If RdrTeam.HasRows Then
                RdrTeam.Read()
                TeamID = RdrTeam.GetString(0)
                TeamID = TeamID + 1
            Else
                TeamID = 1 'default value
            End If
            Me.Txt_teamNo.Text = TeamID
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetVenueLastID()

        Dim StrVenue As String
        Dim CmdVenue As DB2Command
        Dim RdrVenue As DB2DataReader
        Dim VenueID As Integer

        Try
            StrVenue = "Select venueNo from Venue order by venueNo desc"
            CmdVenue = New DB2Command(StrVenue, DbConn)
            RdrVenue = CmdVenue.ExecuteReader

            If RdrVenue.HasRows Then
                RdrVenue.Read()
                VenueID = RdrVenue.GetString(0)
                VenueID = VenueID + 1
            Else
                VenueID = 1 'default value
            End If
            Me.Txt_VenueNo.Text = VenueID
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
