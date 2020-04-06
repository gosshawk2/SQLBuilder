<<<<<<< HEAD
﻿Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.Odbc
Public Class ViewSQL
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()

    End Sub
=======
﻿Public Class ViewSQL
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f

    Private Sub ViewSQL_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub PopulateForm(SQLQuery As String)
        txtSQLQuery.Text = SQLQuery
    End Sub
<<<<<<< HEAD
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


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim dt As New DataTable
        dgv.DataSource = Nothing
        Refresh()
        tssLabel1.Text = "Getting Data"
        Refresh()
        dt = ExecuteSQLQuery(txtSQLQuery.Text)
        If dt.Rows.Count = 0 Then
            MsgBox("No records")
        Else
            tssLabel1.Text = "Loading Data to Grid"
            Refresh()
            dgv.DataSource = dt
            tssLabel1.Text = "Formatting Grid"
            Refresh()
            dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        End If
        tssLabel1.Text = "Records:" & dt.Rows.Count

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

End Class
=======

    Sub ExecuteQuery(DBName As String)
        'CALL SQL SELECT STATEMENT - passing the query through to get a datatable result.
        Dim myDAL As New SQLBuilderDAL
        Dim dt As DataTable

        If txtSQLQuery.Text <> "" Then
            dt = myDAL.ExecuteQuery(DBName, txtSQLQuery.Text)
            dgvOutput.DataSource = dt
        Else
            MsgBox("Please create a query first")
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnExecuteQuery_Click(sender As Object, e As EventArgs) Handles btnExecuteQuery.Click
        ExecuteQuery(txtDBName.Text)
    End Sub
End Class
>>>>>>> 1847373fed29409afa5ab8f16df2430bbe020e9f
