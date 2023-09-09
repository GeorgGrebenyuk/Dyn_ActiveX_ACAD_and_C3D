namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMinorStationStyleSet 
	{
		public AeccXLandLib.IAeccLabelMinorStationStyleSet _i;
		internal AeccLabelMinorStationStyleSet(object AeccLabelMinorStationStyleSet_object) 
		{
			this._i = AeccLabelMinorStationStyleSet_object as AeccXLandLib.IAeccLabelMinorStationStyleSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic LabelStyle,double Increment,dynamic ParentMajorStationStyleSetItem) 
		{
			return this._i.Add(LabelStyle,Increment,ParentMajorStationStyleSetItem);
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
