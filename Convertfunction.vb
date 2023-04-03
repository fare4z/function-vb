Public Class Convertfunction
    Public Function DoConvert(ByVal strConvert As String) As String
        Dim ConvertUpper As String
        ConvertUpper = StrConv(strConvert, VbStrConv.Uppercase)
        DoConvert = ConvertUpper
    End Function

    Public Sub DoMessageBox()
        MsgBox("Accept", MsgBoxStyle.Information, "Successfully")
    End Sub

    Public Function checkError2(ByVal txtBox As String) As Boolean
        Dim textboxdata As String
        textboxdata = txtBox
        If textboxdata = "" Then
            MsgBox("Blank text box")
            checkError2 = False
        Else
            MsgBox("Text box Validated")
            checkError2 = True
        End If

    End Function

    Public Function AddTwoNumbers(ByVal first As Integer, ByVal second As Integer) As Integer
        Dim answer As Integer
        answer = first + second
        AddTwoNumbers = answer
    End Function


    Public Function checkGender(ByVal nric As String)

        Dim st As String = nric
        Dim jantina As String
        Dim subst As String = st.Substring(11, 1)

        If subst Mod 2 = 0 Then
            jantina = "Perempuan"
        Else
            jantina = "Lelaki"
        End If

        Return jantina

    End Function

    Public Function checkDob(ByVal nric As String)
        Dim st As String = nric

        Dim substr As String = st.Substring(0, 5)

        Dim year As Integer = Integer.Parse(st.Substring(0, 2))
        Dim month As Integer = Integer.Parse(st.Substring(2, 2))
        Dim day As Integer = Integer.Parse(st.Substring(4, 2))

        ' Convert the two-digit year to a four-digit year
        If year >= 0 And year <= 29 Then
            year += 2000
        ElseIf year >= 30 And year <= 99 Then
            year += 1900
        End If

        Return New DateTime(year, month, day)

    End Function

    Public Function checkState(ByVal nric As String)

        Dim stateCode As String = nric.Substring(6, 2)
        Dim stateName As String

        Select Case stateCode
            Case "01", "21", "22", "23", "24"
                stateName = "Johor"
            Case "02", "25", "26", "27"
                stateName = "Kedah"
            Case "03", "28", "29"
                stateName = "Kelantan"
            Case "04", "30"
                stateName = "Melaka"
            Case "05", "31", "59"
                stateName = "Negeri Sembilan"
            Case "06", "32", "33"
                stateName = "Pahang"
            Case "07", "34", "35"
                stateName = "Pulau Pinang"
            Case "08", "36", "37", "38", "39"
                stateName = "Perak"
            Case "09", "40"
                stateName = "Perlis"
            Case "10", "41", "42", "43", "44"
                stateName = "Selangor"
            Case "11", "45", "46"
                stateName = "Terengganu"
            Case "12", "47", "48", "49"
                stateName = "Sabah"
            Case "13", "50", "51", "52", "53"
                stateName = "Sarawak"
            Case "14", "54", "55", "56", "57"
                stateName = "Wilayah Persekutuan (Kuala Lumpur)"
            Case "15", "58"
                stateName = "Wilayah Persekutuan (Labuan)"
            Case "16"
                stateName = "Wilayah Persekutuan (Putrajaya)"
            Case "82"
                stateName = "Negeri Tidak Diketahui"
            Case Else
                stateName = "Invalid State Code"
        End Select

        Return stateName

    End Function

End Class
