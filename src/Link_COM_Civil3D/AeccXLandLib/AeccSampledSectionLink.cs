namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampledSectionLink 
	{
		public AeccXLandLib.IAeccSampledSectionLink _i;
		internal AeccSampledSectionLink(object AeccSampledSectionLink_object) 
		{
			this._i = AeccSampledSectionLink_object as AeccXLandLib.IAeccSampledSectionLink;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Flags => this._i.Flags;

		///<summary>
		///
		///</summary>
		public double StartPointStation => this._i.StartPointStation;

		///<summary>
		///
		///</summary>
		public double StartPointOffset => this._i.StartPointOffset;

		///<summary>
		///
		///</summary>
		public double StartPointElevation => this._i.StartPointElevation;

		///<summary>
		///
		///</summary>
		public double EndPointStation => this._i.EndPointStation;

		///<summary>
		///
		///</summary>
		public double EndPointOffset => this._i.EndPointOffset;

		///<summary>
		///
		///</summary>
		public double EndPointElevation => this._i.EndPointElevation;
	}
}
