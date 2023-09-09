namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleTextComponent 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleTextComponent _i;
		internal AeccLabelStyleTextComponent(object AeccLabelStyleTextComponent_object) 
		{
			this._i = AeccLabelStyleTextComponent_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleTextComponent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AnchorComponent => this._i.AnchorComponent;

		///<summary>
		///
		///</summary>
		public dynamic AnchorPoint => this._i.AnchorPoint;

		///<summary>
		///
		///</summary>
		public dynamic AllowToCurve => this._i.AllowToCurve;

		///<summary>
		///
		///</summary>
		public dynamic Attachment => this._i.Attachment;

		///<summary>
		///
		///</summary>
		public dynamic Contents => this._i.Contents;

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
		public dynamic Height => this._i.Height;

		///<summary>
		///
		///</summary>
		public dynamic XOffset => this._i.XOffset;

		///<summary>
		///
		///</summary>
		public dynamic YOffset => this._i.YOffset;

		///<summary>
		///
		///</summary>
		public dynamic BorderStyle => this._i.BorderStyle;

		///<summary>
		///
		///</summary>
		public dynamic Justification => this._i.Justification;

		///<summary>
		///
		///</summary>
		public dynamic SpanOutsideSegments => this._i.SpanOutsideSegments;
	}
}
