Imports System.Data.SqlClient

Public Class CopyBiopsy

    Private Sub CopyBiopsy_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.txtGross.DataBindings.Clear()
        Me.txtMicroscope.DataBindings.Clear()
        Me.txtTissue.DataBindings.Clear()
        Me.txtDiagnosis.DataBindings.Clear()
    End Sub

    Private Sub CopyBiopsy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetConnectionString()
        Me.DataSet1.Clear()
        Me.BindingSource1.DataMember = Nothing
        Me.BindingSource1.DataSource = Nothing
        Dim CopyData As String = "select * from rpt_biopsy where RPTCODE = 'BIOPSY' order by labno"
        ExecuteSqlQuery(SqlDataAdapter, Me.DataSet1, CopyData, "rpt_biopsy", Connection)
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.DataMember = "rpt_biopsy"
        Me.txtGross.DataBindings.Add("TEXT", BindingSource1, "BIOPSY_GROSS")
        Me.txtMicroscope.DataBindings.Add("TEXT", BindingSource1, "BIOPSY_MICROSCOPE")
        Me.txtTissue.DataBindings.Add("TEXT", BindingSource1, "BIOPSY_TISSUE")
        Me.txtDiagnosis.DataBindings.Add("TEXT", BindingSource1, "BIOPSY_CONCLUSION")
    End Sub

    Private Sub ToolStripButtonCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonCopy.Click
        gblGross = txtGross.Text.Trim
        gblMicroscope = txtMicroscope.Text.Trim
        gblTissue = txtTissue.Text.Trim
        gblConclusion = txtDiagnosis.Text.Trim
        Me.txtGross.DataBindings.Clear()
        Me.txtMicroscope.DataBindings.Clear()
        Me.txtTissue.DataBindings.Clear()
        Me.txtDiagnosis.DataBindings.Clear()
        Me.Close()
    End Sub

    Private Sub ToolStripButtonFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButtonFind.Click
        Dim gblfind As String = Microsoft.VisualBasic.InputBox("Please write biopsy to select report.", "Biopsy", "")
        If gblfind = String.Empty Or Len(gblfind) = 0 Then Exit Sub
        Dim CopyData As String = "select * from rpt_biopsy where (biopsy_tissue like '%" & gblfind & "%' or biopsy_conclusion like '%" & gblfind & "%') AND (RPTCODE = 'BIOPSY') order by labno"
        Me.DataSet1.Clear()
        ExecuteSqlQuery(SqlDataAdapter, Me.DataSet1, CopyData, "rpt_biopsy", Connection)
        Me.BindingSource1.DataSource = Me.DataSet1
        Me.BindingSource1.DataMember = "rpt_biopsy"
    End Sub
End Class