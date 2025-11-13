'Option Statements'
Option Strict On
Option Explicit On
Option Infer Off

'Import Commands'
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
<Serializable()> Public Class frmModule

    'Global Variables'
    Private UJModule() As UJModule
    Private nModules As Integer

    'File handling Variables'
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const FN As String = "Module.dat" 'FN --> File Name'

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        nModules = CInt(InputBox("How many Modules does the student have"))

        ReDim UJModule(nModules) 'Resizing an array'

        For i As Integer = 1 To nModules
            Dim ST1, ST2 As Integer 'Some Local Variables

            Try
                Dim Choice As Integer = CInt(InputBox("1. Business Management 1A " + vbNewLine + "2. Mathematics 1A " + vbNewLine + "3. Informatics 1A"))

                Select Case Choice
                    Case 1
                        ST1 = CInt(InputBox("Enter the mark for Semester Test 1 for Business Management 1A"))
                        ST2 = CInt(InputBox("Enter the mark for Semester Test 2 for Business Management 1A"))
                        Dim Assignment As Integer = CInt(InputBox("Enter the mark you got for your assignment"))
                        UJModule(i) = New BusinessManagement1A(ST1, ST2, Assignment) 'Upcasting'
                    Case 2
                        ST1 = CInt(InputBox("Enter the mark for Semester Test 1 for Mathematics 1A"))
                        ST2 = CInt(InputBox("Enter the mark for Semester Test 2 for Mathematics 1A"))
                        Dim nClassTest As Integer = CInt(InputBox("How many classtests are you expected to write this semester??"))
                        UJModule(i) = New Mathematics_1A(ST1, ST2, nClassTest) 'Upcasting'
                    Case 3
                        ST1 = CInt(InputBox("Enter the mark for Semester Test 1 for Informatics 1A"))
                        ST2 = CInt(InputBox("Enter the mark for Semester Test 2 for Informatics 1A"))
                        Dim nP As Integer = CInt(InputBox("How many Practicals are you expected to do this semester??"))
                        UJModule(i) = New Informatics_1A(ST1, ST2, nP) 'Upcasting'
                    Case Else
                        MsgBox("Invalid Number")
                End Select
                'Catching Exceptions'
            Catch eix As InvalidCastException
                MsgBox(eix.Message)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next i
    End Sub

    Private Sub btnCT_Click(sender As Object, e As EventArgs) Handles btnCT.Click
        Dim tempMath As Mathematics_1A

        For i As Integer = 1 To nModules
            tempMath = TryCast(UJModule(i), Mathematics_1A) 'Downcasting'

            If tempMath IsNot Nothing Then

                For j As Integer = 1 To tempMath.nCT
                    tempMath.ClassTests(j) = CInt(InputBox("Enter the mark for Classtest " + CStr(j)))
                Next j

                If tempMath.EvaluateExamEntrance() Then 'Check if the student qualifies for the exam'
                    tempMath.ExamMark = CInt(InputBox("Enter the mark you got for the exam for Mathematics 1A"))
                Else
                    MsgBox("You don't qualify for the exam")
                    tempMath.ExamMark = 0
                End If
            End If

        Next i
    End Sub

    Private Sub btnPrac_Click(sender As Object, e As EventArgs) Handles btnPrac.Click
        Dim tempIFM As Informatics_1A

        For i As Integer = 1 To nModules
            tempIFM = TryCast(UJModule(i), Informatics_1A) 'Downcasting'

            If tempIFM IsNot Nothing Then
                For j As Integer = 1 To tempIFM.nP
                    tempIFM.Practicals(j) = CInt(InputBox("Enter the mark for Practical " + CStr(j)))
                Next j

                If tempIFM.EvaluateExamEntrance() Then 'Check if the student qualifies for the exam'
                    tempIFM.ExamMark = CInt(InputBox("Enter the mark you got for the exam for Informatics 1A"))
                Else
                    MsgBox("You don't qualify for the exam")
                    tempIFM.ExamMark = 0
                End If
            End If
        Next i
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        txtDisplay.Clear()

        For i As Integer = 1 To nModules
            txtDisplay.AppendText(UJModule(i).Display()) 'Polymorphism'
        Next i

    End Sub

    Private Sub btnBusiness_Click(sender As Object, e As EventArgs) Handles btnBusiness.Click
        Dim tempBusiness As BusinessManagement1A

        For i As Integer = 1 To nModules
            tempBusiness = TryCast(UJModule(i), BusinessManagement1A) 'Downcasting'

            If tempBusiness IsNot Nothing Then
                If tempBusiness.EvaluateExamEntrance Then 'Check if the student did qualify for the exam
                    tempBusiness.ExamMark = CInt(InputBox("Enter exam mark"))
                Else
                    MsgBox("You don't qualify for the exam")
                    tempBusiness.ExamMark = 0
                End If
            End If
        Next
    End Sub

    Private Sub btmSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Creating the sequential file'
        FS = New FileStream(FN, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter() 'Used to convert the data to binary'

        For i As Integer = 1 To UJModule.Length - 1
            BF.Serialize(FS, UJModule(i)) 'Serializing all UJModule objects'
        Next i

        FS.Close() 'Cut the connection'
        FS = Nothing
        BF = Nothing

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Open the file to read'
        FS = New FileStream(FN, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()

        Dim tempModule As UJModule

        While FS.Position < FS.Length
            tempModule = TryCast(BF.Deserialize(FS), UJModule) 'DownCast'

            If tempModule IsNot Nothing Then
                txtDisplay.AppendText(tempModule.Display())
            End If

        End While

        FS.Close() 'Cut the Connection'
        FS = Nothing
        BF = Nothing
    End Sub
End Class
