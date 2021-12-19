Module TratarImagen

    Public Function CopiarArchivo(antiguo As String, nuevo As String)
        Try
            FileCopy(antiguo, nuevo)
        Catch ex As Exception
            MsgBox("Falló el guardado de la imagen...", vbYes, "Error")
        End Try
    End Function

End Module
