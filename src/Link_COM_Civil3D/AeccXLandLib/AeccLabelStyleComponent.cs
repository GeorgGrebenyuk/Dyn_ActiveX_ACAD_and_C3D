namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleComponent 
	{
		public AeccXLandLib.IAeccLabelStyleComponent _i;
		internal AeccLabelStyleComponent(object AeccLabelStyleComponent_object) 
		{
			this._i = AeccLabelStyleComponent_object as AeccXLandLib.IAeccLabelStyleComponent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Mode => this._i.Mode;

		///<summary>
		///
		///</summary>
		public dynamic Color => this._i.Color;

		///<summary>
		///
		///</summary>
		public dynamic TrueColor => this._i.TrueColor;

		///<summary>
		///
		///</summary>
		public dynamic Visibility => this._i.Visibility;
	}
}
