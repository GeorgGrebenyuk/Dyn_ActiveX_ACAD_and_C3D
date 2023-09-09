namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineVertex 
	{
		public AeccXLandLib.IAeccSampleLineVertex _i;
		internal AeccSampleLineVertex(object AeccSampleLineVertex_object) 
		{
			this._i = AeccSampleLineVertex_object as AeccXLandLib.IAeccSampleLineVertex;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic DirectionFrom => this._i.DirectionFrom;

		///<summary>
		///
		///</summary>
		public void Set_DirectionFrom(AeccXLandLib.AeccDirectionFromType pVal) 
		{
			this._i.DirectionFrom = pVal;
		}

		///<summary>
		///
		///</summary>
		public object Location => this._i.Location;

		///<summary>
		///
		///</summary>
		public void Set_Location(object pVal) 
		{
			this._i.Location = pVal;
		}

		///<summary>
		///
		///</summary>
		public double StationOffset => this._i.StationOffset;

		///<summary>
		///
		///</summary>
		public string HookPointName => this._i.HookPointName;
	}
}
