namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleLineComponent 
	{
		public AeccXLandLib.IAeccLabelStyleLineComponent _i;
		internal AeccLabelStyleLineComponent(object AeccLabelStyleLineComponent_object) 
		{
			this._i = AeccLabelStyleLineComponent_object as AeccXLandLib.IAeccLabelStyleLineComponent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic StartPointAnchorComponent => this._i.StartPointAnchorComponent;

		///<summary>
		///
		///</summary>
		public dynamic StartPointAnchorPoint => this._i.StartPointAnchorPoint;

		///<summary>
		///
		///</summary>
		public dynamic UseEndPointAnchor => this._i.UseEndPointAnchor;

		///<summary>
		///
		///</summary>
		public dynamic EndPointAnchorComponent => this._i.EndPointAnchorComponent;

		///<summary>
		///
		///</summary>
		public dynamic EndPointAnchorPoint => this._i.EndPointAnchorPoint;

		///<summary>
		///
		///</summary>
		public dynamic Angle => this._i.Angle;

		///<summary>
		///
		///</summary>
		public dynamic Length => this._i.Length;

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
		public dynamic StartPointXOffset => this._i.StartPointXOffset;

		///<summary>
		///
		///</summary>
		public dynamic StartPointYOffset => this._i.StartPointYOffset;

		///<summary>
		///
		///</summary>
		public dynamic EndPointXOffset => this._i.EndPointXOffset;

		///<summary>
		///
		///</summary>
		public dynamic EndPointYOffset => this._i.EndPointYOffset;
	}
}
