namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelLabelStyles 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelLabelStyles _i;
		internal AeccParcelLabelStyles(object AeccParcelLabelStyles_object) 
		{
			this._i = AeccParcelLabelStyles_object as Autodesk.AECC.Interop.Land.IAeccParcelLabelStyles;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic LineLabelStyles => this._i.LineLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic CurveLabelStyles => this._i.CurveLabelStyles;

		///<summary>
		///
		///</summary>
		public dynamic AreaLabelStyles => this._i.AreaLabelStyles;
	}
}
