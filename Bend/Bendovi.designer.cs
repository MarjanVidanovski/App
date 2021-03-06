﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bend
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bendovi")]
	public partial class BendoviDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertClenovi(Clenovi instance);
    partial void UpdateClenovi(Clenovi instance);
    partial void DeleteClenovi(Clenovi instance);
    partial void InsertClenoviNaBend(ClenoviNaBend instance);
    partial void UpdateClenoviNaBend(ClenoviNaBend instance);
    partial void DeleteClenoviNaBend(ClenoviNaBend instance);
    partial void InsertBendovi(Bendovi instance);
    partial void UpdateBendovi(Bendovi instance);
    partial void DeleteBendovi(Bendovi instance);
    #endregion
		
		public BendoviDataContext() : 
				base(global::Bend.Properties.Settings.Default.BendoviConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BendoviDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BendoviDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BendoviDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BendoviDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Clenovi> Clenovis
		{
			get
			{
				return this.GetTable<Clenovi>();
			}
		}
		
		public System.Data.Linq.Table<ClenoviNaBend> ClenoviNaBends
		{
			get
			{
				return this.GetTable<ClenoviNaBend>();
			}
		}
		
		public System.Data.Linq.Table<Bendovi> Bendovis
		{
			get
			{
				return this.GetTable<Bendovi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clenovi")]
	public partial class Clenovi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClenoviID;
		
		private string _Ime;
		
		private string _Prezime;
		
		private string _Nacionalnost;
		
		private System.Nullable<System.DateTime> _GodinaNaRaganje;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClenoviIDChanging(int value);
    partial void OnClenoviIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnPrezimeChanging(string value);
    partial void OnPrezimeChanged();
    partial void OnNacionalnostChanging(string value);
    partial void OnNacionalnostChanged();
    partial void OnGodinaNaRaganjeChanging(System.Nullable<System.DateTime> value);
    partial void OnGodinaNaRaganjeChanged();
    #endregion
		
		public Clenovi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClenoviID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ClenoviID
		{
			get
			{
				return this._ClenoviID;
			}
			set
			{
				if ((this._ClenoviID != value))
				{
					this.OnClenoviIDChanging(value);
					this.SendPropertyChanging();
					this._ClenoviID = value;
					this.SendPropertyChanged("ClenoviID");
					this.OnClenoviIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50)")]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezime", DbType="NVarChar(50)")]
		public string Prezime
		{
			get
			{
				return this._Prezime;
			}
			set
			{
				if ((this._Prezime != value))
				{
					this.OnPrezimeChanging(value);
					this.SendPropertyChanging();
					this._Prezime = value;
					this.SendPropertyChanged("Prezime");
					this.OnPrezimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nacionalnost", DbType="NVarChar(50)")]
		public string Nacionalnost
		{
			get
			{
				return this._Nacionalnost;
			}
			set
			{
				if ((this._Nacionalnost != value))
				{
					this.OnNacionalnostChanging(value);
					this.SendPropertyChanging();
					this._Nacionalnost = value;
					this.SendPropertyChanged("Nacionalnost");
					this.OnNacionalnostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GodinaNaRaganje", DbType="Date")]
		public System.Nullable<System.DateTime> GodinaNaRaganje
		{
			get
			{
				return this._GodinaNaRaganje;
			}
			set
			{
				if ((this._GodinaNaRaganje != value))
				{
					this.OnGodinaNaRaganjeChanging(value);
					this.SendPropertyChanging();
					this._GodinaNaRaganje = value;
					this.SendPropertyChanged("GodinaNaRaganje");
					this.OnGodinaNaRaganjeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ClenoviNaBend")]
	public partial class ClenoviNaBend : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClenID;
		
		private int _BendID;
		
		private string _Uloga;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClenIDChanging(int value);
    partial void OnClenIDChanged();
    partial void OnBendIDChanging(int value);
    partial void OnBendIDChanged();
    partial void OnUlogaChanging(string value);
    partial void OnUlogaChanged();
    #endregion
		
		public ClenoviNaBend()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClenID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ClenID
		{
			get
			{
				return this._ClenID;
			}
			set
			{
				if ((this._ClenID != value))
				{
					this.OnClenIDChanging(value);
					this.SendPropertyChanging();
					this._ClenID = value;
					this.SendPropertyChanged("ClenID");
					this.OnClenIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BendID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BendID
		{
			get
			{
				return this._BendID;
			}
			set
			{
				if ((this._BendID != value))
				{
					this.OnBendIDChanging(value);
					this.SendPropertyChanging();
					this._BendID = value;
					this.SendPropertyChanged("BendID");
					this.OnBendIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Uloga", DbType="NVarChar(50)")]
		public string Uloga
		{
			get
			{
				return this._Uloga;
			}
			set
			{
				if ((this._Uloga != value))
				{
					this.OnUlogaChanging(value);
					this.SendPropertyChanging();
					this._Uloga = value;
					this.SendPropertyChanged("Uloga");
					this.OnUlogaChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bendovi")]
	public partial class Bendovi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BendID;
		
		private string _Ime;
		
		private System.Nullable<int> _BrojNaClenovi;
		
		private System.Nullable<System.DateTime> _GodinaNaFormiranje;
		
		private string _Drzava;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBendIDChanging(int value);
    partial void OnBendIDChanged();
    partial void OnImeChanging(string value);
    partial void OnImeChanged();
    partial void OnBrojNaClenoviChanging(System.Nullable<int> value);
    partial void OnBrojNaClenoviChanged();
    partial void OnGodinaNaFormiranjeChanging(System.Nullable<System.DateTime> value);
    partial void OnGodinaNaFormiranjeChanged();
    partial void OnDrzavaChanging(string value);
    partial void OnDrzavaChanged();
    #endregion
		
		public Bendovi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BendID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int BendID
		{
			get
			{
				return this._BendID;
			}
			set
			{
				if ((this._BendID != value))
				{
					this.OnBendIDChanging(value);
					this.SendPropertyChanging();
					this._BendID = value;
					this.SendPropertyChanged("BendID");
					this.OnBendIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ime", DbType="NVarChar(50)")]
		public string Ime
		{
			get
			{
				return this._Ime;
			}
			set
			{
				if ((this._Ime != value))
				{
					this.OnImeChanging(value);
					this.SendPropertyChanging();
					this._Ime = value;
					this.SendPropertyChanged("Ime");
					this.OnImeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BrojNaClenovi", DbType="Int")]
		public System.Nullable<int> BrojNaClenovi
		{
			get
			{
				return this._BrojNaClenovi;
			}
			set
			{
				if ((this._BrojNaClenovi != value))
				{
					this.OnBrojNaClenoviChanging(value);
					this.SendPropertyChanging();
					this._BrojNaClenovi = value;
					this.SendPropertyChanged("BrojNaClenovi");
					this.OnBrojNaClenoviChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GodinaNaFormiranje", DbType="Date")]
		public System.Nullable<System.DateTime> GodinaNaFormiranje
		{
			get
			{
				return this._GodinaNaFormiranje;
			}
			set
			{
				if ((this._GodinaNaFormiranje != value))
				{
					this.OnGodinaNaFormiranjeChanging(value);
					this.SendPropertyChanging();
					this._GodinaNaFormiranje = value;
					this.SendPropertyChanged("GodinaNaFormiranje");
					this.OnGodinaNaFormiranjeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Drzava", DbType="NVarChar(50)")]
		public string Drzava
		{
			get
			{
				return this._Drzava;
			}
			set
			{
				if ((this._Drzava != value))
				{
					this.OnDrzavaChanging(value);
					this.SendPropertyChanging();
					this._Drzava = value;
					this.SendPropertyChanged("Drzava");
					this.OnDrzavaChanged();
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
}
#pragma warning restore 1591
