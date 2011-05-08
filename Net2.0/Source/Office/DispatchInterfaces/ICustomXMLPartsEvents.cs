//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OfficeApi
{
	///<summary>
	/// DispatchInterface ICustomXMLPartsEvents SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class ICustomXMLPartsEvents : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICustomXMLPartsEvents(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICustomXMLPartsEvents(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICustomXMLPartsEvents(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ICustomXMLPartsEvents()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="NewPart">LateBindingApi.OfficeApi.CustomXMLPart NewPart</param>
		[SupportByLibrary("OF12","OF14")]
		public void PartAfterAdd(LateBindingApi.OfficeApi.CustomXMLPart newPart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newPart);
			Invoker.Method(this, "PartAfterAdd", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="OldPart">LateBindingApi.OfficeApi.CustomXMLPart OldPart</param>
		[SupportByLibrary("OF12","OF14")]
		public void PartBeforeDelete(LateBindingApi.OfficeApi.CustomXMLPart oldPart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldPart);
			Invoker.Method(this, "PartBeforeDelete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Part">LateBindingApi.OfficeApi.CustomXMLPart Part</param>
		[SupportByLibrary("OF12","OF14")]
		public void PartAfterLoad(LateBindingApi.OfficeApi.CustomXMLPart part)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(part);
			Invoker.Method(this, "PartAfterLoad", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}