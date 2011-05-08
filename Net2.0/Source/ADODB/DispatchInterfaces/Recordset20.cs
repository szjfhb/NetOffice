//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ADODBApi
{
	///<summary>
	/// DispatchInterface Recordset20 SupportByLibrary ADO2.1 ADO2.5 
	///</summary>
	[SupportByLibrary("ADO2.1","ADO2.5")]
	public class Recordset20 : Recordset15
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset20()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				LateBindingApi.ADODBApi.Properties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ADODBApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public COMObject DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public COMObject ActiveCommand
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCommand", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public bool StayInSync
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StayInSync", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "StayInSync", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string DataMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataMember", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataMember", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="PersistFormat">LateBindingApi.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADO2.1")]
		public void Save(string fileName, LateBindingApi.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "Save", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="StringFormat">LateBindingApi.ADODBApi.Enums.StringFormatEnum StringFormat</param>
		/// <param name="NumRows">Int32 NumRows</param>
		/// <param name="ColumnDelimeter">string ColumnDelimeter</param>
		/// <param name="RowDelimeter">string RowDelimeter</param>
		/// <param name="NullExpr">string NullExpr</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public string GetString(LateBindingApi.ADODBApi.Enums.StringFormatEnum stringFormat, Int32 numRows, string columnDelimeter, string rowDelimeter, string nullExpr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(stringFormat, numRows, columnDelimeter, rowDelimeter, nullExpr);
			object returnItem = Invoker.MethodReturn(this, "GetString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="Bookmark1">object Bookmark1</param>
		/// <param name="Bookmark2">object Bookmark2</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi.Enums.CompareEnum CompareBookmarks(object bookmark1, object bookmark2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bookmark1, bookmark2);
			object returnItem = Invoker.MethodReturn(this, "CompareBookmarks", paramsArray);
			return (LateBindingApi.ADODBApi.Enums.CompareEnum)returnItem;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="LockType">LateBindingApi.ADODBApi.Enums.LockTypeEnum LockType</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public LateBindingApi.ADODBApi._Recordset Clone(LateBindingApi.ADODBApi.Enums.LockTypeEnum lockType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lockType);
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			LateBindingApi.ADODBApi._Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.ADODBApi._Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary ADO2.1 ADO2.5 
		/// </summary>
		/// <param name="AffectRecords">LateBindingApi.ADODBApi.Enums.AffectEnum AffectRecords</param>
		/// <param name="ResyncValues">LateBindingApi.ADODBApi.Enums.ResyncEnum ResyncValues</param>
		[SupportByLibrary("ADO2.1","ADO2.5")]
		public void Resync(LateBindingApi.ADODBApi.Enums.AffectEnum affectRecords, LateBindingApi.ADODBApi.Enums.ResyncEnum resyncValues)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(affectRecords, resyncValues);
			Invoker.Method(this, "Resync", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary ADO2.5 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="PersistFormat">LateBindingApi.ADODBApi.Enums.PersistFormatEnum PersistFormat</param>
		[SupportByLibrary("ADO2.5")]
		public void _xSave(string fileName, LateBindingApi.ADODBApi.Enums.PersistFormatEnum persistFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, persistFormat);
			Invoker.Method(this, "_xSave", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}