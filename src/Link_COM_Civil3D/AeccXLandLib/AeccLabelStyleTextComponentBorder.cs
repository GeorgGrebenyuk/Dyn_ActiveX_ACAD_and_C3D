namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleTextComponentBorder 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleTextComponentBorder _i;
		internal AeccLabelStyleTextComponentBorder(object AeccLabelStyleTextComponentBorder_object) 
		{
			this._i = AeccLabelStyleTextComponentBorder_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleTextComponentBorder;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Visibility => this._i.Visibility;

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public bool BackgroundMask => this._i.BackgroundMask;

		///<summary>
		///
		///</summary>
		public void Set_BackgroundMask(bool pVal) 
		{
			this._i.BackgroundMask = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Gap => this._i.Gap;

		///<summary>
		///
		///</summary>
		public dynamic Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;
	}
}
