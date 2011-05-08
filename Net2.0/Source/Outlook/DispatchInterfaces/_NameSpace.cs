//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{
	///<summary>
	/// DispatchInterface _NameSpace SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	public class _NameSpace : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NameSpace()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				LateBindingApi.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Recipient CurrentUser
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentUser", paramsArray);
				LateBindingApi.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Recipient;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi._Folders Folders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Folders", paramsArray);
				LateBindingApi.OutlookApi._Folders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi._Folders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public string Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressLists AddressLists
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AddressLists", paramsArray);
				LateBindingApi.OutlookApi.AddressLists newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.AddressLists;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.SyncObjects SyncObjects
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SyncObjects", paramsArray);
				LateBindingApi.OutlookApi.SyncObjects newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.SyncObjects;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public bool Offline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Offline", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public COMObject MAPIOBJECT
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MAPIOBJECT", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlExchangeConnectionMode ExchangeConnectionMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeConnectionMode", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlExchangeConnectionMode)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Accounts Accounts
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Accounts", paramsArray);
				LateBindingApi.OutlookApi.Accounts newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Accounts;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string CurrentProfileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CurrentProfileName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Stores Stores
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stores", paramsArray);
				LateBindingApi.OutlookApi.Stores newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Stores;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Store DefaultStore
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultStore", paramsArray);
				LateBindingApi.OutlookApi.Store newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Store;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Categories Categories
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Categories", paramsArray);
				LateBindingApi.OutlookApi.Categories newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.OutlookApi.Categories;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string ExchangeMailboxServerName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeMailboxServerName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string ExchangeMailboxServerVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExchangeMailboxServerVersion", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public string AutoDiscoverXml
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoDiscoverXml", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Enums.OlAutoDiscoverConnectionMode AutoDiscoverConnectionMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoDiscoverConnectionMode", paramsArray);
				return (LateBindingApi.OutlookApi.Enums.OlAutoDiscoverConnectionMode)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="RecipientName">string RecipientName</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Recipient CreateRecipient(string recipientName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recipientName);
			object returnItem = Invoker.MethodReturn(this, "CreateRecipient", paramsArray);
			LateBindingApi.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Recipient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="FolderType">LateBindingApi.OutlookApi.Enums.OlDefaultFolders FolderType</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder GetDefaultFolder(LateBindingApi.OutlookApi.Enums.OlDefaultFolders folderType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folderType);
			object returnItem = Invoker.MethodReturn(this, "GetDefaultFolder", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="EntryIDFolder">string EntryIDFolder</param>
		/// <param name="EntryIDStore">optional object EntryIDStore</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder GetFolderFromID(string entryIDFolder, object entryIDStore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDFolder, entryIDStore);
			object returnItem = Invoker.MethodReturn(this, "GetFolderFromID", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="EntryIDFolder">string EntryIDFolder</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder GetFolderFromID(string entryIDFolder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDFolder);
			object returnItem = Invoker.MethodReturn(this, "GetFolderFromID", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="EntryIDItem">string EntryIDItem</param>
		/// <param name="EntryIDStore">optional object EntryIDStore</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject GetItemFromID(string entryIDItem, object entryIDStore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDItem, entryIDStore);
			object returnItem = Invoker.MethodReturn(this, "GetItemFromID", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="EntryIDItem">string EntryIDItem</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public COMObject GetItemFromID(string entryIDItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryIDItem);
			object returnItem = Invoker.MethodReturn(this, "GetItemFromID", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="EntryID">string EntryID</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.Recipient GetRecipientFromID(string entryID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(entryID);
			object returnItem = Invoker.MethodReturn(this, "GetRecipientFromID", paramsArray);
			LateBindingApi.OutlookApi.Recipient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Recipient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Recipient">LateBindingApi.OutlookApi.Recipient Recipient</param>
		/// <param name="FolderType">LateBindingApi.OutlookApi.Enums.OlDefaultFolders FolderType</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder GetSharedDefaultFolder(LateBindingApi.OutlookApi.Recipient recipient, LateBindingApi.OutlookApi.Enums.OlDefaultFolders folderType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recipient, folderType);
			object returnItem = Invoker.MethodReturn(this, "GetSharedDefaultFolder", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Logoff()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Logoff", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Profile">optional object Profile</param>
		/// <param name="Password">optional object Password</param>
		/// <param name="ShowDialog">optional object ShowDialog</param>
		/// <param name="NewSession">optional object NewSession</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Logon(object profile, object password, object showDialog, object newSession)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(profile, password, showDialog, newSession);
			Invoker.Method(this, "Logon", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void Logon()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Logon", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder PickFolder()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PickFolder", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void RefreshRemoteHeaders()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshRemoteHeaders", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Store">object Store</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void AddStore(object store)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store);
			Invoker.Method(this, "AddStore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="Folder">LateBindingApi.OutlookApi.MAPIFolder Folder</param>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public void RemoveStore(LateBindingApi.OutlookApi.MAPIFolder folder)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(folder);
			Invoker.Method(this, "RemoveStore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		/// <param name="ContactItem">optional object ContactItem</param>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void Dial(object contactItem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(contactItem);
			Invoker.Method(this, "Dial", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public void Dial()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Dial", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14 
		/// </summary>
		/// <param name="Store">object Store</param>
		/// <param name="Type">LateBindingApi.OutlookApi.Enums.OlStoreType Type</param>
		[SupportByLibrary("OL11","OL12","OL14")]
		public void AddStoreEx(object store, LateBindingApi.OutlookApi.Enums.OlStoreType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(store, type);
			Invoker.Method(this, "AddStoreEx", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.SelectNamesDialog GetSelectNamesDialog()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetSelectNamesDialog", paramsArray);
			LateBindingApi.OutlookApi.SelectNamesDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.SelectNamesDialog;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="showProgressDialog">bool showProgressDialog</param>
		[SupportByLibrary("OL12","OL14")]
		public void SendAndReceive(bool showProgressDialog)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(showProgressDialog);
			Invoker.Method(this, "SendAndReceive", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="ID">string ID</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressEntry GetAddressEntryFromID(string iD)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iD);
			object returnItem = Invoker.MethodReturn(this, "GetAddressEntryFromID", paramsArray);
			LateBindingApi.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.AddressList GetGlobalAddressList()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetGlobalAddressList", paramsArray);
			LateBindingApi.OutlookApi.AddressList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.AddressList;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="ID">string ID</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.Store GetStoreFromID(string iD)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iD);
			object returnItem = Invoker.MethodReturn(this, "GetStoreFromID", paramsArray);
			LateBindingApi.OutlookApi.Store newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.Store;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Name">optional object Name</param>
		/// <param name="DownloadAttachments">optional object DownloadAttachments</param>
		/// <param name="UseTTL">optional object UseTTL</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder OpenSharedFolder(string path, object name, object downloadAttachments, object useTTL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, name, downloadAttachments, useTTL);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedFolder", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.MAPIFolder OpenSharedFolder(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedFolder", paramsArray);
			LateBindingApi.OutlookApi.MAPIFolder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.MAPIFolder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Path">string Path</param>
		[SupportByLibrary("OL12","OL14")]
		public COMObject OpenSharedItem(string path)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path);
			object returnItem = Invoker.MethodReturn(this, "OpenSharedItem", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Context">object Context</param>
		/// <param name="Provider">optional object Provider</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.SharingItem CreateSharingItem(object context, object provider)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(context, provider);
			object returnItem = Invoker.MethodReturn(this, "CreateSharingItem", paramsArray);
			LateBindingApi.OutlookApi.SharingItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.SharingItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="Context">object Context</param>
		[SupportByLibrary("OL12","OL14")]
		public LateBindingApi.OutlookApi.SharingItem CreateSharingItem(object context)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(context);
			object returnItem = Invoker.MethodReturn(this, "CreateSharingItem", paramsArray);
			LateBindingApi.OutlookApi.SharingItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OutlookApi.SharingItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14 
		/// </summary>
		/// <param name="FirstEntryID">string FirstEntryID</param>
		/// <param name="SecondEntryID">string SecondEntryID</param>
		[SupportByLibrary("OL12","OL14")]
		public bool CompareEntryIDs(string firstEntryID, string secondEntryID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(firstEntryID, secondEntryID);
			object returnItem = Invoker.MethodReturn(this, "CompareEntryIDs", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary OL14 
		/// </summary>
		/// <param name="AddressEntry">LateBindingApi.OutlookApi.AddressEntry AddressEntry</param>
		[SupportByLibrary("OL14")]
		public LateBindingApi.OfficeApi.ContactCard CreateContactCard(LateBindingApi.OutlookApi.AddressEntry addressEntry)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(addressEntry);
			object returnItem = Invoker.MethodReturn(this, "CreateContactCard", paramsArray);
			LateBindingApi.OfficeApi.ContactCard newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.OfficeApi.ContactCard;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}