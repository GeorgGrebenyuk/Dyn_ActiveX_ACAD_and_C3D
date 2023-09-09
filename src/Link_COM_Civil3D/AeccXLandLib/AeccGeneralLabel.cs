namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccGeneralLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccGeneralLabel _i;
		internal AeccGeneralLabel(object AeccGeneralLabel_object) 
		{
			this._i = AeccGeneralLabel_object as Autodesk.AECC.Interop.Land.IAeccGeneralLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string LineLabelStyleName => this._i.LineLabelStyleName;

		///<summary>
		///
		///</summary>
		public void Set_LineLabelStyleName(string pVal) 
		{
			this._i.LineLabelStyleName = pVal;
		}

		///<summary>
		///
		///</summary>
		public string CurveLabelStyleName => this._i.CurveLabelStyleName;

		///<summary>
		///
		///</summary>
		public void Set_CurveLabelStyleName(string pVal) 
		{
			this._i.CurveLabelStyleName = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyle => this._i.LineLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_LineLabelStyle(object pVal) 
		{
			this._i.LineLabelStyle = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyle => this._i.CurveLabelStyle;

		///<summary>
		///
		///</summary>
		public void Set_CurveLabelStyle(object pVal) 
		{
			this._i.CurveLabelStyle = pVal;
		}
	}
}
