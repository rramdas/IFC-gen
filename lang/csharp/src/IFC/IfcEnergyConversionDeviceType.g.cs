

using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
	/// <summary>
	/// <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcenergyconversiondevicetype.htm"/>
	/// </summary>
	public abstract partial class IfcEnergyConversionDeviceType : IfcDistributionFlowElementType
	{


		/// <summary>
		/// Construct a IfcEnergyConversionDeviceType with all required attributes.
		/// </summary>
		public IfcEnergyConversionDeviceType(IfcGloballyUniqueId globalId):base(globalId)
		{


		}
		/// <summary>
		/// Construct a IfcEnergyConversionDeviceType with required and optional attributes.
		/// </summary>
		[JsonConstructor]
		public IfcEnergyConversionDeviceType(IfcGloballyUniqueId globalId,IfcOwnerHistory ownerHistory,IfcLabel name,IfcText description,IfcIdentifier applicableOccurrence,List<IfcPropertySetDefinition> hasPropertySets,List<IfcRepresentationMap> representationMaps,IfcLabel tag,IfcLabel elementType):base(globalId,ownerHistory,name,description,applicableOccurrence,hasPropertySets,representationMaps,tag,elementType)
		{


		}
		public static new IfcEnergyConversionDeviceType FromJSON(string json){ return JsonConvert.DeserializeObject<IfcEnergyConversionDeviceType>(json); }

	}
}
