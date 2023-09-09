namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccRoadwayStyle 
	{
		public AeccXRoadwayLib.IAeccRoadwayStyle _i;
		internal AeccRoadwayStyle(object AeccRoadwayStyle_object) 
		{
			this._i = AeccRoadwayStyle_object as AeccXRoadwayLib.IAeccRoadwayStyle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Type => this._i.Type;
	}
}
