Imports MySql.Data.MySqlClient

Module controlJenisMasakan
    Public Sub tampilJenisMasakan(combo As ComboBox)
        Dim sql As String
        sql = "SELECT * FROM tbjenismasakan"
        CMD = New MySqlCommand(sql, conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            Do While RD.Read
                combo.Items.Add(RD("jenismasakan"))
            Loop
        End If
    End Sub
End Module
