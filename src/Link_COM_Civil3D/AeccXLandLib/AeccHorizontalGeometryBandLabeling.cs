﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccHorizontalGeometryBandLabeling 
	{
		public Autodesk.AECC.Interop.Land.IAeccHorizontalGeometryBandLabeling _i;
		internal AeccHorizontalGeometryBandLabeling(object AeccHorizontalGeometryBandLabeling_object) 
		{
			this._i = AeccHorizontalGeometryBandLabeling_object as Autodesk.AECC.Interop.Land.IAeccHorizontalGeometryBandLabeling;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
