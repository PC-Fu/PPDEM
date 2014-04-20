Imports System
Imports System.Management



Public Class Form1()


    Dim objMOS As New Management.ManagementObjectSearcher
    Dim objMOC As Management.ManagementObjectCollection
    Dim objMO As Management.ManagementObject
    Dim searcher As New ManagementObjectSearcher("SELECT * FROM Win32_Share")


    objMOS = New ManagementObjectSearcher("Select * From Win32_Processor")

    objMOC = objMOS.Get


    For Each objMO In objMOC

    MessageBox.Show("CPU ID = " & objMO("ProcessorID"))

Next

Dispose object variables.

objMOS.Dispose()

objMOS = Nothing

objMO.Dispose()

objMO = Nothing

End Class
