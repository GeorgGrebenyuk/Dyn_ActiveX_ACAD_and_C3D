namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleBlockComponent 
	{
		public AeccXLandLib.IAeccLabelStyleBlockComponent _i;
		internal AeccLabelStyleBlockComponent(object AeccLabelStyleBlockComponent_object) 
		{
			this._i = AeccLabelStyleBlockComponent_object as AeccXLandLib.IAeccLabelStyleBlockComponent;
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
		public dynamic XOffset => this._i.XOffset;

		///<summary>
		///
		///</summary>
		public dynamic YOffset => this._i.YOffset;

		///<summary>
		///
		///</summary>
		public dynamic Attachment => this._i.Attachment;
	}
}
