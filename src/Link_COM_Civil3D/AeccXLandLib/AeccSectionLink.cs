namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionLink 
	{
		public AeccXLandLib.IAeccSectionLink _i;
		internal AeccSectionLink(object AeccSectionLink_object) 
		{
			this._i = AeccSectionLink_object as AeccXLandLib.IAeccSectionLink;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double StartPointX => this._i.StartPointX;

		///<summary>
		///
		///</summary>
		public double StartPointY => this._i.StartPointY;

		///<summary>
		///
		///</summary>
		public double StartPointZ => this._i.StartPointZ;

		///<summary>
		///
		///</summary>
		public double EndPointX => this._i.EndPointX;

		///<summary>
		///
		///</summary>
		public double EndPointY => this._i.EndPointY;

		///<summary>
		///
		///</summary>
		public double EndPointZ => this._i.EndPointZ;

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;
	}
}
