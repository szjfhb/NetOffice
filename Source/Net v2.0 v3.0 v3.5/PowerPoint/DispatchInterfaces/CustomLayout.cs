//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface CustomLayout SupportByLibrary PP12 PP14 
	///</summary>
	[SupportByLibrary("PP12","PP14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomLayout : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayout(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayout(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayout(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomLayout()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
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
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Shapes Shapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shapes", paramsArray);
				NetOffice.PowerPointApi.Shapes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Shapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.HeadersFooters HeadersFooters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HeadersFooters", paramsArray);
				NetOffice.PowerPointApi.HeadersFooters newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.HeadersFooters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.ShapeRange Background
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Background", paramsArray);
				NetOffice.PowerPointApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.ShapeRange;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
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
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Single)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Hyperlinks Hyperlinks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlinks", paramsArray);
				NetOffice.PowerPointApi.Hyperlinks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Hyperlinks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.Design Design
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Design", paramsArray);
				NetOffice.PowerPointApi.Design newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Design;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.TimeLine TimeLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TimeLine", paramsArray);
				NetOffice.PowerPointApi.TimeLine newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.TimeLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.SlideShowTransition SlideShowTransition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SlideShowTransition", paramsArray);
				NetOffice.PowerPointApi.SlideShowTransition newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.SlideShowTransition;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public string MatchingName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MatchingName", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MatchingName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState Preserved
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Preserved", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Preserved", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState DisplayMasterShapes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayMasterShapes", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayMasterShapes", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState FollowMasterBackground
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FollowMasterBackground", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FollowMasterBackground", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.ThemeColorScheme ThemeColorScheme
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ThemeColorScheme", paramsArray);
				NetOffice.OfficeApi.ThemeColorScheme newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.ThemeColorScheme;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.CustomerData CustomerData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomerData", paramsArray);
				NetOffice.PowerPointApi.CustomerData newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.CustomerData;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.PowerPointApi.CustomLayout Duplicate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Duplicate", paramsArray);
			NetOffice.PowerPointApi.CustomLayout newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.CustomLayout;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="toPos">Int32 toPos</param>
		[SupportByLibrary("PP12","PP14")]
		public void MoveTo(Int32 toPos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(toPos);
			Invoker.Method(this, "MoveTo", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}