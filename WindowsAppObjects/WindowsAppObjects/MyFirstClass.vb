Public Class MyFirstClass





    'Public intA As Integer
    'Public intB As Integer

    'Private intC As Integer



    Public Sub AddNum(intA As Integer, intB As Integer)


        Dim intC As Integer


        intC = intA + intB


        MsgBox("the Sum of two numbers is " & intC)





    End Sub


    Private _Age As Integer


    Property Age As Integer

        Get

            Return (_Age)

            'Age = _Age


        End Get


        Set(value As Integer)

            If value >= 18 And value <= 37 Then

                _Age = value


            End If

        End Set


    End Property







End Class
