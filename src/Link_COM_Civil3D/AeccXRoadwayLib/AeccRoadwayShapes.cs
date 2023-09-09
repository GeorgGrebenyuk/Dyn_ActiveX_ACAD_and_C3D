namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayShapes 
	{
		public Autodesk.AECC.Interop.Roadway.IAeccRoadwayShapes _i;
		internal AeccRoadwayShapes(object AeccRoadwayShapes_object) 
		{
			this._i = AeccRoadwayShapes_object as Autodesk.AECC.Interop.Roadway.IAeccRoadwayShapes;
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
		public void Add() 
		{
			this._i.Add();
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
