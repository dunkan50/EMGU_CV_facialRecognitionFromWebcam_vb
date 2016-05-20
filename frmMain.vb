Option Explicit On
Option Strict On

Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure
Imports Emgu.CV.CvEnum
Imports Emgu.CV.UI

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


Public Class frmMain
    Dim originalImage As Mat
    ' Dim grayscaleImage As UMat

    Dim acFace As MCvAvgComp()
    Dim acEye As MCvAvgComp()
    Dim hcFace As CascadeClassifier
    Dim hcEye As CascadeClassifier

    Dim getCamera As Capture
    Dim gettingProcess As Boolean = False


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub tbFace_Click(sender As Object, e As EventArgs) Handles tbFace.Click
        Dim drFace As DialogResult

        drFace = ofdFace.ShowDialog()
        tbFace.Text = ofdFace.FileName

        If (drFace = DialogResult.OK And ofdFace.FileName <> "") Then
            tbFace.Text = ofdFace.FileName

        End If
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Private Sub tbEye_Click(sender As Object, e As EventArgs) Handles tbEye.Click
        Dim drEye As DialogResult

        drEye = ofdEye.ShowDialog()
        tbEye.Text = ofdEye.FileName

        If (drEye = DialogResult.OK And ofdEye.FileName <> "") Then
            tbEye.Text = ofdEye.FileName

        End If
    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            getCamera = New Capture()


        Catch ex As Exception

            MessageBox.Show("Can not access webcam, error:" + Environment.NewLine + Environment.NewLine + ex.Message + Environment.NewLine + Environment.NewLine + "exiting Program.")
            Environment.Exit(0)

        End Try

        AddHandler Application.Idle, New EventHandler(AddressOf Me.processNdUpdateFrame)
        gettingProcess = True

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Sub processNdUpdateFrame(sender As Object, e As EventArgs)

        originalImage = getCamera.QueryFrame()

        If (originalImage Is Nothing) Then
            MessageBox.Show("can not read the image from the webcam " + Environment.NewLine + Environment.NewLine + ("exitting program"))
            Environment.Exit(0)

        End If
        Dim grayscaleimage As New Mat(originalImage.Size, DepthType.Cv8U, 1)


        CvInvoke.CvtColor(originalImage, grayscaleImage, CvEnum.ColorConversion.Bgr2Gray)

        'hcEye = New CascadeClassifier("tbEye.Text")

        Dim hcFace As New CascadeClassifier("C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_frontalface_default.xml")

        'hcFace = New CascadeClassifier("tbFace.Text")

        Dim hcEye As New CascadeClassifier("C:\Emgu\emgucv-windesktop 3.1.0.2282\opencv\data\haarcascades\haarcascade_eye.xml")

        'tbFace.Text
        For Each faces As Rectangle In hcFace.DetectMultiScale(grayscaleimage, 1.1, 20, New Size(20, 20), Size.Empty)
            CvInvoke.Rectangle(originalImage, faces, New MCvScalar(0, 255, 0))

        Next

        For Each eye As Rectangle In hcEye.DetectMultiScale(grayscaleimage, 1.1, 25, New Size(20, 20), Size.Empty)
            CvInvoke.Rectangle(originalImage, eye, New MCvScalar(255, 0, 0))

        Next

        ibOriginal.Image = originalImage


    End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    Private Sub btnControl_Click(sender As Object, e As EventArgs) Handles btnControl.Click

        If (gettingProcess = True) Then
            RemoveHandler Application.Idle, New EventHandler(AddressOf Me.processNdUpdateFrame)
            gettingProcess = False
            btnControl.Text = " Resume "

        Else
            AddHandler Application.Idle, New EventHandler(AddressOf Me.processNdUpdateFrame)
            gettingProcess = True
            btnControl.Text = " Pause "
        End If

    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


End Class
