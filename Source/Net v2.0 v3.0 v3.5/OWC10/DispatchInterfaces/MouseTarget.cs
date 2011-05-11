//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface MouseTarget SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MouseTarget : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTarget(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTarget(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTarget(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MouseTarget()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Cursor">ref Int32 Cursor</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseEnter(Int32 x, Int32 y, ref Int32 cursor)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, cursor);
			Invoker.Method(this, "MouseEnter", paramsArray, modifiers);
			cursor = (Int32)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Cursor">ref Int32 Cursor</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseOver(Int32 x, Int32 y, ref Int32 cursor)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, cursor);
			Invoker.Method(this, "MouseOver", paramsArray, modifiers);
			cursor = (Int32)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void MouseLeave()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MouseLeave", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Button">Int32 Button</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseDown(Int32 x, Int32 y, Int32 button)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, button);
			Invoker.Method(this, "MouseDown", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Button">Int32 Button</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseUp(Int32 x, Int32 y, Int32 button)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, button);
			Invoker.Method(this, "MouseUp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Button">Int32 Button</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseClick(Int32 x, Int32 y, Int32 button)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, button);
			Invoker.Method(this, "MouseClick", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Button">Int32 Button</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseDblClick(Int32 x, Int32 y, Int32 button)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, button);
			Invoker.Method(this, "MouseDblClick", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Page">bool Page</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibrary("XWC1.0")]
		public void MouseWheel(bool page, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(page, count);
			Invoker.Method(this, "MouseWheel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}