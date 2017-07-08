'The following has been formatted to be used with your own UI, to use, add a button and call Login() or the Register() 

Public Sub Login()
 
        Dim filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                         "\.\LoginData" &
                         "LoginCache.XML"

        If IO.File.Exists(filePath) Then

            'create a new xmltextreader object
            'this is the object that we will loop and will be used to read the xml file
            Dim document As XmlReader = New XmlTextReader(filePath)

            'loop through the xml file
            While (document.Read())
                Dim type = document.NodeType

                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a <UserName> tag
                    If (document.Name = "UserName") Then
                        If document.ReadInnerXml = UsernameBox.Text Then 'Note I'm assuming it's the same box for log in and to register

                            ' Go to the next line
                            document.Read()

                            If (document.Name = "UserPass") Then
                                If document.ReadInnerXml = PasswordBox.Text Then 'Again, assuming it's the same password box
                                    SuccessfulLogin.Show()


                                End If
                            End If
                        End If
                    End If
                End If
            End While
        End If
        End Sub
