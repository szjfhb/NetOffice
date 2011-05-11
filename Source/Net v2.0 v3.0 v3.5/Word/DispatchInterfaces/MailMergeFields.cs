//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface MailMergeFields SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class MailMergeFields : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFields(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFields(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFields(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public MailMergeFields()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField Add(NetOffice.WordApi.Range range, string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Name">string Name</param>
		/// <param name="Prompt">ref optional object Prompt</param>
		/// <param name="DefaultAskText">ref optional object DefaultAskText</param>
		/// <param name="AskOnce">ref optional object AskOnce</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddAsk(NetOffice.WordApi.Range range, string name, ref object prompt, ref object defaultAskText, ref object askOnce)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, name, prompt, defaultAskText, askOnce);
			object returnItem = Invoker.MethodReturn(this, "AddAsk", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			prompt = (object)paramsArray[2];
			defaultAskText = (object)paramsArray[3];
			askOnce = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddAsk(NetOffice.WordApi.Range range, string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, name);
			object returnItem = Invoker.MethodReturn(this, "AddAsk", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Prompt">ref optional object Prompt</param>
		/// <param name="DefaultFillInText">ref optional object DefaultFillInText</param>
		/// <param name="AskOnce">ref optional object AskOnce</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddFillIn(NetOffice.WordApi.Range range, ref object prompt, ref object defaultFillInText, ref object askOnce)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, prompt, defaultFillInText, askOnce);
			object returnItem = Invoker.MethodReturn(this, "AddFillIn", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			prompt = (object)paramsArray[1];
			defaultFillInText = (object)paramsArray[2];
			askOnce = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddFillIn(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddFillIn", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		/// <param name="CompareTo">ref optional object CompareTo</param>
		/// <param name="TrueAutoText">ref optional object TrueAutoText</param>
		/// <param name="TrueText">ref optional object TrueText</param>
		/// <param name="FalseAutoText">ref optional object FalseAutoText</param>
		/// <param name="FalseText">ref optional object FalseText</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison, ref object compareTo, ref object trueAutoText, ref object trueText, ref object falseAutoText, ref object falseText)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison, compareTo, trueAutoText, trueText, falseAutoText, falseText);
			object returnItem = Invoker.MethodReturn(this, "AddIf", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			compareTo = (object)paramsArray[3];
			trueAutoText = (object)paramsArray[4];
			trueText = (object)paramsArray[5];
			falseAutoText = (object)paramsArray[6];
			falseText = (object)paramsArray[7];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison);
			object returnItem = Invoker.MethodReturn(this, "AddIf", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddMergeRec(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddMergeRec", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddMergeSeq(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddMergeSeq", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddNext(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddNext", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		/// <param name="CompareTo">ref optional object CompareTo</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddNextIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison, ref object compareTo)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison, compareTo);
			object returnItem = Invoker.MethodReturn(this, "AddNextIf", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			compareTo = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddNextIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison);
			object returnItem = Invoker.MethodReturn(this, "AddNextIf", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Name">string Name</param>
		/// <param name="ValueText">ref optional object ValueText</param>
		/// <param name="ValueAutoText">ref optional object ValueAutoText</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddSet(NetOffice.WordApi.Range range, string name, ref object valueText, ref object valueAutoText)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, name, valueText, valueAutoText);
			object returnItem = Invoker.MethodReturn(this, "AddSet", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			valueText = (object)paramsArray[2];
			valueAutoText = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddSet(NetOffice.WordApi.Range range, string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, name);
			object returnItem = Invoker.MethodReturn(this, "AddSet", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		/// <param name="CompareTo">ref optional object CompareTo</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddSkipIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison, ref object compareTo)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison, compareTo);
			object returnItem = Invoker.MethodReturn(this, "AddSkipIf", paramsArray, modifiers);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			compareTo = (object)paramsArray[3];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="MergeField">string MergeField</param>
		/// <param name="Comparison">NetOffice.WordApi.Enums.WdMailMergeComparison Comparison</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.MailMergeField AddSkipIf(NetOffice.WordApi.Range range, string mergeField, NetOffice.WordApi.Enums.WdMailMergeComparison comparison)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, mergeField, comparison);
			object returnItem = Invoker.MethodReturn(this, "AddSkipIf", paramsArray);
			NetOffice.WordApi.MailMergeField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.MailMergeField;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}