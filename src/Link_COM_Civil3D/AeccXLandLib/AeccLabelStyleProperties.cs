namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleProperties 
	{
		public AeccXLandLib.IAeccLabelStyleProperties _i;
		internal AeccLabelStyleProperties(object AeccLabelStyleProperties_object) 
		{
			this._i = AeccLabelStyleProperties_object as AeccXLandLib.IAeccLabelStyleProperties;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic TextStyle => this._i.TextStyle;

		///<summary>
		///
		///</summary>
		public dynamic Visibility => this._i.Visibility;

		///<summary>
		///
		///</summary>
		public dynamic ForceInsideCurve => this._i.ForceInsideCurve;

		///<summary>
		///
		///</summary>
		public dynamic ForcedInsertion => this._i.ForcedInsertion;

		///<summary>
		///
		///</summary>
		public dynamic OrientationReference => this._i.OrientationReference;

		///<summary>
		///
		///</summary>
		public dynamic PlanReadable => this._i.PlanReadable;

		///<summary>
		///
		///</summary>
		public dynamic TagDisplayMode => this._i.TagDisplayMode;

		///<summary>
		///
		///</summary>
		public dynamic Layer => this._i.Layer;

		///<summary>
		///
		///</summary>
		public dynamic PlanReadableBias => this._i.PlanReadableBias;

		///<summary>
		///
		///</summary>
		public dynamic PlanReadableFlipAnchors => this._i.PlanReadableFlipAnchors;
	}
}
