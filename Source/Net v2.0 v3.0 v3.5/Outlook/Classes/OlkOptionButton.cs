//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void OlkOptionButton_ClickEventHandler();
	public delegate void OlkOptionButton_DoubleClickEventHandler();
	public delegate void OlkOptionButton_MouseDownEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkOptionButton_MouseMoveEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkOptionButton_MouseUpEventHandler(NetOffice.OutlookApi.Enums.OlMouseButton Button, NetOffice.OutlookApi.Enums.OlShiftState Shift, Single X, Single Y);
	public delegate void OlkOptionButton_EnterEventHandler();
	public delegate void OlkOptionButton_ExitEventHandler(ref bool Cancel);
	public delegate void OlkOptionButton_KeyDownEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkOptionButton_KeyPressEventHandler(ref Int32 KeyAscii);
	public delegate void OlkOptionButton_KeyUpEventHandler(ref Int32 KeyCode, NetOffice.OutlookApi.Enums.OlShiftState Shift);
	public delegate void OlkOptionButton_ChangeEventHandler();
	public delegate void OlkOptionButton_AfterUpdateEventHandler();
	public delegate void OlkOptionButton_BeforeUpdateEventHandler(ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass OlkOptionButton SupportByLibrary OL12 OL14 
	///</summary>
	[SupportByLibrary("OL12","OL14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class OlkOptionButton : _OlkOptionButton, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		OlkOptionButtonEvents_SinkHelper _olkOptionButtonEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkOptionButton(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkOptionButton(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public OlkOptionButton(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public OlkOptionButton()
		{
			CreateFromProgId("Outlook.OlkOptionButton");
		}
		
		/// <param name="progId">progId</param>
		public OlkOptionButton(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, OlkOptionButtonEvents_SinkHelper.Id);


			if(OlkOptionButtonEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_olkOptionButtonEvents_SinkHelper = new OlkOptionButtonEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_DoubleClickEventHandler _DoubleClickEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_DoubleClickEventHandler DoubleClickEvent
		{
			add
			{
				CreateEventBridge();
				_DoubleClickEvent += value;
			}
			remove
			{
				_DoubleClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_ChangeEventHandler _ChangeEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_ChangeEventHandler ChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ChangeEvent += value;
			}
			remove
			{
				_ChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event OlkOptionButton_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event OlkOptionButton_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _olkOptionButtonEvents_SinkHelper)
			{
				_olkOptionButtonEvents_SinkHelper.Dispose();
				_olkOptionButtonEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}