Imports System.Runtime.InteropServices
Module DogAPI

#Const x64 = 1
#If x64 = 1 Then

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxFind", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxFind(ByVal nAppID As Integer, ByRef keyHandles As Long, ByRef keyNum As Integer) As Integer
    End Function


    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxOpen", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxOpen(ByVal nKeyHandle As Integer, ByVal userPin As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxReadStorage", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxReadStorage(ByVal nKeyHandle As Integer, ByVal page As Integer, ByVal nStartAddr As Integer, ByVal nLen As Integer, ByRef pbuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxWriteStorage", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxWriteStorage(ByVal nKeyHandle As Integer, ByVal page As Integer, ByVal nStartAddr As Integer, ByVal nLen As Integer, ByRef pbuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxReadMemory", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxReadMemory(ByVal nKeyHandle As Integer, ByRef pBuffer As Double) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxWriteMemory", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxWriteMemory(ByVal nKeyHandle As Integer, ByRef pBuffer As Double) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxClose", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxClose(ByVal nKeyHandle As Integer) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxGetLastError", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxGetLastError() As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxGenRandom", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxGenRandom(ByVal nKeyHandle As Integer, ByRef random As Byte) As Integer
    End Function


    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESEncryptFile", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESEncryptFile(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal plainFileName As String, _
                                                              ByVal cipherFileName As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESEncrypt", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESEncrypt(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal dataLen As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESDecrypt", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESDecrypt(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal dataLen As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESDecryptFile", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESDecryptFile(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal cipherFileName As String, _
                                                                       ByVal plainFileName As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAExportPublicKey", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAExportPublicKey(ByVal nKeyHandle As Integer, ByRef pubkey As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAPublic", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAPublic(ByVal nKeyHandle As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAPrivate", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAPrivate(ByVal nKeyHandle As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxHASHMD5", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxHASHMD5(ByVal nKeyHandle As Integer, ByRef pInBuffer As Byte, _
                                                     ByVal dataLen As Integer, ByRef md5Value As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxHASHMD5File", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxHASHMD5File(ByVal nKeyHandle As Integer, ByVal plainFileName As String, ByRef cipher As Byte) As Integer
    End Function



    <DllImport("Nox5AppDLL.X64.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxExecute", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxExecute(ByVal nKeyHandle As Integer, ByRef Param1 As Integer, ByRef Param2 As Integer, ByRef Param3 As Integer, ByRef Param4 As Integer) As Integer
    End Function

#ElseIf x64 = 0 Then

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxFind", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxFind(ByVal nAppID As Integer, ByRef keyHandles As Long, ByRef keyNum As Integer) As Integer
    End Function


    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxOpen", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxOpen(ByVal nKeyHandle As Integer, ByVal userPin As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxReadStorage", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxReadStorage(ByVal nKeyHandle As Integer, ByVal page As Integer, ByVal nStartAddr As Integer, ByVal nLen As Integer, ByRef pbuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxWriteStorage", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxWriteStorage(ByVal nKeyHandle As Integer, ByVal page As Integer, ByVal nStartAddr As Integer, ByVal nLen As Integer, ByRef pbuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxReadMemory", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxReadMemory(ByVal nKeyHandle As Integer, ByRef pBuffer As Double) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxWriteMemory", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxWriteMemory(ByVal nKeyHandle As Integer, ByRef pBuffer As Double) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxClose", CallingConvention:=CallingConvention.StdCall)> _
 Public Function NoxClose(ByVal nKeyHandle As Integer) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxGetLastError", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxGetLastError() As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxGenRandom", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxGenRandom(ByVal nKeyHandle As Integer, ByRef random As Byte) As Integer
    End Function


    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESEncryptFile", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESEncryptFile(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal plainFileName As String, _
                                                              ByVal cipherFileName As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESEncrypt", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESEncrypt(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal dataLen As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESDecrypt", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESDecrypt(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal dataLen As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="Nox3DESDecryptFile", CallingConvention:=CallingConvention.StdCall)> _
Public Function Nox3DESDecryptFile(ByVal nKeyHandle As Integer, ByRef iv As Byte, ByVal cipherFileName As String, _
                                                                       ByVal plainFileName As String) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAExportPublicKey", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAExportPublicKey(ByVal nKeyHandle As Integer, ByRef pubkey As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAPublic", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAPublic(ByVal nKeyHandle As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxRSAPrivate", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxRSAPrivate(ByVal nKeyHandle As Integer, ByRef pDataBuffer As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxHASHMD5", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxHASHMD5(ByVal nKeyHandle As Integer, ByRef pInBuffer As Byte, _
                                                     ByVal dataLen As Integer, ByRef md5Value As Byte) As Integer
    End Function

    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxHASHMD5File", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxHASHMD5File(ByVal nKeyHandle As Integer, ByVal plainFileName As String, ByRef cipher As Byte) As Integer
    End Function



    <DllImport("Nox5AppDLL.dll", CharSet:=CharSet.Ansi, EntryPoint:="NoxExecute", CallingConvention:=CallingConvention.StdCall)> _
Public Function NoxExecute(ByVal nKeyHandle As Integer, ByRef Param1 As Integer, ByRef Param2 As Integer, ByRef Param3 As Integer, ByRef Param4 As Integer) As Integer
    End Function
#End If


 
End Module
