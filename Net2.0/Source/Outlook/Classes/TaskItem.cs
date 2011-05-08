//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void TaskItem_OpenEventHandler(ref bool Cancel);
	public delegate void TaskItem_CustomActionEventHandler(COMObject Action, COMObject Response, ref bool Cancel);
	public delegate void TaskItem_CustomPropertyChangeEventHandler(string Name);
	public delegate void TaskItem_ForwardEventHandler(COMObject Forward, ref bool Cancel);
	public delegate void TaskItem_CloseEventHandler(ref bool Cancel);
	public delegate void TaskItem_PropertyChangeEventHandler(string Name);
	public delegate void TaskItem_ReadEventHandler();
	public delegate void TaskItem_ReplyEventHandler(COMObject Response, ref bool Cancel);
	public delegate void TaskItem_ReplyAllEventHandler(COMObject Response, ref bool Cancel);
	public delegate void TaskItem_SendEventHandler(ref bool Cancel);
	public delegate void TaskItem_WriteEventHandler(ref bool Cancel);
	public delegate void TaskItem_BeforeCheckNamesEventHandler(ref bool Cancel);
	public delegate void TaskItem_AttachmentAddEventHandler(LateBindingApi.OutlookApi.Attachment Attachment);
	public delegate void TaskItem_AttachmentReadEventHandler(LateBindingApi.OutlookApi.Attachment Attachment);
	public delegate void TaskItem_BeforeAttachmentSaveEventHandler(LateBindingApi.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskItem_BeforeDeleteEventHandler(COMObject Item, ref bool Cancel);
	public delegate void TaskItem_AttachmentRemoveEventHandler(LateBindingApi.OutlookApi.Attachment Attachment);
	public delegate void TaskItem_BeforeAttachmentAddEventHandler(LateBindingApi.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskItem_BeforeAttachmentPreviewEventHandler(LateBindingApi.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskItem_BeforeAttachmentReadEventHandler(LateBindingApi.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskItem_BeforeAttachmentWriteToTempFileEventHandler(LateBindingApi.OutlookApi.Attachment Attachment, ref bool Cancel);
	public delegate void TaskItem_UnloadEventHandler();
	public delegate void TaskItem_BeforeAutoSaveEventHandler(ref bool Cancel);
	public delegate void TaskItem_BeforeReadEventHandler();
	public delegate void TaskItem_AfterWriteEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass TaskItem SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	public class TaskItem : _TaskItem, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ItemEvents_SinkHelper _itemEvents_SinkHelper;
		ItemEvents_10_SinkHelper _itemEvents_10_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskItem(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskItem(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TaskItem(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public TaskItem()
		{
			CreateFromProgId("Outlook.TaskItem");
		}
		
		/// <param name="progId">progId</param>
		public TaskItem(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ItemEvents_SinkHelper.Id,ItemEvents_10_SinkHelper.Id);


			if(ItemEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_SinkHelper = new ItemEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(ItemEvents_10_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_itemEvents_10_SinkHelper = new ItemEvents_10_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_OpenEventHandler _OpenEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_OpenEventHandler OpenEvent
		{
			add
			{
				CreateEventBridge();
				_OpenEvent += value;
			}
			remove
			{
				_OpenEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_CustomActionEventHandler _CustomActionEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_CustomActionEventHandler CustomActionEvent
		{
			add
			{
				CreateEventBridge();
				_CustomActionEvent += value;
			}
			remove
			{
				_CustomActionEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_CustomPropertyChangeEventHandler _CustomPropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_CustomPropertyChangeEventHandler CustomPropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_CustomPropertyChangeEvent += value;
			}
			remove
			{
				_CustomPropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_ForwardEventHandler _ForwardEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_ForwardEventHandler ForwardEvent
		{
			add
			{
				CreateEventBridge();
				_ForwardEvent += value;
			}
			remove
			{
				_ForwardEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_CloseEventHandler _CloseEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_CloseEventHandler CloseEvent
		{
			add
			{
				CreateEventBridge();
				_CloseEvent += value;
			}
			remove
			{
				_CloseEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_PropertyChangeEventHandler _PropertyChangeEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_PropertyChangeEventHandler PropertyChangeEvent
		{
			add
			{
				CreateEventBridge();
				_PropertyChangeEvent += value;
			}
			remove
			{
				_PropertyChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_ReadEventHandler _ReadEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_ReadEventHandler ReadEvent
		{
			add
			{
				CreateEventBridge();
				_ReadEvent += value;
			}
			remove
			{
				_ReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_ReplyEventHandler _ReplyEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_ReplyEventHandler ReplyEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyEvent += value;
			}
			remove
			{
				_ReplyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_ReplyAllEventHandler _ReplyAllEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_ReplyAllEventHandler ReplyAllEvent
		{
			add
			{
				CreateEventBridge();
				_ReplyAllEvent += value;
			}
			remove
			{
				_ReplyAllEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_SendEventHandler _SendEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_SendEventHandler SendEvent
		{
			add
			{
				CreateEventBridge();
				_SendEvent += value;
			}
			remove
			{
				_SendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_WriteEventHandler _WriteEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_WriteEventHandler WriteEvent
		{
			add
			{
				CreateEventBridge();
				_WriteEvent += value;
			}
			remove
			{
				_WriteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_BeforeCheckNamesEventHandler _BeforeCheckNamesEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_BeforeCheckNamesEventHandler BeforeCheckNamesEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeCheckNamesEvent += value;
			}
			remove
			{
				_BeforeCheckNamesEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_AttachmentAddEventHandler _AttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_AttachmentAddEventHandler AttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentAddEvent += value;
			}
			remove
			{
				_AttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_AttachmentReadEventHandler _AttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_AttachmentReadEventHandler AttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentReadEvent += value;
			}
			remove
			{
				_AttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAttachmentSaveEventHandler _BeforeAttachmentSaveEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event TaskItem_BeforeAttachmentSaveEventHandler BeforeAttachmentSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentSaveEvent += value;
			}
			remove
			{
				_BeforeAttachmentSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		private event TaskItem_BeforeDeleteEventHandler _BeforeDeleteEvent;

		/// <summary>
		/// SupportByLibrary OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL10","OL11","OL12","OL14")]
		public event TaskItem_BeforeDeleteEventHandler BeforeDeleteEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeDeleteEvent += value;
			}
			remove
			{
				_BeforeDeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_AttachmentRemoveEventHandler _AttachmentRemoveEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_AttachmentRemoveEventHandler AttachmentRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_AttachmentRemoveEvent += value;
			}
			remove
			{
				_AttachmentRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAttachmentAddEventHandler _BeforeAttachmentAddEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_BeforeAttachmentAddEventHandler BeforeAttachmentAddEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentAddEvent += value;
			}
			remove
			{
				_BeforeAttachmentAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAttachmentPreviewEventHandler _BeforeAttachmentPreviewEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_BeforeAttachmentPreviewEventHandler BeforeAttachmentPreviewEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentPreviewEvent += value;
			}
			remove
			{
				_BeforeAttachmentPreviewEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAttachmentReadEventHandler _BeforeAttachmentReadEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_BeforeAttachmentReadEventHandler BeforeAttachmentReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentReadEvent += value;
			}
			remove
			{
				_BeforeAttachmentReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAttachmentWriteToTempFileEventHandler _BeforeAttachmentWriteToTempFileEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_BeforeAttachmentWriteToTempFileEventHandler BeforeAttachmentWriteToTempFileEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAttachmentWriteToTempFileEvent += value;
			}
			remove
			{
				_BeforeAttachmentWriteToTempFileEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_UnloadEventHandler _UnloadEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_UnloadEventHandler UnloadEvent
		{
			add
			{
				CreateEventBridge();
				_UnloadEvent += value;
			}
			remove
			{
				_UnloadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		private event TaskItem_BeforeAutoSaveEventHandler _BeforeAutoSaveEvent;

		/// <summary>
		/// SupportByLibrary OL12 OL14
		/// </summary>
		[SupportByLibrary("OL12","OL14")]
		public event TaskItem_BeforeAutoSaveEventHandler BeforeAutoSaveEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeAutoSaveEvent += value;
			}
			remove
			{
				_BeforeAutoSaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14
		/// </summary>
		private event TaskItem_BeforeReadEventHandler _BeforeReadEvent;

		/// <summary>
		/// SupportByLibrary OL14
		/// </summary>
		[SupportByLibrary("OL14")]
		public event TaskItem_BeforeReadEventHandler BeforeReadEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReadEvent += value;
			}
			remove
			{
				_BeforeReadEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL14
		/// </summary>
		private event TaskItem_AfterWriteEventHandler _AfterWriteEvent;

		/// <summary>
		/// SupportByLibrary OL14
		/// </summary>
		[SupportByLibrary("OL14")]
		public event TaskItem_AfterWriteEventHandler AfterWriteEvent
		{
			add
			{
				CreateEventBridge();
				_AfterWriteEvent += value;
			}
			remove
			{
				_AfterWriteEvent -= value;
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
			if( null != _itemEvents_SinkHelper)
			{
				_itemEvents_SinkHelper.Dispose();
				_itemEvents_SinkHelper = null;
			}
			if( null != _itemEvents_10_SinkHelper)
			{
				_itemEvents_10_SinkHelper.Dispose();
				_itemEvents_10_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}