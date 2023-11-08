Imports System.Data.SqlClient

Public Class Form1
    Private connStr As String = "Data Source=DESKTOP-3PLH1HV; Initial Catalog=BDParcial2Estudiante1yEstudiante2;Integrated Security=True"
    Private conn As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New SqlConnection(connStr)
        Try
            conn.Open()
            MsgBox("Conexión exitosa a la base de datos.")
            CargarDepartamentos()
        Catch ex As Exception
            MsgBox("Error al conectar a la base de datos: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarDepartamentos()

        Dim query As String = "SELECT DepartamentoID, Nombre FROM Departamento"
        Dim cmd As New SqlCommand(query, conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cbDepartamento.Items.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32(0), reader.GetString(1)))
        End While
        reader.Close()

        If cbDepartamento.Items.Count > 0 Then
            Dim primerDepartamento = DirectCast(cbDepartamento.Items(0), KeyValuePair(Of Integer, String))
            CargarMunicipios(primerDepartamento.Key)
        End If
    End Sub

    Private Sub CargarMunicipios(departamentoID As Integer)
        cbMunicipio.Items.Clear()
        Dim query As String = "SELECT MunicipioID, Nombre FROM Municipio WHERE DepartamentoID = @DepartamentoID"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@DepartamentoID", departamentoID)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            cbMunicipio.Items.Add(New KeyValuePair(Of Integer, String)(reader.GetInt32(0), reader.GetString(1)))
        End While
        reader.Close()
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click

        Dim nombre As String = tbNombre.Text
        Dim apellido As String = tbApellido.Text
        Dim departamentoID As Integer = DirectCast(cbDepartamento.SelectedItem, KeyValuePair(Of Integer, String)).Key
        Dim municipioID As Integer = DirectCast(cbMunicipio.SelectedItem, KeyValuePair(Of Integer, String)).Key

        Dim query As String = "INSERT INTO Cliente (Nombre, Apellido, DepartamentoID, MunicipioID) VALUES (@Nombre, @Apellido, @DepartamentoID, @MunicipioID)"
        Dim cmd As New SqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Nombre", nombre)
        cmd.Parameters.AddWithValue("@Apellido", apellido)
        cmd.Parameters.AddWithValue("@DepartamentoID", departamentoID)
        cmd.Parameters.AddWithValue("@MunicipioID", municipioID)

        If cmd.ExecuteNonQuery() > 0 Then
            MsgBox("Inserción exitosa.")
        Else
            MsgBox("Error al insertar los datos.")
        End If
    End Sub


    Private Sub MostrarDesarrolladores()
        MsgBox("Desarrollado por: Jonathan Gabriel Perez Esquina y Carlos Jose Garcia Suarez")
    End Sub

    Private Sub CapturarPantalla()

    End Sub
End Class
