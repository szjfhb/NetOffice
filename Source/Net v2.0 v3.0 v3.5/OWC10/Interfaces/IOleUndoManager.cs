//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// Interface IOleUndoManager SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IOleUndoManager : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleUndoManager(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleUndoManager(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleUndoManager(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IOleUndoManager()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pPUU">NetOffice.OWC10Api.IOleParentUndoUnit pPUU</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 Open(NetOffice.OWC10Api.IOleParentUndoUnit pPUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPUU);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pPUU">NetOffice.OWC10Api.IOleParentUndoUnit pPUU</param>
		/// <param name="fCommit">Int32 fCommit</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 Close(NetOffice.OWC10Api.IOleParentUndoUnit pPUU, Int32 fCommit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pPUU, fCommit);
			object returnItem = Invoker.MethodReturn(this, "Close", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 Add(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pdwState">ref Int32 pdwState</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 GetOpenParentState(ref Int32 pdwState)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pdwState);
			object returnItem = Invoker.MethodReturn(this, "GetOpenParentState", paramsArray);
			pdwState = (Int32)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 DiscardFrom(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "DiscardFrom", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 UndoTo(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "UndoTo", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pUU">NetOffice.OWC10Api.IOleUndoUnit pUU</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 RedoTo(NetOffice.OWC10Api.IOleUndoUnit pUU)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pUU);
			object returnItem = Invoker.MethodReturn(this, "RedoTo", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="ppEnum">ref NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 EnumUndoable(ref NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			object returnItem = Invoker.MethodReturn(this, "EnumUndoable", paramsArray);
			ppEnum = (NetOffice.OWC10Api.IEnumOleUndoUnits)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="ppEnum">ref NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 EnumRedoable(ref NetOffice.OWC10Api.IEnumOleUndoUnits ppEnum)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(ppEnum);
			object returnItem = Invoker.MethodReturn(this, "EnumRedoable", paramsArray);
			ppEnum = (NetOffice.OWC10Api.IEnumOleUndoUnits)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pbstr">ref string pbstr</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 GetLastUndoDescription(ref string pbstr)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pbstr);
			object returnItem = Invoker.MethodReturn(this, "GetLastUndoDescription", paramsArray);
			pbstr = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="pbstr">ref string pbstr</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 GetLastRedoDescription(ref string pbstr)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(pbstr);
			object returnItem = Invoker.MethodReturn(this, "GetLastRedoDescription", paramsArray);
			pbstr = (string)paramsArray[0];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="fEnable">Int32 fEnable</param>
		[SupportByLibrary("XWC1.0")]
		public Int32 Enable(Int32 fEnable)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fEnable);
			object returnItem = Invoker.MethodReturn(this, "Enable", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}