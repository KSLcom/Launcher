using System;
using System.Collections.Generic;
using System.Xml;
using System.ServiceModel.Channels;
using System.Runtime.Serialization;
using System.ServiceModel.Description;

namespace PowerShellTunnel.Common
{
	//ref: http://blogs.msdn.com/sowmy/archive/2006/03/26/561188.aspx
	public class WCFCustomDataContractSerializerAttribute : Attribute, IOperationBehavior
	{
		#region private state
		private int maxItemsInObjectGraph = 65536;
		#endregion
			
		#region constructor
		public WCFCustomDataContractSerializerAttribute()
		{
		}
		#endregion

		#region public properties
		public int MaxItemsInObjectGraph
		{
			get { return maxItemsInObjectGraph; }
			set { maxItemsInObjectGraph = value; }
		}
		#endregion

		#region IOperationBehavior Members
		public void AddBindingParameters(OperationDescription description, BindingParameterCollection parameters)
		{
		}

		public void ApplyClientBehavior(OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy)
		{
			description.Behaviors.Clear();
			IOperationBehavior innerBehavior = new WCFCustomDataContractSerializerOperationBehavior(description, maxItemsInObjectGraph);
			innerBehavior.ApplyClientBehavior(description, proxy);
		}

		public void ApplyDispatchBehavior(OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch)
		{
			description.Behaviors.Clear();
			IOperationBehavior innerBehavior = new WCFCustomDataContractSerializerOperationBehavior(description, maxItemsInObjectGraph);
			innerBehavior.ApplyDispatchBehavior(description, dispatch);
		}

		public void Validate(OperationDescription description)
		{
		}
		#endregion

		#region private class WCFCustomDataContractSerializerOperationBehavior
		private class WCFCustomDataContractSerializerOperationBehavior : DataContractSerializerOperationBehavior
		{
			#region private state
			private readonly int maxItemsInObjectGraph;
			#endregion

			#region constructor
			public WCFCustomDataContractSerializerOperationBehavior(OperationDescription operationDescription, int maxItemsInObjectGraph)
				: base(operationDescription)
			{
				this.maxItemsInObjectGraph = maxItemsInObjectGraph;
			}
			#endregion

			#region public override methods
			public override XmlObjectSerializer CreateSerializer(Type type, string name, string ns, IList<Type> knownTypes)
			{
				return new DataContractSerializer(type, name, ns, knownTypes,
					maxItemsInObjectGraph,
					false, //ignoreExtensionDataObject
					true,  //preserveReferences
					null); //dataContractSurrogate
			}

			public override XmlObjectSerializer CreateSerializer(Type type, XmlDictionaryString name, XmlDictionaryString ns, IList<Type> knownTypes)
			{
				return new DataContractSerializer(type, name, ns, knownTypes,
					maxItemsInObjectGraph,
					false, //ignoreExtensionDataObject
					true,  //preserveReferences
					null); //dataContractSurrogate
			}
			#endregion
		}
		#endregion
	}
}
