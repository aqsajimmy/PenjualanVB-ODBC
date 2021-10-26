Imports System.Data.Odbc
Public Class UBarang
    Sub reset()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox1.Focus()
    End Sub
    Sub tampil_barang()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from barang", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong")
        Else
            cmd = New OdbcCommand("select * from barang where kodeb='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                cmd = New OdbcCommand("insert into barang values('" & TextBox1.Text.ToUpper & _
                                       "','" & TextBox2.Text & _
                                       "','" & TextBox3.Text & _
                                       "','" & TextBox4.Text & _
                                       "','" & TextBox5.Text & _
                                       "','" & TextBox6.Text & _
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Tersimpan")
                Call reset()
                Call tampil_barang()

            Else

                cmd = New OdbcCommand("update barang set nama='" & TextBox2.Text & _
                                       "',satuan='" & TextBox3.Text & _
                                       "',hargab='" & TextBox4.Text & _
                                       "',hargaj='" & TextBox5.Text & _
                                       "',stock='" & TextBox6.Text & _
                                       "' where kodeb='" & TextBox1.Text.ToUpper & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit")
                Call reset()
                Call tampil_barang()
            End If

        End If
    End Sub



    Private Sub UBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_barang()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OdbcCommand("select * from barang where kodeb ='" & TextBox1.Text.ToUpper & "' ", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd(1)
            TextBox3.Text = rd(2)
            TextBox4.Text = rd(3)
            TextBox5.Text = rd(4)
            TextBox6.Text = rd(5)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Ingin Menghapus Data ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim HapusData As String = "delete from barang where kodeb='" & TextBox1.Text.ToUpper & "'"
            cmd = New OdbcCommand(HapusData, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil diHapus")
            Call reset()
            Call tampil_barang()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        cmd = New OdbcCommand("select * from barang where nama like '%" & TextBox7.Text & "%' or kodeb like '%" & TextBox7.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5))
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call reset()
    End Sub
End Class
