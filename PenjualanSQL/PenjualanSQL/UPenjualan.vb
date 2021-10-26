Imports System.Data.Odbc
Public Class UPenjualan
    Dim vgt As Double
    Sub cbkodecustomer()
        Call koneksi()
        Dim str As String
        str = "select kodec from customer"
        cmd = New OdbcCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                kodecustomer.Items.Add(rd("kodec"))
            Loop
        Else

        End If
    End Sub
    Sub tanggal()
        tgl.Text = Format(Now, "yyMMdd")

    End Sub

    Sub Reset()
        DataGridView1.Rows.Clear()
        kodebrg.Clear()
        dibayar.Clear()
        kembalian.Clear()
        namabrg.Clear()
        hargabrg.Clear()
        jjual.Clear()
        kodecustomer.Text = "Kode Customer"
        subtotalhrg.Clear()
        vgrandtotal.Text = "0"
        kodecustomer.Select()

    End Sub
    Sub grandtotal()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            jumlah = jumlah + DataGridView1.Rows(i).Cells(4).Value
            'vgrandtotal.Text = jumlah.ToString("C")
            vgrandtotal.Text = jumlah


        Next
        If vgrandtotal.Text = "" Then
            vgrandtotal.Text = "0"
        End If
    End Sub

    Sub notransaksi()
        cmd = New OdbcCommand("select * from penjualan where nofak in(select max(nofak)from penjualan) order by nofak DESC", conn)
        rd = cmd.ExecuteReader()
        rd.Read()
        If Not rd.HasRows Then
            vtransaksi.Text = Format(Now, "yyMMdd") + "0001"
        Else

            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yymmdd") Then
                vtransaksi.Text = Format(Now, "yyMMdd") + "0001"
            End If
            vtransaksi.Text = rd.Item("nofak") + 1
        End If

    End Sub
    Private Sub USupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Reset()
        Call koneksi()
        Call notransaksi()
        Call grandtotal()
        Call tanggal()
        Call cbkodecustomer()

    End Sub
    Private Sub vtransaksi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vtransaksi.TextChanged

    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kodebrg.TextChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from barang where kodeb='" & kodebrg.Text.ToUpper & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            namabrg.Text = rd.Item("nama")
            hargabrg.Text = rd.Item("hargaj")
            jjual.Focus()
        Else
            namabrg.Clear()
            hargabrg.Clear()
            kodebrg.Focus()
        End If

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles jjual.TextChanged
        Try
            subtotalhrg.Text = Val(jjual.Text) * Val(hargabrg.Text)
        Catch ex As Exception
            subtotalhrg.Text = "0"
        End Try
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles namabrg.TextChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from barang where nama like '%" & namabrg.Text & "%'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            kodebrg.Text = rd.Item("kodeb")
            hargabrg.Text = rd.Item("hargaj")
            jjual.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call Reset()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kodebrg.Clear()
        dibayar.Text = "0"
        kembalian.Text = "0"
        namabrg.Clear()
        hargabrg.Clear()
        jjual.Clear()
        kodecustomer.Text = "Kode Customer"
        subtotalhrg.Clear()
        vgrandtotal.Text = "0"

    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles jjual.KeyPress
        If e.KeyChar = Chr(13) Then
            DataGridView1.Rows.Add(kodebrg.Text, namabrg.Text, hargabrg.Text, jjual.Text, subtotalhrg.Text)
            kodebrg.Clear()
            namabrg.Clear()
            hargabrg.Clear()
            jjual.Clear()
            subtotalhrg.Clear()
            kodebrg.Focus()
            Call grandtotal()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Rows.Add(kodebrg.Text, namabrg.Text, hargabrg.Text, jjual.Text, subtotalhrg.Text)
        kodebrg.Clear()
        namabrg.Clear()
        hargabrg.Clear()
        jjual.Clear()
        subtotalhrg.Clear()
        kodebrg.Focus()
        Call grandtotal()
    End Sub

    Private Sub kodecustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dibayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dibayar.TextChanged
        Try
            'Dim dib As Double 
            'Dim kem As Double
            'kem = Val(dibayar.Text) - Val(vgrandtotal.Text)
            'kembalian.Text = kem.ToString("###.###")

            kembalian.Text = Val(dibayar.Text) - Val(vgrandtotal.Text)
        Catch ex As Exception
            kembalian.Text = "0"
        End Try

        If Val(dibayar.Text) >= Val(vgrandtotal.Text) Then
            'simpantrx.Focus()

        End If
    End Sub

    Private Sub simpantrx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles simpantrx.Click
        If vgrandtotal.Text = "0" Then
            MessageBox.Show("Belum ada Transaksi")
        Else
            Call koneksi()
            'simpan data transaksi ke tabel penjualan
            cmd = New OdbcCommand("insert into penjualan(nofak,tfak,kodec,dibayar,kembalian,jbayar)values('" & vtransaksi.Text & _
                                   "','" & tgl.Text & _
                                   "','" & kodecustomer.Text & _
                                   "','" & dibayar.Text & _
                                   "','" & kembalian.Text & _
                                   "','" & vgrandtotal.Text & _
                                   "')", conn)
            cmd.ExecuteNonQuery()
            'simpan ke table rinci_jual
            For baris As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New OdbcCommand("insert into dpenjualan(nofak,kodeb,jjual)values('" & vtransaksi.Text & _
                                       "','" & DataGridView1.Rows(baris).Cells(0).Value & _
                                       "','" & DataGridView1.Rows(baris).Cells(3).Value & _
                                       "')", conn)
                cmd.ExecuteNonQuery()
                'pengurangan stock
                cmd = New OdbcCommand("select * from barang where kodeb='" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OdbcCommand("update barang set stock='" & rd.Item("stock") - Val(DataGridView1.Rows(baris).Cells(3).Value) & _
                          "' where kodeb='" & DataGridView1.Rows(baris).Cells(0).Value & "'", conn)
                    cmd.ExecuteNonQuery()

                End If


            Next
            'membersihkan grodview setelah transaksi
            MessageBox.Show("Transaksi Berhasil Disimpan !")
            DataGridView1.Rows.Clear()
            vgrandtotal.Text = "0"
            dibayar.Text = "0"
            kembalian.Text = "0"
            Call notransaksi()
            Call Reset()
            kodebrg.Focus()
        End If
    End Sub

    Private Sub kodecustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kodecustomer.SelectedIndexChanged
        Call koneksi()
        cmd = New OdbcCommand("select * from customer where kodec='" & kodecustomer.Text.ToUpper & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            namacustomer.Text = rd.Item("nama")
            kodebrg.Focus()
        Else
            namacustomer.Text = ""
            kodecustomer.Focus()
        End If
    End Sub


End Class
