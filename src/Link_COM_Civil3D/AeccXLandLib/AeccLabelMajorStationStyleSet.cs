namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMajorStationStyleSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelMajorStationStyleSet _i;
		internal AeccLabelMajorStationStyleSet(object AeccLabelMajorStationStyleSet_object) 
		{
			this._i = AeccLabelMajorStationStyleSet_object as Autodesk.AECC.Interop.Land.IAeccLabelMajorStationStyleSet;
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
