Public Class frmOrder
    'this program calculates bill for patients of Nutritional Associates of New Jersey
    
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim patientName As String = ""
        Dim firstName As String = ""
        Dim lastName As String = ""
        Dim address As String = ""
        Dim city As String = ""
        Dim BloodKits As Integer = CInt(txtBloodKits.Text)
        Dim HeartKits As Integer = CInt(txtHeartKits.Text)
        Dim ActivityJournals As Integer = CInt(txtActivityMonitors.Text)
        Dim IntakeJournals As Integer = CInt(txtActivityMonitors.Text)
        Dim BothJournals As Integer = CInt(txtBothJournals.Text)
        Dim price As Double

        lstInvoice.Items.Clear()

        patientName = txtName.Text
        city = txtCity.Text

        'reverse the order of customer name
        RevPatientName(firstName, lastName)

        lstInvoice.Items.Add("Nutritional Associates of New Jersey: " & firstName & " " & lastName)
        lstInvoice.Items.Add("Invoice Number: NA-" & InvoiceNumber(patientName, city))
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Name: " & firstName & " " & lastName)
        lstInvoice.Items.Add("Address: " & txtAddress.Text)
        lstInvoice.Items.Add("City: " & txtCity.Text)
        lstInvoice.Items.Add("")
        lstInvoice.Items.Add("Number of blood pressure kits: " & txtBloodKits.Text)
        lstInvoice.Items.Add("Number of heart monitor kits: " & txtHeartKits.Text)
        lstInvoice.Items.Add("Number of activity monitor kits: " & txtActivityMonitors.Text)
        lstInvoice.Items.Add("Number of food intake journals: " & txtIntakeJournals.Text)
        lstInvoice.Items.Add("Number of both food intake and ")
        lstInvoice.Items.Add("            acitivity journals: " & txtBothJournals.Text)
        lstInvoice.Items.Add("")

        'single blood pressure kit is 129
        'single heart monitor kit is 95
        'single activity monitor is 109
        'single food intake journal is 4.99
        'single both food and acitvity journal is 9.99
        price = (BloodKits * 129 + HeartKits * 95 + ActivityJournals * 109) +
                (IntakeJournals * 4.99 + BothJournals * 9.99)

        lstInvoice.Items.Add("      Price: " & price.ToString("C"))

        'sales tax is seven percent
        lstInvoice.Items.Add("  Sales Tax: " & (0.07 * price).ToString("C"))
        lstInvoice.Items.Add("           --------------")
        lstInvoice.Items.Add("Total Price: " & (price + 0.07 * price).ToString("C"))
    End Sub

    Function InvoiceNumber(patientName As String, city As String) As String
        'for invoice number we need last two letters of last name
        'and last four digits of zip code
        Dim lastTwoLetters As String = ""
        Dim lastFourDigits As String = ""
        Dim firstSpace, secondSpace As Integer 'there is total two spaces

        lastTwoLetters = patientName.Substring(0, 2).ToUpper
        firstSpace = txtCity.Text.IndexOf(" ")
        secondSpace = txtCity.Text.IndexOf(" ", firstSpace + 1)
        lastFourDigits = txtCity.Text.Substring(secondSpace + 2)
        Return lastTwoLetters & lastFourDigits
    End Function

    Function RevPatientName(ByRef firstName As String, ByRef lastName As String) As String
        Dim spaceFirst As Integer
        Dim reversedPatientName As String

        spaceFirst = txtName.Text.IndexOf(" ")
        firstName = txtName.Text.Substring(spaceFirst)
        lastName = txtName.Text.Substring(0, spaceFirst - 1)
        reversedPatientName = firstName & lastName
        Return reversedPatientName
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'this part clears all text boxes and list box
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtBloodKits.Clear()
        txtHeartKits.Clear()
        txtActivityMonitors.Clear()
        txtIntakeJournals.Clear()
        txtBothJournals.Clear()
        lstInvoice.Items.Clear()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'this part creates quit button
        Me.Close()
    End Sub

    'Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class
