namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleDirectionArrowComponent 
	{
		public AeccXLandLib.IAeccLabelStyleDirectionArrowComponent _i;
		internal AeccLabelStyleDirectionArrowComponent(object AeccLabelStyleDirectionArrowComponent_object) 
		{
			this._i = AeccLabelStyleDirectionArrowComponent_object as AeccXLandLib.IAeccLabelStyleDirectionArrowComponent;
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
		public dynamic ArrowheadSize => this._i.ArrowheadSize;

		///<summary>
		///
		///</summary>
		public dynamic ArrowheadStyle => this._i.ArrowheadStyle;

		///<summary>
		///
		///</summary>
		public dynamic FixedLength => this._i.FixedLength;

		///<summary>
		///
		///</summary>
		public dynamic Length => this._i.Length;

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
		public dynamic Linetype => this._i.Linetype;

		///<summary>
		///
		///</summary>
		public dynamic Lineweight => this._i.Lineweight;

		///<summary>
		///
		///</summary>
		public dynamic SpanOutsideSegments => this._i.SpanOutsideSegments;
	}
}
