
import {BaseIfc} from "./BaseIfc"
import {IfcDimensionalExponents} from "./IfcDimensionalExponents.g"
import {IfcUnitEnum} from "./IfcUnitEnum.g"

/**
 * http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcnamedunit.htm
 */
export abstract class IfcNamedUnit extends BaseIfc {
	Dimensions : IfcDimensionalExponents
	UnitType : IfcUnitEnum

    constructor(dimensions : IfcDimensionalExponents, unitType : IfcUnitEnum) {
        super()

		this.Dimensions = dimensions
		this.UnitType = unitType

    }
}