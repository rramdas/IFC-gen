	
using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
    /// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctemperaturerateofchangemeasure.htm
	/// </summary>
	public class IfcTemperatureRateOfChangeMeasure : BaseIfc
	{
		internal double value;

		public IfcTemperatureRateOfChangeMeasure(double value){ this.value = value; }	
		public static implicit operator double(IfcTemperatureRateOfChangeMeasure v){ return v.value; }
		public static implicit operator IfcTemperatureRateOfChangeMeasure(double v){ return new IfcTemperatureRateOfChangeMeasure(v); }	
		public static IfcTemperatureRateOfChangeMeasure FromJSON(string json){ return JsonConvert.DeserializeObject<IfcTemperatureRateOfChangeMeasure>(json); }
        public override string ToString(){ return value.ToString(); }
		public override string ToStepValue(bool isSelectOption = false){
			if(isSelectOption){ return $"{GetType().Name.ToUpper()}({value.ToStepValue(isSelectOption)})"; }
			else{ return value.ToStepValue(isSelectOption); }
        }
	}
}
