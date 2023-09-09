namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamPoint 
	{
		public AeccXLandLib.IAeccParamPoint _i;
		internal AeccParamPoint(object AeccParamPoint_object) 
		{
			this._i = AeccParamPoint_object as AeccXLandLib.IAeccParamPoint;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public void Set_Station(double pdStation) 
		{
			this._i.Station = pdStation;
		}

		///<summary>
		///
		///</summary>
		public double Offset => this._i.Offset;

		///<summary>
		///
		///</summary>
		public void Set_Offset(double pdOffset) 
		{
			this._i.Offset = pdOffset;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double pdElevation) 
		{
			this._i.Elevation = pdElevation;
		}

		///<summary>
		///
		///</summary>
		public void SetPoint(double dStation,double dOffset,double dElevation) 
		{
			this._i.SetPoint(dStation,dOffset,dElevation);
		}

		///<summary>
		///
		///</summary>
		public void GetPoint(out double pdStation,out double pdOffset,out double pdElevation) 
		{
			this._i.GetPoint(out pdStation,out pdOffset,out pdElevation);
		}
	}
}
