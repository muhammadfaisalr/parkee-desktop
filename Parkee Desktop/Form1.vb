Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Transactions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private Const BASE_URL = "http://localhost:9090/api/parkee"
    Private Const URL_ADD_TRX = "/new-transaction"
    Private Const URL_INQ_TRX = "/inquiry-transaction"
    Private Const URL_PAY_TRX = "/payment-transaction"
    Private Const RC_SUCCESS As Integer = 200
    Dim selectedVehicleType
    Dim selectedPaymentMethod

    Private Sub cbVehicleType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVehicleType.SelectedIndexChanged
        selectedVehicleType = cbVehicleType.SelectedIndex + 1
    End Sub

    Private Sub btnCheckIn_Click(sender As Object, e As EventArgs) Handles btnCheckIn.Click
        Dim json = JObject.FromObject(
            New With {
                Key .vehicleNumber = tbVehicleNumber.Text.Trim,
                Key .vehicleType = selectedVehicleType,
                Key .status = 1
            }).ToString

        If selectedVehicleType Is Nothing Or String.IsNullOrEmpty(tbVehicleNumber.Text) Then
            'Check is Selected Vehicle Type or Vehicle Number is Empty. Throw Error
            MessageBox.Show("Data yang anda masukkan belum lengkap, harap periksa kembali.")
            Return
        End If

        Dim response = HttpPost(URL_ADD_TRX, json)

        Dim rc As Integer = response("code")
        Dim rm = response("message")

        If CInt("200") = rc Then

            tbVehicleNumber.Clear()
            cbVehicleType.SelectedIndex = -1

            GetDataParkings()

            MessageBox.Show(rm)
            Return
        End If

        MessageBox.Show(rm)
    End Sub

    Function HttpRequest() As JObject
        Dim url = BASE_URL + "/all-transaction"
        Dim request As WebRequest = WebRequest.Create(url)
        Dim dataStream As Stream = request.GetResponse.GetResponseStream()
        Dim sr As New StreamReader(dataStream)
        Return JObject.Parse(sr.ReadToEnd)
    End Function

    Function HttpPost(endpoint As String, JSON As String) As JObject
        Dim url = BASE_URL + endpoint

        ' JSON Data
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(JSON)

        ' HTTP Request
        Dim request As WebRequest = WebRequest.Create(url)
        request.Method = "POST"
        request.ContentType = "application/json"

        ' Requesting
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()

        ' Recieving a Response
        dataStream = request.GetResponse.GetResponseStream()
        Dim reader As New StreamReader(dataStream)
        Dim responseFromServer As String = reader.ReadToEnd()
        dataStream.Close()
        reader.Close()

        Return JObject.Parse(responseFromServer)
    End Function

    Function GetDataParkings()
        lvDataParkings.Clear()
        Dim response = HttpRequest()

        Dim rc As Integer = response("code")
        Dim rm = response("message")

        If CInt("200") = rc Then
            Dim datas = response("data")

            lvDataParkings.Columns.Add("Jam Masuk", 160, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Jam Keluar", 160, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Plat Nomor", 120, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Tipe Kendaraan", 120, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Status", 160, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Harga Dasar", 80, HorizontalAlignment.Center)
            lvDataParkings.Columns.Add("Total Tagihan", 80, HorizontalAlignment.Center)

            For Each data As JObject In datas
                Dim item As New ListViewItem()
                item.Text = data("checkInTime")
                item.SubItems.Add(data("checkOutTime"))
                item.SubItems.Add(data("vehicleNumber"))
                item.SubItems.Add(data("vehicleType")("name"))
                item.SubItems.Add(data("status"))
                item.SubItems.Add(data("vehicleType")("price"))
                item.SubItems.Add(data("totalAmount"))

                lvDataParkings.Items.Add(item)
            Next
        Else
            MessageBox.Show("Gagal Mendapatkan Data. Harap Restart Aplikasi")
        End If



    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelPayment.Hide()
        Timer1.Start()

        Me.WindowState = FormWindowState.Maximized

        GetDataParkings()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelCurrentClock.Text = Format(Now, "hh:mm:ss")
        labelCurrentDate.Text = Format(Now, "ddd, dd/MM/yyyy")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcessInquiry.Click
        Dim json = JObject.FromObject(
            New With {
                Key .vehicleNumber = tbVehicleNumberInqPanel.Text.Trim
            }).ToString



        If tbVehicleNumberInqPanel.Text Is Nothing Then
            'Check is Selected Vehicle Type or Vehicle Number is Empty. Throw Error
            MessageBox.Show("Data yang anda masukkan belum lengkap, harap periksa kembali.")
            Return
        End If


        Dim response = HttpPost(URL_INQ_TRX, json)

        Dim rc As Integer = response("code")
        Dim rm = response("message")


        If CInt("200") = rc Then
            Dim data = response("data")

            setPaymentData(data("checkInTime"), data("checkOutTime"), data("vehicleType"), data("baseAmount"), data("totalAmount"))

            panelPayment.Show()
            tbVehicleNumberInqPanel.Enabled = False

            Return
        End If

        MessageBox.Show(rm)

    End Sub

    Function setPaymentData(checkInTime As String, checkOutTime As String, vehicleType As String, basePrice As String, totalBill As String)
        labelCheckInTime.Text = checkInTime
        labelVehicleType.Text = vehicleType
        labelBasePrice.Text = basePrice
        labelBilling.Text = totalBill

        Dim startTime As DateTime = DateTime.Parse(checkInTime)
        Dim endTime As DateTime = DateTime.Parse(checkOutTime)

        Dim duration As TimeSpan = endTime - startTime

        Dim durationText As String = String.Format("{0} Hari, {1} Jam, {2} Menit", duration.Days, duration.Hours, duration.Minutes)

        labelDuration.Text = durationText
    End Function

    Private Sub btnCancelPayment_Click(sender As Object, e As EventArgs) Handles btnCancelPayment.Click
        panelPayment.Hide()
        tbVehicleNumberInqPanel.Clear()
        tbVehicleNumberInqPanel.Enabled = True
    End Sub

    Private Sub btnProcessPayment_Click(sender As Object, e As EventArgs) Handles btnProcessPayment.Click
        Dim json = JObject.FromObject(
            New With {
                Key .vehicleNumber = tbVehicleNumberInqPanel.Text,
                Key .paymentMethod = selectedPaymentMethod
            }).ToString

        Dim response = HttpPost(URL_PAY_TRX, json)

        Dim rc As Integer = response("code")
        Dim rm = response("message")

        If CInt("200") = rc Then
            'If Get Response Code 200.
            Dim data = response("data")
            MessageBox.Show("Sukses Melakukan Pembayaran. Selamat Jalan!")

            GetDataParkings()
            panelPayment.Hide()
            tbVehicleNumberInqPanel.Clear()
            tbVehicleNumberInqPanel.Enabled = True
            Return
        End If

        MessageBox.Show(rm)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPaymentMethod.SelectedIndexChanged
        selectedPaymentMethod = cbPaymentMethod.SelectedIndex + 1
    End Sub

    Private Sub labelBilling_Click(sender As Object, e As EventArgs) Handles labelBilling.Click

    End Sub
End Class
