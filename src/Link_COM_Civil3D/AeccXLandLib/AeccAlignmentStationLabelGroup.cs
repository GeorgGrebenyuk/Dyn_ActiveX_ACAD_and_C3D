﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStationLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStationLabelGroup _i;
		internal AeccAlignmentStationLabelGroup(object AeccAlignmentStationLabelGroup_object) 
		{
			this._i = AeccAlignmentStationLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStationLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Increment => this._i.Increment;

		///<summary>
		///
		///</summary>
		public void Set_Increment(double pValue) 
		{
			this._i.Increment = pValue;
		}
	}
}
