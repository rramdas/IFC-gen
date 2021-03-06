	
using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
    /// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcenergymeasure.htm
	/// </summary>
	public class IfcEnergyMeasure : BaseIfc
	{
		internal double value;

		public IfcEnergyMeasure(double value){ this.value = value; }	
		public static implicit operator double(IfcEnergyMeasure v){ return v.value; }
		public static implicit operator IfcEnergyMeasure(double v){ return new IfcEnergyMeasure(v); }	
		public static IfcEnergyMeasure FromJSON(string json){ return JsonConvert.DeserializeObject<IfcEnergyMeasure>(json); }
        public override string ToString(){ return value.ToString(); }
		public override string ToStepValue(bool isSelectOption = false){
			if(isSelectOption){ return $"{GetType().Name.ToUpper()}({value.ToStepValue(isSelectOption)})"; }
			else{ return value.ToStepValue(isSelectOption); }
        }
	}
}
