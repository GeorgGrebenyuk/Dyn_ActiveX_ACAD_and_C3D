namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSegmentDisplayOrder 
	{
		public Autodesk.AECC.Interop.Land.IAeccSegmentDisplayOrder _i;
		internal AeccSegmentDisplayOrder(object AeccSegmentDisplayOrder_object) 
		{
			this._i = AeccSegmentDisplayOrder_object as Autodesk.AECC.Interop.Land.IAeccSegmentDisplayOrder;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(dynamic Priority) 
		{
			return this._i.Item(Priority);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public void SetPriority(object Index,dynamic NewPriority) 
		{
			this._i.SetPriority(Index,NewPriority);
		}

		///<summary>
		///
		///</summary>
		public dynamic GetPriority(dynamic ParcelStyle) 
		{
			return this._i.GetPriority(ParcelStyle);
		}
	}
}
