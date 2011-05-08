//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.ExcelApi
{
	///<summary>
	/// DispatchInterface ListObject SupportByLibrary XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL11","XL12","XL14")]
	public class ListObject : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListObject()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
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
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public string _Default
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool Active
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Active", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range DataBodyRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataBodyRange", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool DisplayRightToLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayRightToLeft", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range HeaderRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeaderRowRange", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range InsertRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsertRowRange", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.ListColumns ListColumns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListColumns", paramsArray);
				LateBindingApi.ExcelApi.ListColumns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.ListColumns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.ListRows ListRows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListRows", paramsArray);
				LateBindingApi.ExcelApi.ListRows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.ListRows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
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
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.QueryTable QueryTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryTable", paramsArray);
				LateBindingApi.ExcelApi.QueryTable newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.QueryTable;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool ShowAutoFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowAutoFilter", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowAutoFilter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public bool ShowTotals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTotals", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTotals", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Enums.XlListObjectSourceType SourceType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceType", paramsArray);
				return (LateBindingApi.ExcelApi.Enums.XlListObjectSourceType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.Range TotalsRowRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TotalsRowRange", paramsArray);
				LateBindingApi.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public string SharePointURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SharePointURL", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public LateBindingApi.ExcelApi.XmlMap XmlMap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XmlMap", paramsArray);
				LateBindingApi.ExcelApi.XmlMap newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.XmlMap;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public string DisplayName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowHeaders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowHeaders", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowHeaders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.AutoFilter AutoFilter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFilter", paramsArray);
				LateBindingApi.ExcelApi.AutoFilter newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.AutoFilter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public object TableStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableStyle", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TableStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowTableStyleFirstColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleFirstColumn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleFirstColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowTableStyleLastColumn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleLastColumn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleLastColumn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowTableStyleRowStripes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleRowStripes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleRowStripes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public bool ShowTableStyleColumnStripes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowTableStyleColumnStripes", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowTableStyleColumnStripes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public LateBindingApi.ExcelApi.Sort Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				LateBindingApi.ExcelApi.Sort newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.ExcelApi.Sort;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public string Comment
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Comment", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Comment", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public string Summary
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Summary", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Summary", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="Target">object Target</param>
		/// <param name="LinkSource">bool LinkSource</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public string Publish(object target, bool linkSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(target, linkSource);
			object returnItem = Invoker.MethodReturn(this, "Publish", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void Unlink()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Unlink", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void Unlist()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Unlist", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="iConflictType">LateBindingApi.ExcelApi.Enums.XlListConflict iConflictType</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void UpdateChanges(LateBindingApi.ExcelApi.Enums.XlListConflict iConflictType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(iConflictType);
			Invoker.Method(this, "UpdateChanges", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL11 XL12 XL14 
		/// </summary>
		/// <param name="Range">LateBindingApi.ExcelApi.Range Range</param>
		[SupportByLibrary("XL11","XL12","XL14")]
		public void Resize(LateBindingApi.ExcelApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "Resize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public void ExportToVisio()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ExportToVisio", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}