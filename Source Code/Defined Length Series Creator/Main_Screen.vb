Public Class Main_Screen

    Private Sub Error_Handler(ByVal ex As Exception, ByVal message As String)
        MsgBox("The following error was trapped from " & message & ": " & vbCrLf & ex.Message & vbCrLf & vbCrLf & "{" & ex.ToString & "}", MsgBoxStyle.Exclamation, "Error Encountered")
    End Sub

    Private Function StripAlphaNumerics(ByVal input As String) As String
        Dim output As String = ""
        Try
            If input.Length > 0 Then
                Dim iterate As CharEnumerator
                iterate = input.GetEnumerator()

                While iterate.MoveNext = True
                    If (IsNumeric(iterate.Current) = True) Then
                        output = output & iterate.Current
                    End If
                End While
            End If

        Catch ex As Exception
            Error_Handler(ex, "StripAlphaNumerics")
        End Try
        Return output
    End Function

    Private Sub InputStart_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputStart.TextChanged, InputEnd.TextChanged, InputStep.TextChanged, InputLength.TextChanged
        Try
            Dim text As TextBox = sender
            If text.Text.Length > 0 Then
                If IsNumeric(text.Text) = False Then
                    text.Text = StripAlphaNumerics(text.Text)
                    text.SelectionStart = text.Text.Length
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Input Text Change")
        End Try
    End Sub

    Private Sub ButtonLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLaunch.Click
        Try
            OutputSeries.Clear()
            If InputStart.Text.Length > 0 And InputEnd.Text.Length > 0 And InputStep.Text.Length > 0 And InputLength.Text.Length > 0 Then
                Dim result As DialogResult
                result = MsgBox("Do you wish to write this series to a text file?", MsgBoxStyle.YesNo, "Save Results?")
                If result = Windows.Forms.DialogResult.Yes Then
                    SaveFileDialog1.FileName = "GeneratedSeries.txt"
                    result = SaveFileDialog1.ShowDialog
                    If Not result = Windows.Forms.DialogResult.Cancel Then
                        Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter(SaveFileDialog1.FileName, False)
                        For counter As Integer = Integer.Parse(InputStart.Text) To Integer.Parse(InputEnd.Text) Step Integer.Parse(InputStep.Text)
                            Dim towrite As String = ""
                            towrite = counter
                            While towrite.Length < Integer.Parse(InputLength.Text)
                                towrite = "0" & towrite
                            End While
                            OutputSeries.Text = OutputSeries.Text & towrite
                            If Not counter = Integer.Parse(InputEnd.Text) Then
                                OutputSeries.Text = OutputSeries.Text & vbCrLf
                            End If
                            filewriter.WriteLine(towrite)
                        Next
                        filewriter.Flush()
                        filewriter.Close()
                        filewriter = Nothing
                    Else
                        For counter As Integer = Integer.Parse(InputStart.Text) To Integer.Parse(InputEnd.Text) Step Integer.Parse(InputStep.Text)
                            Dim towrite As String = ""
                            towrite = counter
                            While towrite.Length < Integer.Parse(InputLength.Text)
                                towrite = "0" & towrite
                            End While
                            OutputSeries.Text = OutputSeries.Text & towrite
                            If Not counter = Integer.Parse(InputEnd.Text) Then
                                OutputSeries.Text = OutputSeries.Text & vbCrLf
                            End If

                        Next
                    End If

                Else

                    For counter As Integer = Integer.Parse(InputStart.Text) To Integer.Parse(InputEnd.Text) Step Integer.Parse(InputStep.Text)
                        Dim towrite As String = ""
                        towrite = counter
                        While towrite.Length < Integer.Parse(InputLength.Text)
                            towrite = "0" & towrite
                        End While
                        OutputSeries.Text = OutputSeries.Text & towrite
                        If Not counter = Integer.Parse(InputEnd.Text) Then
                            OutputSeries.Text = OutputSeries.Text & vbCrLf
                        End If

                    Next
                End If
            Else
                MsgBox("Please ensure all input options are filled in correctly")
            End If
            MsgBox("Operation Successfully Completed")
        Catch ex As Exception
            Error_Handler(ex, "Operation Launch")
            MsgBox("Operation Failed")
        End Try
    End Sub
End Class
