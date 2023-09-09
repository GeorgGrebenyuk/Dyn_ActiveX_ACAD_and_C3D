namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCurveAndSpiralOption 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCurveAndSpiralOption _i;
		internal AeccSettingsCurveAndSpiralOption(object AeccSettingsCurveAndSpiralOption_object) 
		{
			this._i = AeccSettingsCurveAndSpiralOption_object as Autodesk.AECC.Interop.Land.IAeccSettingsCurveAndSpiralOption;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SpiralType => this._i.SpiralType;

		///<summary>
		///
		///</summary>
		public dynamic UseSpiralIn => this._i.UseSpiralIn;

		///<summary>
		///
		///</summary>
		public dynamic SpiralInLength => this._i.SpiralInLength;

		///<summary>
		///
		///</summary>
		public dynamic SpiralInAValue => this._i.SpiralInAValue;

		///<summary>
		///
		///</summary>
		public dynamic UseCurve => this._i.UseCurve;

		///<summary>
		///
		///</summary>
		public dynamic CurveRadiusforSCSGroup => this._i.CurveRadiusforSCSGroup;

		///<summary>
		///
		///</summary>
		public dynamic UseSpiralOut => this._i.UseSpiralOut;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOutLength => this._i.SpiralOutLength;

		///<summary>
		///
		///</summary>
		public dynamic SpiralOutAValue => this._i.SpiralOutAValue;
	}
}
