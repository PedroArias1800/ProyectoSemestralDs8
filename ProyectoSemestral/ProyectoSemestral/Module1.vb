Imports System.Data.SqlClient
Imports System.Xml
Module Module1
    Public mYConn As SqlConnection
    Public accion As String
    Public tipo As Integer
    Public idUsuario As Integer
    Public nombreCompleto As String
    Public cobrar2 As String

    Sub conexion()
        Dim cadenadeconexion As String
        Dim servidorDb As String = "", nameDb As String = "", usuario As String = "", pass As String = ""
        lecturaXML(servidorDb, nameDb, usuario, pass)
        cadenadeconexion = "data source =" & servidorDb & " ; initial catalog =" & nameDb & "; user id =" & usuario & " ; password =" & pass
        'MsgBox(cadenadeconexion)'
        mYConn = New SqlConnection(cadenadeconexion)
    End Sub


    Sub lecturaXML(ByRef servidorDb As String, ByRef nameDb As String, ByRef usuario As String, ByRef pass As String)
        Dim mxml As XmlTextReader
        mxml = New XmlTextReader("../../Archivo/datacon.xml")
        mxml.Read()
        While Not mxml.EOF
            mxml.Read()
            If Not mxml.IsStartElement Then
                Exit While
            End If
            mxml.Read()
            servidorDb = DecodeBase64(mxml.ReadElementString("datasorurce"))
            nameDb = DecodeBase64(mxml.ReadElementString("initialcatalog"))
            usuario = DecodeBase64(mxml.ReadElementString("usuario"))
            pass = DecodeBase64(mxml.ReadElementString("pass"))

            'MsgBox(servidorDb + " " + nameDb + " " + usuario + " " + pass)'

        End While
        mxml.Close()

    End Sub

    Public Function DecodeBase64(ByVal mensajeCodificado As String) As String

        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(mensajeCodificado))
    End Function

End Module

