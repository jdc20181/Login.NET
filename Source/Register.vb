'The following has been formatted to be used with your own UI, to use, add a button and call Login() or the Register() 

' The following requires that the XML file and the folder exist, change the name accordingly. 

' You also need to import: System, and System.xml
Public Sub Register()
        Dim filePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) &
                         "\.\LoginData" &
                        "LoginCache.xml"
      Dim xmlfile As New XmlDocument
            'loading our xml
            xmlfile.Load(filePath)

            'creating tags
            Dim UserInfo As XmlElement = xmlfile.CreateElement("User")
            Dim UserName As XmlElement = xmlfile.CreateElement("UserName")
            Dim UserPass As XmlElement = xmlfile.CreateElement("UserPass")

            'create information that goes into the tags
            Dim uPass As XmlText = xmlfile.CreateTextNode(PasswordBox.Text)
            Dim uName As XmlText = xmlfile.CreateTextNode(UserNameBox.Text)

            'append the textnode to elements tags
            UserName.AppendChild(uName)
            UserPass.AppendChild(uPass)

            'appent all the information to the task tag
            UserInfo.AppendChild(UserName)
            UserInfo.AppendChild(UserPass)

            'now we are going to add UserInfo to the document element which is the root element (winnners)
            xmlfile.DocumentElement.AppendChild(UserInfo)

            'now we are going to save the xml file
            xmlfile.Save(filePath)
            End Sub
