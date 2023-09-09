namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSurfaceWatershedBaseStyle 
	{
		public AeccXLandLib.IAeccSurfaceWatershedBaseStyle _i;
		internal AeccSurfaceWatershedBaseStyle(object AeccSurfaceWatershedBaseStyle_object) 
		{
			this._i = AeccSurfaceWatershedBaseStyle_object as AeccXLandLib.IAeccSurfaceWatershedBaseStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public void Set_Color(dynamic pVal) 
		{
			this._i.Color = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public void Put_TrueColor(dynamic pVal) 
		{
			this._i.TrueColor = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public void Set_Linetype(string pVal) 
		{
			this._i.Linetype = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseHatching => this._i.UseHatching;

		///<summary>
		///
		///</summary>
		public void Set_UseHatching(bool pVal) 
		{
			this._i.UseHatching = pVal;
		}

		///<summary>
		///
		///</summary>
		public string HatchPattern => this._i.HatchPattern;

		///<summary>
		///
		///</summary>
		public void Set_HatchPattern(string pVal) 
		{
			this._i.HatchPattern = pVal;
		}
	}
}
