'Option Statements'
Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class Mathematics_1A
    Inherits UJModule 'Inheritance'

    Private _ClassTests() As Integer
    Private _nCT As Integer

    Public Sub New(ST1 As Integer, ST2 As Integer, nCT As Integer)
        MyBase.New(ST1, ST2)

        _nCT = nCT

        ReDim _ClassTests(_nCT) 'Resizing an array'

    End Sub

    Public Property nCT() As Integer
        Get
            Return _nCT
        End Get
        Set(value As Integer)
            _nCT = value
        End Set
    End Property

    'A property method that allows us to access a single element at a time in an array'
    Public Property ClassTests() As Integer()
        Get
            Return _ClassTests
        End Get
        Set(value As Integer())
            For i As Integer = 1 To _ClassTests.Length - 1
                _ClassTests(i) = value(i)
            Next i
        End Set
    End Property

    'A function that calculates the Class Test Average'
    Private Function ClassTest() As Double
        Dim Total As Integer = 0
        Dim Average As Double

        For i As Integer = 1 To _ClassTests.Length - 1
            Total += _ClassTests(i)
        Next i

        Average = Total / _nCT

        Return Average
    End Function

    Protected Overrides Function CalculateSM() As Integer
        Return CInt((0.4 * _ST1Mark) + (0.4 * _ST2Mark) + (0.2 * ClassTest()))
    End Function

    Public Overrides Function EvaluateExamEntrance() As Boolean
        If CalculateSM() >= 40 Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overrides Function CalculateFM() As Integer
        Return CInt((0.5 * _ExamMark) + (0.5 * CalculateSM()))
    End Function

    Public Overrides Function Display() As String
        Dim Output As String = ""

        Output += "~~Mathematics 1A~~" + vbNewLine
        Output += MyBase.Display()
        For i As Integer = 1 To _ClassTests.Length - 1
            Output += "ClassTest " + CStr(i) + ": " + CStr(_ClassTests(i)) + vbNewLine
        Next i
        Output += "Semester Mark: " + CStr(CalculateSM()) + vbNewLine
        Output += "Exam Mark: " + CStr(_ExamMark) + vbNewLine
        Output += "Final Mark: " + CStr(CalculateFM()) + vbNewLine + vbNewLine

        Return Output
    End Function
End Class
