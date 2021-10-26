Imports System.Data.Odbc
Public Class UCustomer
    Sub reset()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub
    Sub tampil_customer()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from customer", conn)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan Data Gagal")
        End Try
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub UCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call reset()
        Call koneksi()
        Call tampil_customer()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call tampil_customer()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong")
        Else
            cmd = New OdbcCommand("select * from customer where kodec='" & TextBox1.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                cmd = New OdbcCommand("insert into customer values('" & TextBox1.Text.ToUpper & _
                                       "','" & TextBox2.Text & _
                                       "','" & TextBox3.Text & _
                                       "','" & TextBox4.Text & _
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Tersimpan")
                Call reset()
                Call tampil_customer()

            Else

                cmd = New OdbcCommand("update customer set nama='" & TextBox2.Text & _
                                       "',alamat='" & TextBox3.Text & _
                                       "',telpon='" & TextBox4.Text & _
                                       "' where kodec='" & TextBox1.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Berhasil di Edit")
                Call reset()
                Call tampil_customer()
            End If

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cmd = New OdbcCommand("select * from customer where kodec ='" & TextBox1.Text & "' ", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            TextBox2.Text = rd(1)
            TextBox3.Text = rd(2)
            TextBox4.Text = rd(3)
        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Ingin Menghapus Data ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim HapusData As String = "delete from customer where kodec='" & TextBox1.Text.ToUpper & "'"
            cmd = New OdbcCommand(HapusData, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil diHapus")
            Call reset()
            Call tampil_customer()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        cmd = New OdbcCommand("select * from customer where nama like '%" & TextBox5.Text & "%' or kodec like '%" & TextBox5.Text & "%'", conn)
        rd = cmd.ExecuteReader
        DataGridView1.Rows.Clear()
        Do While rd.Read = True
            DataGridView1.Rows.Add(rd(0), rd(1), rd(2), rd(3))
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call reset()
    End Sub
End Class
