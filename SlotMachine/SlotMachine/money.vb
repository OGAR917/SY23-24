Imports System.Reflection.Emit

Public Class money
    Public Event coinreturnevent(d As Integer, f As Integer, t As Integer, h As Integer)
    Public Event spinevent(p As Image)
    Public Property dollar As Integer
    Public Property five As Integer
    Public Property twenty As Integer
    Public Property hundred As Integer
    Dim _total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            _total = dollar + five * 5 + twenty * 20 + hundred * 100
            Return _total
        End Get
    End Property
    Sub coinreturn()
        RaiseEvent coinreturnevent(dollar, five, twenty, hundred)
        dollar = 0
        five = 0
        twenty = 0
        hundred = 0
    End Sub

    Sub remove()
        twenty = twenty - 1
    End Sub
    Sub insertdollar()
        dollar = dollar + 1
    End Sub
    Sub insertfive()
        five = five + 1
    End Sub
    Sub inserttwenty()
        twenty = twenty + 1
    End Sub
    Sub inserthundred()
        hundred = hundred + 1
    End Sub
    Sub spin2()
        If _total > 1 Then
            _total = _total - 1
            dollar = 0
            five = 0
            twenty = _total / 20
            hundred = 0
        End If
    End Sub
End Class
