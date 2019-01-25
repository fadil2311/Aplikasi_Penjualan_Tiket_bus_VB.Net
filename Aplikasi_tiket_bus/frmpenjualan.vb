Public Class frmpenjualan
    Dim tambah As Boolean
    Dim nomor As String
    Dim tanggal As String
    Dim a As Integer
    Dim b As String
    Dim c As Integer
    Dim NILAI1 As Integer

    Sub tampilgrid1()
        sqL = "select* from penjualan12"
        Tabel = Proses.ExecuteQuery(sqL)
        dgv2.DataSource = Tabel


    End Sub
    Sub tampilgrid2()
        sqL = "select* from stroke"
        Tabel = Proses.ExecuteQuery(sqL)
        dgvstroke.DataSource = Tabel


    End Sub
    Sub CHECK()
        If Rnonac.Checked = True Then
            thargakelas.Text = "8000"
        ElseIf racpatas.Checked = True Then
            thargakelas.Text = "15000"
        ElseIf racvip.Checked = True Then
            thargakelas.Text = "25000"
        ElseIf rexecutive.Checked = True Then
            thargakelas.Text = "35000"
        End If
    End Sub
    Sub isicari()
        cberdasarkan.Items.Clear()
        cberdasarkan.Items.Add("ID")
        cberdasarkan.Items.Add("Nama")
        cberdasarkan.Items.Add("no telpon")
        cberdasarkan.SelectedIndex = 0
    End Sub
    Sub kosong()
        tidpembeli.Text = ""
        tnama.Text = ""
        ttelpon.Text = ""
        tjam.Text = ""
        tnokursi.Text = ""
        tjumlahbeli.Text = ""
        ttanggal.Text = ""
        ttotalharga.Text = ""
        tdibayar.Text = ""
        tkembalian.Text = ""
        ttujuan.Text = ""
        tnopol.Text = ""
        tharga.Text = ""
        thargasementara.Text = ""
        thargakelas.Text = ""
        cberdasarkan.Text = ""
        tcari.Text = ""
        tkelas.Text = ""
        Rnonac.Checked = False
        racpatas.Checked = False
        racvip.Checked = False
        rexecutive.Checked = False
    End Sub
    Sub btnawal()
        btn1.Text = "Tambah"
        btn2.Text = "Edit"
        btn3.Text = "Hapus"
        btn5.Visible = False
        btn4.Visible = True
        btn1.Visible = True
        btnimpor.Enabled = False

    End Sub
    Sub btnsimpan()
        btnimpor.Enabled = True
        btn1.Visible = False
        btn4.Visible = False
        btn5.Visible = True
        btn5.Text = "Hitung"
        btn2.Text = "Simpan"
        btn3.Text = "Batal"
    End Sub
    Sub tutup()
        tidpembeli.Enabled = False
        tnama.Enabled = False
        ttelpon.Enabled = False
        tjam.Enabled = False
        ttanggal.Enabled = False
        tnokursi.Enabled = False
        tjumlahbeli.Enabled = False
        tjumlahbeli.Enabled = False
        ttotalharga.Enabled = False
        tdibayar.Enabled = False
        tkembalian.Enabled = False
        ttujuan.Enabled = False
        tnopol.Enabled = False
        thargakelas.Enabled = False
        thargasementara.Enabled = False
        tharga.Enabled = False
        tkelas.Enabled = False
        Rnonac.Enabled = False
        racpatas.Enabled = False
        racvip.Enabled = False
        rexecutive.Enabled = False

    End Sub

    Sub buka()

        tidpembeli.Enabled = False
        tnama.Enabled = True
        ttelpon.Enabled = True
        tjam.Enabled = True
        ttanggal.Enabled = True
        tnokursi.Enabled = True
        tjumlahbeli.Enabled = True
        tjumlahbeli.Enabled = True
        ttotalharga.Enabled = True
        tdibayar.Enabled = True
        tkembalian.Enabled = True
        ttujuan.Enabled = True
        tnopol.Enabled = True
        tkelas.Enabled = True
        Rnonac.Enabled = True
        racpatas.Enabled = True
        racvip.Enabled = True
        rexecutive.Enabled = True

    End Sub
    Sub autoNo()
        sqL = "select id from penjualan12 order by id desc"
        Tabel = Proses.ExecuteQuery(sqL)
        If Tabel.Rows.Count = 0 Then
            nomor = "C0001"
        Else
            Dim nom As String = Microsoft.VisualBasic.Right(Trim(Tabel.Rows(0).Item(0).ToString), 4)
            Dim urut As Integer = Val(nom) + 1
            nom = urut
            Dim panjang As Byte = Len(nom)
            nomor = "C" & Microsoft.VisualBasic.Right("0000" & urut, 4)
        End If
        tidpembeli.Text = nomor
    End Sub

    Sub isi()
        With dgv2
            If .RowCount > 0 Then

                tidpembeli.Text = .Item("id", .CurrentRow.Index).Value
                tnama.Text = .Item("nama_pembeli", .CurrentRow.Index).Value
                ttelpon.Text = .Item("no_telpon", .CurrentRow.Index).Value
                ttujuan.Text = .Item("tujuan", .CurrentRow.Index).Value
                ttanggal.Text = .Item("tanggal_berangkat", .CurrentRow.Index).Value
                tjam.Text = .Item("jam_berangkat", .CurrentRow.Index).Value
                tkelas.Text = .Item("kelas", .CurrentRow.Index).Value
                tnokursi.Text = .Item("no_kursi", .CurrentRow.Index).Value
                tnopol.Text = .Item("nopol", .CurrentRow.Index).Value
                    tharga.Text = .Item("harga", .CurrentRow.Index).Value
                    tjumlahbeli.Text = .Item("jumlah_beli", .CurrentRow.Index).Value
                    ttotalharga.Text = .Item("total_harga", .CurrentRow.Index).Value
                    tdibayar.Text = .Item("dibayar", .CurrentRow.Index).Value
                tkembalian.Text = .Item("kembalian", .CurrentRow.Index).Value
                End If
        End With
    End Sub
    Private Sub frmpenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilgrid1()
        tampilgrid2()
        isicari()
        btnawal()
        tutup()
        kosong()
        tcari.Focus()
        nomor = ""
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btnawal()
        btnsimpan()
        tambah = True
        buka()
        kosong()
        autoNo()
        tnama.Focus()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn2.Text = "Edit" Then
            If dgv2.RowCount > 0 Then
                btnsimpan()
                tambah = False
                isi()
                buka()
                tidpembeli.Focus()
                nomor = tidpembeli.Text
            Else
                MsgBox("Data Masih Kosong", vbCritical, "Isi Data Dahulu")
            End If
        Else
            If tidpembeli.Text = "" Or tnama.Text = "" Or ttelpon.Text = "" Or tjam.Text = "" Or tnokursi.Text = "" Or tjumlahbeli.Text = "" Or tjumlahbeli.Text = "" Or ttotalharga.Text = "" Or tdibayar.Text = "" Or tkembalian.Text = "" Or ttujuan.Text = "" Or tnopol.Text = "" Or tharga.Text = "" Or thargakelas.Text = "" Or thargasementara.Text = "" Then
                MsgBox("Isi Data Yang Kosong", vbInformation, "Isi Data Kosong")
            Else
                If tambah = True Then
                    autoNo()
                    sqL = "insert into penjualan12(id,nama_pembeli,no_telpon,tujuan,tanggal_berangkat,jam_berangkat,kelas,no_kursi,nopol,harga,jumlah_beli,total_harga,dibayar,kembalian) values(" & Aphostrophe(tidpembeli.Text) &
                        "," & Aphostrophe(tnama.Text) &
                        "," & Aphostrophe(ttelpon.Text) &
                         "," & Aphostrophe(ttujuan.Text) &
                        "," & Aphostrophe(ttanggal.Text) &
                         "," & Aphostrophe(tjam.Text) &
                         "," & Aphostrophe(tkelas.Text) &
                         "," & Aphostrophe(tnokursi.Text) &
                         "," & Aphostrophe(tnopol.Text) &
                            "," & Aphostrophe(tharga.Text) &
                         "," & Aphostrophe(tjumlahbeli.Text) &
                         "," & Aphostrophe(ttotalharga.Text) &
                          "," & Aphostrophe(tdibayar.Text) &
                          "," & Aphostrophe(tkembalian.Text) & ")"
                    Proses.ExecuteNonQuery(sqL)
                Else
                    sqL = "update penjualan12 set id=" & Aphostrophe(tidpembeli.Text) &
                        ", nama_pembeli=" & Aphostrophe(tnama.Text) &
                        ",no_telpon=" & Aphostrophe(ttelpon.Text) &
                        ",tujuan=" & Aphostrophe(ttujuan.Text) &
                        " ,tanggal_berangkat=" & Aphostrophe(ttanggal.Text) &
                        ",jam_berangkat=" & Aphostrophe(tjam.Text) &
                       ",kelas=" & Aphostrophe(tkelas.Text) &
                       ",no_kursi=" & Aphostrophe(tnokursi.Text) &
                       ",nopol=" & Aphostrophe(tnopol.Text) &
                     ",harga=" & Aphostrophe(tharga.Text) &
                       ",jumlah_beli=" & Aphostrophe(tjumlahbeli.Text) &
                       ",total_harga=" & Aphostrophe(ttotalharga.Text) &
                       ",dibayar=" & Aphostrophe(tdibayar.Text) &
                       ",kembalian=" & Aphostrophe(tkembalian.Text) &
                        "where id=" & Aphostrophe(nomor)
                    Proses.ExecuteNonQuery(sqL)
                End If
                MsgBox("Data Berhasil Disimpan", vbInformation, "Data Sukses")
                btnawal()
                tampilgrid1()
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
            If tidpembeli.Text <> "" Then
                Dim tny As String = MsgBox("Apakah Anda Ingin Menghapus..?", vbYesNo, "Konfirmasi")
                If tny = vbYes Then
                    sqL = "delete from penjualan12 where id=" & Aphostrophe(tidpembeli.Text)
                    Proses.ExecuteNonQuery(sqL)
                    MsgBox("Data Berhasil Dihapus", vbInformation, "Data Sukses")
                    tampilgrid1()
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
                    sqL = "select* from penjualan12 where id like" & Aphostrophe("%" & tcari.Text)
                    sqL = "select* from penjualan12 where id like" & Aphostrophe("%" & tcari.Text & "%")
                    sqL = "select* from penjualan12 where id like" & Aphostrophe(tcari.Text & "%")
                Case 1
                    sqL = "select* from penjualan12 where nama_pembeli like" & Aphostrophe("%" & tcari.Text)
                    sqL = "select* from penjualan12 where nama_pembeli like" & Aphostrophe("%" & tcari.Text & "%")
                    sqL = "select* from penjualan12 where nama_pembeli like" & Aphostrophe(tcari.Text & "%")
                Case 2
                    sqL = "select* from penjualan12 where no_telpon like" & Aphostrophe("%" & tcari.Text)
                    sqL = "select* from penjualan12 where no_telpon like" & Aphostrophe("%" & tcari.Text & "%")
                    sqL = "select* from penjualan12 where no_telpon like" & Aphostrophe(tcari.Text & "%")
            End Select
            Tabel = Proses.ExecuteQuery(sqL)


            If Tabel.Rows.Count > 0 Then
                MsgBox("Data Yang Dicari Ada.." & Tabel.Rows.Count, vbInformation, "Ini Data Yang Dicari")
                dgv2.DataSource = Tabel
                isi()
            Else
                MsgBox("Data Yang Dicari Tidak Ada", vbInformation, "Cari Data yang Lain")
            End If
        End If

        tcari.Clear()
    End Sub

    Private Sub dgv2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv2.CellContentClick
        isi()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        report_penjualan.MdiParent = utama
        report_penjualan.Show()

    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Me.Close()
    End Sub

    Private Sub thargasementara_TextChanged(sender As Object, e As EventArgs) Handles thargasementara.TextChanged


    End Sub

  
    Private Sub tkelas_TextChanged(sender As Object, e As EventArgs) Handles tkelas.TextChanged
     

    End Sub
    Private Sub ttujuan_TextChanged(sender As Object, e As EventArgs) Handles ttujuan.TextChanged

        If ttujuan.Text = "cikarang-bandung" Then
            thargasementara.Text = "100000"
        ElseIf ttujuan.Text = "cikarang-tasikmalaya" Then
            thargasementara.Text = "100000"
        ElseIf ttujuan.Text = "cikarang-purwokerto" Then
            thargasementara.Text = "125000"
        ElseIf ttujuan.Text = "cikarang-kebumen" Then
            thargasementara.Text = "150000"
        ElseIf ttujuan.Text = "cikarang-purworejo" Then
            thargasementara.Text = "150000"
        ElseIf ttujuan.Text = "cikarang-cirebon" Then
            thargasementara.Text = "100000"
        ElseIf ttujuan.Text = "cikarang-pekalongan" Then
            thargasementara.Text = "125000"
        ElseIf ttujuan.Text = "cikarang-semarang" Then
            thargasementara.Text = "150000"
        ElseIf ttujuan.Text = "cikarang-magelang" Then
            thargasementara.Text = "150000"
        End If

      
    End Sub
    Private Sub tharga_TextChanged_1(sender As Object, e As EventArgs) Handles tharga.TextChanged
    End Sub

    Private Sub btnhitung1_Click(sender As Object, e As EventArgs) Handles btn5.Click
       
        NILAI1 = Val(thargakelas.Text) + Val(thargasementara.Text)
        tharga.Text = NILAI1
        a = Val(tharga.Text) * Val(tjumlahbeli.Text)
        ttotalharga.Text = a
       
    End Sub

    Private Sub tjumlahbeli_TextChanged(sender As Object, e As EventArgs) Handles tjumlahbeli.TextChanged
       
    End Sub

    Private Sub tdibayar_TextChanged(sender As Object, e As EventArgs) Handles tdibayar.TextChanged
        b = Val(tdibayar.Text) - Val(ttotalharga.Text)
        tkembalian.Text = b
    End Sub

    Private Sub btnimpor_Click(sender As Object, e As EventArgs) Handles btnimpor.Click
        flmtiket.Show()
        Me.Hide()
    End Sub

  
    Private Sub Rnonac_CheckedChanged(sender As Object, e As EventArgs) Handles Rnonac.CheckedChanged
        CHECK()
    End Sub

    Private Sub racpatas_CheckedChanged(sender As Object, e As EventArgs) Handles racpatas.CheckedChanged
        CHECK()
    End Sub

    Private Sub racvip_CheckedChanged(sender As Object, e As EventArgs) Handles racvip.CheckedChanged
        CHECK()
    End Sub

    Private Sub rexecutive_CheckedChanged(sender As Object, e As EventArgs) Handles rexecutive.CheckedChanged
        CHECK()
    End Sub
    Sub simpan()
        sqL = "insert into stroke(id,nama_pembeli,no_telpon,tujuan,tanggal_berangkat,jam_berangkat,kelas,no_kursi,nopol,harga) values(" & Aphostrophe(tidpembeli.Text) &
                      "," & Aphostrophe(tnama.Text) &
                      "," & Aphostrophe(ttelpon.Text) &
                       "," & Aphostrophe(ttujuan.Text) &
                      "," & Aphostrophe(ttanggal.Text) &
                       "," & Aphostrophe(tjam.Text) &
                       "," & Aphostrophe(tkelas.Text) &
                       "," & Aphostrophe(tnokursi.Text) &
                       "," & Aphostrophe(tnopol.Text) &
                          "," & Aphostrophe(tharga.Text) & ")"
        Proses.ExecuteNonQuery(sqL)
    End Sub
    Sub DELETe()
        sqL = "delete from stroke where id=" & Aphostrophe(tidpembeli.Text)
        Proses.ExecuteNonQuery(sqL)
        tampilgrid2()
    End Sub
    Private Sub btntiket_Click(sender As Object, e As EventArgs) Handles btntiket.Click
        simpan()
        cetak_tiket.MdiParent = utama
        cetak_tiket.Show()

        DELETe()
    End Sub

    Private Sub tidpembeli_TextChanged(sender As Object, e As EventArgs) Handles tidpembeli.TextChanged

    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged

    End Sub
End Class