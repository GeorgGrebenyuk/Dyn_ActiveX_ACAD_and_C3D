namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayPoints 
	{
		public AeccXRoadwayLib.IAeccRoadwayPoints _i;
		internal AeccRoadwayPoints(object AeccRoadwayPoints_object) 
		{
			this._i = AeccRoadwayPoints_object as AeccXRoadwayLib.IAeccRoadwayPoints;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Owner => this._i.Owner;

		///<summary>
		///
		///</summary>
		public void Put_Owner(dynamic ppVal) 
		{
			this._i.Owner = ppVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(double dOffset,double dElevation,string bstrCode) 
		{
			return this._i.Add(dOffset,dElevation,bstrCode);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}
	}
}
