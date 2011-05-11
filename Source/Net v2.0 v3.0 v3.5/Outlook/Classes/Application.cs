//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Application_ItemSendEventHandler(COMObject Item, ref bool Cancel);
	public delegate void Application_NewMailEventHandler();
	public delegate void Application_ReminderEventHandler(COMObject Item);
	public delegate void Application_OptionsPagesAddEventHandler(NetOffice.OutlookApi.PropertyPages Pages);
	public delegate void Application_StartupEventHandler();
	public delegate void Application_QuitEventHandler();
	public delegate void Application_AdvancedSearchCompleteEventHandler(NetOffice.OutlookApi.Search SearchObject);
	public delegate void Application_AdvancedSearchStoppedEventHandler(NetOffice.OutlookApi.Search SearchObject);
	public delegate void Application_MAPILogonCompleteEventHandler();
	public delegate void Application_NewMailExEventHandler(string EntryIDCollection);
	public delegate void Application_AttachmentContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.AttachmentSelection Attachments);
	public delegate void Application_FolderContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.Folder Folder);
	public delegate void Application_StoreContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.Store Store);
	public delegate void Application_ShortcutContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.OutlookBarShortcut Shortcut);
	public delegate void Application_ViewContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.View View);
	public delegate void Application_ItemContextMenuDisplayEventHandler(NetOffice.OfficeApi.CommandBar CommandBar, NetOffice.OutlookApi.Selection Selection);
	public delegate void Application_ContextMenuCloseEventHandler(NetOffice.OutlookApi.Enums.OlContextMenu ContextMenu);
	public delegate void Application_ItemLoadEventHandler(COMObject Item);
	public delegate void Application_BeforeFolderSharingDialogEventHandler(NetOffice.OutlookApi.MAPIFolder FolderToShare, ref bool Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Application SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class Application : _Application, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ApplicationEvents_SinkHelper _applicationEvents_SinkHelper;
		ApplicationEvents_10_SinkHelper _applicationEvents_10_SinkHelper;
		ApplicationEvents_11_SinkHelper _applicationEvents_11_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Application(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Application()
		{
			CreateFromProgId("Outlook.Application");
		}
		
		/// <param name="progId">progId</param>
		public Application(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ApplicationEvents_SinkHelper.Id,ApplicationEvents_10_SinkHelper.Id,ApplicationEvents_11_SinkHelper.Id);


			if(ApplicationEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_applicationEvents_SinkHelper = new ApplicationEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ApplicationEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_applicationEvents_10_SinkHelper = new ApplicationEvents_10_SinkHelper(this, _connectPoint);
				return;
			}

			if(ApplicationEvents_11_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_applicationEvents_11_SinkHelper = new ApplicationEvents_11_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_ItemSendEventHandler _ItemSendEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_ItemSendEventHandler ItemSendEvent
		{
			add
			{
				CreateEventBridge();
				_ItemSendEvent += value;
			}
			remove
			{
				_ItemSendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_NewMailEventHandler _NewMailEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_NewMailEventHandler NewMailEvent
		{
			add
			{
				CreateEventBridge();
				_NewMailEvent += value;
			}
			remove
			{
				_NewMailEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_ReminderEventHandler _ReminderEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_ReminderEventHandler ReminderEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderEvent += value;
			}
			remove
			{
				_ReminderEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_OptionsPagesAddEventHandler _OptionsPagesAddEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_OptionsPagesAddEventHandler OptionsPagesAddEvent
		{
			add
			{
				CreateEventBridge();
				_OptionsPagesAddEvent += value;
			}
			remove
			{
				_OptionsPagesAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_StartupEventHandler _StartupEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_StartupEventHandler StartupEvent
		{
			add
			{
				CreateEventBridge();
				_StartupEvent += value;
			}
			remove
			{
				_StartupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_QuitEventHandler _QuitEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Application_QuitEventHandler QuitEvent
		{
			add
			{
				CreateEventBridge();
				_QuitEvent += value;
			}
			remove
			{
				_QuitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_AdvancedSearchCompleteEventHandler _AdvancedSearchCompleteEvent;

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public event Application_AdvancedSearchCompleteEventHandler AdvancedSearchCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_AdvancedSearchCompleteEvent += value;
			}
			remove
			{
				_AdvancedSearchCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_AdvancedSearchStoppedEventHandler _AdvancedSearchStoppedEvent;

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public event Application_AdvancedSearchStoppedEventHandler AdvancedSearchStoppedEvent
		{
			add
			{
				CreateEventBridge();
				_AdvancedSearchStoppedEvent += value;
			}
			remove
			{
				_AdvancedSearchStoppedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		private event Application_MAPILogonCompleteEventHandler _MAPILogonCompleteEvent;

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public event Application_MAPILogonCompleteEventHandler MAPILogonCompleteEvent
		{
			add
			{
				CreateEventBridge();
				_MAPILogonCompleteEvent += value;
			}
			remove
			{
				_MAPILogonCompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14
		/// </summary>
		private event Application_NewMailExEventHandler _NewMailExEvent;

		/// <summary>
		/// SupportByLibrary OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL11","OL12","OL14")]
		public event Application_NewMailExEventHandler NewMailExEvent
		{
			add
			{
				CreateEventBridge();
				_NewMailExEvent += value;
			}
			remove
			{
				_NewMailExEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_AttachmentContextMenuDisplayEventHandler _AttachmentContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_AttachmentContextMenuDisplayEventHandler AttachmentContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentContextMenuDisplayEvent += value;
			}
			remove
			{
				_AttachmentContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_FolderContextMenuDisplayEventHandler _FolderContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_FolderContextMenuDisplayEventHandler FolderContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_FolderContextMenuDisplayEvent += value;
			}
			remove
			{
				_FolderContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_StoreContextMenuDisplayEventHandler _StoreContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_StoreContextMenuDisplayEventHandler StoreContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_StoreContextMenuDisplayEvent += value;
			}
			remove
			{
				_StoreContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_ShortcutContextMenuDisplayEventHandler _ShortcutContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_ShortcutContextMenuDisplayEventHandler ShortcutContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_ShortcutContextMenuDisplayEvent += value;
			}
			remove
			{
				_ShortcutContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_ViewContextMenuDisplayEventHandler _ViewContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_ViewContextMenuDisplayEventHandler ViewContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_ViewContextMenuDisplayEvent += value;
			}
			remove
			{
				_ViewContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_ItemContextMenuDisplayEventHandler _ItemContextMenuDisplayEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_ItemContextMenuDisplayEventHandler ItemContextMenuDisplayEvent
		{
			add
			{
				CreateEventBridge();
				_ItemContextMenuDisplayEvent += value;
			}
			remove
			{
				_ItemContextMenuDisplayEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_ContextMenuCloseEventHandler _ContextMenuCloseEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_ContextMenuCloseEventHandler ContextMenuCloseEvent
		{
			add
			{
				CreateEventBridge();
				_ContextMenuCloseEvent += value;
			}
			remove
			{
				_ContextMenuCloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_ItemLoadEventHandler _ItemLoadEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_ItemLoadEventHandler ItemLoadEvent
		{
			add
			{
				CreateEventBridge();
				_ItemLoadEvent += value;
			}
			remove
			{
				_ItemLoadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event Application_BeforeFolderSharingDialogEventHandler _BeforeFolderSharingDialogEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event Application_BeforeFolderSharingDialogEventHandler BeforeFolderSharingDialogEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeFolderSharingDialogEvent += value;
			}
			remove
			{
				_BeforeFolderSharingDialogEvent -= value;
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
			if( null != _applicationEvents_SinkHelper)
			{
				_applicationEvents_SinkHelper.Dispose();
				_applicationEvents_SinkHelper = null;
			}
			if( null != _applicationEvents_10_SinkHelper)
			{
				_applicationEvents_10_SinkHelper.Dispose();
				_applicationEvents_10_SinkHelper = null;
			}
			if( null != _applicationEvents_11_SinkHelper)
			{
				_applicationEvents_11_SinkHelper.Dispose();
				_applicationEvents_11_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}