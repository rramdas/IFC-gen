
import {BaseIfc} from "./BaseIfc"
import {IfcLabel} from "./IfcLabel.g"
import {IfcLengthMeasure} from "./IfcLengthMeasure.g"
import {IfcRatioMeasure} from "./IfcRatioMeasure.g"
import {IfcStructuralLoadOrResult} from "./IfcStructuralLoadOrResult.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsurfacereinforcementarea.htm
 */
export class IfcSurfaceReinforcementArea extends IfcStructuralLoadOrResult {
	SurfaceReinforcement1 : Array<IfcLengthMeasure> // optional
	SurfaceReinforcement2 : Array<IfcLengthMeasure> // optional
	ShearReinforcement : IfcRatioMeasure // optional

    constructor() {
        super()
		this.SurfaceReinforcement1 = new Array<IfcLengthMeasure>()
		this.SurfaceReinforcement2 = new Array<IfcLengthMeasure>()

    }
    getStepParameters() : string {
            var parameters = new Array<string>();
    		parameters.push(BaseIfc.toStepValue(this.Name))
		parameters.push(BaseIfc.toStepValue(this.SurfaceReinforcement1))
		parameters.push(BaseIfc.toStepValue(this.SurfaceReinforcement2))
		parameters.push(BaseIfc.toStepValue(this.ShearReinforcement))

            return parameters.join();
        }
}