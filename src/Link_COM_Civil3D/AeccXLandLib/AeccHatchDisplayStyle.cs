namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccHatchDisplayStyle 
	{
		public Autodesk.AECC.Interop.Land.IAeccHatchDisplayStyle _i;
		internal AeccHatchDisplayStyle(object AeccHatchDisplayStyle_object) 
		{
			this._i = AeccHatchDisplayStyle_object as Autodesk.AECC.Interop.Land.IAeccHatchDisplayStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic HatchType => this._i.HatchType;

		///<summary>
		///
		///</summary>
		public void Set_HatchType(Autodesk.AECC.Interop.Land.AeccHatchType pVal) 
		{
			this._i.HatchType = pVal;
		}

		///<summary>
		///
		///</summary>
		public string Pattern => this._i.Pattern;

		///<summary>
		///
		///</summary>
		public void Set_Pattern(string pVal) 
		{
			this._i.Pattern = pVal;
		}

		///<summary>
		///
		///</summary>
		public double ScaleFactor => this._i.ScaleFactor;

		///<summary>
		///
		///</summary>
		public void Set_ScaleFactor(double pVal) 
		{
			this._i.ScaleFactor = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Angle => this._i.Angle;

		///<summary>
		///
		///</summary>
		public void Set_Angle(double pVal) 
		{
			this._i.Angle = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool UseAngleOfObject => this._i.UseAngleOfObject;

		///<summary>
		///
		///</summary>
		public void Set_UseAngleOfObject(bool pVal) 
		{
			this._i.UseAngleOfObject = pVal;
		}

		///<summary>
		///
		///</summary>
		public double Spacing => this._i.Spacing;

		///<summary>
		///
		///</summary>
		public void Set_Spacing(double pVal) 
		{
			this._i.Spacing = pVal;
		}

		///<summary>
		///
		///</summary>
		public double UOffset => this._i.UOffset;

		///<summary>
		///
		///</summary>
		public void Set_UOffset(double pVal) 
		{
			this._i.UOffset = pVal;
		}

		///<summary>
		///
		///</summary>
		public double VOffset => this._i.VOffset;

		///<summary>
		///
		///</summary>
		public void Set_VOffset(double pVal) 
		{
			this._i.VOffset = pVal;
		}

		///<summary>
		///
		///</summary>
		public bool IsDoubleHatch => this._i.IsDoubleHatch;

		///<summary>
		///
		///</summary>
		public void Set_IsDoubleHatch(bool pVal) 
		{
			this._i.IsDoubleHatch = pVal;
		}
	}
}
