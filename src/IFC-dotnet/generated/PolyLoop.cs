/*
This code was generated by a tool. DO NOT MODIFY this code manually, unless you really know what you are doing.
 */
using System;
				
namespace IFC4
{
	/// <summary>
	/// http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpolyloop.htm
	/// </summary>
	internal  partial class PolyLoop : Loop 
	{
		public PolyLoopPolygon Polygon {get;set;}

		public PolyLoop(PolyLoopPolygon polygon,
				StyledItem styledByItem) : base(styledByItem)
		{
			this.Polygon = polygon;
		}
	}
}