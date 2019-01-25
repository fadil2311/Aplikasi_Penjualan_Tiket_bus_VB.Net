Public Class mstiket
    Dim tambah As Boolean
    Dim nomor As String

    Sub tampilgrid()
        sqL = "select* from mstiket1"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv1.DataSource = Tabel

    End Sub
    Sub isikelas()
        ckelas.Items.Clear()
        ckelas.Items.Add("NON AC")
        ckelas.Items.Add("AC PATAS")
        ckelas.Items.Add("AC VIP")
        ckelas.Items.Add("EXSECUTIVE")
        ckelas.SelectedIndex = 0

    End Sub
    Sub isicari()
        cberdasarkan.Items.Clear()
        cberdasarkan.Items.Add("id")
        cberdasarkan.Items.Add("tujuan")
        cberdasarkan.SelectedIndex = 0
    End Sub
    Sub isitrayek()
        ctrayek.Items.Clear()
        ctrayek.Items.Add("Antar Kota")
        ctrayek.Items.Add("Antar provinsi")
        ctrayek.SelectedIndex = 0
    End Sub
    Sub kosong()
        tidbus.Text = ""
        ctrayek.Text = ""
        ttujuan.Text = ""
        tnopol.Text = ""
        ckelas.Text = ""

    End Sub
    Sub btnawal()
        btn1.Text = "Tambah"
        btn2.Text = "Edit"
        btn3.Text = "Hapus"
        btn4.Visible = True
        btn5.Visible = True
        btn1.Visible = True
    End Sub
    Sub btnsimpan()
        btn1.Visible = False
        btn4.Visible = False
        btn5.Visible = False
        btn2.Text = "Simpan"
        btn3.Text = "Batal"
    End Sub
    Sub tutup()
        tidbus.Enabled = False

        ctrayek.Enabled = False
        ttujuan.Enabled = False
        tnopol.Enabled = False
        ckelas.Enabled = False

    End Sub
    Sub buka()
        tidbus.Enabled = False
        ctrayek.Enabled = True
        ttujuan.Enabled = True
        tnopol.Enabled = True
        ckelas.Enabled = True

    End Sub
    Sub autoNo()
        sqL = "select id from mstiket1 order by id desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "B001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 3)
            Dim urut As Integer = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "B" & Microsoft.VisualBasic.Right("000" & urut, 3)
        End If
        tidbus.Text = nomor
    End Sub
    Sub isi()
        With dgv1
            isitrayek()
            isikelas()
            If .RowCount > 0 Then
                Dim trayek1 As String = .Item(0, .CurrentRow.Index).Value
                tidbus.Text = .Item("id", .CurrentRow.Index).Value
                For i = 0 To ctrayek.Items.Count - 1
                    Dim trayek2 As String = ctrayek.Items(i).ToString
                    If UCase(Trim(trayek2)) = UCase(Trim(trayek1)) Then
                        ctrayek.SelectedIndex = i

                    End If
                Next

                If .RowCount > 0 Then
                    Dim kelas1 As String = .Item(1, .CurrentRow.Index).Value
                    For i = 0 To ckelas.Items.Count - 1
                        Dim kelas2 As String = ckelas.Items(i).ToString
                        If UCase(Trim(kelas2)) = UCase(Trim(kelas1)) Then
                            ckelas.SelectedIndex = i

                        End If

                    Next

                    ttujuan.Text = .Item("tujuan", .CurrentRow.Index).Value
                    tnopol.Text = .Item("nopol", .CurrentRow.Index).Value
                End If
            End If
        End With
    End Sub




    Private Sub mstiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilgrid()
        isicari()
        isikelas()
        isitrayek()
        btnawal()
        tutup()
        kosong()
        tcari.Focus()
        nomor = ""

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ctrayek.SelectedIndexChanged

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btnawal()
        btnsimpan()
        kosong()
        tambah = True
        buka()
        isikelas()
        isitrayek()
        autoNo()
        ctrayek.Focus()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = "Edit" Then
            If dgv1.RowCount > 0 Then
                btnsimpan()
                tambah = False
                isitrayek()
                isikelas()
                isi()
                buka()
                tidbus.Focus()
                nomor = tidbus.Text
            Else
                MsgBox("Data Masih Kosong", vbCritical, "Isi Data Dahulu")
            End If
        Else
            If ctrayek.Text = "" Or ttujuan.Text = "" Or ckelas.Text = "" Or tnopol.Text = "" Then
                MsgBox("Isi Data Yang Kosong", vbInformation, "Isi Data Kosong")
            Else
                If tambah = True Then
                    autoNo()
                    sqL = "insert into mstiket1(id, trayek, tujuan, nopol,kelas) values(" & Aphostrophe(tidbus.Text) &
                        "," & Aphostrophe(ctrayek.Text) &
                        "," & Aphostrophe(ttujuan.Text) &
                         "," & Aphostrophe(tnopol.Text) &
                        "," & Aphostrophe(ckelas.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "update mstiket1 set id=" & Aphostrophe(tidbus.Text) & ", trayek=" & Aphostrophe(ctrayek.Text) &
                        ",tujuan=" & Aphostrophe(ttujuan.Text) & ",kelas=" & Aphostrophe(ckelas.Text) & " ,nopol=" & Aphostrophe(tnopol.Text) & "where id=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data Berhasil Disimpan", vbInformation, "Data Sukses")
                btnawal()
                isitrayek()
                isikelas()
                tampilgrid()
                kosong()
                tutup()
                tcari.Focus()
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn3.Text = "Batal" Then
            btnawal()
            tutup()
            kosong()

            tcari.Focus()
        Else
            If tidbus.Text <> "" Then
                Dim tny As String = MsgBox("Apakah Anda Ingin Menghapus..?", vbYesNo, "Konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from mstiket1 where id=" & Aphostrophe(tidbus.Text)
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data Berhasil Dihapus", vbInformation, "Data Sukses")
                    tampilgrid()
                    kosong()
                End If
            End If
        End If

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        If tcari.Text = "" Then
            MsgBox("Data Yang Dicari Tidak Ada", vbInformation, "Cari Data yang Lain")

            kosong()
        Else
            Select Case cberdasarkan.SelectedIndex
                Case 0
                    sqL = "select* from mstiket1 where id like" & Aphostrophe("%" & tcari.Text)
                    sqL = "select* from mstiket1 where id like" & Aphostrophe("%" & tcari.Text & "%")
                    sqL = "select* from mstiket1 where id like" & Aphostrophe(tcari.Text & "%")
                Case 1
                    sqL = "select* from mstiket1 where tujuan like" & Aphostrophe("%" & tcari.Text)
                    sqL = "select* from mstiket1 where tujuan like" & Aphostrophe("%" & tcari.Text & "%")
                    sqL = "select* from mstiket1 where tujuan like" & Aphostrophe(tcari.Text & "%")
            End Select
            Tabel = Proses.ExecuteQuery(sqL)


            If Tabel.Rows.Count > 0 Then
                MsgBox("Data Yang Dicari Ada.." & Tabel.Rows.Count, vbInformation, "Ini Data Yang Dicari")
                dgv1.DataSource = Tabel
                isi()
            Else
                MsgBox("Data Yang Dicari Tidak Ada", vbInformation, "Cari Data yang Lain")
            End If
        End If

        tcari.Clear()

    End Sub

    Private Sub dgv1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick
        isi()
    End Sub

    Private Sub cberdasarkan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cberdasarkan.SelectedIndexChanged
        If cberdasarkan.Text = "tujuan" Then
            tcari.Text = "cikarang-"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click




        Me.Close()



    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Report_mstiket.MdiParent = utama
        Report_mstiket.Show()
   

    End Sub
End Class