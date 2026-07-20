Imports System.Data.SqlClient
Imports System.Data

Public Class FrmSessionDetails
    Public SessionID As Integer

    Private Sub FrmSessionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLaserTypes()

        LoadSessionDetails()
    End Sub

    Private Sub LoadLaserTypes()

        Try

            Dim cmd As New SqlCommand("SELECT LaserTypeID,
                                               LaserTypeName
                                        FROM LaserTypes
                                        WHERE IsActive = 1
                                        ORDER BY SortOrder, LaserTypeName")

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            cbLaserType.DataSource = dt

            cbLaserType.DisplayMember = "LaserTypeName"

            cbLaserType.ValueMember = "LaserTypeID"

            cbLaserType.SelectedIndex = -1

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub LoadSessionDetails()

        Try

            Dim cmd As New SqlCommand("SELECT *  FROM SessionDetails  WHERE SessionID=@SessionID")

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            Dim dt As DataTable = DatabaseHelper.GetDataTable(cmd)

            If dt.Rows.Count > 0 Then

                If Not IsDBNull(dt.Rows(0)("LaserTypeID")) Then

                    cbLaserType.SelectedValue = CInt(dt.Rows(0)("LaserTypeID"))

                End If

                txtEnergy.Text = dt.Rows(0)("EnergyLevel").ToString()

                txtPulseWidth.Text = dt.Rows(0)("PulseWidth").ToString()

                txtSpotSize.Text = dt.Rows(0)("SpotSize").ToString()

                txtAreaDetails.Text = dt.Rows(0)("AreaDetails").ToString()

                txtSkinReaction.Text = dt.Rows(0)("SkinReaction").ToString()

                txtDoctorNotes.Text = dt.Rows(0)("DoctorNotes").ToString()

                If Not IsDBNull(dt.Rows(0)("NextSessionDate")) Then

                    dtNextSession.Value = Convert.ToDateTime(dt.Rows(0)("NextSessionDate"))

                End If

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            Dim checkCmd As New SqlCommand("SELECT COUNT(*)  FROM SessionDetails WHERE SessionID=@SessionID")

            checkCmd.Parameters.AddWithValue("@SessionID", SessionID)

            Dim exists As Integer = DatabaseHelper.ExecuteScalar(checkCmd)

            Dim query As String = ""

            If exists = 0 Then

                query = "INSERT INTO SessionDetails
                            (
                                SessionID,
                                LaserTypeID,
                                EnergyLevel,
                                PulseWidth,
                                SpotSize,
                                AreaDetails,
                                SkinReaction,
                                DoctorNotes,
                                NextSessionDate
                            )

                            VALUES
                            (
                                @SessionID,
                                @LaserTypeID,
                                @EnergyLevel,
                                @PulseWidth,
                                @SpotSize,
                                @AreaDetails,
                                @SkinReaction,
                                @DoctorNotes,
                                @NextSessionDate
                            )"

            ElseIf exists = 1 Then

                query = "UPDATE SessionDetails

                         SET

                            LaserTypeID=@LaserTypeID,

                            EnergyLevel=@EnergyLevel,

                            PulseWidth=@PulseWidth,

                            SpotSize=@SpotSize,

                            AreaDetails=@AreaDetails,

                            SkinReaction=@SkinReaction,

                            DoctorNotes=@DoctorNotes,

                            NextSessionDate=@NextSessionDate

                         WHERE SessionID=@SessionID"

            Else
                MsgBox("error")
                Exit Sub
            End If

            Dim cmd As New SqlCommand(query)

            cmd.Parameters.AddWithValue("@SessionID", SessionID)

            cmd.Parameters.AddWithValue("@LaserTypeID", CInt(cbLaserType.SelectedValue))

            cmd.Parameters.AddWithValue("@EnergyLevel", txtEnergy.Text)

            cmd.Parameters.AddWithValue("@PulseWidth", txtPulseWidth.Text)

            cmd.Parameters.AddWithValue("@SpotSize", txtSpotSize.Text)

            cmd.Parameters.AddWithValue("@AreaDetails", txtAreaDetails.Text)

            cmd.Parameters.AddWithValue("@SkinReaction", txtSkinReaction.Text)

            cmd.Parameters.AddWithValue("@DoctorNotes", txtDoctorNotes.Text)

            cmd.Parameters.AddWithValue("@NextSessionDate", dtNextSession.Value.Date)

            DatabaseHelper.ExecuteNonQuery(cmd)

            MessageBox.Show("تم حفظ تفاصيل الجلسة")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class