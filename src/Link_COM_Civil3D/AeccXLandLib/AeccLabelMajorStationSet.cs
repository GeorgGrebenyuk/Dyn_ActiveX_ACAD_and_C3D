﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationSet 
	{
		public AeccXLandLib.IAeccLabelMajorStationSet _i;
		internal AeccLabelMajorStationSet(object AeccLabelMajorStationSet_object) 
		{
			this._i = AeccLabelMajorStationSet_object as AeccXLandLib.IAeccLabelMajorStationSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic LabelStyle,double Increment) 
		{
			return this._i.Add(LabelStyle,Increment);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Index) 
		{
			return this._i.Item(Index);
		}
	}
}
