'Option Statements'
Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public Class BusinessManagement1A
    Inherits UJModule 'Inheritance'

    Private _Assignment As Integer
    Public Sub New(ST1 As Integer, ST2 As Integer, Assignment As Integer)
        MyBase.New(ST1, ST2)

        _Assignment = Assignment
    End Sub

    Public Property Assignment As Integer
        Get
            Return _Assignment
        End Get
        Set(value As Integer)
            _Assignment = value
        End Set
    End Property

    Public Overrides Function EvaluateExamEntrance() As Boolean
        If CalculateSM() >= 40 Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overrides Function CalculateFM() As Integer
        Dim FinalMark As Integer

        FinalMark = CInt((0.5 * _ExamMark) + (0.5 * CalculateSM()))

        Return FinalMark

    End Function

    Protected Overrides Function CalculateSM() As Integer
        Return CInt((0.4 * _ST1Mark) + (0.4 * _ST2Mark) + (0.2 * _Assignment))
    End Function

    Public Overrides Function Display() As String
        Dim Output As String = ""

        Output = "~~Business Management 1A~~" + vbNewLine
        Output += MyBase.Display()
        Output += "Assignment: " + CStr(_Assignment) + vbNewLine
        Output += "Semester Mark: " + CStr(CalculateSM()) + vbNewLine
        Output += "Exam Mark: " + CStr(_ExamMark) + vbNewLine
        Output += "Final Mark: " + CStr(CalculateFM()) + vbNewLine + vbNewLine

        Return Output
    End Function
End Class
