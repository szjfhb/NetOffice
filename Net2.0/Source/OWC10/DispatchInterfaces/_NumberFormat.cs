//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{
	///<summary>
	/// DispatchInterface _NumberFormat SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class _NumberFormat : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NumberFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NumberFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NumberFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _NumberFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
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
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Code
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Code", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Code", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Value">object Value</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibrary("XWC1.0")]
		public string get_Format(object value, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(value, count);
			object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="hDC">Int32 hDC</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 get_Width(Int32 hDC, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hDC, value);
			object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="hDC">Int32 hDC</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 get_Height(Int32 hDC, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hDC, value);
			object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
			return (Int32)returnItem;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="hDC">Int32 hDC</param>
		/// <param name="hDCInfo">Int32 hDCInfo</param>
		/// <param name="cx1">Int32 cx1</param>
		/// <param name="cy1">Int32 cy1</param>
		/// <param name="cx2">Int32 cx2</param>
		/// <param name="cy2">Int32 cy2</param>
		/// <param name="Left">Int32 Left</param>
		/// <param name="Top">Int32 Top</param>
		/// <param name="Width">Int32 Width</param>
		/// <param name="Height">Int32 Height</param>
		/// <param name="HorizontalAlignment">Int32 HorizontalAlignment</param>
		/// <param name="VerticalAlignment">Int32 VerticalAlignment</param>
		/// <param name="Value">object Value</param>
		[SupportByLibrary("XWC1.0")]
		public void Render(Int32 hDC, Int32 hDCInfo, Int32 cx1, Int32 cy1, Int32 cx2, Int32 cy2, Int32 left, Int32 top, Int32 width, Int32 height, Int32 horizontalAlignment, Int32 verticalAlignment, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hDC, hDCInfo, cx1, cy1, cx2, cy2, left, top, width, height, horizontalAlignment, verticalAlignment, value);
			Invoker.Method(this, "Render", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}