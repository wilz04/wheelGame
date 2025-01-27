Public Class Fruleta
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents LnumeroGanador As System.Windows.Forms.Label
    Friend WithEvents RTBresultados As System.Windows.Forms.RichTextBox
    Friend WithEvents RTBapuestas As System.Windows.Forms.RichTextBox
    Friend WithEvents MIjuego As System.Windows.Forms.MenuItem
    Friend WithEvents MInuevo As System.Windows.Forms.MenuItem
    Friend WithEvents MIopciones As System.Windows.Forms.MenuItem
    Friend WithEvents MIayuda As System.Windows.Forms.MenuItem
    Friend WithEvents MIgirar As System.Windows.Forms.MenuItem
    Friend WithEvents MIsalir As System.Windows.Forms.MenuItem
    Friend WithEvents MIjugadores As System.Windows.Forms.MenuItem
    Friend WithEvents MIuno As System.Windows.Forms.MenuItem
    Friend WithEvents MIdos As System.Windows.Forms.MenuItem
    Friend WithEvents MItres As System.Windows.Forms.MenuItem
    Friend WithEvents MIcuatro As System.Windows.Forms.MenuItem
    Friend WithEvents MIcomoJugar As System.Windows.Forms.MenuItem
    Friend WithEvents MIacercaDe As System.Windows.Forms.MenuItem
    Friend WithEvents ASWFruleta As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents ASWFtablero As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents GBnumeroGanador As System.Windows.Forms.GroupBox
    Friend WithEvents GBresultados As System.Windows.Forms.GroupBox
    Friend WithEvents DGapuestas As System.Windows.Forms.DataGrid
    Friend WithEvents Lwz4dd05 As System.Windows.Forms.Label
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents ASWFradios As AxShockwaveFlashObjects.AxShockwaveFlash
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Fruleta))
        Me.GBresultados = New System.Windows.Forms.GroupBox
        Me.RTBresultados = New System.Windows.Forms.RichTextBox
        Me.GBnumeroGanador = New System.Windows.Forms.GroupBox
        Me.LnumeroGanador = New System.Windows.Forms.Label
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.MIjuego = New System.Windows.Forms.MenuItem
        Me.MInuevo = New System.Windows.Forms.MenuItem
        Me.MIgirar = New System.Windows.Forms.MenuItem
        Me.MIsalir = New System.Windows.Forms.MenuItem
        Me.MIopciones = New System.Windows.Forms.MenuItem
        Me.MIjugadores = New System.Windows.Forms.MenuItem
        Me.MIuno = New System.Windows.Forms.MenuItem
        Me.MIdos = New System.Windows.Forms.MenuItem
        Me.MItres = New System.Windows.Forms.MenuItem
        Me.MIcuatro = New System.Windows.Forms.MenuItem
        Me.MIayuda = New System.Windows.Forms.MenuItem
        Me.MIcomoJugar = New System.Windows.Forms.MenuItem
        Me.MIacercaDe = New System.Windows.Forms.MenuItem
        Me.ASWFruleta = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.ASWFtablero = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.DGapuestas = New System.Windows.Forms.DataGrid
        Me.Lwz4dd05 = New System.Windows.Forms.Label
        Me.ASWFradios = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.RTBapuestas = New System.Windows.Forms.RichTextBox
        Me.GBresultados.SuspendLayout()
        Me.GBnumeroGanador.SuspendLayout()
        CType(Me.ASWFruleta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASWFtablero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGapuestas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASWFradios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBresultados
        '
        Me.GBresultados.Controls.Add(Me.RTBresultados)
        Me.GBresultados.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBresultados.ForeColor = System.Drawing.Color.Black
        Me.GBresultados.Location = New System.Drawing.Point(367, 136)
        Me.GBresultados.Name = "GBresultados"
        Me.GBresultados.Size = New System.Drawing.Size(233, 104)
        Me.GBresultados.TabIndex = 2
        Me.GBresultados.TabStop = False
        Me.GBresultados.Text = "Resultados"
        '
        'RTBresultados
        '
        Me.RTBresultados.BackColor = System.Drawing.Color.FromArgb(CType(72, Byte), CType(146, Byte), CType(73, Byte))
        Me.RTBresultados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBresultados.ForeColor = System.Drawing.Color.FromArgb(CType(36, Byte), CType(73, Byte), CType(36, Byte))
        Me.RTBresultados.Location = New System.Drawing.Point(8, 16)
        Me.RTBresultados.Name = "RTBresultados"
        Me.RTBresultados.ReadOnly = True
        Me.RTBresultados.Size = New System.Drawing.Size(216, 80)
        Me.RTBresultados.TabIndex = 0
        Me.RTBresultados.Text = ""
        '
        'GBnumeroGanador
        '
        Me.GBnumeroGanador.Controls.Add(Me.LnumeroGanador)
        Me.GBnumeroGanador.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBnumeroGanador.ForeColor = System.Drawing.Color.Black
        Me.GBnumeroGanador.Location = New System.Drawing.Point(367, 24)
        Me.GBnumeroGanador.Name = "GBnumeroGanador"
        Me.GBnumeroGanador.Size = New System.Drawing.Size(233, 104)
        Me.GBnumeroGanador.TabIndex = 3
        Me.GBnumeroGanador.TabStop = False
        Me.GBnumeroGanador.Text = "Numero ganador"
        '
        'LnumeroGanador
        '
        Me.LnumeroGanador.AutoSize = True
        Me.LnumeroGanador.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnumeroGanador.ForeColor = System.Drawing.Color.FromArgb(CType(36, Byte), CType(73, Byte), CType(36, Byte))
        Me.LnumeroGanador.Location = New System.Drawing.Point(72, 24)
        Me.LnumeroGanador.Name = "LnumeroGanador"
        Me.LnumeroGanador.Size = New System.Drawing.Size(0, 62)
        Me.LnumeroGanador.TabIndex = 0
        Me.LnumeroGanador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MIjuego, Me.MIopciones, Me.MIayuda})
        '
        'MIjuego
        '
        Me.MIjuego.Index = 0
        Me.MIjuego.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MInuevo, Me.MIgirar, Me.MIsalir})
        Me.MIjuego.Text = "Juego"
        '
        'MInuevo
        '
        Me.MInuevo.Index = 0
        Me.MInuevo.Text = "Nuevo"
        '
        'MIgirar
        '
        Me.MIgirar.Index = 1
        Me.MIgirar.Text = "Girar"
        '
        'MIsalir
        '
        Me.MIsalir.Index = 2
        Me.MIsalir.Text = "Salir"
        '
        'MIopciones
        '
        Me.MIopciones.Index = 1
        Me.MIopciones.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MIjugadores})
        Me.MIopciones.Text = "Opciones"
        '
        'MIjugadores
        '
        Me.MIjugadores.Index = 0
        Me.MIjugadores.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MIuno, Me.MIdos, Me.MItres, Me.MIcuatro})
        Me.MIjugadores.Text = "Jugadores"
        '
        'MIuno
        '
        Me.MIuno.Index = 0
        Me.MIuno.Text = "uno"
        '
        'MIdos
        '
        Me.MIdos.Index = 1
        Me.MIdos.Text = "dos"
        '
        'MItres
        '
        Me.MItres.Index = 2
        Me.MItres.Text = "tres"
        '
        'MIcuatro
        '
        Me.MIcuatro.Index = 3
        Me.MIcuatro.Text = "cuatro"
        '
        'MIayuda
        '
        Me.MIayuda.Index = 2
        Me.MIayuda.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MIcomoJugar, Me.MIacercaDe})
        Me.MIayuda.Text = "Ayuda"
        '
        'MIcomoJugar
        '
        Me.MIcomoJugar.Index = 0
        Me.MIcomoJugar.Text = "Como jugar..?"
        '
        'MIacercaDe
        '
        Me.MIacercaDe.Index = 1
        Me.MIacercaDe.Text = "Acerca de..."
        '
        'ASWFruleta
        '
        Me.ASWFruleta.Enabled = True
        Me.ASWFruleta.Location = New System.Drawing.Point(48, 8)
        Me.ASWFruleta.Name = "ASWFruleta"
        Me.ASWFruleta.OcxState = CType(resources.GetObject("ASWFruleta.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ASWFruleta.Size = New System.Drawing.Size(224, 232)
        Me.ASWFruleta.TabIndex = 4
        '
        'ASWFtablero
        '
        Me.ASWFtablero.Enabled = True
        Me.ASWFtablero.Location = New System.Drawing.Point(240, 248)
        Me.ASWFtablero.Name = "ASWFtablero"
        Me.ASWFtablero.OcxState = CType(resources.GetObject("ASWFtablero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ASWFtablero.Size = New System.Drawing.Size(360, 216)
        Me.ASWFtablero.TabIndex = 5
        '
        'DGapuestas
        '
        Me.DGapuestas.BackgroundColor = System.Drawing.Color.FromArgb(CType(164, Byte), CType(201, Byte), CType(164, Byte))
        Me.DGapuestas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DGapuestas.CaptionBackColor = System.Drawing.Color.FromArgb(CType(173, Byte), CType(37, Byte), CType(80, Byte))
        Me.DGapuestas.CaptionFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGapuestas.CaptionText = "Apuestas"
        Me.DGapuestas.DataMember = ""
        Me.DGapuestas.FlatMode = True
        Me.DGapuestas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGapuestas.GridLineColor = System.Drawing.SystemColors.WindowFrame
        Me.DGapuestas.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DGapuestas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGapuestas.Location = New System.Drawing.Point(48, 248)
        Me.DGapuestas.Name = "DGapuestas"
        Me.DGapuestas.Size = New System.Drawing.Size(160, 216)
        Me.DGapuestas.TabIndex = 6
        '
        'Lwz4dd05
        '
        Me.Lwz4dd05.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lwz4dd05.Location = New System.Drawing.Point(262, 470)
        Me.Lwz4dd05.Name = "Lwz4dd05"
        Me.Lwz4dd05.Size = New System.Drawing.Size(135, 15)
        Me.Lwz4dd05.TabIndex = 7
        Me.Lwz4dd05.Text = "wilz04 Design And Develop 2005"
        Me.Lwz4dd05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ASWFradios
        '
        Me.ASWFradios.Enabled = True
        Me.ASWFradios.Location = New System.Drawing.Point(248, 408)
        Me.ASWFradios.Name = "ASWFradios"
        Me.ASWFradios.OcxState = CType(resources.GetObject("ASWFradios.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ASWFradios.Size = New System.Drawing.Size(344, 48)
        Me.ASWFradios.TabIndex = 9
        '
        'RTBapuestas
        '
        Me.RTBapuestas.BackColor = System.Drawing.Color.FromArgb(CType(164, Byte), CType(201, Byte), CType(164, Byte))
        Me.RTBapuestas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RTBapuestas.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTBapuestas.ForeColor = System.Drawing.Color.FromArgb(CType(36, Byte), CType(73, Byte), CType(36, Byte))
        Me.RTBapuestas.Location = New System.Drawing.Point(56, 272)
        Me.RTBapuestas.Name = "RTBapuestas"
        Me.RTBapuestas.ReadOnly = True
        Me.RTBapuestas.Size = New System.Drawing.Size(144, 184)
        Me.RTBapuestas.TabIndex = 10
        Me.RTBapuestas.Text = ""
        '
        'Fruleta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(72, Byte), CType(146, Byte), CType(73, Byte))
        Me.ClientSize = New System.Drawing.Size(658, 490)
        Me.Controls.Add(Me.RTBapuestas)
        Me.Controls.Add(Me.ASWFradios)
        Me.Controls.Add(Me.Lwz4dd05)
        Me.Controls.Add(Me.DGapuestas)
        Me.Controls.Add(Me.GBnumeroGanador)
        Me.Controls.Add(Me.ASWFtablero)
        Me.Controls.Add(Me.ASWFruleta)
        Me.Controls.Add(Me.GBresultados)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "Fruleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ruleta"
        Me.GBresultados.ResumeLayout(False)
        Me.GBnumeroGanador.ResumeLayout(False)
        CType(Me.ASWFruleta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASWFtablero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGapuestas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASWFradios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Declaración de constantes "


    Const direccion = "C:\wheelGame\bin\objects\"
    Const pazivoInicial = 1000
    Const tab = "          "

#End Region

#Region " Declaración de variables "

    Dim pazivo(4) As Integer
    Dim activo As Integer
    Dim numeroXY As Integer
    Dim numeroGanador As Integer
    Dim numeroDeJugadores As Integer
    Dim jugadorX As Integer
    Dim apuesta(35, 4) As Integer

#End Region

#Region " Declaración de funciones "

    Function DevolverResultados()
        Dim i As Integer
        Dim j As Integer

        'Escribe los resultados en resultados en la caja RTBresultados
        RTBresultados.Text = "Capital del Jugador 1:" + Str(pazivo(1)) + tab
        If numeroDeJugadores > 1 Then
            RTBresultados.Text += "Capital del Jugador 2:" + Str(pazivo(2)) + tab
            If numeroDeJugadores > 2 Then
                RTBresultados.Text += "Capital del Jugador 3:" + Str(pazivo(3)) + tab
                If numeroDeJugadores > 3 Then
                    RTBresultados.Text += "Capital del Jugador 4:" + Str(pazivo(4)) + tab
                End If
            End If
        End If

        'Escribe los resultados en resultados en la caja RTBapuestas
        RTBapuestas.Text = ""
        For i = 1 To numeroDeJugadores
            RTBapuestas.Text += "__________________  "
            RTBapuestas.Text += "Jugador" + Str(i) + ":" + tab + tab + tab
            For j = 0 To 35
                If apuesta(j, i) <> 0 Then
                    If j < 10 Then
                        RTBapuestas.Text += "0"
                    End If
                    RTBapuestas.Text += Trim(Str(j)) + ":" + tab + Str(apuesta(j, i)) + tab + tab
                End If
            Next j
        Next i
    End Function

    Function CrearNuevo()
        Dim i As Integer
        Dim j As Integer

        activo = 0
        For i = 0 To 35
            apuesta(i, 1) = 0
        Next

        ASWFruleta.LoadMovie(0, direccion + "RuletaBacia.swf")
        ASWFruleta.LoadMovie(0, direccion + "Ruleta.swf")

        ASWFtablero.LoadMovie(0, direccion + "TableroBacio.swf")
        ASWFtablero.LoadMovie(0, direccion + "Tablero.swf")
        ASWFtablero.SetVariable("pazivo", pazivoInicial)

        pazivo(1) = pazivoInicial
        pazivo(2) = pazivoInicial
        pazivo(3) = pazivoInicial
        pazivo(4) = pazivoInicial

        For j = 1 To 4
            For i = 0 To 35
                apuesta(i, j) = 0
            Next i
        Next j

        DevolverResultados()
    End Function

#End Region

    Private Sub Form1OnLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ASWFruleta.Movie = direccion + "Ruleta.swf"
        ASWFtablero.Movie = direccion + "Tablero.swf"
        ASWFtablero.SetVariable("pazivo", pazivoInicial)
        ASWFradios.Movie = direccion + "Radios.swf"

        numeroDeJugadores = 1

        pazivo(1) = pazivoInicial
        pazivo(2) = pazivoInicial
        pazivo(3) = pazivoInicial
        pazivo(4) = pazivoInicial

        MIuno.Checked = True
        jugadorX = 1

        DevolverResultados()
    End Sub

    Private Sub ruletaOnFscommand(ByVal sender As System.Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles ASWFruleta.FSCommand
        Dim i As Integer
        Dim j As Integer
        numeroGanador = ASWFruleta.GetVariable("numeroGanador")

        If numeroGanador < 10 Then
            LnumeroGanador.Text = Str(numeroGanador)
        Else
            LnumeroGanador.Text = numeroGanador
        End If

        'Limpieza del tablero'
        ASWFtablero.LoadMovie(0, direccion + "TableroBacio.swf")
        ASWFtablero.LoadMovie(0, direccion + "Tablero.swf")
        activo = 0
        For j = 1 To numeroDeJugadores
            For i = 0 To 35
                If i = numeroGanador Then
                    pazivo(j) += (apuesta(i, j) * 35)
                    DevolverResultados()
                End If
            Next i
        Next j
        ASWFtablero.SetVariable("pazivo", pazivo(jugadorX))

        'Limpieza de los numeros'
        For j = 1 To 4
            For i = 0 To 35
                apuesta(i, j) = 0
            Next i
        Next j

        'Limites'
        For i = 1 To numeroDeJugadores
            If pazivo(i) >= 5000 Then
                MsgBox("El ganador del juego es el jugador" + Str(i))
                CrearNuevo()
                Exit For
            End If
        Next
        For i = 1 To numeroDeJugadores
            If pazivo(i) <> 0 Then
                Exit For
            ElseIf i = numeroDeJugadores Then
                MsgBox("El juego ha terminado por falta de capital de todos los jugadores")
                CrearNuevo()
            End If
        Next
    End Sub

    Private Sub tableroOnFscommand(ByVal sender As System.Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles ASWFtablero.FSCommand
        numeroXY = ASWFtablero.GetVariable("numeroXY")
        activo = ASWFtablero.GetVariable("activo")
        If pazivo(jugadorX) >= activo Then
            pazivo(jugadorX) -= activo
            ASWFruleta.SetVariable("girar", "true")
        End If
        ASWFtablero.SetVariable("pazivo", pazivo(jugadorX))

        apuesta(numeroXY, jugadorX) += activo

        DevolverResultados()
    End Sub

    Private Sub radiosOnFscommand(ByVal sender As System.Object, ByVal e As AxShockwaveFlashObjects._IShockwaveFlashEvents_FSCommandEvent) Handles ASWFradios.FSCommand
        jugadorX = ASWFradios.GetVariable("jugadorX")
        ASWFtablero.SetVariable("pazivo", pazivo(jugadorX))
    End Sub

    Private Sub aCercaDeOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIacercaDe.Click
        MsgBox("Poligon Teknologies ©")
    End Sub

    Private Sub nuevoOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MInuevo.Click
        CrearNuevo()
    End Sub

    Private Sub salirOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIsalir.Click
        Me.Close()
    End Sub

    Private Sub comoJugarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIcomoJugar.Click
        openWebSite(direccion + "Help\WheelGameHelp.htm")
    End Sub

    Private Sub girarOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIgirar.Click
        Dim activo As String
        activo = ASWFtablero.GetVariable("activo")
        If ASWFruleta.Playing = False And activo <> "undefined" Then
            ASWFruleta.SetVariable("girar", "true")
            ASWFruleta.Play()
        End If
    End Sub

    Private Sub MIunoOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIuno.Click
        CrearNuevo()
        MIuno.Checked = True
        MIdos.Checked = False
        MItres.Checked = False
        MIcuatro.Checked = False
        numeroDeJugadores = 1
        ASWFradios.SetVariable("numeroDeJugadores", "1")
        DevolverResultados()
    End Sub

    Private Sub MIdosOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIdos.Click
        CrearNuevo()
        MIuno.Checked = False
        MIdos.Checked = True
        MItres.Checked = False
        MIcuatro.Checked = False
        numeroDeJugadores = 2
        ASWFradios.SetVariable("numeroDeJugadores", "2")
        DevolverResultados()
    End Sub

    Private Sub MItresOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MItres.Click
        CrearNuevo()
        MIuno.Checked = False
        MIdos.Checked = False
        MItres.Checked = True
        MIcuatro.Checked = False
        numeroDeJugadores = 3
        ASWFradios.SetVariable("numeroDeJugadores", "3")
        DevolverResultados()
    End Sub

    Private Sub MIcuatroOnClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIcuatro.Click
        CrearNuevo()
        MIuno.Checked = False
        MIdos.Checked = False
        MItres.Checked = False
        MIcuatro.Checked = True
        numeroDeJugadores = 4
        ASWFradios.SetVariable("numeroDeJugadores", "4")
        DevolverResultados()
    End Sub
End Class
