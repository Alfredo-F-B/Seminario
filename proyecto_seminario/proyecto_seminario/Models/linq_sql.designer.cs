﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proyecto_seminario.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BibliotecaColectiva")]
	public partial class linq_sqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertComentario(Comentario instance);
    partial void UpdateComentario(Comentario instance);
    partial void DeleteComentario(Comentario instance);
    partial void InsertPublicacion(Publicacion instance);
    partial void UpdatePublicacion(Publicacion instance);
    partial void DeletePublicacion(Publicacion instance);
    partial void InsertUsuario(Usuario instance);
    partial void UpdateUsuario(Usuario instance);
    partial void DeleteUsuario(Usuario instance);
    #endregion
		
		public linq_sqlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["BibliotecaColectivaConnectionString2"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public linq_sqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linq_sqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linq_sqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public linq_sqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Articulo> Articulo
		{
			get
			{
				return this.GetTable<Articulo>();
			}
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Comentario> Comentario
		{
			get
			{
				return this.GetTable<Comentario>();
			}
		}
		
		public System.Data.Linq.Table<Curso> Curso
		{
			get
			{
				return this.GetTable<Curso>();
			}
		}
		
		public System.Data.Linq.Table<Karma> Karma
		{
			get
			{
				return this.GetTable<Karma>();
			}
		}
		
		public System.Data.Linq.Table<Libro> Libro
		{
			get
			{
				return this.GetTable<Libro>();
			}
		}
		
		public System.Data.Linq.Table<Publicacion> Publicacion
		{
			get
			{
				return this.GetTable<Publicacion>();
			}
		}
		
		public System.Data.Linq.Table<Tutorial> Tutorial
		{
			get
			{
				return this.GetTable<Tutorial>();
			}
		}
		
		public System.Data.Linq.Table<Usuario> Usuario
		{
			get
			{
				return this.GetTable<Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Info_Libro> Info_Libro
		{
			get
			{
				return this.GetTable<Info_Libro>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Articulo")]
	public partial class Articulo
	{
		
		private System.Nullable<int> _IdPublicacion;
		
		private string _Tema;
		
		private System.Nullable<int> _MeGusta;
		
		public Articulo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", DbType="Int")]
		public System.Nullable<int> IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this._IdPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tema", DbType="VarChar(50)")]
		public string Tema
		{
			get
			{
				return this._Tema;
			}
			set
			{
				if ((this._Tema != value))
				{
					this._Tema = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeGusta", DbType="Int")]
		public System.Nullable<int> MeGusta
		{
			get
			{
				return this._MeGusta;
			}
			set
			{
				if ((this._MeGusta != value))
				{
					this._MeGusta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdCategoria;
		
		private string _Nombre;
		
		private EntitySet<Publicacion> _Publicacion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdCategoriaChanging(int value);
    partial void OnIdCategoriaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    #endregion
		
		public Categoria()
		{
			this._Publicacion = new EntitySet<Publicacion>(new Action<Publicacion>(this.attach_Publicacion), new Action<Publicacion>(this.detach_Publicacion));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdCategoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdCategoria
		{
			get
			{
				return this._IdCategoria;
			}
			set
			{
				if ((this._IdCategoria != value))
				{
					this.OnIdCategoriaChanging(value);
					this.SendPropertyChanging();
					this._IdCategoria = value;
					this.SendPropertyChanged("IdCategoria");
					this.OnIdCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Publicacion", Storage="_Publicacion", ThisKey="IdCategoria", OtherKey="Id_Cat")]
		public EntitySet<Publicacion> Publicacion
		{
			get
			{
				return this._Publicacion;
			}
			set
			{
				this._Publicacion.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Publicacion(Publicacion entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = this;
		}
		
		private void detach_Publicacion(Publicacion entity)
		{
			this.SendPropertyChanging();
			entity.Categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comentario")]
	public partial class Comentario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Com;
		
		private System.Nullable<System.Guid> _Id_Us;
		
		private System.Nullable<int> _Id_Pub;
		
		private string _Texto;
		
		private System.Nullable<System.DateTime> _Fecha;
		
		private EntityRef<Publicacion> _Publicacion;
		
		private EntityRef<Usuario> _Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_ComChanging(int value);
    partial void OnId_ComChanged();
    partial void OnId_UsChanging(System.Nullable<System.Guid> value);
    partial void OnId_UsChanged();
    partial void OnId_PubChanging(System.Nullable<int> value);
    partial void OnId_PubChanged();
    partial void OnTextoChanging(string value);
    partial void OnTextoChanged();
    partial void OnFechaChanging(System.Nullable<System.DateTime> value);
    partial void OnFechaChanged();
    #endregion
		
		public Comentario()
		{
			this._Publicacion = default(EntityRef<Publicacion>);
			this._Usuario = default(EntityRef<Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Com", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Com
		{
			get
			{
				return this._Id_Com;
			}
			set
			{
				if ((this._Id_Com != value))
				{
					this.OnId_ComChanging(value);
					this.SendPropertyChanging();
					this._Id_Com = value;
					this.SendPropertyChanged("Id_Com");
					this.OnId_ComChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Us", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> Id_Us
		{
			get
			{
				return this._Id_Us;
			}
			set
			{
				if ((this._Id_Us != value))
				{
					if (this._Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_UsChanging(value);
					this.SendPropertyChanging();
					this._Id_Us = value;
					this.SendPropertyChanged("Id_Us");
					this.OnId_UsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Pub", DbType="Int")]
		public System.Nullable<int> Id_Pub
		{
			get
			{
				return this._Id_Pub;
			}
			set
			{
				if ((this._Id_Pub != value))
				{
					if (this._Publicacion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_PubChanging(value);
					this.SendPropertyChanging();
					this._Id_Pub = value;
					this.SendPropertyChanged("Id_Pub");
					this.OnId_PubChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Texto", DbType="VarChar(50)")]
		public string Texto
		{
			get
			{
				return this._Texto;
			}
			set
			{
				if ((this._Texto != value))
				{
					this.OnTextoChanging(value);
					this.SendPropertyChanging();
					this._Texto = value;
					this.SendPropertyChanged("Texto");
					this.OnTextoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fecha", DbType="Date")]
		public System.Nullable<System.DateTime> Fecha
		{
			get
			{
				return this._Fecha;
			}
			set
			{
				if ((this._Fecha != value))
				{
					this.OnFechaChanging(value);
					this.SendPropertyChanging();
					this._Fecha = value;
					this.SendPropertyChanged("Fecha");
					this.OnFechaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publicacion_Comentario", Storage="_Publicacion", ThisKey="Id_Pub", OtherKey="IdPublicacion", IsForeignKey=true)]
		public Publicacion Publicacion
		{
			get
			{
				return this._Publicacion.Entity;
			}
			set
			{
				Publicacion previousValue = this._Publicacion.Entity;
				if (((previousValue != value) 
							|| (this._Publicacion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Publicacion.Entity = null;
						previousValue.Comentario.Remove(this);
					}
					this._Publicacion.Entity = value;
					if ((value != null))
					{
						value.Comentario.Add(this);
						this._Id_Pub = value.IdPublicacion;
					}
					else
					{
						this._Id_Pub = default(Nullable<int>);
					}
					this.SendPropertyChanged("Publicacion");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Comentario", Storage="_Usuario", ThisKey="Id_Us", OtherKey="IdUsuario", IsForeignKey=true)]
		public Usuario Usuario
		{
			get
			{
				return this._Usuario.Entity;
			}
			set
			{
				Usuario previousValue = this._Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuario.Entity = null;
						previousValue.Comentario.Remove(this);
					}
					this._Usuario.Entity = value;
					if ((value != null))
					{
						value.Comentario.Add(this);
						this._Id_Us = value.IdUsuario;
					}
					else
					{
						this._Id_Us = default(Nullable<System.Guid>);
					}
					this.SendPropertyChanged("Usuario");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Curso")]
	public partial class Curso
	{
		
		private System.Nullable<int> _IdPublicacion;
		
		private string _Tema;
		
		private System.Nullable<int> _MeGusta;
		
		public Curso()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", DbType="Int")]
		public System.Nullable<int> IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this._IdPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tema", DbType="VarChar(60)")]
		public string Tema
		{
			get
			{
				return this._Tema;
			}
			set
			{
				if ((this._Tema != value))
				{
					this._Tema = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeGusta", DbType="Int")]
		public System.Nullable<int> MeGusta
		{
			get
			{
				return this._MeGusta;
			}
			set
			{
				if ((this._MeGusta != value))
				{
					this._MeGusta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Karma")]
	public partial class Karma
	{
		
		private System.Nullable<System.Guid> _Id_Us;
		
		private System.Nullable<int> _IdPub;
		
		public Karma()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Us", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> Id_Us
		{
			get
			{
				return this._Id_Us;
			}
			set
			{
				if ((this._Id_Us != value))
				{
					this._Id_Us = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPub", DbType="Int")]
		public System.Nullable<int> IdPub
		{
			get
			{
				return this._IdPub;
			}
			set
			{
				if ((this._IdPub != value))
				{
					this._IdPub = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Libro")]
	public partial class Libro
	{
		
		private System.Nullable<int> _IdPublicacion;
		
		private string _Tema;
		
		private string _Indice;
		
		private string _Portada;
		
		private string _Autor;
		
		private System.Nullable<System.DateTime> _AnoPublicacion;
		
		private System.Nullable<int> _MeGusta;
		
		public Libro()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", DbType="Int")]
		public System.Nullable<int> IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this._IdPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tema", DbType="VarChar(50)")]
		public string Tema
		{
			get
			{
				return this._Tema;
			}
			set
			{
				if ((this._Tema != value))
				{
					this._Tema = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indice", DbType="VarChar(50)")]
		public string Indice
		{
			get
			{
				return this._Indice;
			}
			set
			{
				if ((this._Indice != value))
				{
					this._Indice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Portada", DbType="VarChar(50)")]
		public string Portada
		{
			get
			{
				return this._Portada;
			}
			set
			{
				if ((this._Portada != value))
				{
					this._Portada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Autor", DbType="VarChar(30)")]
		public string Autor
		{
			get
			{
				return this._Autor;
			}
			set
			{
				if ((this._Autor != value))
				{
					this._Autor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnoPublicacion", DbType="Date")]
		public System.Nullable<System.DateTime> AnoPublicacion
		{
			get
			{
				return this._AnoPublicacion;
			}
			set
			{
				if ((this._AnoPublicacion != value))
				{
					this._AnoPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeGusta", DbType="Int")]
		public System.Nullable<int> MeGusta
		{
			get
			{
				return this._MeGusta;
			}
			set
			{
				if ((this._MeGusta != value))
				{
					this._MeGusta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Publicacion")]
	public partial class Publicacion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdPublicacion;
		
		private string _Titulo;
		
		private string _Descripcion;
		
		private System.Nullable<int> _Id_Cat;
		
		private EntitySet<Comentario> _Comentario;
		
		private EntityRef<Categoria> _Categoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdPublicacionChanging(int value);
    partial void OnIdPublicacionChanged();
    partial void OnTituloChanging(string value);
    partial void OnTituloChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnId_CatChanging(System.Nullable<int> value);
    partial void OnId_CatChanged();
    #endregion
		
		public Publicacion()
		{
			this._Comentario = new EntitySet<Comentario>(new Action<Comentario>(this.attach_Comentario), new Action<Comentario>(this.detach_Comentario));
			this._Categoria = default(EntityRef<Categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this.OnIdPublicacionChanging(value);
					this.SendPropertyChanging();
					this._IdPublicacion = value;
					this.SendPropertyChanged("IdPublicacion");
					this.OnIdPublicacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this.OnTituloChanging(value);
					this.SendPropertyChanging();
					this._Titulo = value;
					this.SendPropertyChanged("Titulo");
					this.OnTituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Cat", DbType="Int")]
		public System.Nullable<int> Id_Cat
		{
			get
			{
				return this._Id_Cat;
			}
			set
			{
				if ((this._Id_Cat != value))
				{
					if (this._Categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_CatChanging(value);
					this.SendPropertyChanging();
					this._Id_Cat = value;
					this.SendPropertyChanged("Id_Cat");
					this.OnId_CatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Publicacion_Comentario", Storage="_Comentario", ThisKey="IdPublicacion", OtherKey="Id_Pub")]
		public EntitySet<Comentario> Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				this._Comentario.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Categoria_Publicacion", Storage="_Categoria", ThisKey="Id_Cat", OtherKey="IdCategoria", IsForeignKey=true)]
		public Categoria Categoria
		{
			get
			{
				return this._Categoria.Entity;
			}
			set
			{
				Categoria previousValue = this._Categoria.Entity;
				if (((previousValue != value) 
							|| (this._Categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Categoria.Entity = null;
						previousValue.Publicacion.Remove(this);
					}
					this._Categoria.Entity = value;
					if ((value != null))
					{
						value.Publicacion.Add(this);
						this._Id_Cat = value.IdCategoria;
					}
					else
					{
						this._Id_Cat = default(Nullable<int>);
					}
					this.SendPropertyChanged("Categoria");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Publicacion = this;
		}
		
		private void detach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Publicacion = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tutorial")]
	public partial class Tutorial
	{
		
		private System.Nullable<int> _IdPublicacion;
		
		private string _Tema;
		
		private System.Nullable<int> _MeGusta;
		
		public Tutorial()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", DbType="Int")]
		public System.Nullable<int> IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this._IdPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tema", DbType="VarChar(150)")]
		public string Tema
		{
			get
			{
				return this._Tema;
			}
			set
			{
				if ((this._Tema != value))
				{
					this._Tema = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeGusta", DbType="Int")]
		public System.Nullable<int> MeGusta
		{
			get
			{
				return this._MeGusta;
			}
			set
			{
				if ((this._MeGusta != value))
				{
					this._MeGusta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuario")]
	public partial class Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IdUsuario;
		
		private string _ApellidoPat;
		
		private string _ApellidoMat;
		
		private string _Nombre;
		
		private string _Email;
		
		private string _Contrasena;
		
		private string _NickName;
		
		private string _Avatar;
		
		private string _Ubicacion;
		
		private string _Intereses;
		
		private System.Nullable<double> _Karma;
		
		private EntitySet<Comentario> _Comentario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUsuarioChanging(System.Guid value);
    partial void OnIdUsuarioChanged();
    partial void OnApellidoPatChanging(string value);
    partial void OnApellidoPatChanged();
    partial void OnApellidoMatChanging(string value);
    partial void OnApellidoMatChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnContrasenaChanging(string value);
    partial void OnContrasenaChanged();
    partial void OnNickNameChanging(string value);
    partial void OnNickNameChanged();
    partial void OnAvatarChanging(string value);
    partial void OnAvatarChanged();
    partial void OnUbicacionChanging(string value);
    partial void OnUbicacionChanged();
    partial void OnInteresesChanging(string value);
    partial void OnInteresesChanged();
    partial void OnKarmaChanging(System.Nullable<double> value);
    partial void OnKarmaChanged();
    #endregion
		
		public Usuario()
		{
			this._Comentario = new EntitySet<Comentario>(new Action<Comentario>(this.attach_Comentario), new Action<Comentario>(this.detach_Comentario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUsuario", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IdUsuario
		{
			get
			{
				return this._IdUsuario;
			}
			set
			{
				if ((this._IdUsuario != value))
				{
					this.OnIdUsuarioChanging(value);
					this.SendPropertyChanging();
					this._IdUsuario = value;
					this.SendPropertyChanged("IdUsuario");
					this.OnIdUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPat", DbType="VarChar(15)")]
		public string ApellidoPat
		{
			get
			{
				return this._ApellidoPat;
			}
			set
			{
				if ((this._ApellidoPat != value))
				{
					this.OnApellidoPatChanging(value);
					this.SendPropertyChanging();
					this._ApellidoPat = value;
					this.SendPropertyChanged("ApellidoPat");
					this.OnApellidoPatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMat", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string ApellidoMat
		{
			get
			{
				return this._ApellidoMat;
			}
			set
			{
				if ((this._ApellidoMat != value))
				{
					this.OnApellidoMatChanging(value);
					this.SendPropertyChanging();
					this._ApellidoMat = value;
					this.SendPropertyChanged("ApellidoMat");
					this.OnApellidoMatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(15)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this.OnContrasenaChanging(value);
					this.SendPropertyChanging();
					this._Contrasena = value;
					this.SendPropertyChanged("Contrasena");
					this.OnContrasenaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NickName", DbType="VarChar(15)")]
		public string NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				if ((this._NickName != value))
				{
					this.OnNickNameChanging(value);
					this.SendPropertyChanging();
					this._NickName = value;
					this.SendPropertyChanged("NickName");
					this.OnNickNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Avatar", DbType="VarChar(30)")]
		public string Avatar
		{
			get
			{
				return this._Avatar;
			}
			set
			{
				if ((this._Avatar != value))
				{
					this.OnAvatarChanging(value);
					this.SendPropertyChanging();
					this._Avatar = value;
					this.SendPropertyChanged("Avatar");
					this.OnAvatarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="VarChar(30)")]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this.OnUbicacionChanging(value);
					this.SendPropertyChanging();
					this._Ubicacion = value;
					this.SendPropertyChanged("Ubicacion");
					this.OnUbicacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Intereses", DbType="VarChar(50)")]
		public string Intereses
		{
			get
			{
				return this._Intereses;
			}
			set
			{
				if ((this._Intereses != value))
				{
					this.OnInteresesChanging(value);
					this.SendPropertyChanging();
					this._Intereses = value;
					this.SendPropertyChanged("Intereses");
					this.OnInteresesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Karma", DbType="Float")]
		public System.Nullable<double> Karma
		{
			get
			{
				return this._Karma;
			}
			set
			{
				if ((this._Karma != value))
				{
					this.OnKarmaChanging(value);
					this.SendPropertyChanging();
					this._Karma = value;
					this.SendPropertyChanged("Karma");
					this.OnKarmaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuario_Comentario", Storage="_Comentario", ThisKey="IdUsuario", OtherKey="Id_Us")]
		public EntitySet<Comentario> Comentario
		{
			get
			{
				return this._Comentario;
			}
			set
			{
				this._Comentario.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = this;
		}
		
		private void detach_Comentario(Comentario entity)
		{
			this.SendPropertyChanging();
			entity.Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Info_Libro")]
	public partial class Info_Libro
	{
		
		private int _IdPublicacion;
		
		private string _Titulo;
		
		private string _Descripcion;
		
		private string _Portada;
		
		private System.Nullable<int> _MeGusta;
		
		private string _Nombre;
		
		public Info_Libro()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdPublicacion", DbType="Int NOT NULL")]
		public int IdPublicacion
		{
			get
			{
				return this._IdPublicacion;
			}
			set
			{
				if ((this._IdPublicacion != value))
				{
					this._IdPublicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this._Titulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this._Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Portada", DbType="VarChar(50)")]
		public string Portada
		{
			get
			{
				return this._Portada;
			}
			set
			{
				if ((this._Portada != value))
				{
					this._Portada = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MeGusta", DbType="Int")]
		public System.Nullable<int> MeGusta
		{
			get
			{
				return this._MeGusta;
			}
			set
			{
				if ((this._MeGusta != value))
				{
					this._MeGusta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
