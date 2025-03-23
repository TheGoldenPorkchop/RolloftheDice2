'Angel Nava
'Spring 2025
'RCET2265
'RolloftheDice
'https://github.com/TheGoldenPorkchop/RolloftheDice2
Option Strict On
Option Explicit On

Public Class RolloftheDice2
    Sub TestRandomness()
        Dim dieCountTotal(12) As Integer
        Dim woag As String = ""
        Dim header As String = ""
        Dim width As Integer = 6
        Dim heading() As String = {"2 |", "3 |", "4 |", "5 |", "6 |", "7 |", "8 |", "9 |", "10 |", "11 |", "12 |"}
        Dim headingBase As String = ""

        DiceDisplay.Items.Clear() 'values cleared
        DiceDisplay.Items.Add(StrDup(25, " ") & "Roll of The Dice")
        DiceDisplay.Items.Add(StrDup(66, "- "))

        For Each letter In heading
            headingBase = headingBase + (letter.PadLeft(6).PadRight(6))
        Next

        DiceDisplay.Items.Add(headingBase.PadLeft(6).PadRight(6))
        DiceDisplay.Items.Add(StrDup(66, "- "))

        For i = 1 To 1000
            dieCountTotal((RandomDieOne(1, 6)) + RandomDieTwo(1, 6)) += 1
        Next

        For i = 2 To 12
            woag = woag & CStr(dieCountTotal(i)).PadLeft(4) & " |"
        Next

        DiceDisplay.Items.Add(woag)
        DiceDisplay.Items.Add(StrDup(66, "- "))

    End Sub

    Function RandomDieOne(min As Integer, max As Integer) As Integer
        Dim woag As Single
        max += 1 'ensures max is included for math dot floor
        Randomize()
        woag = Rnd()
        woag *= max - min
        woag += min
        Return CInt(Int(woag))

    End Function

    Function RandomDieTwo(min As Integer, max As Integer) As Integer
        Dim pow As Single
        max += 1 'ensures max is included for math dot floor
        Randomize()
        pow = Rnd()
        pow *= max - min
        pow += min
        Return CInt(Int(pow))
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        TestRandomness()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DiceDisplay.Items.Clear()
    End Sub
End Class
