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

namespace CRM
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CRM")]
	public partial class DataClassesCRMDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcountry(country instance);
    partial void Updatecountry(country instance);
    partial void Deletecountry(country instance);
    partial void Insertlogin(login instance);
    partial void Updatelogin(login instance);
    partial void Deletelogin(login instance);
    partial void Insertmenu(menu instance);
    partial void Updatemenu(menu instance);
    partial void Deletemenu(menu instance);
    partial void Inserttask(task instance);
    partial void Updatetask(task instance);
    partial void Deletetask(task instance);
    partial void Insertcustomer(customer instance);
    partial void Updatecustomer(customer instance);
    partial void Deletecustomer(customer instance);
    partial void Insertstatus(status instance);
    partial void Updatestatus(status instance);
    partial void Deletestatus(status instance);
    #endregion
		
		public DataClassesCRMDataContext() : 
				base(global::CRM.Properties.Settings.Default.CRMConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCRMDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCRMDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCRMDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesCRMDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<country> countries
		{
			get
			{
				return this.GetTable<country>();
			}
		}
		
		public System.Data.Linq.Table<login> logins
		{
			get
			{
				return this.GetTable<login>();
			}
		}
		
		public System.Data.Linq.Table<menu> menus
		{
			get
			{
				return this.GetTable<menu>();
			}
		}
		
		public System.Data.Linq.Table<task> tasks
		{
			get
			{
				return this.GetTable<task>();
			}
		}
		
		public System.Data.Linq.Table<customer> customers
		{
			get
			{
				return this.GetTable<customer>();
			}
		}
		
		public System.Data.Linq.Table<status> status
		{
			get
			{
				return this.GetTable<status>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.country")]
	public partial class country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_country;
		
		private string _name;
		
		private string _alpha_2;
		
		private string _aplha_3;
		
		private string _country_code;
		
		private string _iso;
		
		private string _region;
		
		private string _sub_region;
		
		private string _region_code;
		
		private string _sub_region_code;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_countryChanging(int value);
    partial void Onid_countryChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onalpha_2Changing(string value);
    partial void Onalpha_2Changed();
    partial void Onaplha_3Changing(string value);
    partial void Onaplha_3Changed();
    partial void Oncountry_codeChanging(string value);
    partial void Oncountry_codeChanged();
    partial void OnisoChanging(string value);
    partial void OnisoChanged();
    partial void OnregionChanging(string value);
    partial void OnregionChanged();
    partial void Onsub_regionChanging(string value);
    partial void Onsub_regionChanged();
    partial void Onregion_codeChanging(string value);
    partial void Onregion_codeChanged();
    partial void Onsub_region_codeChanging(string value);
    partial void Onsub_region_codeChanged();
    #endregion
		
		public country()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_country", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_country
		{
			get
			{
				return this._id_country;
			}
			set
			{
				if ((this._id_country != value))
				{
					this.Onid_countryChanging(value);
					this.SendPropertyChanging();
					this._id_country = value;
					this.SendPropertyChanged("id_country");
					this.Onid_countryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alpha_2", DbType="VarChar(2)")]
		public string alpha_2
		{
			get
			{
				return this._alpha_2;
			}
			set
			{
				if ((this._alpha_2 != value))
				{
					this.Onalpha_2Changing(value);
					this.SendPropertyChanging();
					this._alpha_2 = value;
					this.SendPropertyChanged("alpha_2");
					this.Onalpha_2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aplha_3", DbType="VarChar(3)")]
		public string aplha_3
		{
			get
			{
				return this._aplha_3;
			}
			set
			{
				if ((this._aplha_3 != value))
				{
					this.Onaplha_3Changing(value);
					this.SendPropertyChanging();
					this._aplha_3 = value;
					this.SendPropertyChanged("aplha_3");
					this.Onaplha_3Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country_code", DbType="VarChar(3)")]
		public string country_code
		{
			get
			{
				return this._country_code;
			}
			set
			{
				if ((this._country_code != value))
				{
					this.Oncountry_codeChanging(value);
					this.SendPropertyChanging();
					this._country_code = value;
					this.SendPropertyChanged("country_code");
					this.Oncountry_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_iso", DbType="VarChar(20)")]
		public string iso
		{
			get
			{
				return this._iso;
			}
			set
			{
				if ((this._iso != value))
				{
					this.OnisoChanging(value);
					this.SendPropertyChanging();
					this._iso = value;
					this.SendPropertyChanged("iso");
					this.OnisoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region", DbType="VarChar(20)")]
		public string region
		{
			get
			{
				return this._region;
			}
			set
			{
				if ((this._region != value))
				{
					this.OnregionChanging(value);
					this.SendPropertyChanging();
					this._region = value;
					this.SendPropertyChanged("region");
					this.OnregionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sub_region", DbType="VarChar(50)")]
		public string sub_region
		{
			get
			{
				return this._sub_region;
			}
			set
			{
				if ((this._sub_region != value))
				{
					this.Onsub_regionChanging(value);
					this.SendPropertyChanging();
					this._sub_region = value;
					this.SendPropertyChanged("sub_region");
					this.Onsub_regionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region_code", DbType="VarChar(3)")]
		public string region_code
		{
			get
			{
				return this._region_code;
			}
			set
			{
				if ((this._region_code != value))
				{
					this.Onregion_codeChanging(value);
					this.SendPropertyChanging();
					this._region_code = value;
					this.SendPropertyChanged("region_code");
					this.Onregion_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sub_region_code", DbType="VarChar(3)")]
		public string sub_region_code
		{
			get
			{
				return this._sub_region_code;
			}
			set
			{
				if ((this._sub_region_code != value))
				{
					this.Onsub_region_codeChanging(value);
					this.SendPropertyChanging();
					this._sub_region_code = value;
					this.SendPropertyChanged("sub_region_code");
					this.Onsub_region_codeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.logins")]
	public partial class login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_logins;
		
		private string _first_name;
		
		private string _name;
		
		private string _login1;
		
		private string _pass;
		
		private System.Nullable<bool> _bloced;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_loginsChanging(int value);
    partial void Onid_loginsChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onlogin1Changing(string value);
    partial void Onlogin1Changed();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    partial void OnblocedChanging(System.Nullable<bool> value);
    partial void OnblocedChanged();
    #endregion
		
		public login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_logins", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_logins
		{
			get
			{
				return this._id_logins;
			}
			set
			{
				if ((this._id_logins != value))
				{
					this.Onid_loginsChanging(value);
					this.SendPropertyChanging();
					this._id_logins = value;
					this.SendPropertyChanged("id_logins");
					this.Onid_loginsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="login", Storage="_login1", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string login1
		{
			get
			{
				return this._login1;
			}
			set
			{
				if ((this._login1 != value))
				{
					this.Onlogin1Changing(value);
					this.SendPropertyChanging();
					this._login1 = value;
					this.SendPropertyChanged("login1");
					this.Onlogin1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bloced", DbType="Bit")]
		public System.Nullable<bool> bloced
		{
			get
			{
				return this._bloced;
			}
			set
			{
				if ((this._bloced != value))
				{
					this.OnblocedChanging(value);
					this.SendPropertyChanging();
					this._bloced = value;
					this.SendPropertyChanged("bloced");
					this.OnblocedChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.menu")]
	public partial class menu : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_menu;
		
		private string _menu1;
		
		private string _parent_id;
		
		private System.Nullable<bool> _activie;
		
		private System.Nullable<int> _orders;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_menuChanging(int value);
    partial void Onid_menuChanged();
    partial void Onmenu1Changing(string value);
    partial void Onmenu1Changed();
    partial void Onparent_idChanging(string value);
    partial void Onparent_idChanged();
    partial void OnactivieChanging(System.Nullable<bool> value);
    partial void OnactivieChanged();
    partial void OnordersChanging(System.Nullable<int> value);
    partial void OnordersChanged();
    #endregion
		
		public menu()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_menu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_menu
		{
			get
			{
				return this._id_menu;
			}
			set
			{
				if ((this._id_menu != value))
				{
					this.Onid_menuChanging(value);
					this.SendPropertyChanging();
					this._id_menu = value;
					this.SendPropertyChanged("id_menu");
					this.Onid_menuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="menu", Storage="_menu1", DbType="VarChar(200)")]
		public string menu1
		{
			get
			{
				return this._menu1;
			}
			set
			{
				if ((this._menu1 != value))
				{
					this.Onmenu1Changing(value);
					this.SendPropertyChanging();
					this._menu1 = value;
					this.SendPropertyChanged("menu1");
					this.Onmenu1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_parent_id", DbType="NChar(10)")]
		public string parent_id
		{
			get
			{
				return this._parent_id;
			}
			set
			{
				if ((this._parent_id != value))
				{
					this.Onparent_idChanging(value);
					this.SendPropertyChanging();
					this._parent_id = value;
					this.SendPropertyChanged("parent_id");
					this.Onparent_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activie", DbType="Bit")]
		public System.Nullable<bool> activie
		{
			get
			{
				return this._activie;
			}
			set
			{
				if ((this._activie != value))
				{
					this.OnactivieChanging(value);
					this.SendPropertyChanging();
					this._activie = value;
					this.SendPropertyChanged("activie");
					this.OnactivieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_orders", DbType="Int")]
		public System.Nullable<int> orders
		{
			get
			{
				return this._orders;
			}
			set
			{
				if ((this._orders != value))
				{
					this.OnordersChanging(value);
					this.SendPropertyChanging();
					this._orders = value;
					this.SendPropertyChanged("orders");
					this.OnordersChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tasks")]
	public partial class task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_tasks;
		
		private string _title;
		
		private string _descryption;
		
		private System.DateTime _date_created;
		
		private System.Nullable<int> _id_next_task;
		
		private string _status;
		
		private System.Nullable<int> _id_customers;
		
		private System.Nullable<System.DateTime> _next_contact;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_tasksChanging(int value);
    partial void Onid_tasksChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndescryptionChanging(string value);
    partial void OndescryptionChanged();
    partial void Ondate_createdChanging(System.DateTime value);
    partial void Ondate_createdChanged();
    partial void Onid_next_taskChanging(System.Nullable<int> value);
    partial void Onid_next_taskChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void Onid_customersChanging(System.Nullable<int> value);
    partial void Onid_customersChanged();
    partial void Onnext_contactChanging(System.Nullable<System.DateTime> value);
    partial void Onnext_contactChanged();
    #endregion
		
		public task()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_tasks", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_tasks
		{
			get
			{
				return this._id_tasks;
			}
			set
			{
				if ((this._id_tasks != value))
				{
					this.Onid_tasksChanging(value);
					this.SendPropertyChanging();
					this._id_tasks = value;
					this.SendPropertyChanged("id_tasks");
					this.Onid_tasksChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descryption", DbType="VarChar(1)")]
		public string descryption
		{
			get
			{
				return this._descryption;
			}
			set
			{
				if ((this._descryption != value))
				{
					this.OndescryptionChanging(value);
					this.SendPropertyChanging();
					this._descryption = value;
					this.SendPropertyChanged("descryption");
					this.OndescryptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_created", DbType="DateTime NOT NULL")]
		public System.DateTime date_created
		{
			get
			{
				return this._date_created;
			}
			set
			{
				if ((this._date_created != value))
				{
					this.Ondate_createdChanging(value);
					this.SendPropertyChanging();
					this._date_created = value;
					this.SendPropertyChanged("date_created");
					this.Ondate_createdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_next_task", DbType="Int")]
		public System.Nullable<int> id_next_task
		{
			get
			{
				return this._id_next_task;
			}
			set
			{
				if ((this._id_next_task != value))
				{
					this.Onid_next_taskChanging(value);
					this.SendPropertyChanging();
					this._id_next_task = value;
					this.SendPropertyChanged("id_next_task");
					this.Onid_next_taskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(3)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_customers", DbType="Int")]
		public System.Nullable<int> id_customers
		{
			get
			{
				return this._id_customers;
			}
			set
			{
				if ((this._id_customers != value))
				{
					this.Onid_customersChanging(value);
					this.SendPropertyChanging();
					this._id_customers = value;
					this.SendPropertyChanged("id_customers");
					this.Onid_customersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_next_contact", DbType="DateTime")]
		public System.Nullable<System.DateTime> next_contact
		{
			get
			{
				return this._next_contact;
			}
			set
			{
				if ((this._next_contact != value))
				{
					this.Onnext_contactChanging(value);
					this.SendPropertyChanging();
					this._next_contact = value;
					this.SendPropertyChanged("next_contact");
					this.Onnext_contactChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.customers")]
	public partial class customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_customers;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _nationality;
		
		private string _state;
		
		private string _city;
		
		private string _street;
		
		private string _No;
		
		private System.Nullable<System.DateTime> _dob;
		
		private string _email;
		
		private string _phone;
		
		private string _phone2;
		
		private string _status;
		
		private string _job;
		
		private string _descryption;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_customersChanging(int value);
    partial void Onid_customersChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    partial void OnstateChanging(string value);
    partial void OnstateChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OnNoChanging(string value);
    partial void OnNoChanged();
    partial void OndobChanging(System.Nullable<System.DateTime> value);
    partial void OndobChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void Onphone2Changing(string value);
    partial void Onphone2Changed();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OnjobChanging(string value);
    partial void OnjobChanged();
    partial void OndescryptionChanging(string value);
    partial void OndescryptionChanged();
    #endregion
		
		public customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_customers", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_customers
		{
			get
			{
				return this._id_customers;
			}
			set
			{
				if ((this._id_customers != value))
				{
					this.Onid_customersChanging(value);
					this.SendPropertyChanging();
					this._id_customers = value;
					this.SendPropertyChanged("id_customers");
					this.Onid_customersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(3)")]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="VarChar(100)")]
		public string state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(100)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="VarChar(100)")]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_No", DbType="VarChar(50)")]
		public string No
		{
			get
			{
				return this._No;
			}
			set
			{
				if ((this._No != value))
				{
					this.OnNoChanging(value);
					this.SendPropertyChanging();
					this._No = value;
					this.SendPropertyChanged("No");
					this.OnNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="Date")]
		public System.Nullable<System.DateTime> dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(20)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone2", DbType="VarChar(20)")]
		public string phone2
		{
			get
			{
				return this._phone2;
			}
			set
			{
				if ((this._phone2 != value))
				{
					this.Onphone2Changing(value);
					this.SendPropertyChanging();
					this._phone2 = value;
					this.SendPropertyChanged("phone2");
					this.Onphone2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(2)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job", DbType="VarChar(100)")]
		public string job
		{
			get
			{
				return this._job;
			}
			set
			{
				if ((this._job != value))
				{
					this.OnjobChanging(value);
					this.SendPropertyChanging();
					this._job = value;
					this.SendPropertyChanged("job");
					this.OnjobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descryption", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string descryption
		{
			get
			{
				return this._descryption;
			}
			set
			{
				if ((this._descryption != value))
				{
					this.OndescryptionChanging(value);
					this.SendPropertyChanging();
					this._descryption = value;
					this.SendPropertyChanged("descryption");
					this.OndescryptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.status")]
	public partial class status : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_status;
		
		private string _name;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_statusChanging(int value);
    partial void Onid_statusChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public status()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_status", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_status
		{
			get
			{
				return this._id_status;
			}
			set
			{
				if ((this._id_status != value))
				{
					this.Onid_statusChanging(value);
					this.SendPropertyChanging();
					this._id_status = value;
					this.SendPropertyChanged("id_status");
					this.Onid_statusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
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
