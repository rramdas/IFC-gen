	
using System;
using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using STEP;
	
namespace IFC
{
    /// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmagneticfluxmeasure.htm
	/// </summary>
	public class IfcMagneticFluxMeasure : BaseIfc
	{
		internal double value;

		public IfcMagneticFluxMeasure(double value){ this.value = value; }	
		public static implicit operator double(IfcMagneticFluxMeasure v){ return v.value; }
		public static implicit operator IfcMagneticFluxMeasure(double v){ return new IfcMagneticFluxMeasure(v); }	
		public static IfcMagneticFluxMeasure FromJSON(string json){ return JsonConvert.DeserializeObject<IfcMagneticFluxMeasure>(json); }
        public override string ToString(){ return value.ToString(); }
		public override string ToStepValue(bool isSelectOption = false){
			if(isSelectOption){ return $"{GetType().Name.ToUpper()}({value.ToStepValue(isSelectOption)})"; }
			else{ return value.ToStepValue(isSelectOption); }
        }
	}
}
