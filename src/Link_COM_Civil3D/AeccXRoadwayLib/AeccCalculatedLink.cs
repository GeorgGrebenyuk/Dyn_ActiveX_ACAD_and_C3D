namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccCalculatedLink 
	{
		public AeccXRoadwayLib.IAeccCalculatedLink _i;
		internal AeccCalculatedLink(object AeccCalculatedLink_object) 
		{
			this._i = AeccCalculatedLink_object as AeccXRoadwayLib.IAeccCalculatedLink;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CalculatedPoints => this._i.CalculatedPoints;

		///<summary>
		///
		///</summary>
		public dynamic DrawOverride => this._i.DrawOverride;
	}
}
