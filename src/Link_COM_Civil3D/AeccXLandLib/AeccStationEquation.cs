namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccStationEquation 
	{
		public Autodesk.AECC.Interop.Land.IAeccStationEquation _i;
		internal AeccStationEquation(object AeccStationEquation_object) 
		{
			this._i = AeccStationEquation_object as Autodesk.AECC.Interop.Land.IAeccStationEquation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double RawStationBack => this._i.RawStationBack;

		///<summary>
		///
		///</summary>
		public void Set_RawStationBack(double val) 
		{
			this._i.RawStationBack = val;
		}

		///<summary>
		///
		///</summary>
		public double StationBack => this._i.StationBack;

		///<summary>
		///
		///</summary>
		public double StationAhead => this._i.StationAhead;

		///<summary>
		///
		///</summary>
		public void Set_StationAhead(double val) 
		{
			this._i.StationAhead = val;
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public void Set_Type(Autodesk.AECC.Interop.Land.AeccStationEquationType val) 
		{
			this._i.Type = val;
		}
	}
}
