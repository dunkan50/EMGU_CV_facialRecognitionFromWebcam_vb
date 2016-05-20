<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lbHaarFace = New System.Windows.Forms.Label()
        Me.lblEye = New System.Windows.Forms.Label()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.ibOriginal = New Emgu.CV.UI.ImageBox()
        Me.tbFace = New System.Windows.Forms.TextBox()
        Me.tbEye = New System.Windows.Forms.TextBox()
        Me.tblOuter = New System.Windows.Forms.TableLayoutPanel()
        Me.ofdFace = New System.Windows.Forms.OpenFileDialog()
        Me.ofdEye = New System.Windows.Forms.OpenFileDialog()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblOuter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbHaarFace
        '
        Me.lbHaarFace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbHaarFace.AutoSize = True
        Me.lbHaarFace.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHaarFace.Location = New System.Drawing.Point(3, 0)
        Me.lbHaarFace.Name = "lbHaarFace"
        Me.lbHaarFace.Size = New System.Drawing.Size(81, 33)
        Me.lbHaarFace.TabIndex = 0
        Me.lbHaarFace.Text = "Face File"
        Me.lbHaarFace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEye
        '
        Me.lblEye.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEye.AutoSize = True
        Me.lblEye.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEye.Location = New System.Drawing.Point(3, 33)
        Me.lblEye.Name = "lblEye"
        Me.lblEye.Size = New System.Drawing.Size(62, 33)
        Me.lblEye.TabIndex = 1
        Me.lblEye.Text = "Eye FIle"
        Me.lblEye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnControl
        '
        Me.btnControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnControl.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControl.Location = New System.Drawing.Point(3, 69)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(81, 30)
        Me.btnControl.TabIndex = 4
        Me.btnControl.Text = " Pause "
        Me.btnControl.UseVisualStyleBackColor = True
        '
        'ibOriginal
        '
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tblOuter.SetColumnSpan(Me.ibOriginal, 2)
        Me.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ibOriginal.Enabled = False
        Me.ibOriginal.Location = New System.Drawing.Point(3, 105)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(880, 418)
        Me.ibOriginal.TabIndex = 2
        Me.ibOriginal.TabStop = False
        '
        'tbFace
        '
        Me.tbFace.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFace.Location = New System.Drawing.Point(90, 3)
        Me.tbFace.Name = "tbFace"
        Me.tbFace.Size = New System.Drawing.Size(766, 27)
        Me.tbFace.TabIndex = 5
        Me.tbFace.Text = "C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_frontal" &
    "face_default.xml"
        '
        'tbEye
        '
        Me.tbEye.Font = New System.Drawing.Font("Myriad Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEye.Location = New System.Drawing.Point(90, 36)
        Me.tbEye.Name = "tbEye"
        Me.tbEye.Size = New System.Drawing.Size(766, 27)
        Me.tbEye.TabIndex = 6
        Me.tbEye.Text = "C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_eye.xml" &
    ""
        '
        'tblOuter
        '
        Me.tblOuter.ColumnCount = 2
        Me.tblOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.88764!))
        Me.tblOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.11236!))
        Me.tblOuter.Controls.Add(Me.lbHaarFace, 0, 0)
        Me.tblOuter.Controls.Add(Me.ibOriginal, 0, 3)
        Me.tblOuter.Controls.Add(Me.tbEye, 1, 1)
        Me.tblOuter.Controls.Add(Me.btnControl, 0, 2)
        Me.tblOuter.Controls.Add(Me.lblEye, 0, 1)
        Me.tblOuter.Controls.Add(Me.tbFace, 1, 0)
        Me.tblOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblOuter.Location = New System.Drawing.Point(0, 0)
        Me.tblOuter.Name = "tblOuter"
        Me.tblOuter.RowCount = 4
        Me.tblOuter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblOuter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblOuter.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblOuter.Size = New System.Drawing.Size(886, 526)
        Me.tblOuter.TabIndex = 7
        '
        'ofdFace
        '
        Me.ofdFace.FileName = "OpenFileDialog1"
        '
        'ofdEye
        '
        Me.ofdEye.FileName = "OpenFileDialog2"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 526)
        Me.Controls.Add(Me.tblOuter)
        Me.Name = "frmMain"
        Me.Text = "facialReconiton"
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblOuter.ResumeLayout(False)
        Me.tblOuter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbHaarFace As Label
    Friend WithEvents lblEye As Label
    Friend WithEvents btnControl As Button
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
    Friend WithEvents tbFace As TextBox
    Friend WithEvents tbEye As TextBox
    Friend WithEvents tblOuter As TableLayoutPanel
    Friend WithEvents ofdFace As OpenFileDialog
    Friend WithEvents ofdEye As OpenFileDialog
End Class
