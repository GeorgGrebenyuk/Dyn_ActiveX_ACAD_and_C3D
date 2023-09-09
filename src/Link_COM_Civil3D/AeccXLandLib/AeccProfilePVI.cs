namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVI 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVI _i;
		internal AeccProfilePVI(object AeccProfilePVI_object) 
		{
			this._i = AeccProfilePVI_object as Autodesk.AECC.Interop.Land.IAeccProfilePVI;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Station(double Station) 
		{
			this._i.Station = Station;
		}

		///<summary>
		///
		///</summary>
		public double Station => this._i.Station;

		///<summary>
		///
		///</summary>
		public void Set_Elevation(double Elevation) 
		{
			this._i.Elevation = Elevation;
		}

		///<summary>
		///
		///</summary>
		public double Elevation => this._i.Elevation;

		///<summary>
		///
		///</summary>
		public void Set_GradeIn(double GradeIn) 
		{
			this._i.GradeIn = GradeIn;
		}

		///<summary>
		///
		///</summary>
		public double GradeIn => this._i.GradeIn;

		///<summary>
		///
		///</summary>
		public void Set_GradeOut(double GradeOut) 
		{
			this._i.GradeOut = GradeOut;
		}

		///<summary>
		///
		///</summary>
		public double GradeOut => this._i.GradeOut;
	}
}
