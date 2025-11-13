'Option Statements'
Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Informatics_1A
    Inherits UJModule 'Inheritance'

    'Instance Variables'
    Private _Practicals() As Integer
    Private _nP As Integer

    Public Sub New(ST1 As Integer, ST2 As Integer, nP As Integer)
        MyBase.New(ST1, ST2)

        _nP = nP

        ReDim _Practicals(_nP)


    End Sub

    Public Property nP() As Integer
        Get
            Return _nP
        End Get
        Set(value As Integer)
            _nP = value
        End Set
    End Property
    Public Property Practicals() As Integer()
        Get
            Return _Practicals
        End Get
        Set(value As Integer())
            For i As Integer = 1 To _Practicals.Length - 1
                _Practicals(i) = value(i)
            Next i
        End Set
    End Property

    Public Function CalculatePCM() As Integer
        Dim Total As Integer = 0
        Dim A, B As Double
        Dim PCM As Integer

        For i As Integer = 1 To _Practicals.Length - 1
            Total += _Practicals(i)
        Next i

        A = ((Total \ _nP) * 10 / 75)
        B = _ST2Mark * 65 / 75

        PCM = CInt(A + B)

        Return PCM
    End Function
    Public Overrides Function EvaluateExamEntrance() As Boolean
        If CalculateSM() >= 40 And CalculatePCM() >= 50 Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overrides Function CalculateSM() As Integer
        Dim Total As Integer = 0
        Dim Average As Double

        For i As Integer = 1 To _Practicals.Length - 1
            Total += _Practicals(i)
        Next i

        Average = Total / _nP

        Return CInt((0.25 * _ST1Mark) + (0.65 * _ST2Mark) + (0.1 * Average))
    End Function

    Protected Overrides Function CalculateFM() As Integer
        Return CInt((0.5 * CalculateSM()) + (0.5 * _ExamMark))
    End Function

    Public Overrides Function Display() As String
        Dim Output As String = ""

        Output = "~~~Informatics 1A~~~" + vbNewLine
        Output += MyBase.Display()
        For i As Integer = 1 To _Practicals.Length - 1
            Output += "Practical " + CStr(i) + ": " + CStr(_Practicals(i)) + vbNewLine
        Next i
        Output += "Semester Mark: " + CStr(CalculateSM()) + vbNewLine
        Output += "PCM: " + CStr(CalculatePCM()) + vbNewLine
        Output += "Exam Mark: " + CStr(_ExamMark) + vbNewLine
        Output += "Final Mark: " + CStr(CalculateFM()) + vbNewLine + vbNewLine

        Return Output
    End Function
End Class
