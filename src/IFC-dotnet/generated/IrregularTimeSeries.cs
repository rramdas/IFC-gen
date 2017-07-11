/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcirregulartimeseries.htm
	/// </summary>
	internal  partial class IrregularTimeSeries : TimeSeries 
	{
		public IrregularTimeSeriesValues Values {get;set;}

		public IrregularTimeSeries(IrregularTimeSeriesValues values,
				TimeSeriesUnit unit,
				String name,
				String description,
				String startTime,
				String endTime,
				TimeSeriesDataTypeEnum timeSeriesDataType,
				DataOriginEnum dataOrigin,
				String userDefinedDataOrigin) : base(unit,
				name,
				description,
				startTime,
				endTime,
				timeSeriesDataType,
				dataOrigin,
				userDefinedDataOrigin)
		{
			this.Values = values;
		}
	}
}