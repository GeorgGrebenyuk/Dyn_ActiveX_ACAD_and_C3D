namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccElevationRegion 
	{
		public Autodesk.AECC.Interop.Land.IAeccElevationRegion _i;
		internal AeccElevationRegion(object AeccElevationRegion_object) 
		{
			this._i = AeccElevationRegion_object as Autodesk.AECC.Interop.Land.IAeccElevationRegion;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double MinimumElevation => this._i.MinimumElevation;

		///<summary>
		///
		///</summary>
		public void Set_MinimumElevation(double pdVal) 
		{
			this._i.MinimumElevation = pdVal;
		}

		///<summary>
		///
		///</summary>
		public double MaximumElevation => this._i.MaximumElevation;

		///<summary>
		///
		///</summary>
		public void Set_MaximumElevation(double pdVal) 
		{
			this._i.MaximumElevation = pdVal;
		}

		///<summary>
		///
		///</summary>
		public int Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public void Set_Color(int pnVal) 
		{
			this._i.Color = pnVal;
		}
	}
}
