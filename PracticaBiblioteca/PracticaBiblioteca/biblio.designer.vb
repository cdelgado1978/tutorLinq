﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="biblio")>  _
Partial Public Class biblioDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertautor(instance As autor)
    End Sub
  Partial Private Sub Updateautor(instance As autor)
    End Sub
  Partial Private Sub Deleteautor(instance As autor)
    End Sub
  Partial Private Sub InsertLibro_lector(instance As Libro_lector)
    End Sub
  Partial Private Sub UpdateLibro_lector(instance As Libro_lector)
    End Sub
  Partial Private Sub DeleteLibro_lector(instance As Libro_lector)
    End Sub
  Partial Private Sub Insertgenero(instance As genero)
    End Sub
  Partial Private Sub Updategenero(instance As genero)
    End Sub
  Partial Private Sub Deletegenero(instance As genero)
    End Sub
  Partial Private Sub Insertlector(instance As lector)
    End Sub
  Partial Private Sub Updatelector(instance As lector)
    End Sub
  Partial Private Sub Deletelector(instance As lector)
    End Sub
  Partial Private Sub InsertLibro(instance As Libro)
    End Sub
  Partial Private Sub UpdateLibro(instance As Libro)
    End Sub
  Partial Private Sub DeleteLibro(instance As Libro)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.PracticaBiblioteca.My.MySettings.Default.biblioConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property autors() As System.Data.Linq.Table(Of autor)
		Get
			Return Me.GetTable(Of autor)
		End Get
	End Property
	
	Public ReadOnly Property Libro_lectors() As System.Data.Linq.Table(Of Libro_lector)
		Get
			Return Me.GetTable(Of Libro_lector)
		End Get
	End Property
	
	Public ReadOnly Property generos() As System.Data.Linq.Table(Of genero)
		Get
			Return Me.GetTable(Of genero)
		End Get
	End Property
	
	Public ReadOnly Property lectors() As System.Data.Linq.Table(Of lector)
		Get
			Return Me.GetTable(Of lector)
		End Get
	End Property
	
	Public ReadOnly Property Libros() As System.Data.Linq.Table(Of Libro)
		Get
			Return Me.GetTable(Of Libro)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.autor")>  _
Partial Public Class autor
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _autorId As Integer
	
	Private _nombre As String
	
	Private _Libros As EntitySet(Of Libro)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnautorIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnautorIdChanged()
    End Sub
    Partial Private Sub OnnombreChanging(value As String)
    End Sub
    Partial Private Sub OnnombreChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Libros = New EntitySet(Of Libro)(AddressOf Me.attach_Libros, AddressOf Me.detach_Libros)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_autorId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property autorId() As Integer
		Get
			Return Me._autorId
		End Get
		Set
			If ((Me._autorId = value)  _
						= false) Then
				Me.OnautorIdChanging(value)
				Me.SendPropertyChanging
				Me._autorId = value
				Me.SendPropertyChanged("autorId")
				Me.OnautorIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nombre", DbType:="VarChar(60)")>  _
	Public Property nombre() As String
		Get
			Return Me._nombre
		End Get
		Set
			If (String.Equals(Me._nombre, value) = false) Then
				Me.OnnombreChanging(value)
				Me.SendPropertyChanging
				Me._nombre = value
				Me.SendPropertyChanged("nombre")
				Me.OnnombreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="autor_Libro", Storage:="_Libros", ThisKey:="autorId", OtherKey:="autorId")>  _
	Public Property Libros() As EntitySet(Of Libro)
		Get
			Return Me._Libros
		End Get
		Set
			Me._Libros.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Libros(ByVal entity As Libro)
		Me.SendPropertyChanging
		entity.autor = Me
	End Sub
	
	Private Sub detach_Libros(ByVal entity As Libro)
		Me.SendPropertyChanging
		entity.autor = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Libro_lector")>  _
Partial Public Class Libro_lector
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _libroId As Integer
	
	Private _lectorId As Integer
	
	Private _lector As EntityRef(Of lector)
	
	Private _Libro As EntityRef(Of Libro)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlibroIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnlibroIdChanged()
    End Sub
    Partial Private Sub OnlectorIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnlectorIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._lector = CType(Nothing, EntityRef(Of lector))
		Me._Libro = CType(Nothing, EntityRef(Of Libro))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_libroId", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property libroId() As Integer
		Get
			Return Me._libroId
		End Get
		Set
			If ((Me._libroId = value)  _
						= false) Then
				If Me._Libro.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnlibroIdChanging(value)
				Me.SendPropertyChanging
				Me._libroId = value
				Me.SendPropertyChanged("libroId")
				Me.OnlibroIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_lectorId", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property lectorId() As Integer
		Get
			Return Me._lectorId
		End Get
		Set
			If ((Me._lectorId = value)  _
						= false) Then
				If Me._lector.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnlectorIdChanging(value)
				Me.SendPropertyChanging
				Me._lectorId = value
				Me.SendPropertyChanged("lectorId")
				Me.OnlectorIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="lector_Libro_lector", Storage:="_lector", ThisKey:="lectorId", OtherKey:="lectorId", IsForeignKey:=true)>  _
	Public Property lector() As lector
		Get
			Return Me._lector.Entity
		End Get
		Set
			Dim previousValue As lector = Me._lector.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._lector.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._lector.Entity = Nothing
					previousValue.Libro_lectors.Remove(Me)
				End If
				Me._lector.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Libro_lectors.Add(Me)
					Me._lectorId = value.lectorId
				Else
					Me._lectorId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("lector")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Libro_Libro_lector", Storage:="_Libro", ThisKey:="libroId", OtherKey:="libroId", IsForeignKey:=true)>  _
	Public Property Libro() As Libro
		Get
			Return Me._Libro.Entity
		End Get
		Set
			Dim previousValue As Libro = Me._Libro.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Libro.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Libro.Entity = Nothing
					previousValue.Libro_lectors.Remove(Me)
				End If
				Me._Libro.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Libro_lectors.Add(Me)
					Me._libroId = value.libroId
				Else
					Me._libroId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Libro")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.genero")>  _
Partial Public Class genero
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _generoId As Integer
	
	Private _nombre As String
	
	Private _Libros As EntitySet(Of Libro)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OngeneroIdChanging(value As Integer)
    End Sub
    Partial Private Sub OngeneroIdChanged()
    End Sub
    Partial Private Sub OnnombreChanging(value As String)
    End Sub
    Partial Private Sub OnnombreChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Libros = New EntitySet(Of Libro)(AddressOf Me.attach_Libros, AddressOf Me.detach_Libros)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_generoId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property generoId() As Integer
		Get
			Return Me._generoId
		End Get
		Set
			If ((Me._generoId = value)  _
						= false) Then
				Me.OngeneroIdChanging(value)
				Me.SendPropertyChanging
				Me._generoId = value
				Me.SendPropertyChanged("generoId")
				Me.OngeneroIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nombre", DbType:="VarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property nombre() As String
		Get
			Return Me._nombre
		End Get
		Set
			If (String.Equals(Me._nombre, value) = false) Then
				Me.OnnombreChanging(value)
				Me.SendPropertyChanging
				Me._nombre = value
				Me.SendPropertyChanged("nombre")
				Me.OnnombreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="genero_Libro", Storage:="_Libros", ThisKey:="generoId", OtherKey:="generoId")>  _
	Public Property Libros() As EntitySet(Of Libro)
		Get
			Return Me._Libros
		End Get
		Set
			Me._Libros.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Libros(ByVal entity As Libro)
		Me.SendPropertyChanging
		entity.genero = Me
	End Sub
	
	Private Sub detach_Libros(ByVal entity As Libro)
		Me.SendPropertyChanging
		entity.genero = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.lector")>  _
Partial Public Class lector
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _lectorId As Integer
	
	Private _nombre As String
	
	Private _Libro_lectors As EntitySet(Of Libro_lector)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlectorIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnlectorIdChanged()
    End Sub
    Partial Private Sub OnnombreChanging(value As String)
    End Sub
    Partial Private Sub OnnombreChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Libro_lectors = New EntitySet(Of Libro_lector)(AddressOf Me.attach_Libro_lectors, AddressOf Me.detach_Libro_lectors)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_lectorId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property lectorId() As Integer
		Get
			Return Me._lectorId
		End Get
		Set
			If ((Me._lectorId = value)  _
						= false) Then
				Me.OnlectorIdChanging(value)
				Me.SendPropertyChanging
				Me._lectorId = value
				Me.SendPropertyChanged("lectorId")
				Me.OnlectorIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_nombre", DbType:="VarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property nombre() As String
		Get
			Return Me._nombre
		End Get
		Set
			If (String.Equals(Me._nombre, value) = false) Then
				Me.OnnombreChanging(value)
				Me.SendPropertyChanging
				Me._nombre = value
				Me.SendPropertyChanged("nombre")
				Me.OnnombreChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="lector_Libro_lector", Storage:="_Libro_lectors", ThisKey:="lectorId", OtherKey:="lectorId")>  _
	Public Property Libro_lectors() As EntitySet(Of Libro_lector)
		Get
			Return Me._Libro_lectors
		End Get
		Set
			Me._Libro_lectors.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Libro_lectors(ByVal entity As Libro_lector)
		Me.SendPropertyChanging
		entity.lector = Me
	End Sub
	
	Private Sub detach_Libro_lectors(ByVal entity As Libro_lector)
		Me.SendPropertyChanging
		entity.lector = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Libro")>  _
Partial Public Class Libro
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _libroId As Integer
	
	Private _titulo As String
	
	Private _fechaPublicacion As System.Nullable(Of Date)
	
	Private _autorId As Integer
	
	Private _generoId As Integer
	
	Private _Libro_lectors As EntitySet(Of Libro_lector)
	
	Private _autor As EntityRef(Of autor)
	
	Private _genero As EntityRef(Of genero)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnlibroIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnlibroIdChanged()
    End Sub
    Partial Private Sub OntituloChanging(value As String)
    End Sub
    Partial Private Sub OntituloChanged()
    End Sub
    Partial Private Sub OnfechaPublicacionChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub OnfechaPublicacionChanged()
    End Sub
    Partial Private Sub OnautorIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnautorIdChanged()
    End Sub
    Partial Private Sub OngeneroIdChanging(value As Integer)
    End Sub
    Partial Private Sub OngeneroIdChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Libro_lectors = New EntitySet(Of Libro_lector)(AddressOf Me.attach_Libro_lectors, AddressOf Me.detach_Libro_lectors)
		Me._autor = CType(Nothing, EntityRef(Of autor))
		Me._genero = CType(Nothing, EntityRef(Of genero))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_libroId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property libroId() As Integer
		Get
			Return Me._libroId
		End Get
		Set
			If ((Me._libroId = value)  _
						= false) Then
				Me.OnlibroIdChanging(value)
				Me.SendPropertyChanging
				Me._libroId = value
				Me.SendPropertyChanged("libroId")
				Me.OnlibroIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_titulo", DbType:="VarChar(60) NOT NULL", CanBeNull:=false)>  _
	Public Property titulo() As String
		Get
			Return Me._titulo
		End Get
		Set
			If (String.Equals(Me._titulo, value) = false) Then
				Me.OntituloChanging(value)
				Me.SendPropertyChanging
				Me._titulo = value
				Me.SendPropertyChanged("titulo")
				Me.OntituloChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_fechaPublicacion", DbType:="Date")>  _
	Public Property fechaPublicacion() As System.Nullable(Of Date)
		Get
			Return Me._fechaPublicacion
		End Get
		Set
			If (Me._fechaPublicacion.Equals(value) = false) Then
				Me.OnfechaPublicacionChanging(value)
				Me.SendPropertyChanging
				Me._fechaPublicacion = value
				Me.SendPropertyChanged("fechaPublicacion")
				Me.OnfechaPublicacionChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_autorId", DbType:="Int NOT NULL")>  _
	Public Property autorId() As Integer
		Get
			Return Me._autorId
		End Get
		Set
			If ((Me._autorId = value)  _
						= false) Then
				If Me._autor.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnautorIdChanging(value)
				Me.SendPropertyChanging
				Me._autorId = value
				Me.SendPropertyChanged("autorId")
				Me.OnautorIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_generoId", DbType:="Int NOT NULL")>  _
	Public Property generoId() As Integer
		Get
			Return Me._generoId
		End Get
		Set
			If ((Me._generoId = value)  _
						= false) Then
				If Me._genero.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OngeneroIdChanging(value)
				Me.SendPropertyChanging
				Me._generoId = value
				Me.SendPropertyChanged("generoId")
				Me.OngeneroIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Libro_Libro_lector", Storage:="_Libro_lectors", ThisKey:="libroId", OtherKey:="libroId")>  _
	Public Property Libro_lectors() As EntitySet(Of Libro_lector)
		Get
			Return Me._Libro_lectors
		End Get
		Set
			Me._Libro_lectors.Assign(value)
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="autor_Libro", Storage:="_autor", ThisKey:="autorId", OtherKey:="autorId", IsForeignKey:=true)>  _
	Public Property autor() As autor
		Get
			Return Me._autor.Entity
		End Get
		Set
			Dim previousValue As autor = Me._autor.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._autor.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._autor.Entity = Nothing
					previousValue.Libros.Remove(Me)
				End If
				Me._autor.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Libros.Add(Me)
					Me._autorId = value.autorId
				Else
					Me._autorId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("autor")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="genero_Libro", Storage:="_genero", ThisKey:="generoId", OtherKey:="generoId", IsForeignKey:=true)>  _
	Public Property genero() As genero
		Get
			Return Me._genero.Entity
		End Get
		Set
			Dim previousValue As genero = Me._genero.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._genero.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._genero.Entity = Nothing
					previousValue.Libros.Remove(Me)
				End If
				Me._genero.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Libros.Add(Me)
					Me._generoId = value.generoId
				Else
					Me._generoId = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("genero")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Libro_lectors(ByVal entity As Libro_lector)
		Me.SendPropertyChanging
		entity.Libro = Me
	End Sub
	
	Private Sub detach_Libro_lectors(ByVal entity As Libro_lector)
		Me.SendPropertyChanging
		entity.Libro = Nothing
	End Sub
End Class
