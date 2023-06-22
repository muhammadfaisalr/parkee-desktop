<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        tbVehicleNumber = New TextBox()
        Label2 = New Label()
        cbVehicleType = New ComboBox()
        btnCheckIn = New Button()
        Label1 = New Label()
        labelCurrentClock = New Label()
        Timer1 = New Timer(components)
        labelCurrentDate = New Label()
        Label3 = New Label()
        panelInquiry = New Panel()
        btnProcessInquiry = New Button()
        Label6 = New Label()
        Label5 = New Label()
        tbVehicleNumberInqPanel = New TextBox()
        Label12 = New Label()
        Label4 = New Label()
        panelPayment = New Panel()
        labelDuration = New Label()
        Label15 = New Label()
        btnCancelPayment = New Button()
        cbPaymentMethod = New ComboBox()
        Label10 = New Label()
        labelBilling = New Label()
        Label11 = New Label()
        labelBasePrice = New Label()
        label8 = New Label()
        labelVehicleType = New Label()
        Label9 = New Label()
        labelCheckInTime = New Label()
        Label7 = New Label()
        btnProcessPayment = New Button()
        lvDataParkings = New ListView()
        Label13 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        panelInquiry.SuspendLayout()
        panelPayment.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(291, 554)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' tbVehicleNumber
        ' 
        tbVehicleNumber.CharacterCasing = CharacterCasing.Upper
        tbVehicleNumber.Location = New Point(12, 242)
        tbVehicleNumber.MaxLength = 9
        tbVehicleNumber.Name = "tbVehicleNumber"
        tbVehicleNumber.Size = New Size(234, 27)
        tbVehicleNumber.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(12, 287)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 3
        Label2.Text = "Jenis Kendaraan"
        ' 
        ' cbVehicleType
        ' 
        cbVehicleType.AllowDrop = True
        cbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList
        cbVehicleType.FormattingEnabled = True
        cbVehicleType.Items.AddRange(New Object() {"1. [M] Mobil", "2. [O] Motor", "3. [T] Truk", "4. [B] Bus"})
        cbVehicleType.Location = New Point(12, 322)
        cbVehicleType.Name = "cbVehicleType"
        cbVehicleType.Size = New Size(234, 28)
        cbVehicleType.TabIndex = 4
        ' 
        ' btnCheckIn
        ' 
        btnCheckIn.ForeColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        btnCheckIn.Location = New Point(12, 383)
        btnCheckIn.Name = "btnCheckIn"
        btnCheckIn.Size = New Size(234, 29)
        btnCheckIn.TabIndex = 5
        btnCheckIn.Text = "Proses"
        btnCheckIn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(12, 205)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 20)
        Label1.TabIndex = 2
        Label1.Text = "Plat No. Kendaraan"
        ' 
        ' labelCurrentClock
        ' 
        labelCurrentClock.AutoSize = True
        labelCurrentClock.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        labelCurrentClock.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        labelCurrentClock.ForeColor = SystemColors.ButtonFace
        labelCurrentClock.Location = New Point(12, 27)
        labelCurrentClock.Name = "labelCurrentClock"
        labelCurrentClock.Size = New Size(253, 41)
        labelCurrentClock.TabIndex = 6
        labelCurrentClock.Text = "labelCurrentClock"
        ' 
        ' Timer1
        ' 
        ' 
        ' labelCurrentDate
        ' 
        labelCurrentDate.AutoSize = True
        labelCurrentDate.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        labelCurrentDate.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        labelCurrentDate.ForeColor = SystemColors.ButtonFace
        labelCurrentDate.Location = New Point(12, 68)
        labelCurrentDate.Name = "labelCurrentDate"
        labelCurrentDate.Size = New Size(140, 23)
        labelCurrentDate.TabIndex = 7
        labelCurrentDate.Text = "labelCurrentDate"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(12, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 23)
        Label3.TabIndex = 8
        Label3.Text = "Tambah Data Parkir"
        ' 
        ' panelInquiry
        ' 
        panelInquiry.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panelInquiry.Controls.Add(btnProcessInquiry)
        panelInquiry.Controls.Add(Label6)
        panelInquiry.Controls.Add(Label5)
        panelInquiry.Controls.Add(tbVehicleNumberInqPanel)
        panelInquiry.Location = New Point(966, 89)
        panelInquiry.Name = "panelInquiry"
        panelInquiry.Size = New Size(390, 157)
        panelInquiry.TabIndex = 9
        ' 
        ' btnProcessInquiry
        ' 
        btnProcessInquiry.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        btnProcessInquiry.ForeColor = SystemColors.ButtonFace
        btnProcessInquiry.Location = New Point(24, 99)
        btnProcessInquiry.Name = "btnProcessInquiry"
        btnProcessInquiry.Size = New Size(234, 29)
        btnProcessInquiry.TabIndex = 11
        btnProcessInquiry.Text = "Cek"
        btnProcessInquiry.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Location = New Point(24, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 20)
        Label6.TabIndex = 12
        Label6.Text = "Plat No. Kendaraan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(22), CByte(26), CByte(29))
        Label5.Location = New Point(24, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 23)
        Label5.TabIndex = 11
        Label5.Text = "Inquiry"
        ' 
        ' tbVehicleNumberInqPanel
        ' 
        tbVehicleNumberInqPanel.CharacterCasing = CharacterCasing.Upper
        tbVehicleNumberInqPanel.Location = New Point(24, 66)
        tbVehicleNumberInqPanel.MaxLength = 9
        tbVehicleNumberInqPanel.Name = "tbVehicleNumberInqPanel"
        tbVehicleNumberInqPanel.Size = New Size(234, 27)
        tbVehicleNumberInqPanel.TabIndex = 11
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label12.ForeColor = Color.FromArgb(CByte(22), CByte(26), CByte(29))
        Label12.Location = New Point(24, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(79, 23)
        Label12.TabIndex = 13
        Label12.Text = "Payment"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        Label4.Location = New Point(966, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(248, 41)
        Label4.TabIndex = 10
        Label4.Text = "Kendaraan Keluar"
        ' 
        ' panelPayment
        ' 
        panelPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        panelPayment.Controls.Add(labelDuration)
        panelPayment.Controls.Add(Label15)
        panelPayment.Controls.Add(Label12)
        panelPayment.Controls.Add(btnCancelPayment)
        panelPayment.Controls.Add(cbPaymentMethod)
        panelPayment.Controls.Add(Label10)
        panelPayment.Controls.Add(labelBilling)
        panelPayment.Controls.Add(Label11)
        panelPayment.Controls.Add(labelBasePrice)
        panelPayment.Controls.Add(label8)
        panelPayment.Controls.Add(labelVehicleType)
        panelPayment.Controls.Add(Label9)
        panelPayment.Controls.Add(labelCheckInTime)
        panelPayment.Controls.Add(Label7)
        panelPayment.Controls.Add(btnProcessPayment)
        panelPayment.Location = New Point(966, 241)
        panelPayment.Name = "panelPayment"
        panelPayment.Size = New Size(392, 408)
        panelPayment.TabIndex = 11
        ' 
        ' labelDuration
        ' 
        labelDuration.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        labelDuration.AutoSize = True
        labelDuration.Location = New Point(221, 91)
        labelDuration.Name = "labelDuration"
        labelDuration.Size = New Size(97, 20)
        labelDuration.TabIndex = 24
        labelDuration.Text = "Total Tagihan"
        labelDuration.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(25, 91)
        Label15.Name = "Label15"
        Label15.Size = New Size(91, 20)
        Label15.TabIndex = 23
        Label15.Text = "Durasi Parkir"
        ' 
        ' btnCancelPayment
        ' 
        btnCancelPayment.BackColor = Color.Transparent
        btnCancelPayment.ForeColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        btnCancelPayment.Location = New Point(25, 321)
        btnCancelPayment.Name = "btnCancelPayment"
        btnCancelPayment.Size = New Size(234, 29)
        btnCancelPayment.TabIndex = 22
        btnCancelPayment.Text = "Batal"
        btnCancelPayment.UseVisualStyleBackColor = False
        ' 
        ' cbPaymentMethod
        ' 
        cbPaymentMethod.FormattingEnabled = True
        cbPaymentMethod.Items.AddRange(New Object() {"1. Cash", "2. QRIS"})
        cbPaymentMethod.Location = New Point(22, 252)
        cbPaymentMethod.Name = "cbPaymentMethod"
        cbPaymentMethod.Size = New Size(234, 28)
        cbPaymentMethod.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.FromArgb(CByte(22), CByte(26), CByte(29))
        Label10.Location = New Point(22, 217)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 20)
        Label10.TabIndex = 12
        Label10.Text = "Metode Pembayaran"
        ' 
        ' labelBilling
        ' 
        labelBilling.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        labelBilling.AutoSize = True
        labelBilling.Location = New Point(221, 151)
        labelBilling.Name = "labelBilling"
        labelBilling.Size = New Size(97, 20)
        labelBilling.TabIndex = 21
        labelBilling.Text = "Total Tagihan"
        labelBilling.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(25, 151)
        Label11.Name = "Label11"
        Label11.Size = New Size(97, 20)
        Label11.TabIndex = 20
        Label11.Text = "Total Tagihan"
        ' 
        ' labelBasePrice
        ' 
        labelBasePrice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        labelBasePrice.AutoSize = True
        labelBasePrice.Location = New Point(221, 120)
        labelBasePrice.Name = "labelBasePrice"
        labelBasePrice.Size = New Size(92, 20)
        labelBasePrice.TabIndex = 19
        labelBasePrice.Text = "Harga Dasar"
        labelBasePrice.TextAlign = ContentAlignment.TopRight
        ' 
        ' label8
        ' 
        label8.AutoSize = True
        label8.Location = New Point(25, 120)
        label8.Name = "label8"
        label8.Size = New Size(92, 20)
        label8.TabIndex = 18
        label8.Text = "Harga Dasar"
        ' 
        ' labelVehicleType
        ' 
        labelVehicleType.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        labelVehicleType.AutoSize = True
        labelVehicleType.Location = New Point(221, 63)
        labelVehicleType.Name = "labelVehicleType"
        labelVehicleType.Size = New Size(113, 20)
        labelVehicleType.TabIndex = 17
        labelVehicleType.Text = "Tipe Kendaraan"
        labelVehicleType.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(24, 63)
        Label9.Name = "Label9"
        Label9.Size = New Size(113, 20)
        Label9.TabIndex = 16
        Label9.Text = "Tipe Kendaraan"
        ' 
        ' labelCheckInTime
        ' 
        labelCheckInTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        labelCheckInTime.AutoSize = True
        labelCheckInTime.Location = New Point(221, 32)
        labelCheckInTime.Name = "labelCheckInTime"
        labelCheckInTime.Size = New Size(81, 20)
        labelCheckInTime.TabIndex = 15
        labelCheckInTime.Text = "Jam Masuk"
        labelCheckInTime.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(25, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 20)
        Label7.TabIndex = 14
        Label7.Text = "Jam Masuk"
        ' 
        ' btnProcessPayment
        ' 
        btnProcessPayment.BackColor = Color.FromArgb(CByte(199), CByte(31), CByte(55))
        btnProcessPayment.ForeColor = SystemColors.ButtonFace
        btnProcessPayment.Location = New Point(22, 286)
        btnProcessPayment.Name = "btnProcessPayment"
        btnProcessPayment.Size = New Size(237, 29)
        btnProcessPayment.TabIndex = 13
        btnProcessPayment.Text = "Proses Bayar"
        btnProcessPayment.UseVisualStyleBackColor = False
        ' 
        ' lvDataParkings
        ' 
        lvDataParkings.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvDataParkings.Location = New Point(314, 89)
        lvDataParkings.Name = "lvDataParkings"
        lvDataParkings.Size = New Size(627, 402)
        lvDataParkings.Sorting = SortOrder.Descending
        lvDataParkings.TabIndex = 12
        lvDataParkings.UseCompatibleStateImageBehavior = False
        lvDataParkings.View = View.Details
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(314, 27)
        Label13.Name = "Label13"
        Label13.Size = New Size(129, 31)
        Label13.TabIndex = 13
        Label13.Text = "Data Parkir"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1355, 578)
        Controls.Add(Label13)
        Controls.Add(lvDataParkings)
        Controls.Add(panelPayment)
        Controls.Add(Label4)
        Controls.Add(panelInquiry)
        Controls.Add(Label3)
        Controls.Add(labelCurrentDate)
        Controls.Add(labelCurrentClock)
        Controls.Add(btnCheckIn)
        Controls.Add(cbVehicleType)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbVehicleNumber)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        panelInquiry.ResumeLayout(False)
        panelInquiry.PerformLayout()
        panelPayment.ResumeLayout(False)
        panelPayment.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbVehicleNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbVehicleType As ComboBox
    Friend WithEvents btnCheckIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents labelCurrentClock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents labelCurrentDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents panelInquiry As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProcessInquiry As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbVehicleNumberInqPanel As TextBox
    Friend WithEvents panelPayment As Panel
    Friend WithEvents btnProcessPayment As Button
    Friend WithEvents labelBasePrice As Label
    Friend WithEvents label8 As Label
    Friend WithEvents labelVehicleType As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents labelCheckInTime As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents labelBilling As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancelPayment As Button
    Friend WithEvents cbPaymentMethod As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lvDataParkings As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents labelDuration As Label
    Friend WithEvents Label13 As Label
End Class
