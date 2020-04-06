Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.Odbc
Public Class ViewSQL

    Private Sub ViewSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Sub PopulateForm(SQLQuery As String)
        txtSQLQuery.Text = SQLQuery
    End Sub

    Public Function ExecuteSQLQuery(SQLStatement As String) As DataTable
        Dim ConnectString As String
        ConnectString = "Provider=MSDASQL.1;DRIVER=Client Access ODBC Driver (32-bit);SYSTEM=PARAGON;TRANSLATE=1;DBQ=,epobespliv,epobesiliv, ault2f3,ault1f3,epocrmfliv,epoapefliv,epoutility,islrtgf,aulamf3,eposysfliv,zxref;DFTPKGLIB=QGPL;LANGUAGEID=ENU;PKG=QGPL/DEFAULT(IBM),2,0,1,0,512;LIBVIEW=1;CONNTYPE=0;userid=odbcuser;password=odbcuser;Initial Catalog=PARAGON;NAM=1 "
        Dim cn As New OdbcConnection(ConnectString)
        Dim cm As OdbcCommand = cn.CreateCommand 'Create a command object via the connection
        cn.Open()
        cm.CommandTimeout = 0
        cm.CommandType = CommandType.Text
        cm.CommandText = SQLStatement
        Dim da As New OdbcDataAdapter(cm)
        Dim ds As New DataSet
        da.Fill(ds)
        Return ds.Tables(0)
    End Function


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim dt As New DataTable
        dgvOutput.DataSource = Nothing
        Refresh()
        tssLabel1.Text = "Getting Data"
        Refresh()
        dt = ExecuteSQLQuery(txtSQLQuery.Text)
        If dt.Rows.Count = 0 Then
            MsgBox("No records")
        Else
            tssLabel1.Text = "Loading Data to Grid"
            Refresh()
            dgvOutput.DataSource = dt
            tssLabel1.Text = "Formatting Grid"
            Refresh()
            dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        End If
        tssLabel1.Text = "Records:" & dt.Rows.Count
    End Sub
End Class