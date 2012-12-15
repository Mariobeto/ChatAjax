﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebChat.Data
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Chat")]
	public partial class SessionDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblChatRoom(tblChatRoom instance);
    partial void UpdatetblChatRoom(tblChatRoom instance);
    partial void DeletetblChatRoom(tblChatRoom instance);
    partial void InserttblSession(tblSession instance);
    partial void UpdatetblSession(tblSession instance);
    partial void DeletetblSession(tblSession instance);
    partial void InserttblMessagePool(tblMessagePool instance);
    partial void UpdatetblMessagePool(tblMessagePool instance);
    partial void DeletetblMessagePool(tblMessagePool instance);
    partial void InserttblTalker(tblTalker instance);
    partial void UpdatetblTalker(tblTalker instance);
    partial void DeletetblTalker(tblTalker instance);
    #endregion
		
		public SessionDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ChatConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SessionDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SessionDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblChatRoom> tblChatRooms
		{
			get
			{
				return this.GetTable<tblChatRoom>();
			}
		}
		
		public System.Data.Linq.Table<tblSession> tblSessions
		{
			get
			{
				return this.GetTable<tblSession>();
			}
		}
		
		public System.Data.Linq.Table<tblMessagePool> tblMessagePools
		{
			get
			{
				return this.GetTable<tblMessagePool>();
			}
		}
		
		public System.Data.Linq.Table<tblTalker> tblTalkers
		{
			get
			{
				return this.GetTable<tblTalker>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblChatRoom")]
	public partial class tblChatRoom : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _ChatRoomID;
		
		private string _ChatRoomPassword;
		
		private string _ChatRoomName;
		
		private bool _NeedPassword;
		
		private int _MaxUserNumber;
		
		private bool _IsLock;
		
		private EntitySet<tblTalker> _tblTalkers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnChatRoomIDChanging(System.Guid value);
    partial void OnChatRoomIDChanged();
    partial void OnChatRoomPasswordChanging(string value);
    partial void OnChatRoomPasswordChanged();
    partial void OnChatRoomNameChanging(string value);
    partial void OnChatRoomNameChanged();
    partial void OnNeedPasswordChanging(bool value);
    partial void OnNeedPasswordChanged();
    partial void OnMaxUserNumberChanging(int value);
    partial void OnMaxUserNumberChanged();
    partial void OnIsLockChanging(bool value);
    partial void OnIsLockChanged();
    #endregion
		
		public tblChatRoom()
		{
			this._tblTalkers = new EntitySet<tblTalker>(new Action<tblTalker>(this.attach_tblTalkers), new Action<tblTalker>(this.detach_tblTalkers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatRoomID", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid ChatRoomID
		{
			get
			{
				return this._ChatRoomID;
			}
			set
			{
				if ((this._ChatRoomID != value))
				{
					this.OnChatRoomIDChanging(value);
					this.SendPropertyChanging();
					this._ChatRoomID = value;
					this.SendPropertyChanged("ChatRoomID");
					this.OnChatRoomIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatRoomPassword", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ChatRoomPassword
		{
			get
			{
				return this._ChatRoomPassword;
			}
			set
			{
				if ((this._ChatRoomPassword != value))
				{
					this.OnChatRoomPasswordChanging(value);
					this.SendPropertyChanging();
					this._ChatRoomPassword = value;
					this.SendPropertyChanged("ChatRoomPassword");
					this.OnChatRoomPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatRoomName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ChatRoomName
		{
			get
			{
				return this._ChatRoomName;
			}
			set
			{
				if ((this._ChatRoomName != value))
				{
					this.OnChatRoomNameChanging(value);
					this.SendPropertyChanging();
					this._ChatRoomName = value;
					this.SendPropertyChanged("ChatRoomName");
					this.OnChatRoomNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NeedPassword", DbType="Bit NOT NULL")]
		public bool NeedPassword
		{
			get
			{
				return this._NeedPassword;
			}
			set
			{
				if ((this._NeedPassword != value))
				{
					this.OnNeedPasswordChanging(value);
					this.SendPropertyChanging();
					this._NeedPassword = value;
					this.SendPropertyChanged("NeedPassword");
					this.OnNeedPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxUserNumber", DbType="Int NOT NULL")]
		public int MaxUserNumber
		{
			get
			{
				return this._MaxUserNumber;
			}
			set
			{
				if ((this._MaxUserNumber != value))
				{
					this.OnMaxUserNumberChanging(value);
					this.SendPropertyChanging();
					this._MaxUserNumber = value;
					this.SendPropertyChanged("MaxUserNumber");
					this.OnMaxUserNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsLock", DbType="Bit NOT NULL")]
		public bool IsLock
		{
			get
			{
				return this._IsLock;
			}
			set
			{
				if ((this._IsLock != value))
				{
					this.OnIsLockChanging(value);
					this.SendPropertyChanging();
					this._IsLock = value;
					this.SendPropertyChanged("IsLock");
					this.OnIsLockChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChatRoom_tblTalker", Storage="_tblTalkers", ThisKey="ChatRoomID", OtherKey="ChatRoomID")]
		public EntitySet<tblTalker> tblTalkers
		{
			get
			{
				return this._tblTalkers;
			}
			set
			{
				this._tblTalkers.Assign(value);
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
		
		private void attach_tblTalkers(tblTalker entity)
		{
			this.SendPropertyChanging();
			entity.tblChatRoom = this;
		}
		
		private void detach_tblTalkers(tblTalker entity)
		{
			this.SendPropertyChanging();
			entity.tblChatRoom = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblSession")]
	public partial class tblSession : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UID;
		
		private string _SessionID;
		
		private string _IP;
		
		private string _UserAlias;
		
		private EntitySet<tblTalker> _tblTalkers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUIDChanging(int value);
    partial void OnUIDChanged();
    partial void OnSessionIDChanging(string value);
    partial void OnSessionIDChanged();
    partial void OnIPChanging(string value);
    partial void OnIPChanged();
    partial void OnUserAliasChanging(string value);
    partial void OnUserAliasChanged();
    #endregion
		
		public tblSession()
		{
			this._tblTalkers = new EntitySet<tblTalker>(new Action<tblTalker>(this.attach_tblTalkers), new Action<tblTalker>(this.detach_tblTalkers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UID
		{
			get
			{
				return this._UID;
			}
			set
			{
				if ((this._UID != value))
				{
					this.OnUIDChanging(value);
					this.SendPropertyChanging();
					this._UID = value;
					this.SendPropertyChanged("UID");
					this.OnUIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				if ((this._SessionID != value))
				{
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._SessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IP", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IP
		{
			get
			{
				return this._IP;
			}
			set
			{
				if ((this._IP != value))
				{
					this.OnIPChanging(value);
					this.SendPropertyChanging();
					this._IP = value;
					this.SendPropertyChanged("IP");
					this.OnIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserAlias", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string UserAlias
		{
			get
			{
				return this._UserAlias;
			}
			set
			{
				if ((this._UserAlias != value))
				{
					this.OnUserAliasChanging(value);
					this.SendPropertyChanging();
					this._UserAlias = value;
					this.SendPropertyChanged("UserAlias");
					this.OnUserAliasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSession_tblTalker", Storage="_tblTalkers", ThisKey="UID", OtherKey="SessionID")]
		public EntitySet<tblTalker> tblTalkers
		{
			get
			{
				return this._tblTalkers;
			}
			set
			{
				this._tblTalkers.Assign(value);
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
		
		private void attach_tblTalkers(tblTalker entity)
		{
			this.SendPropertyChanging();
			entity.tblSession = this;
		}
		
		private void detach_tblTalkers(tblTalker entity)
		{
			this.SendPropertyChanging();
			entity.tblSession = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblMessagePool")]
	public partial class tblMessagePool : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _messageID;
		
		private string _message;
		
		private System.DateTime _SendTime;
		
		private int _talkerID;
		
		private EntityRef<tblTalker> _tblTalker;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmessageIDChanging(int value);
    partial void OnmessageIDChanged();
    partial void OnmessageChanging(string value);
    partial void OnmessageChanged();
    partial void OnSendTimeChanging(System.DateTime value);
    partial void OnSendTimeChanged();
    partial void OntalkerIDChanging(int value);
    partial void OntalkerIDChanged();
    #endregion
		
		public tblMessagePool()
		{
			this._tblTalker = default(EntityRef<tblTalker>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_messageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int messageID
		{
			get
			{
				return this._messageID;
			}
			set
			{
				if ((this._messageID != value))
				{
					this.OnmessageIDChanging(value);
					this.SendPropertyChanging();
					this._messageID = value;
					this.SendPropertyChanged("messageID");
					this.OnmessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="NVarChar(1000) NOT NULL", CanBeNull=false)]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this.OnmessageChanging(value);
					this.SendPropertyChanging();
					this._message = value;
					this.SendPropertyChanged("message");
					this.OnmessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SendTime", DbType="DateTime NOT NULL")]
		public System.DateTime SendTime
		{
			get
			{
				return this._SendTime;
			}
			set
			{
				if ((this._SendTime != value))
				{
					this.OnSendTimeChanging(value);
					this.SendPropertyChanging();
					this._SendTime = value;
					this.SendPropertyChanged("SendTime");
					this.OnSendTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_talkerID", DbType="Int NOT NULL")]
		public int talkerID
		{
			get
			{
				return this._talkerID;
			}
			set
			{
				if ((this._talkerID != value))
				{
					if (this._tblTalker.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntalkerIDChanging(value);
					this.SendPropertyChanging();
					this._talkerID = value;
					this.SendPropertyChanged("talkerID");
					this.OntalkerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblTalker_tblMessagePool", Storage="_tblTalker", ThisKey="talkerID", OtherKey="TalkerID", IsForeignKey=true)]
		public tblTalker tblTalker
		{
			get
			{
				return this._tblTalker.Entity;
			}
			set
			{
				tblTalker previousValue = this._tblTalker.Entity;
				if (((previousValue != value) 
							|| (this._tblTalker.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblTalker.Entity = null;
						previousValue.tblMessagePools.Remove(this);
					}
					this._tblTalker.Entity = value;
					if ((value != null))
					{
						value.tblMessagePools.Add(this);
						this._talkerID = value.TalkerID;
					}
					else
					{
						this._talkerID = default(int);
					}
					this.SendPropertyChanged("tblTalker");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTalker")]
	public partial class tblTalker : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TalkerID;
		
		private int _SessionID;
		
		private System.Guid _ChatRoomID;
		
		private System.DateTime _CheckInTime;
		
		private System.Nullable<System.DateTime> _CheckOutTime;
		
		private EntitySet<tblMessagePool> _tblMessagePools;
		
		private EntityRef<tblChatRoom> _tblChatRoom;
		
		private EntityRef<tblSession> _tblSession;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTalkerIDChanging(int value);
    partial void OnTalkerIDChanged();
    partial void OnSessionIDChanging(int value);
    partial void OnSessionIDChanged();
    partial void OnChatRoomIDChanging(System.Guid value);
    partial void OnChatRoomIDChanged();
    partial void OnCheckInTimeChanging(System.DateTime value);
    partial void OnCheckInTimeChanged();
    partial void OnCheckOutTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnCheckOutTimeChanged();
    #endregion
		
		public tblTalker()
		{
			this._tblMessagePools = new EntitySet<tblMessagePool>(new Action<tblMessagePool>(this.attach_tblMessagePools), new Action<tblMessagePool>(this.detach_tblMessagePools));
			this._tblChatRoom = default(EntityRef<tblChatRoom>);
			this._tblSession = default(EntityRef<tblSession>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TalkerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TalkerID
		{
			get
			{
				return this._TalkerID;
			}
			set
			{
				if ((this._TalkerID != value))
				{
					this.OnTalkerIDChanging(value);
					this.SendPropertyChanging();
					this._TalkerID = value;
					this.SendPropertyChanged("TalkerID");
					this.OnTalkerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SessionID", DbType="Int NOT NULL")]
		public int SessionID
		{
			get
			{
				return this._SessionID;
			}
			set
			{
				if ((this._SessionID != value))
				{
					if (this._tblSession.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._SessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChatRoomID", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid ChatRoomID
		{
			get
			{
				return this._ChatRoomID;
			}
			set
			{
				if ((this._ChatRoomID != value))
				{
					if (this._tblChatRoom.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnChatRoomIDChanging(value);
					this.SendPropertyChanging();
					this._ChatRoomID = value;
					this.SendPropertyChanged("ChatRoomID");
					this.OnChatRoomIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckInTime", DbType="DateTime NOT NULL")]
		public System.DateTime CheckInTime
		{
			get
			{
				return this._CheckInTime;
			}
			set
			{
				if ((this._CheckInTime != value))
				{
					this.OnCheckInTimeChanging(value);
					this.SendPropertyChanging();
					this._CheckInTime = value;
					this.SendPropertyChanged("CheckInTime");
					this.OnCheckInTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CheckOutTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> CheckOutTime
		{
			get
			{
				return this._CheckOutTime;
			}
			set
			{
				if ((this._CheckOutTime != value))
				{
					this.OnCheckOutTimeChanging(value);
					this.SendPropertyChanging();
					this._CheckOutTime = value;
					this.SendPropertyChanged("CheckOutTime");
					this.OnCheckOutTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblTalker_tblMessagePool", Storage="_tblMessagePools", ThisKey="TalkerID", OtherKey="talkerID")]
		public EntitySet<tblMessagePool> tblMessagePools
		{
			get
			{
				return this._tblMessagePools;
			}
			set
			{
				this._tblMessagePools.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblChatRoom_tblTalker", Storage="_tblChatRoom", ThisKey="ChatRoomID", OtherKey="ChatRoomID", IsForeignKey=true)]
		public tblChatRoom tblChatRoom
		{
			get
			{
				return this._tblChatRoom.Entity;
			}
			set
			{
				tblChatRoom previousValue = this._tblChatRoom.Entity;
				if (((previousValue != value) 
							|| (this._tblChatRoom.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblChatRoom.Entity = null;
						previousValue.tblTalkers.Remove(this);
					}
					this._tblChatRoom.Entity = value;
					if ((value != null))
					{
						value.tblTalkers.Add(this);
						this._ChatRoomID = value.ChatRoomID;
					}
					else
					{
						this._ChatRoomID = default(System.Guid);
					}
					this.SendPropertyChanged("tblChatRoom");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblSession_tblTalker", Storage="_tblSession", ThisKey="SessionID", OtherKey="UID", IsForeignKey=true)]
		public tblSession tblSession
		{
			get
			{
				return this._tblSession.Entity;
			}
			set
			{
				tblSession previousValue = this._tblSession.Entity;
				if (((previousValue != value) 
							|| (this._tblSession.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblSession.Entity = null;
						previousValue.tblTalkers.Remove(this);
					}
					this._tblSession.Entity = value;
					if ((value != null))
					{
						value.tblTalkers.Add(this);
						this._SessionID = value.UID;
					}
					else
					{
						this._SessionID = default(int);
					}
					this.SendPropertyChanged("tblSession");
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
		
		private void attach_tblMessagePools(tblMessagePool entity)
		{
			this.SendPropertyChanging();
			entity.tblTalker = this;
		}
		
		private void detach_tblMessagePools(tblMessagePool entity)
		{
			this.SendPropertyChanging();
			entity.tblTalker = null;
		}
	}
}
#pragma warning restore 1591
