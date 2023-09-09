namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationStyleSet 
	{
		public AeccXLandLib.IAeccLabelMajorStationStyleSet _i;
		internal AeccLabelMajorStationStyleSet(object AeccLabelMajorStationStyleSet_object) 
		{
			this._i = AeccLabelMajorStationStyleSet_object as AeccXLandLib.IAeccLabelMajorStationStyleSet;
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
