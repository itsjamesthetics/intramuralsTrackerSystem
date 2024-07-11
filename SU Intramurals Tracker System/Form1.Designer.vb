<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelStudents = New System.Windows.Forms.Panel()
        Me.B_StudUpdate = New System.Windows.Forms.Button()
        Me.B_StudSave = New System.Windows.Forms.Button()
        Me.B_StudDelete = New System.Windows.Forms.Button()
        Me.GroupBoxStudent = New System.Windows.Forms.GroupBox()
        Me.T_TName = New System.Windows.Forms.TextBox()
        Me.D_SearchColumn = New System.Windows.Forms.ComboBox()
        Me.T_Search = New System.Windows.Forms.TextBox()
        Me.L_Search = New System.Windows.Forms.Label()
        Me.StudError = New System.Windows.Forms.Label()
        Me.DGVStudent = New System.Windows.Forms.DataGridView()
        Me.T_StudID = New System.Windows.Forms.TextBox()
        Me.L_StudID = New System.Windows.Forms.Label()
        Me.T_LName = New System.Windows.Forms.TextBox()
        Me.T_FName = New System.Windows.Forms.TextBox()
        Me.L_FName = New System.Windows.Forms.Label()
        Me.L_Team = New System.Windows.Forms.Label()
        Me.L_LName = New System.Windows.Forms.Label()
        Me.PanelSports = New System.Windows.Forms.Panel()
        Me.GroupBoxStudandSport = New System.Windows.Forms.GroupBox()
        Me.T_SportSportNo = New System.Windows.Forms.TextBox()
        Me.L_SportSportNo = New System.Windows.Forms.Label()
        Me.B_SportAssign = New System.Windows.Forms.Button()
        Me.B_SportUpdate = New System.Windows.Forms.Button()
        Me.B_SportDelete = New System.Windows.Forms.Button()
        Me.B_SportSave = New System.Windows.Forms.Button()
        Me.D_SportSearchColumnStud = New System.Windows.Forms.ComboBox()
        Me.T_SportSearchStud = New System.Windows.Forms.TextBox()
        Me.L_SportSearchStud = New System.Windows.Forms.Label()
        Me.T_SportVName = New System.Windows.Forms.TextBox()
        Me.L_SportVName = New System.Windows.Forms.Label()
        Me.T_SportSName = New System.Windows.Forms.TextBox()
        Me.L_SportSName = New System.Windows.Forms.Label()
        Me.T_SportStudID = New System.Windows.Forms.TextBox()
        Me.L_SportStudID = New System.Windows.Forms.Label()
        Me.DGVSport = New System.Windows.Forms.DataGridView()
        Me.DGVSportStudent = New System.Windows.Forms.DataGridView()
        Me.GroupBoxStud_Sport = New System.Windows.Forms.GroupBox()
        Me.T_SSEntryNo = New System.Windows.Forms.TextBox()
        Me.L_SSEntryNo = New System.Windows.Forms.Label()
        Me.T_SSStudID = New System.Windows.Forms.TextBox()
        Me.L_SSStudID = New System.Windows.Forms.Label()
        Me.T_SSSport = New System.Windows.Forms.TextBox()
        Me.L_SSSport = New System.Windows.Forms.Label()
        Me.B_SSUpdate = New System.Windows.Forms.Button()
        Me.B_SSDelete = New System.Windows.Forms.Button()
        Me.D_SearchColumnSS = New System.Windows.Forms.ComboBox()
        Me.T_SSSearch = New System.Windows.Forms.TextBox()
        Me.L_SearchSS = New System.Windows.Forms.Label()
        Me.DGVStud_Sport = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SbClose = New System.Windows.Forms.Button()
        Me.SbSchedule = New System.Windows.Forms.Button()
        Me.SbStudents = New System.Windows.Forms.Button()
        Me.SbTeams = New System.Windows.Forms.Button()
        Me.SbSports = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Pnl_Home = New System.Windows.Forms.Panel()
        Me.Pnl_Teams = New System.Windows.Forms.Panel()
        Me.GB_Venues = New System.Windows.Forms.GroupBox()
        Me.CBVenue = New System.Windows.Forms.ComboBox()
        Me.Btn_saveVenue = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.View_Venues = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_VenueNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_updateVenue = New System.Windows.Forms.Button()
        Me.Btn_deleteVenue = New System.Windows.Forms.Button()
        Me.GB_Teams = New System.Windows.Forms.GroupBox()
        Me.Cb_teams = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_teamNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_teamSave = New System.Windows.Forms.Button()
        Me.Btn_updateTeams = New System.Windows.Forms.Button()
        Me.Btn_deleteTeams = New System.Windows.Forms.Button()
        Me.Txt_searchTeams = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.View_Teams = New System.Windows.Forms.DataGridView()
        Me.SCHEDULE = New System.Windows.Forms.GroupBox()
        Me.Sched_TxtSchedNo = New System.Windows.Forms.TextBox()
        Me.Sched_SchedNo_Label = New System.Windows.Forms.Label()
        Me.Sched_TimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sched_DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Sched_DeleteButton = New System.Windows.Forms.Button()
        Me.Sched_UpdateButton = New System.Windows.Forms.Button()
        Me.Sched_NewButton = New System.Windows.Forms.Button()
        Me.Sched_TxtVenue = New System.Windows.Forms.TextBox()
        Me.Sched_Venue_Label = New System.Windows.Forms.Label()
        Me.Sched_TxtSport = New System.Windows.Forms.TextBox()
        Me.Sched_Sport_Label = New System.Windows.Forms.Label()
        Me.Sched_TxtTeam2 = New System.Windows.Forms.TextBox()
        Me.Sched_Team2_Label = New System.Windows.Forms.Label()
        Me.Sched_TxtTeam1 = New System.Windows.Forms.TextBox()
        Me.Sched_Team1_Label = New System.Windows.Forms.Label()
        Me.View_Sched = New System.Windows.Forms.DataGridView()
        Me.Pnl_Sched = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PanelStudents.SuspendLayout()
        Me.GroupBoxStudent.SuspendLayout()
        CType(Me.DGVStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSports.SuspendLayout()
        Me.GroupBoxStudandSport.SuspendLayout()
        CType(Me.DGVSport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSportStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxStud_Sport.SuspendLayout()
        CType(Me.DGVStud_Sport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Pnl_Teams.SuspendLayout()
        Me.GB_Venues.SuspendLayout()
        CType(Me.View_Venues, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Teams.SuspendLayout()
        CType(Me.View_Teams, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SCHEDULE.SuspendLayout()
        CType(Me.View_Sched, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Sched.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelStudents
        '
        Me.PanelStudents.BackColor = System.Drawing.Color.Firebrick
        Me.PanelStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelStudents.Controls.Add(Me.B_StudUpdate)
        Me.PanelStudents.Controls.Add(Me.B_StudSave)
        Me.PanelStudents.Controls.Add(Me.B_StudDelete)
        Me.PanelStudents.Controls.Add(Me.GroupBoxStudent)
        Me.PanelStudents.Location = New System.Drawing.Point(203, 86)
        Me.PanelStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelStudents.Name = "PanelStudents"
        Me.PanelStudents.Size = New System.Drawing.Size(1103, 459)
        Me.PanelStudents.TabIndex = 0
        '
        'B_StudUpdate
        '
        Me.B_StudUpdate.Enabled = False
        Me.B_StudUpdate.Location = New System.Drawing.Point(743, 409)
        Me.B_StudUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_StudUpdate.Name = "B_StudUpdate"
        Me.B_StudUpdate.Size = New System.Drawing.Size(168, 36)
        Me.B_StudUpdate.TabIndex = 2
        Me.B_StudUpdate.Text = "Update"
        Me.B_StudUpdate.UseVisualStyleBackColor = True
        '
        'B_StudSave
        '
        Me.B_StudSave.Enabled = False
        Me.B_StudSave.Location = New System.Drawing.Point(567, 409)
        Me.B_StudSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_StudSave.Name = "B_StudSave"
        Me.B_StudSave.Size = New System.Drawing.Size(168, 36)
        Me.B_StudSave.TabIndex = 1
        Me.B_StudSave.Text = "Save"
        Me.B_StudSave.UseVisualStyleBackColor = True
        '
        'B_StudDelete
        '
        Me.B_StudDelete.Enabled = False
        Me.B_StudDelete.Location = New System.Drawing.Point(919, 409)
        Me.B_StudDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_StudDelete.Name = "B_StudDelete"
        Me.B_StudDelete.Size = New System.Drawing.Size(168, 36)
        Me.B_StudDelete.TabIndex = 3
        Me.B_StudDelete.Text = "Delete"
        Me.B_StudDelete.UseVisualStyleBackColor = True
        '
        'GroupBoxStudent
        '
        Me.GroupBoxStudent.BackColor = System.Drawing.Color.White
        Me.GroupBoxStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxStudent.Controls.Add(Me.T_TName)
        Me.GroupBoxStudent.Controls.Add(Me.D_SearchColumn)
        Me.GroupBoxStudent.Controls.Add(Me.T_Search)
        Me.GroupBoxStudent.Controls.Add(Me.L_Search)
        Me.GroupBoxStudent.Controls.Add(Me.StudError)
        Me.GroupBoxStudent.Controls.Add(Me.DGVStudent)
        Me.GroupBoxStudent.Controls.Add(Me.T_StudID)
        Me.GroupBoxStudent.Controls.Add(Me.L_StudID)
        Me.GroupBoxStudent.Controls.Add(Me.T_LName)
        Me.GroupBoxStudent.Controls.Add(Me.T_FName)
        Me.GroupBoxStudent.Controls.Add(Me.L_FName)
        Me.GroupBoxStudent.Controls.Add(Me.L_Team)
        Me.GroupBoxStudent.Controls.Add(Me.L_LName)
        Me.GroupBoxStudent.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxStudent.Location = New System.Drawing.Point(9, 6)
        Me.GroupBoxStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStudent.Name = "GroupBoxStudent"
        Me.GroupBoxStudent.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStudent.Size = New System.Drawing.Size(1077, 395)
        Me.GroupBoxStudent.TabIndex = 0
        Me.GroupBoxStudent.TabStop = False
        Me.GroupBoxStudent.Text = "Student Information"
        '
        'T_TName
        '
        Me.T_TName.Location = New System.Drawing.Point(111, 190)
        Me.T_TName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_TName.Name = "T_TName"
        Me.T_TName.Size = New System.Drawing.Size(64, 22)
        Me.T_TName.TabIndex = 3
        '
        'D_SearchColumn
        '
        Me.D_SearchColumn.AutoCompleteCustomSource.AddRange(New String() {"Student ID", "Last Name", "First Name", "Team"})
        Me.D_SearchColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.D_SearchColumn.FormattingEnabled = True
        Me.D_SearchColumn.Items.AddRange(New Object() {"Student ID", "Last Name", "First Name", "Team"})
        Me.D_SearchColumn.Location = New System.Drawing.Point(709, 21)
        Me.D_SearchColumn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.D_SearchColumn.Name = "D_SearchColumn"
        Me.D_SearchColumn.Size = New System.Drawing.Size(107, 24)
        Me.D_SearchColumn.TabIndex = 5
        '
        'T_Search
        '
        Me.T_Search.Location = New System.Drawing.Point(481, 21)
        Me.T_Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_Search.Name = "T_Search"
        Me.T_Search.Size = New System.Drawing.Size(225, 22)
        Me.T_Search.TabIndex = 4
        '
        'L_Search
        '
        Me.L_Search.AutoSize = True
        Me.L_Search.ForeColor = System.Drawing.Color.Black
        Me.L_Search.Location = New System.Drawing.Point(416, 25)
        Me.L_Search.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Search.Name = "L_Search"
        Me.L_Search.Size = New System.Drawing.Size(57, 17)
        Me.L_Search.TabIndex = 42
        Me.L_Search.Text = "Search:"
        '
        'StudError
        '
        Me.StudError.AutoSize = True
        Me.StudError.ForeColor = System.Drawing.Color.Firebrick
        Me.StudError.Location = New System.Drawing.Point(125, 336)
        Me.StudError.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StudError.Name = "StudError"
        Me.StudError.Size = New System.Drawing.Size(155, 17)
        Me.StudError.TabIndex = 40
        Me.StudError.Text = "All Fields Must be Filled"
        '
        'DGVStudent
        '
        Me.DGVStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStudent.Location = New System.Drawing.Point(420, 53)
        Me.DGVStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVStudent.Name = "DGVStudent"
        Me.DGVStudent.Size = New System.Drawing.Size(592, 322)
        Me.DGVStudent.TabIndex = 0
        Me.DGVStudent.TabStop = False
        '
        'T_StudID
        '
        Me.T_StudID.Location = New System.Drawing.Point(111, 53)
        Me.T_StudID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_StudID.Name = "T_StudID"
        Me.T_StudID.Size = New System.Drawing.Size(225, 22)
        Me.T_StudID.TabIndex = 0
        '
        'L_StudID
        '
        Me.L_StudID.AutoSize = True
        Me.L_StudID.ForeColor = System.Drawing.Color.Black
        Me.L_StudID.Location = New System.Drawing.Point(25, 57)
        Me.L_StudID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_StudID.Name = "L_StudID"
        Me.L_StudID.Size = New System.Drawing.Size(78, 17)
        Me.L_StudID.TabIndex = 5
        Me.L_StudID.Text = "Student ID:"
        '
        'T_LName
        '
        Me.T_LName.Location = New System.Drawing.Point(111, 98)
        Me.T_LName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_LName.Name = "T_LName"
        Me.T_LName.Size = New System.Drawing.Size(225, 22)
        Me.T_LName.TabIndex = 1
        '
        'T_FName
        '
        Me.T_FName.Location = New System.Drawing.Point(111, 144)
        Me.T_FName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_FName.Name = "T_FName"
        Me.T_FName.Size = New System.Drawing.Size(225, 22)
        Me.T_FName.TabIndex = 2
        '
        'L_FName
        '
        Me.L_FName.AutoSize = True
        Me.L_FName.ForeColor = System.Drawing.Color.Black
        Me.L_FName.Location = New System.Drawing.Point(25, 148)
        Me.L_FName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_FName.Name = "L_FName"
        Me.L_FName.Size = New System.Drawing.Size(80, 17)
        Me.L_FName.TabIndex = 1
        Me.L_FName.Text = "First Name:"
        '
        'L_Team
        '
        Me.L_Team.AutoSize = True
        Me.L_Team.ForeColor = System.Drawing.Color.Black
        Me.L_Team.Location = New System.Drawing.Point(55, 193)
        Me.L_Team.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_Team.Name = "L_Team"
        Me.L_Team.Size = New System.Drawing.Size(48, 17)
        Me.L_Team.TabIndex = 1
        Me.L_Team.Text = "Team:"
        '
        'L_LName
        '
        Me.L_LName.AutoSize = True
        Me.L_LName.ForeColor = System.Drawing.Color.Black
        Me.L_LName.Location = New System.Drawing.Point(25, 102)
        Me.L_LName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_LName.Name = "L_LName"
        Me.L_LName.Size = New System.Drawing.Size(80, 17)
        Me.L_LName.TabIndex = 1
        Me.L_LName.Text = "Last Name:"
        '
        'PanelSports
        '
        Me.PanelSports.BackColor = System.Drawing.Color.Firebrick
        Me.PanelSports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSports.Controls.Add(Me.GroupBoxStudandSport)
        Me.PanelSports.Controls.Add(Me.GroupBoxStud_Sport)
        Me.PanelSports.Location = New System.Drawing.Point(203, 86)
        Me.PanelSports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSports.Name = "PanelSports"
        Me.PanelSports.Size = New System.Drawing.Size(1103, 459)
        Me.PanelSports.TabIndex = 2
        '
        'GroupBoxStudandSport
        '
        Me.GroupBoxStudandSport.BackColor = System.Drawing.Color.White
        Me.GroupBoxStudandSport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxStudandSport.Controls.Add(Me.T_SportSportNo)
        Me.GroupBoxStudandSport.Controls.Add(Me.L_SportSportNo)
        Me.GroupBoxStudandSport.Controls.Add(Me.B_SportAssign)
        Me.GroupBoxStudandSport.Controls.Add(Me.B_SportUpdate)
        Me.GroupBoxStudandSport.Controls.Add(Me.B_SportDelete)
        Me.GroupBoxStudandSport.Controls.Add(Me.B_SportSave)
        Me.GroupBoxStudandSport.Controls.Add(Me.D_SportSearchColumnStud)
        Me.GroupBoxStudandSport.Controls.Add(Me.T_SportSearchStud)
        Me.GroupBoxStudandSport.Controls.Add(Me.L_SportSearchStud)
        Me.GroupBoxStudandSport.Controls.Add(Me.T_SportVName)
        Me.GroupBoxStudandSport.Controls.Add(Me.L_SportVName)
        Me.GroupBoxStudandSport.Controls.Add(Me.T_SportSName)
        Me.GroupBoxStudandSport.Controls.Add(Me.L_SportSName)
        Me.GroupBoxStudandSport.Controls.Add(Me.T_SportStudID)
        Me.GroupBoxStudandSport.Controls.Add(Me.L_SportStudID)
        Me.GroupBoxStudandSport.Controls.Add(Me.DGVSport)
        Me.GroupBoxStudandSport.Controls.Add(Me.DGVSportStudent)
        Me.GroupBoxStudandSport.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxStudandSport.Location = New System.Drawing.Point(4, 4)
        Me.GroupBoxStudandSport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStudandSport.Name = "GroupBoxStudandSport"
        Me.GroupBoxStudandSport.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStudandSport.Size = New System.Drawing.Size(523, 446)
        Me.GroupBoxStudandSport.TabIndex = 3
        Me.GroupBoxStudandSport.TabStop = False
        Me.GroupBoxStudandSport.Text = "Student and Sport Information"
        '
        'T_SportSportNo
        '
        Me.T_SportSportNo.Location = New System.Drawing.Point(361, 255)
        Me.T_SportSportNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SportSportNo.Name = "T_SportSportNo"
        Me.T_SportSportNo.Size = New System.Drawing.Size(40, 22)
        Me.T_SportSportNo.TabIndex = 57
        '
        'L_SportSportNo
        '
        Me.L_SportSportNo.AutoSize = True
        Me.L_SportSportNo.ForeColor = System.Drawing.Color.Black
        Me.L_SportSportNo.Location = New System.Drawing.Point(288, 258)
        Me.L_SportSportNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SportSportNo.Name = "L_SportSportNo"
        Me.L_SportSportNo.Size = New System.Drawing.Size(68, 17)
        Me.L_SportSportNo.TabIndex = 56
        Me.L_SportSportNo.Text = "Sport No:"
        '
        'B_SportAssign
        '
        Me.B_SportAssign.Enabled = False
        Me.B_SportAssign.ForeColor = System.Drawing.Color.Black
        Me.B_SportAssign.Location = New System.Drawing.Point(8, 370)
        Me.B_SportAssign.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SportAssign.Name = "B_SportAssign"
        Me.B_SportAssign.Size = New System.Drawing.Size(168, 36)
        Me.B_SportAssign.TabIndex = 51
        Me.B_SportAssign.Text = "Assign Student"
        Me.B_SportAssign.UseVisualStyleBackColor = True
        '
        'B_SportUpdate
        '
        Me.B_SportUpdate.Enabled = False
        Me.B_SportUpdate.ForeColor = System.Drawing.Color.Black
        Me.B_SportUpdate.Location = New System.Drawing.Point(220, 390)
        Me.B_SportUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SportUpdate.Name = "B_SportUpdate"
        Me.B_SportUpdate.Size = New System.Drawing.Size(136, 36)
        Me.B_SportUpdate.TabIndex = 50
        Me.B_SportUpdate.Text = "Update Sport"
        Me.B_SportUpdate.UseVisualStyleBackColor = True
        '
        'B_SportDelete
        '
        Me.B_SportDelete.Enabled = False
        Me.B_SportDelete.ForeColor = System.Drawing.Color.Black
        Me.B_SportDelete.Location = New System.Drawing.Point(364, 390)
        Me.B_SportDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SportDelete.Name = "B_SportDelete"
        Me.B_SportDelete.Size = New System.Drawing.Size(136, 36)
        Me.B_SportDelete.TabIndex = 49
        Me.B_SportDelete.Text = "Delete Sport"
        Me.B_SportDelete.UseVisualStyleBackColor = True
        '
        'B_SportSave
        '
        Me.B_SportSave.Enabled = False
        Me.B_SportSave.ForeColor = System.Drawing.Color.Black
        Me.B_SportSave.Location = New System.Drawing.Point(364, 350)
        Me.B_SportSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SportSave.Name = "B_SportSave"
        Me.B_SportSave.Size = New System.Drawing.Size(136, 36)
        Me.B_SportSave.TabIndex = 48
        Me.B_SportSave.Text = "Save Sport"
        Me.B_SportSave.UseVisualStyleBackColor = True
        '
        'D_SportSearchColumnStud
        '
        Me.D_SportSearchColumnStud.AutoCompleteCustomSource.AddRange(New String() {"Student ID", "Last Name", "First Name", "Team"})
        Me.D_SportSearchColumnStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.D_SportSearchColumnStud.FormattingEnabled = True
        Me.D_SportSearchColumnStud.Items.AddRange(New Object() {"Student ID", "Last Name", "First Name", "Team"})
        Me.D_SportSearchColumnStud.Location = New System.Drawing.Point(305, 30)
        Me.D_SportSearchColumnStud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.D_SportSearchColumnStud.Name = "D_SportSearchColumnStud"
        Me.D_SportSearchColumnStud.Size = New System.Drawing.Size(107, 24)
        Me.D_SportSearchColumnStud.TabIndex = 44
        '
        'T_SportSearchStud
        '
        Me.T_SportSearchStud.Location = New System.Drawing.Point(77, 30)
        Me.T_SportSearchStud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SportSearchStud.Name = "T_SportSearchStud"
        Me.T_SportSearchStud.Size = New System.Drawing.Size(225, 22)
        Me.T_SportSearchStud.TabIndex = 43
        '
        'L_SportSearchStud
        '
        Me.L_SportSearchStud.AutoSize = True
        Me.L_SportSearchStud.ForeColor = System.Drawing.Color.Black
        Me.L_SportSearchStud.Location = New System.Drawing.Point(12, 33)
        Me.L_SportSearchStud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SportSearchStud.Name = "L_SportSearchStud"
        Me.L_SportSearchStud.Size = New System.Drawing.Size(57, 17)
        Me.L_SportSearchStud.TabIndex = 45
        Me.L_SportSearchStud.Text = "Search:"
        '
        'T_SportVName
        '
        Me.T_SportVName.AutoCompleteCustomSource.AddRange(New String() {"Ravello Ballfield", "SU Hall"})
        Me.T_SportVName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.T_SportVName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.T_SportVName.Location = New System.Drawing.Point(361, 316)
        Me.T_SportVName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SportVName.Name = "T_SportVName"
        Me.T_SportVName.Size = New System.Drawing.Size(143, 22)
        Me.T_SportVName.TabIndex = 15
        '
        'L_SportVName
        '
        Me.L_SportVName.AutoSize = True
        Me.L_SportVName.ForeColor = System.Drawing.Color.Black
        Me.L_SportVName.Location = New System.Drawing.Point(303, 320)
        Me.L_SportVName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SportVName.Name = "L_SportVName"
        Me.L_SportVName.Size = New System.Drawing.Size(53, 17)
        Me.L_SportVName.TabIndex = 14
        Me.L_SportVName.Text = "Venue:"
        '
        'T_SportSName
        '
        Me.T_SportSName.Location = New System.Drawing.Point(361, 284)
        Me.T_SportSName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SportSName.Name = "T_SportSName"
        Me.T_SportSName.Size = New System.Drawing.Size(143, 22)
        Me.T_SportSName.TabIndex = 9
        '
        'L_SportSName
        '
        Me.L_SportSName.AutoSize = True
        Me.L_SportSName.ForeColor = System.Drawing.Color.Black
        Me.L_SportSName.Location = New System.Drawing.Point(307, 288)
        Me.L_SportSName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SportSName.Name = "L_SportSName"
        Me.L_SportSName.Size = New System.Drawing.Size(46, 17)
        Me.L_SportSName.TabIndex = 8
        Me.L_SportSName.Text = "Sport:"
        '
        'T_SportStudID
        '
        Me.T_SportStudID.Location = New System.Drawing.Point(399, 223)
        Me.T_SportStudID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SportStudID.Name = "T_SportStudID"
        Me.T_SportStudID.Size = New System.Drawing.Size(80, 22)
        Me.T_SportStudID.TabIndex = 6
        '
        'L_SportStudID
        '
        Me.L_SportStudID.AutoSize = True
        Me.L_SportStudID.ForeColor = System.Drawing.Color.Black
        Me.L_SportStudID.Location = New System.Drawing.Point(309, 226)
        Me.L_SportStudID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SportStudID.Name = "L_SportStudID"
        Me.L_SportStudID.Size = New System.Drawing.Size(78, 17)
        Me.L_SportStudID.TabIndex = 7
        Me.L_SportStudID.Text = "Student ID:"
        '
        'DGVSport
        '
        Me.DGVSport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSport.Location = New System.Drawing.Point(8, 228)
        Me.DGVSport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVSport.Name = "DGVSport"
        Me.DGVSport.RowHeadersVisible = False
        Me.DGVSport.Size = New System.Drawing.Size(276, 123)
        Me.DGVSport.TabIndex = 2
        Me.DGVSport.TabStop = False
        '
        'DGVSportStudent
        '
        Me.DGVSportStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSportStudent.Location = New System.Drawing.Point(8, 63)
        Me.DGVSportStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVSportStudent.Name = "DGVSportStudent"
        Me.DGVSportStudent.RowHeadersVisible = False
        Me.DGVSportStudent.Size = New System.Drawing.Size(495, 158)
        Me.DGVSportStudent.TabIndex = 1
        Me.DGVSportStudent.TabStop = False
        '
        'GroupBoxStud_Sport
        '
        Me.GroupBoxStud_Sport.BackColor = System.Drawing.Color.White
        Me.GroupBoxStud_Sport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBoxStud_Sport.Controls.Add(Me.T_SSEntryNo)
        Me.GroupBoxStud_Sport.Controls.Add(Me.L_SSEntryNo)
        Me.GroupBoxStud_Sport.Controls.Add(Me.T_SSStudID)
        Me.GroupBoxStud_Sport.Controls.Add(Me.L_SSStudID)
        Me.GroupBoxStud_Sport.Controls.Add(Me.T_SSSport)
        Me.GroupBoxStud_Sport.Controls.Add(Me.L_SSSport)
        Me.GroupBoxStud_Sport.Controls.Add(Me.B_SSUpdate)
        Me.GroupBoxStud_Sport.Controls.Add(Me.B_SSDelete)
        Me.GroupBoxStud_Sport.Controls.Add(Me.D_SearchColumnSS)
        Me.GroupBoxStud_Sport.Controls.Add(Me.T_SSSearch)
        Me.GroupBoxStud_Sport.Controls.Add(Me.L_SearchSS)
        Me.GroupBoxStud_Sport.Controls.Add(Me.DGVStud_Sport)
        Me.GroupBoxStud_Sport.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBoxStud_Sport.Location = New System.Drawing.Point(529, 4)
        Me.GroupBoxStud_Sport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStud_Sport.Name = "GroupBoxStud_Sport"
        Me.GroupBoxStud_Sport.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxStud_Sport.Size = New System.Drawing.Size(564, 446)
        Me.GroupBoxStud_Sport.TabIndex = 1
        Me.GroupBoxStud_Sport.TabStop = False
        Me.GroupBoxStud_Sport.Text = "Student Participation Information"
        '
        'T_SSEntryNo
        '
        Me.T_SSEntryNo.Location = New System.Drawing.Point(89, 346)
        Me.T_SSEntryNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SSEntryNo.Name = "T_SSEntryNo"
        Me.T_SSEntryNo.Size = New System.Drawing.Size(40, 22)
        Me.T_SSEntryNo.TabIndex = 55
        '
        'L_SSEntryNo
        '
        Me.L_SSEntryNo.AutoSize = True
        Me.L_SSEntryNo.ForeColor = System.Drawing.Color.Black
        Me.L_SSEntryNo.Location = New System.Drawing.Point(16, 350)
        Me.L_SSEntryNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SSEntryNo.Name = "L_SSEntryNo"
        Me.L_SSEntryNo.Size = New System.Drawing.Size(67, 17)
        Me.L_SSEntryNo.TabIndex = 54
        Me.L_SSEntryNo.Text = "Entry No:"
        '
        'T_SSStudID
        '
        Me.T_SSStudID.Location = New System.Drawing.Point(237, 346)
        Me.T_SSStudID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SSStudID.Name = "T_SSStudID"
        Me.T_SSStudID.Size = New System.Drawing.Size(80, 22)
        Me.T_SSStudID.TabIndex = 52
        '
        'L_SSStudID
        '
        Me.L_SSStudID.AutoSize = True
        Me.L_SSStudID.ForeColor = System.Drawing.Color.Black
        Me.L_SSStudID.Location = New System.Drawing.Point(148, 350)
        Me.L_SSStudID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SSStudID.Name = "L_SSStudID"
        Me.L_SSStudID.Size = New System.Drawing.Size(78, 17)
        Me.L_SSStudID.TabIndex = 53
        Me.L_SSStudID.Text = "Student ID:"
        '
        'T_SSSport
        '
        Me.T_SSSport.Location = New System.Drawing.Point(384, 346)
        Me.T_SSSport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SSSport.Name = "T_SSSport"
        Me.T_SSSport.Size = New System.Drawing.Size(143, 22)
        Me.T_SSSport.TabIndex = 53
        '
        'L_SSSport
        '
        Me.L_SSSport.AutoSize = True
        Me.L_SSSport.ForeColor = System.Drawing.Color.Black
        Me.L_SSSport.Location = New System.Drawing.Point(329, 350)
        Me.L_SSSport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SSSport.Name = "L_SSSport"
        Me.L_SSSport.Size = New System.Drawing.Size(46, 17)
        Me.L_SSSport.TabIndex = 52
        Me.L_SSSport.Text = "Sport:"
        '
        'B_SSUpdate
        '
        Me.B_SSUpdate.Enabled = False
        Me.B_SSUpdate.ForeColor = System.Drawing.Color.Black
        Me.B_SSUpdate.Location = New System.Drawing.Point(199, 385)
        Me.B_SSUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SSUpdate.Name = "B_SSUpdate"
        Me.B_SSUpdate.Size = New System.Drawing.Size(168, 36)
        Me.B_SSUpdate.TabIndex = 53
        Me.B_SSUpdate.Text = "Update"
        Me.B_SSUpdate.UseVisualStyleBackColor = True
        '
        'B_SSDelete
        '
        Me.B_SSDelete.Enabled = False
        Me.B_SSDelete.ForeColor = System.Drawing.Color.Black
        Me.B_SSDelete.Location = New System.Drawing.Point(375, 385)
        Me.B_SSDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.B_SSDelete.Name = "B_SSDelete"
        Me.B_SSDelete.Size = New System.Drawing.Size(168, 36)
        Me.B_SSDelete.TabIndex = 52
        Me.B_SSDelete.Text = "Delete"
        Me.B_SSDelete.UseVisualStyleBackColor = True
        '
        'D_SearchColumnSS
        '
        Me.D_SearchColumnSS.AutoCompleteCustomSource.AddRange(New String() {"Student ID", "Last Name", "First Name", "Team"})
        Me.D_SearchColumnSS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.D_SearchColumnSS.FormattingEnabled = True
        Me.D_SearchColumnSS.Items.AddRange(New Object() {"Entry No.", "Student ID", "Last Name", "First Name", "Team", "Sport"})
        Me.D_SearchColumnSS.Location = New System.Drawing.Point(309, 30)
        Me.D_SearchColumnSS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.D_SearchColumnSS.Name = "D_SearchColumnSS"
        Me.D_SearchColumnSS.Size = New System.Drawing.Size(107, 24)
        Me.D_SearchColumnSS.TabIndex = 47
        '
        'T_SSSearch
        '
        Me.T_SSSearch.Location = New System.Drawing.Point(81, 30)
        Me.T_SSSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.T_SSSearch.Name = "T_SSSearch"
        Me.T_SSSearch.Size = New System.Drawing.Size(225, 22)
        Me.T_SSSearch.TabIndex = 46
        '
        'L_SearchSS
        '
        Me.L_SearchSS.AutoSize = True
        Me.L_SearchSS.ForeColor = System.Drawing.Color.Black
        Me.L_SearchSS.Location = New System.Drawing.Point(16, 33)
        Me.L_SearchSS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.L_SearchSS.Name = "L_SearchSS"
        Me.L_SearchSS.Size = New System.Drawing.Size(57, 17)
        Me.L_SearchSS.TabIndex = 48
        Me.L_SearchSS.Text = "Search:"
        '
        'DGVStud_Sport
        '
        Me.DGVStud_Sport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVStud_Sport.Location = New System.Drawing.Point(8, 63)
        Me.DGVStud_Sport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVStud_Sport.Name = "DGVStud_Sport"
        Me.DGVStud_Sport.RowHeadersVisible = False
        Me.DGVStud_Sport.Size = New System.Drawing.Size(535, 271)
        Me.DGVStud_Sport.TabIndex = 1
        Me.DGVStud_Sport.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SbClose)
        Me.Panel1.Controls.Add(Me.SbSchedule)
        Me.Panel1.Controls.Add(Me.SbStudents)
        Me.Panel1.Controls.Add(Me.SbTeams)
        Me.Panel1.Controls.Add(Me.SbSports)
        Me.Panel1.Location = New System.Drawing.Point(3, 86)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 459)
        Me.Panel1.TabIndex = 1
        '
        'SbClose
        '
        Me.SbClose.BackColor = System.Drawing.Color.White
        Me.SbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SbClose.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbClose.ForeColor = System.Drawing.Color.Black
        Me.SbClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SbClose.Location = New System.Drawing.Point(11, 406)
        Me.SbClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbClose.Name = "SbClose"
        Me.SbClose.Size = New System.Drawing.Size(165, 43)
        Me.SbClose.TabIndex = 4
        Me.SbClose.Text = "Close"
        Me.SbClose.UseVisualStyleBackColor = False
        '
        'SbSchedule
        '
        Me.SbSchedule.BackColor = System.Drawing.Color.White
        Me.SbSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SbSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SbSchedule.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbSchedule.ForeColor = System.Drawing.Color.Black
        Me.SbSchedule.Image = CType(resources.GetObject("SbSchedule.Image"), System.Drawing.Image)
        Me.SbSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SbSchedule.Location = New System.Drawing.Point(11, 14)
        Me.SbSchedule.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbSchedule.Name = "SbSchedule"
        Me.SbSchedule.Size = New System.Drawing.Size(164, 37)
        Me.SbSchedule.TabIndex = 0
        Me.SbSchedule.Text = "Schedule"
        Me.SbSchedule.UseVisualStyleBackColor = False
        '
        'SbStudents
        '
        Me.SbStudents.BackColor = System.Drawing.Color.White
        Me.SbStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SbStudents.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbStudents.ForeColor = System.Drawing.Color.Black
        Me.SbStudents.Image = CType(resources.GetObject("SbStudents.Image"), System.Drawing.Image)
        Me.SbStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SbStudents.Location = New System.Drawing.Point(11, 55)
        Me.SbStudents.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbStudents.Name = "SbStudents"
        Me.SbStudents.Size = New System.Drawing.Size(164, 37)
        Me.SbStudents.TabIndex = 1
        Me.SbStudents.Text = "Students"
        Me.SbStudents.UseVisualStyleBackColor = False
        '
        'SbTeams
        '
        Me.SbTeams.BackColor = System.Drawing.Color.White
        Me.SbTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SbTeams.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbTeams.ForeColor = System.Drawing.Color.Black
        Me.SbTeams.Image = CType(resources.GetObject("SbTeams.Image"), System.Drawing.Image)
        Me.SbTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SbTeams.Location = New System.Drawing.Point(11, 142)
        Me.SbTeams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbTeams.Name = "SbTeams"
        Me.SbTeams.Size = New System.Drawing.Size(164, 37)
        Me.SbTeams.TabIndex = 3
        Me.SbTeams.Text = "       Teams Venues"
        Me.SbTeams.UseVisualStyleBackColor = False
        '
        'SbSports
        '
        Me.SbSports.BackColor = System.Drawing.Color.White
        Me.SbSports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SbSports.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SbSports.ForeColor = System.Drawing.Color.Black
        Me.SbSports.Image = CType(resources.GetObject("SbSports.Image"), System.Drawing.Image)
        Me.SbSports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SbSports.Location = New System.Drawing.Point(11, 97)
        Me.SbSports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SbSports.Name = "SbSports"
        Me.SbSports.Size = New System.Drawing.Size(164, 37)
        Me.SbSports.TabIndex = 2
        Me.SbSports.Text = "Sports"
        Me.SbSports.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Firebrick
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 2)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1303, 78)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "        SU Intramurals Tracker System"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Pnl_Home
        '
        Me.Pnl_Home.AutoSize = True
        Me.Pnl_Home.BackColor = System.Drawing.Color.Firebrick
        Me.Pnl_Home.BackgroundImage = CType(resources.GetObject("Pnl_Home.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pnl_Home.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Home.Location = New System.Drawing.Point(203, 86)
        Me.Pnl_Home.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnl_Home.Name = "Pnl_Home"
        Me.Pnl_Home.Size = New System.Drawing.Size(1103, 459)
        Me.Pnl_Home.TabIndex = 72
        '
        'Pnl_Teams
        '
        Me.Pnl_Teams.BackColor = System.Drawing.Color.Firebrick
        Me.Pnl_Teams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Pnl_Teams.Controls.Add(Me.GB_Venues)
        Me.Pnl_Teams.Controls.Add(Me.GB_Teams)
        Me.Pnl_Teams.Location = New System.Drawing.Point(203, 86)
        Me.Pnl_Teams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Pnl_Teams.Name = "Pnl_Teams"
        Me.Pnl_Teams.Size = New System.Drawing.Size(1103, 459)
        Me.Pnl_Teams.TabIndex = 61
        '
        'GB_Venues
        '
        Me.GB_Venues.BackColor = System.Drawing.Color.White
        Me.GB_Venues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GB_Venues.Controls.Add(Me.CBVenue)
        Me.GB_Venues.Controls.Add(Me.Btn_saveVenue)
        Me.GB_Venues.Controls.Add(Me.Txt_Search)
        Me.GB_Venues.Controls.Add(Me.Label4)
        Me.GB_Venues.Controls.Add(Me.View_Venues)
        Me.GB_Venues.Controls.Add(Me.Label3)
        Me.GB_Venues.Controls.Add(Me.Txt_VenueNo)
        Me.GB_Venues.Controls.Add(Me.Label2)
        Me.GB_Venues.Controls.Add(Me.Btn_updateVenue)
        Me.GB_Venues.Controls.Add(Me.Btn_deleteVenue)
        Me.GB_Venues.ForeColor = System.Drawing.Color.Maroon
        Me.GB_Venues.Location = New System.Drawing.Point(531, 5)
        Me.GB_Venues.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Venues.Name = "GB_Venues"
        Me.GB_Venues.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Venues.Size = New System.Drawing.Size(563, 444)
        Me.GB_Venues.TabIndex = 59
        Me.GB_Venues.TabStop = False
        Me.GB_Venues.Text = "VENUES"
        '
        'CBVenue
        '
        Me.CBVenue.FormattingEnabled = True
        Me.CBVenue.Items.AddRange(New Object() {"ALASKA COURT", "CIMAFRANCA BALLFIELD", "DARO COVERED COURT", "GROUND ZERO", "MULTIPURPOSE ROOM", "ORIENTAL HALL", "PERDICES COLISEUM", "RAVELLO BALLFIELD", "RIVERSIDE COURT", "SU HALL", "SU LAWN TENNIS COURT", "SU POOL"})
        Me.CBVenue.Location = New System.Drawing.Point(69, 65)
        Me.CBVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBVenue.Name = "CBVenue"
        Me.CBVenue.Size = New System.Drawing.Size(231, 24)
        Me.CBVenue.TabIndex = 65
        '
        'Btn_saveVenue
        '
        Me.Btn_saveVenue.Enabled = False
        Me.Btn_saveVenue.ForeColor = System.Drawing.Color.Black
        Me.Btn_saveVenue.Location = New System.Drawing.Point(91, 389)
        Me.Btn_saveVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_saveVenue.Name = "Btn_saveVenue"
        Me.Btn_saveVenue.Size = New System.Drawing.Size(123, 36)
        Me.Btn_saveVenue.TabIndex = 64
        Me.Btn_saveVenue.Text = "Save"
        Me.Btn_saveVenue.UseVisualStyleBackColor = True
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(301, 26)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(236, 22)
        Me.Txt_Search.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(159, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Search Venue Place:"
        '
        'View_Venues
        '
        Me.View_Venues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Venues.Location = New System.Drawing.Point(19, 102)
        Me.View_Venues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.View_Venues.Name = "View_Venues"
        Me.View_Venues.RowHeadersVisible = False
        Me.View_Venues.RowTemplate.Height = 24
        Me.View_Venues.Size = New System.Drawing.Size(519, 278)
        Me.View_Venues.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 66)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Venue:"
        '
        'Txt_VenueNo
        '
        Me.Txt_VenueNo.Location = New System.Drawing.Point(91, 26)
        Me.Txt_VenueNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_VenueNo.Name = "Txt_VenueNo"
        Me.Txt_VenueNo.Size = New System.Drawing.Size(63, 22)
        Me.Txt_VenueNo.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Venue No:"
        '
        'Btn_updateVenue
        '
        Me.Btn_updateVenue.ForeColor = System.Drawing.Color.Black
        Me.Btn_updateVenue.Location = New System.Drawing.Point(221, 386)
        Me.Btn_updateVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_updateVenue.Name = "Btn_updateVenue"
        Me.Btn_updateVenue.Size = New System.Drawing.Size(127, 36)
        Me.Btn_updateVenue.TabIndex = 55
        Me.Btn_updateVenue.Text = "Update"
        Me.Btn_updateVenue.UseVisualStyleBackColor = True
        '
        'Btn_deleteVenue
        '
        Me.Btn_deleteVenue.Enabled = False
        Me.Btn_deleteVenue.ForeColor = System.Drawing.Color.Black
        Me.Btn_deleteVenue.Location = New System.Drawing.Point(356, 386)
        Me.Btn_deleteVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_deleteVenue.Name = "Btn_deleteVenue"
        Me.Btn_deleteVenue.Size = New System.Drawing.Size(127, 36)
        Me.Btn_deleteVenue.TabIndex = 54
        Me.Btn_deleteVenue.Text = "Delete"
        Me.Btn_deleteVenue.UseVisualStyleBackColor = True
        '
        'GB_Teams
        '
        Me.GB_Teams.BackColor = System.Drawing.Color.White
        Me.GB_Teams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GB_Teams.Controls.Add(Me.Cb_teams)
        Me.GB_Teams.Controls.Add(Me.Label6)
        Me.GB_Teams.Controls.Add(Me.Txt_teamNo)
        Me.GB_Teams.Controls.Add(Me.Label5)
        Me.GB_Teams.Controls.Add(Me.Btn_teamSave)
        Me.GB_Teams.Controls.Add(Me.Btn_updateTeams)
        Me.GB_Teams.Controls.Add(Me.Btn_deleteTeams)
        Me.GB_Teams.Controls.Add(Me.Txt_searchTeams)
        Me.GB_Teams.Controls.Add(Me.Label1)
        Me.GB_Teams.Controls.Add(Me.View_Teams)
        Me.GB_Teams.ForeColor = System.Drawing.Color.Maroon
        Me.GB_Teams.Location = New System.Drawing.Point(5, 5)
        Me.GB_Teams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Teams.Name = "GB_Teams"
        Me.GB_Teams.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GB_Teams.Size = New System.Drawing.Size(517, 444)
        Me.GB_Teams.TabIndex = 55
        Me.GB_Teams.TabStop = False
        Me.GB_Teams.Text = "TEAMS"
        '
        'Cb_teams
        '
        Me.Cb_teams.FormattingEnabled = True
        Me.Cb_teams.Items.AddRange(New Object() {"AGRI", "CAS", "CBA", "CCS", "CED", "CMC", "COE", "COPVA", "DIV", "ICLS", "IEMS", "IRS", "LAW", "MED", "NRSG", "SHS", "SPAG"})
        Me.Cb_teams.Location = New System.Drawing.Point(104, 65)
        Me.Cb_teams.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_teams.Name = "Cb_teams"
        Me.Cb_teams.Size = New System.Drawing.Size(185, 24)
        Me.Cb_teams.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 17)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Team Name:"
        '
        'Txt_teamNo
        '
        Me.Txt_teamNo.Location = New System.Drawing.Point(83, 28)
        Me.Txt_teamNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_teamNo.Name = "Txt_teamNo"
        Me.Txt_teamNo.Size = New System.Drawing.Size(63, 22)
        Me.Txt_teamNo.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Team No:"
        '
        'Btn_teamSave
        '
        Me.Btn_teamSave.Enabled = False
        Me.Btn_teamSave.ForeColor = System.Drawing.Color.Black
        Me.Btn_teamSave.Location = New System.Drawing.Point(75, 389)
        Me.Btn_teamSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_teamSave.Name = "Btn_teamSave"
        Me.Btn_teamSave.Size = New System.Drawing.Size(113, 34)
        Me.Btn_teamSave.TabIndex = 58
        Me.Btn_teamSave.Text = "Save"
        Me.Btn_teamSave.UseVisualStyleBackColor = True
        '
        'Btn_updateTeams
        '
        Me.Btn_updateTeams.ForeColor = System.Drawing.Color.Black
        Me.Btn_updateTeams.Location = New System.Drawing.Point(195, 389)
        Me.Btn_updateTeams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_updateTeams.Name = "Btn_updateTeams"
        Me.Btn_updateTeams.Size = New System.Drawing.Size(113, 34)
        Me.Btn_updateTeams.TabIndex = 57
        Me.Btn_updateTeams.Text = "Update"
        Me.Btn_updateTeams.UseVisualStyleBackColor = True
        '
        'Btn_deleteTeams
        '
        Me.Btn_deleteTeams.Enabled = False
        Me.Btn_deleteTeams.ForeColor = System.Drawing.Color.Black
        Me.Btn_deleteTeams.Location = New System.Drawing.Point(316, 389)
        Me.Btn_deleteTeams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_deleteTeams.Name = "Btn_deleteTeams"
        Me.Btn_deleteTeams.Size = New System.Drawing.Size(113, 34)
        Me.Btn_deleteTeams.TabIndex = 56
        Me.Btn_deleteTeams.Text = "Delete"
        Me.Btn_deleteTeams.UseVisualStyleBackColor = True
        '
        'Txt_searchTeams
        '
        Me.Txt_searchTeams.Location = New System.Drawing.Point(295, 31)
        Me.Txt_searchTeams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txt_searchTeams.Name = "Txt_searchTeams"
        Me.Txt_searchTeams.Size = New System.Drawing.Size(208, 22)
        Me.Txt_searchTeams.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(151, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Search Team Name:"
        '
        'View_Teams
        '
        Me.View_Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Teams.Location = New System.Drawing.Point(8, 102)
        Me.View_Teams.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.View_Teams.Name = "View_Teams"
        Me.View_Teams.RowHeadersVisible = False
        Me.View_Teams.Size = New System.Drawing.Size(495, 273)
        Me.View_Teams.TabIndex = 1
        Me.View_Teams.TabStop = False
        '
        'SCHEDULE
        '
        Me.SCHEDULE.BackColor = System.Drawing.Color.White
        Me.SCHEDULE.Controls.Add(Me.Sched_TxtSchedNo)
        Me.SCHEDULE.Controls.Add(Me.Sched_SchedNo_Label)
        Me.SCHEDULE.Controls.Add(Me.Sched_TimePicker)
        Me.SCHEDULE.Controls.Add(Me.Sched_DatePicker)
        Me.SCHEDULE.Controls.Add(Me.Sched_DeleteButton)
        Me.SCHEDULE.Controls.Add(Me.Sched_UpdateButton)
        Me.SCHEDULE.Controls.Add(Me.Sched_NewButton)
        Me.SCHEDULE.Controls.Add(Me.Sched_TxtVenue)
        Me.SCHEDULE.Controls.Add(Me.Sched_Venue_Label)
        Me.SCHEDULE.Controls.Add(Me.Sched_TxtSport)
        Me.SCHEDULE.Controls.Add(Me.Sched_Sport_Label)
        Me.SCHEDULE.Controls.Add(Me.Sched_TxtTeam2)
        Me.SCHEDULE.Controls.Add(Me.Sched_Team2_Label)
        Me.SCHEDULE.Controls.Add(Me.Sched_TxtTeam1)
        Me.SCHEDULE.Controls.Add(Me.Sched_Team1_Label)
        Me.SCHEDULE.ForeColor = System.Drawing.Color.Firebrick
        Me.SCHEDULE.Location = New System.Drawing.Point(5, 305)
        Me.SCHEDULE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SCHEDULE.Name = "SCHEDULE"
        Me.SCHEDULE.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SCHEDULE.Size = New System.Drawing.Size(1088, 148)
        Me.SCHEDULE.TabIndex = 18
        Me.SCHEDULE.TabStop = False
        Me.SCHEDULE.Text = "SCHEDULE"
        '
        'Sched_TxtSchedNo
        '
        Me.Sched_TxtSchedNo.AutoCompleteCustomSource.AddRange(New String() {"AGRI", "CAS", "CBA", "CCS", "CED", "CMC", "COE", "COPVA", "DIV", "ICLS", "IEMS", "IRS", "LAW", "MED", "NRSG", "SHS", "SPAG"})
        Me.Sched_TxtSchedNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Sched_TxtSchedNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Sched_TxtSchedNo.Location = New System.Drawing.Point(235, 31)
        Me.Sched_TxtSchedNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_TxtSchedNo.Name = "Sched_TxtSchedNo"
        Me.Sched_TxtSchedNo.Size = New System.Drawing.Size(44, 22)
        Me.Sched_TxtSchedNo.TabIndex = 51
        '
        'Sched_SchedNo_Label
        '
        Me.Sched_SchedNo_Label.AutoSize = True
        Me.Sched_SchedNo_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_SchedNo_Label.Location = New System.Drawing.Point(147, 37)
        Me.Sched_SchedNo_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sched_SchedNo_Label.Name = "Sched_SchedNo_Label"
        Me.Sched_SchedNo_Label.Size = New System.Drawing.Size(74, 17)
        Me.Sched_SchedNo_Label.TabIndex = 50
        Me.Sched_SchedNo_Label.Text = "Sched No:"
        '
        'Sched_TimePicker
        '
        Me.Sched_TimePicker.CustomFormat = "hh:mm"
        Me.Sched_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Sched_TimePicker.Location = New System.Drawing.Point(604, 31)
        Me.Sched_TimePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sched_TimePicker.MaxDate = New Date(9997, 1, 1, 20, 0, 0, 0)
        Me.Sched_TimePicker.MinDate = New Date(1753, 1, 1, 7, 0, 0, 0)
        Me.Sched_TimePicker.Name = "Sched_TimePicker"
        Me.Sched_TimePicker.ShowUpDown = True
        Me.Sched_TimePicker.Size = New System.Drawing.Size(112, 22)
        Me.Sched_TimePicker.TabIndex = 49
        Me.Sched_TimePicker.Value = New Date(2023, 6, 4, 7, 0, 0, 0)
        '
        'Sched_DatePicker
        '
        Me.Sched_DatePicker.CustomFormat = "yyyy-MM-dd"
        Me.Sched_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Sched_DatePicker.Location = New System.Drawing.Point(403, 31)
        Me.Sched_DatePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Sched_DatePicker.Name = "Sched_DatePicker"
        Me.Sched_DatePicker.Size = New System.Drawing.Size(121, 22)
        Me.Sched_DatePicker.TabIndex = 47
        '
        'Sched_DeleteButton
        '
        Me.Sched_DeleteButton.Enabled = False
        Me.Sched_DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_DeleteButton.Location = New System.Drawing.Point(756, 91)
        Me.Sched_DeleteButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_DeleteButton.Name = "Sched_DeleteButton"
        Me.Sched_DeleteButton.Size = New System.Drawing.Size(116, 28)
        Me.Sched_DeleteButton.TabIndex = 46
        Me.Sched_DeleteButton.Text = "Delete"
        Me.Sched_DeleteButton.UseVisualStyleBackColor = True
        '
        'Sched_UpdateButton
        '
        Me.Sched_UpdateButton.Enabled = False
        Me.Sched_UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_UpdateButton.Location = New System.Drawing.Point(756, 58)
        Me.Sched_UpdateButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_UpdateButton.Name = "Sched_UpdateButton"
        Me.Sched_UpdateButton.Size = New System.Drawing.Size(116, 28)
        Me.Sched_UpdateButton.TabIndex = 45
        Me.Sched_UpdateButton.Text = "Update"
        Me.Sched_UpdateButton.UseVisualStyleBackColor = True
        '
        'Sched_NewButton
        '
        Me.Sched_NewButton.Enabled = False
        Me.Sched_NewButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_NewButton.Location = New System.Drawing.Point(756, 26)
        Me.Sched_NewButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_NewButton.Name = "Sched_NewButton"
        Me.Sched_NewButton.Size = New System.Drawing.Size(116, 28)
        Me.Sched_NewButton.TabIndex = 44
        Me.Sched_NewButton.Text = "New Schedule"
        Me.Sched_NewButton.UseVisualStyleBackColor = True
        '
        'Sched_TxtVenue
        '
        Me.Sched_TxtVenue.Location = New System.Drawing.Point(525, 106)
        Me.Sched_TxtVenue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_TxtVenue.Name = "Sched_TxtVenue"
        Me.Sched_TxtVenue.Size = New System.Drawing.Size(201, 22)
        Me.Sched_TxtVenue.TabIndex = 43
        '
        'Sched_Venue_Label
        '
        Me.Sched_Venue_Label.AutoSize = True
        Me.Sched_Venue_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_Venue_Label.Location = New System.Drawing.Point(471, 110)
        Me.Sched_Venue_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sched_Venue_Label.Name = "Sched_Venue_Label"
        Me.Sched_Venue_Label.Size = New System.Drawing.Size(53, 17)
        Me.Sched_Venue_Label.TabIndex = 42
        Me.Sched_Venue_Label.Text = "Venue:"
        '
        'Sched_TxtSport
        '
        Me.Sched_TxtSport.Location = New System.Drawing.Point(525, 74)
        Me.Sched_TxtSport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_TxtSport.Name = "Sched_TxtSport"
        Me.Sched_TxtSport.Size = New System.Drawing.Size(201, 22)
        Me.Sched_TxtSport.TabIndex = 41
        '
        'Sched_Sport_Label
        '
        Me.Sched_Sport_Label.AutoSize = True
        Me.Sched_Sport_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_Sport_Label.Location = New System.Drawing.Point(471, 78)
        Me.Sched_Sport_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sched_Sport_Label.Name = "Sched_Sport_Label"
        Me.Sched_Sport_Label.Size = New System.Drawing.Size(46, 17)
        Me.Sched_Sport_Label.TabIndex = 40
        Me.Sched_Sport_Label.Text = "Sport:"
        '
        'Sched_TxtTeam2
        '
        Me.Sched_TxtTeam2.AutoCompleteCustomSource.AddRange(New String() {"AGRI", "CAS", "CBA", "CCS", "CED", "CMC", "COE", "COPVA", "DIV", "ICLS", "IEMS", "IRS", "LAW", "MED", "NRSG", "SHS", "SPAG"})
        Me.Sched_TxtTeam2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Sched_TxtTeam2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Sched_TxtTeam2.Location = New System.Drawing.Point(197, 105)
        Me.Sched_TxtTeam2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_TxtTeam2.Name = "Sched_TxtTeam2"
        Me.Sched_TxtTeam2.Size = New System.Drawing.Size(213, 22)
        Me.Sched_TxtTeam2.TabIndex = 39
        '
        'Sched_Team2_Label
        '
        Me.Sched_Team2_Label.AutoSize = True
        Me.Sched_Team2_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_Team2_Label.Location = New System.Drawing.Point(127, 108)
        Me.Sched_Team2_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sched_Team2_Label.Name = "Sched_Team2_Label"
        Me.Sched_Team2_Label.Size = New System.Drawing.Size(60, 17)
        Me.Sched_Team2_Label.TabIndex = 38
        Me.Sched_Team2_Label.Text = "Team 2:"
        '
        'Sched_TxtTeam1
        '
        Me.Sched_TxtTeam1.AutoCompleteCustomSource.AddRange(New String() {"AGRI", "CAS", "CBA", "CCS", "CED", "CMC", "COE", "COPVA", "DIV", "ICLS", "IEMS", "IRS", "LAW", "MED", "NRSG", "SHS", "SPAG"})
        Me.Sched_TxtTeam1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Sched_TxtTeam1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Sched_TxtTeam1.Location = New System.Drawing.Point(197, 73)
        Me.Sched_TxtTeam1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Sched_TxtTeam1.Name = "Sched_TxtTeam1"
        Me.Sched_TxtTeam1.Size = New System.Drawing.Size(213, 22)
        Me.Sched_TxtTeam1.TabIndex = 37
        '
        'Sched_Team1_Label
        '
        Me.Sched_Team1_Label.AutoSize = True
        Me.Sched_Team1_Label.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Sched_Team1_Label.Location = New System.Drawing.Point(127, 76)
        Me.Sched_Team1_Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sched_Team1_Label.Name = "Sched_Team1_Label"
        Me.Sched_Team1_Label.Size = New System.Drawing.Size(60, 17)
        Me.Sched_Team1_Label.TabIndex = 36
        Me.Sched_Team1_Label.Text = "Team 1:"
        '
        'View_Sched
        '
        Me.View_Sched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_Sched.Location = New System.Drawing.Point(5, 6)
        Me.View_Sched.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.View_Sched.Name = "View_Sched"
        Me.View_Sched.Size = New System.Drawing.Size(1088, 292)
        Me.View_Sched.TabIndex = 17
        '
        'Pnl_Sched
        '
        Me.Pnl_Sched.BackColor = System.Drawing.Color.Firebrick
        Me.Pnl_Sched.Controls.Add(Me.View_Sched)
        Me.Pnl_Sched.Controls.Add(Me.SCHEDULE)
        Me.Pnl_Sched.Location = New System.Drawing.Point(203, 86)
        Me.Pnl_Sched.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pnl_Sched.Name = "Pnl_Sched"
        Me.Pnl_Sched.Size = New System.Drawing.Size(1099, 458)
        Me.Pnl_Sched.TabIndex = 71
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(155, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(123, 71)
        Me.Panel2.TabIndex = 73
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Pnl_Teams)
        Me.Controls.Add(Me.Pnl_Sched)
        Me.Controls.Add(Me.PanelSports)
        Me.Controls.Add(Me.Pnl_Home)
        Me.Controls.Add(Me.PanelStudents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Silliman University Intramurals Tracker System: SUIT System"
        Me.PanelStudents.ResumeLayout(False)
        Me.GroupBoxStudent.ResumeLayout(False)
        Me.GroupBoxStudent.PerformLayout()
        CType(Me.DGVStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSports.ResumeLayout(False)
        Me.GroupBoxStudandSport.ResumeLayout(False)
        Me.GroupBoxStudandSport.PerformLayout()
        CType(Me.DGVSport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSportStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxStud_Sport.ResumeLayout(False)
        Me.GroupBoxStud_Sport.PerformLayout()
        CType(Me.DGVStud_Sport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Pnl_Teams.ResumeLayout(False)
        Me.GB_Venues.ResumeLayout(False)
        Me.GB_Venues.PerformLayout()
        CType(Me.View_Venues, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Teams.ResumeLayout(False)
        Me.GB_Teams.PerformLayout()
        CType(Me.View_Teams, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SCHEDULE.ResumeLayout(False)
        Me.SCHEDULE.PerformLayout()
        CType(Me.View_Sched, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Sched.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelStudents As System.Windows.Forms.Panel
    Friend WithEvents B_StudDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SbSchedule As System.Windows.Forms.Button
    Friend WithEvents SbStudents As System.Windows.Forms.Button
    Friend WithEvents SbTeams As System.Windows.Forms.Button
    Friend WithEvents SbSports As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents B_StudUpdate As System.Windows.Forms.Button
    Friend WithEvents B_StudSave As System.Windows.Forms.Button
    Friend WithEvents SbClose As System.Windows.Forms.Button
    Friend WithEvents GroupBoxStudent As System.Windows.Forms.GroupBox
    Friend WithEvents T_TName As System.Windows.Forms.TextBox
    Friend WithEvents D_SearchColumn As System.Windows.Forms.ComboBox
    Friend WithEvents T_Search As System.Windows.Forms.TextBox
    Friend WithEvents L_Search As System.Windows.Forms.Label
    Friend WithEvents StudError As System.Windows.Forms.Label
    Friend WithEvents DGVStudent As System.Windows.Forms.DataGridView
    Friend WithEvents T_StudID As System.Windows.Forms.TextBox
    Friend WithEvents L_StudID As System.Windows.Forms.Label
    Friend WithEvents T_LName As System.Windows.Forms.TextBox
    Friend WithEvents T_FName As System.Windows.Forms.TextBox
    Friend WithEvents L_FName As System.Windows.Forms.Label
    Friend WithEvents L_Team As System.Windows.Forms.Label
    Friend WithEvents L_LName As System.Windows.Forms.Label
    Friend WithEvents PanelSports As System.Windows.Forms.Panel
    Friend WithEvents GroupBoxStudandSport As System.Windows.Forms.GroupBox
    Friend WithEvents B_SportAssign As System.Windows.Forms.Button
    Friend WithEvents B_SportUpdate As System.Windows.Forms.Button
    Friend WithEvents B_SportDelete As System.Windows.Forms.Button
    Friend WithEvents B_SportSave As System.Windows.Forms.Button
    Friend WithEvents D_SportSearchColumnStud As System.Windows.Forms.ComboBox
    Friend WithEvents T_SportSearchStud As System.Windows.Forms.TextBox
    Friend WithEvents L_SportSearchStud As System.Windows.Forms.Label
    Friend WithEvents T_SportVName As System.Windows.Forms.TextBox
    Friend WithEvents L_SportVName As System.Windows.Forms.Label
    Friend WithEvents T_SportSName As System.Windows.Forms.TextBox
    Friend WithEvents L_SportSName As System.Windows.Forms.Label
    Friend WithEvents T_SportStudID As System.Windows.Forms.TextBox
    Friend WithEvents L_SportStudID As System.Windows.Forms.Label
    Friend WithEvents DGVSport As System.Windows.Forms.DataGridView
    Friend WithEvents DGVSportStudent As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBoxStud_Sport As System.Windows.Forms.GroupBox
    Friend WithEvents B_SSUpdate As System.Windows.Forms.Button
    Friend WithEvents B_SSDelete As System.Windows.Forms.Button
    Friend WithEvents D_SearchColumnSS As System.Windows.Forms.ComboBox
    Friend WithEvents T_SSSearch As System.Windows.Forms.TextBox
    Friend WithEvents L_SearchSS As System.Windows.Forms.Label
    Friend WithEvents DGVStud_Sport As System.Windows.Forms.DataGridView
    Friend WithEvents T_SSStudID As System.Windows.Forms.TextBox
    Friend WithEvents L_SSStudID As System.Windows.Forms.Label
    Friend WithEvents T_SSSport As System.Windows.Forms.TextBox
    Friend WithEvents L_SSSport As System.Windows.Forms.Label
    Friend WithEvents T_SSEntryNo As System.Windows.Forms.TextBox
    Friend WithEvents L_SSEntryNo As System.Windows.Forms.Label
    Friend WithEvents T_SportSportNo As System.Windows.Forms.TextBox
    Friend WithEvents L_SportSportNo As System.Windows.Forms.Label
    Friend WithEvents Pnl_Teams As System.Windows.Forms.Panel
    Friend WithEvents GB_Venues As System.Windows.Forms.GroupBox
    Friend WithEvents CBVenue As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_saveVenue As System.Windows.Forms.Button
    Friend WithEvents Txt_Search As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents View_Venues As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_VenueNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Btn_updateVenue As System.Windows.Forms.Button
    Friend WithEvents Btn_deleteVenue As System.Windows.Forms.Button
    Friend WithEvents GB_Teams As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_teams As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_teamNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btn_teamSave As System.Windows.Forms.Button
    Friend WithEvents Btn_updateTeams As System.Windows.Forms.Button
    Friend WithEvents Btn_deleteTeams As System.Windows.Forms.Button
    Friend WithEvents Txt_searchTeams As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents View_Teams As System.Windows.Forms.DataGridView
    Friend WithEvents Pnl_Home As System.Windows.Forms.Panel
    Friend WithEvents SCHEDULE As System.Windows.Forms.GroupBox
    Friend WithEvents Sched_TxtSchedNo As System.Windows.Forms.TextBox
    Friend WithEvents Sched_SchedNo_Label As System.Windows.Forms.Label
    Friend WithEvents Sched_TimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sched_DatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Sched_DeleteButton As System.Windows.Forms.Button
    Friend WithEvents Sched_UpdateButton As System.Windows.Forms.Button
    Friend WithEvents Sched_NewButton As System.Windows.Forms.Button
    Friend WithEvents Sched_TxtVenue As System.Windows.Forms.TextBox
    Friend WithEvents Sched_Venue_Label As System.Windows.Forms.Label
    Friend WithEvents Sched_TxtSport As System.Windows.Forms.TextBox
    Friend WithEvents Sched_Sport_Label As System.Windows.Forms.Label
    Friend WithEvents Sched_TxtTeam2 As System.Windows.Forms.TextBox
    Friend WithEvents Sched_Team2_Label As System.Windows.Forms.Label
    Friend WithEvents Sched_TxtTeam1 As System.Windows.Forms.TextBox
    Friend WithEvents Sched_Team1_Label As System.Windows.Forms.Label
    Friend WithEvents View_Sched As System.Windows.Forms.DataGridView
    Friend WithEvents Pnl_Sched As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
