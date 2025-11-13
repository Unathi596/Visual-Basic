'Option Statements'
Option Strict On
Option Explicit On
Option Infer Off
<Serializable()> Public MustInherit Class UJModule

    'Instance Variables'
    Protected _ST1Mark As Integer
    Protected _ST2Mark As Integer
    Protected _ExamMark As Integer

    Public Sub New(ST1 As Integer, ST2 As Integer)
        'Build the object'
        _ST1Mark = ST1
        _ST2Mark = ST2
    End Sub

    'A Property Method'
    Public Property ExamMark() As Integer
        Get
            Return _ExamMark
        End Get
        Set(value As Integer)
            _ExamMark = value
        End Set

    End Property

    'Functions that must be Overriden by the derived classes'
    Protected MustOverride Function CalculateSM() As Integer
    Public MustOverride Function EvaluateExamEntrance() As Boolean
    Protected MustOverride Function CalculateFM() As Integer

    'A function that enables Polymorphism'
    Public Overridable Function Display() As String
        Dim Output As String = ""

        Output = "Semester Test 1: " + CStr(_ST1Mark) + vbNewLine
        Output += "Semester Test 2: " + CStr(_ST2Mark) + vbNewLine


        Return Output
    End Function
End Class
