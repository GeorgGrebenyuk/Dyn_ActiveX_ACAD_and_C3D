namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVICurveAsymmetric 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVICurveAsymmetric _i;
		internal AeccProfilePVICurveAsymmetric(object AeccProfilePVICurveAsymmetric_object) 
		{
			this._i = AeccProfilePVICurveAsymmetric_object as Autodesk.AECC.Interop.Land.IAeccProfilePVICurveAsymmetric;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_VerticalLength1(double vl1) 
		{
			this._i.VerticalLength1 = vl1;
		}

		///<summary>
		///
		///</summary>
		public double VerticalLength1 => this._i.VerticalLength1;

		///<summary>
		///
		///</summary>
		public void Set_VerticalLength2(double vl2) 
		{
			this._i.VerticalLength2 = vl2;
		}

		///<summary>
		///
		///</summary>
		public double VerticalLength2 => this._i.VerticalLength2;
	}
}
