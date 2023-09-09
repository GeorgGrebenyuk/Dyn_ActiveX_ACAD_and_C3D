namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStationEquations 
	{
		public Autodesk.AECC.Interop.Land.IAeccStationEquations _i;
		internal AeccStationEquations(object AeccStationEquations_object) 
		{
			this._i = AeccStationEquations_object as Autodesk.AECC.Interop.Land.IAeccStationEquations;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Add(double RawStationBack,double StationBack,double StationAhead,Autodesk.AECC.Interop.Land.AeccStationEquationType StationEquationType) 
		{
			return this._i.Add(RawStationBack,StationBack,StationAhead,StationEquationType);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object Index) 
		{
			this._i.Remove(Index);
		}
	}
}
