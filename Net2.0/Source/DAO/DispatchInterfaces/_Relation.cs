//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.DAOApi
{
	///<summary>
	/// DispatchInterface _Relation SupportByLibrary DAO3.6 DAO12 
	///</summary>
	[SupportByLibrary("DAO3.6","DAO12")]
	public class _Relation : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Relation()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string Table
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Table", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Table", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public string ForeignTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeignTable", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeignTable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public Int32 Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Attributes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public LateBindingApi.DAOApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				LateBindingApi.DAOApi.Fields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.DAOApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public bool PartialReplica
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PartialReplica", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PartialReplica", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Size">optional object Size</param>
		[SupportByLibrary("DAO3.6","DAO12")]
		public LateBindingApi.DAOApi.Field CreateField(object name, object type, object size)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, size);
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			LateBindingApi.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.DAOApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary DAO3.6 DAO12 
		/// </summary>
		[SupportByLibrary("DAO3.6","DAO12")]
		public LateBindingApi.DAOApi.Field CreateField()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateField", paramsArray);
			LateBindingApi.DAOApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.DAOApi.Field;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}