Public Class frmFileComparison

    Private Sub ButnFIleComp_Click(sender As System.Object, e As System.EventArgs) Handles ButnFIleComp.Click


        ChrtCryptAnalytics.Series("ROUND").Points.Clear()

        'Chart Varabiles 

        Dim xArray(4) As String
        Dim yArray(4) As Double


       
        '   ChrtCryptAnalytics.Series("ROUNDS").XAxisType = DataVisualization.Charting.AxisType.Primary
        ChrtCryptAnalytics.Series("ROUND").ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
        ChrtCryptAnalytics.Series("ROUND").IsValueShownAsLabel = True


        'Set lables

        ChrtCryptAnalytics.ChartAreas(0).AxisX.Title = "> > > > > > > > R O U N D S > > > > > >"
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Center
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleForeColor = Color.Blue
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 12)

        ChrtCryptAnalytics.ChartAreas(0).AxisY.Title = "> > P E R C E N T A G E > > > "
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Center
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Rotated270
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleForeColor = Color.Blue
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleFont = New Font("Arial", 12)



        Dim byteSource() As Byte
        Dim byteEncrypt() As Byte
        Dim strPath As String = "C:\FSO\FileEncrypt"

        Dim dblPer As Double

        Dim intCnt As Integer = 0

        Dim strChangeVal As String

        Dim intXOR As Integer

        Dim intTotalBitChange As Integer

       
        Dim strOutput As String = ""

        byteSource = My.Computer.FileSystem.ReadAllBytes(strPath & "\one.jpg")

        Dim intTotalBits As Integer = byteSource.Length * 8



        For j As Integer = 1 To 4

            PGEncrypt.Value = j
            strOutput = strOutput & "Round " & j & " = "
            intTotalBitChange = 0

            byteEncrypt = My.Computer.FileSystem.ReadAllBytes(strPath & "\e" & j & "one.txt")

            For i As Integer = 0 To byteSource.Length - 1


                ' Exor Values
                intXOR = byteSource(i) Xor byteEncrypt(i)

                ' Check Changed Bits
                strChangeVal = ToBinary(intXOR)


                ' Count bit Changes [Value set to 1] 

                intTotalBitChange = intTotalBitChange + CountOnes(strChangeVal)




            Next




            dblPer = Convert.ToDouble(intTotalBitChange / intTotalBits) * 100

            yArray(j) = Math.Round(dblPer, 3)
            xArray(j) = "Round " & j


            strOutput = strOutput & dblPer & vbCrLf

        Next


        MsgBox(strOutput)


        For i As Integer = 1 To 4


            ChrtCryptAnalytics.Series("ROUND").Points.AddXY(xArray(i), yArray(i))


        Next


    End Sub

    Private Function ToBinary(dec As Integer) As String

        Dim bin As Integer
        Dim output As String = ""

        While dec <> 0
            If dec Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            dec = dec \ 2
            output = Convert.ToString(bin) & output
        End While
        If output Is Nothing Then
            Return "0"
        Else
            Return output
        End If
    End Function


    Function CountOnes(strBinary As String) As Integer


        Dim chrBinArry() As Char

        Dim intCntOne As Integer = 0

        chrBinArry = strBinary.ToCharArray

        For Each chrVal As Char In chrBinArry

            If chrVal = "1" Then
                intCntOne = intCntOne + 1

            End If


        Next

        Return intCntOne

    End Function

    Private Sub frmFileComparison_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        ChrtCryptAnalytics.Series.Add("ROUND")


    End Sub

    Private Sub utnCommulative_Click(sender As System.Object, e As System.EventArgs) Handles ButnCommulative.Click
        'Commulative Compare
        ChrtCryptAnalytics.Series("ROUND").Points.Clear()


        'Chart Varabiles 

        Dim xArray(4) As String
        Dim yArray(4) As Double



        '   ChrtCryptAnalytics.Series("ROUNDS").XAxisType = DataVisualization.Charting.AxisType.Primary
        ChrtCryptAnalytics.Series("ROUND").ChartType = DataVisualization.Charting.SeriesChartType.SplineArea
        ChrtCryptAnalytics.Series("ROUND").IsValueShownAsLabel = True


        'Set lables

        ChrtCryptAnalytics.ChartAreas(0).AxisX.Title = "> > > > > > > > R O U N D S > > > > > >"
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleAlignment = StringAlignment.Center
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TextOrientation = DataVisualization.Charting.TextOrientation.Horizontal
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleForeColor = Color.Blue
        ChrtCryptAnalytics.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 12)

        ChrtCryptAnalytics.ChartAreas(0).AxisY.Title = "> > P E R C E N T A G E > > > "
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleAlignment = StringAlignment.Center
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TextOrientation = DataVisualization.Charting.TextOrientation.Rotated270
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleForeColor = Color.Blue
        ChrtCryptAnalytics.ChartAreas(0).AxisY.TitleFont = New Font("Arial", 12)



        Dim byteSource() As Byte = Nothing
        Dim byteEncrypt() As Byte = Nothing
        Dim strPath As String = "C:\FSO\FileEncrypt"

        Dim dblPer As Double

        Dim intCnt As Integer = 0

        Dim strChangeVal As String

        Dim intXOR As Integer

        Dim intTotalBitChange As Integer


        Dim strOutput As String = ""


        Dim intTotalBits As Integer



        For j As Integer = 1 To 4


            Select Case j


                Case 1

                    byteSource = My.Computer.FileSystem.ReadAllBytes(strPath & "\one.jpg")
                    byteEncrypt = My.Computer.FileSystem.ReadAllBytes(strPath & "\e1one.txt")

                Case 2

                    byteSource = My.Computer.FileSystem.ReadAllBytes(strPath & "\e1one.txt")
                    byteEncrypt = My.Computer.FileSystem.ReadAllBytes(strPath & "\e2one.txt")
                Case 3

                    byteSource = My.Computer.FileSystem.ReadAllBytes(strPath & "\e2one.txt")
                    byteEncrypt = My.Computer.FileSystem.ReadAllBytes(strPath & "\e3one.txt")
                Case 4

                    byteSource = My.Computer.FileSystem.ReadAllBytes(strPath & "\e3one.txt")
                    byteEncrypt = My.Computer.FileSystem.ReadAllBytes(strPath & "\e4one.txt")

            End Select


            intTotalBits = byteSource.Length * 8

            PGEncrypt.Value = j

            strOutput = strOutput & "Round " & j & " = "

            intTotalBitChange = 0

            For i As Integer = 0 To byteSource.Length - 1


                ' Exor Values
                intXOR = byteSource(i) Xor byteEncrypt(i)

                ' Check Changed Bits
                strChangeVal = ToBinary(intXOR)


                ' Count bit Changes [Value set to 1] 

                intTotalBitChange = intTotalBitChange + CountOnes(strChangeVal)




            Next




            dblPer = Convert.ToDouble(intTotalBitChange / intTotalBits) * 100

            yArray(j) = Math.Round(dblPer, 3)
            xArray(j) = "Round " & j


            strOutput = strOutput & dblPer & vbCrLf

        Next


        MsgBox(strOutput)


        For i As Integer = 1 To 4


            ChrtCryptAnalytics.Series("ROUND").Points.AddXY(xArray(i), yArray(i))


        Next


















    End Sub
End Class
