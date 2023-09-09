namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelMinorStationSet 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelMinorStationSet _i;
		internal AeccLabelMinorStationSet(object AeccLabelMinorStationSet_object) 
		{
			this._i = AeccLabelMinorStationSet_object as Autodesk.AECC.Interop.Land.IAeccLabelMinorStationSet;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(dynamic LabelStyle,double Increment,dynamic ParentMajorStationSetItem) 
		{
			return this._i.Add(LabelStyle,Increment,ParentMajorStationSetItem);
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
