Imports DymoSDK.Implementations
Imports System.IO.Path
Imports System.Xml.Linq

Module Module1

    Sub Main()
        DymoSDK.App.Init()

        Dim fullpath As String = System.IO.Path.GetFullPath("samplelabel.dymo")
        Dim dymoSDKLabel = DymoLabel.Instance
        Dim dymoXML As XDocument = XDocument.Load(System.IO.Path.GetFullPath("samplelabel.dymo"))
        Dim ql As XElement = (From txOj In dymoXML.Root.Elements.Elements.Elements.Elements.Elements.Elements.Elements("TextSpan")
                              Where txOj.Element("Text").Value = "CaseNumber").FirstOrDefault




        ql.Element("Text").SetValue("2022-12345")


        Dim q2 As XElement = (From txOj2 In dymoXML.Root.Elements.Elements.Elements.Elements.Elements.Elements.Elements("TextSpan")
                              Where txOj2.Element("Text").Value = "Address").FirstOrDefault

        q2.Element("Text").SetValue("My house")


        dymoSDKLabel.LoadLabelFromXML(dymoXML.ToString)

        For Each dymoObj As DymoSDK.Interfaces.ILabelObject In dymoSDKLabel.GetLabelObjects()
            Console.WriteLine(dymoObj.Name + vbCrLf)

        Next

        Console.ReadKey()

        'Exit Sub
        Dim dymoSDKPrinter = DymoPrinter.Instance

        Dim Printers = DymoPrinter.Instance.GetPrinters()
        Dim ConnectedPrinter = Printers.FirstOrDefault()

        For Each prt In Printers    ' Iterate through each element and find a connected printer.  
            Console.WriteLine($"Printer info: {prt.DriverName}, {prt.Name}, {prt.IsTwinTurbo}")
            If prt.IsConnected Then
                ConnectedPrinter = prt
            End If
        Next

        If dymoSDKPrinter.PrintLabel(dymoSDKLabel, ConnectedPrinter.Name, 1, False, False, 0, False, False) Then
            Console.WriteLine("Print successful.")
        End If

        Console.ReadKey()

    End Sub

End Module
