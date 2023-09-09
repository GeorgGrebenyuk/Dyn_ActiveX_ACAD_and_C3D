namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleTickComponent 
	{
		public AeccXLandLib.IAeccLabelStyleTickComponent _i;
		internal AeccLabelStyleTickComponent(object AeccLabelStyleTickComponent_object) 
		{
			this._i = AeccLabelStyleTickComponent_object as AeccXLandLib.IAeccLabelStyleTickComponent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Height => this._i.Height;

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
		public dynamic Angle => this._i.Angle;

		///<summary>
		///
		///</summary>
		public dynamic BlockName => this._i.BlockName;

		///<summary>
		///
		///</summary>
		public dynamic AlignWithObject => this._i.AlignWithObject;
	}
}
