namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccElevationTarget 
	{
		public AeccXRoadwayLib.IAeccElevationTarget _i;
		internal AeccElevationTarget(object AeccElevationTarget_object) 
		{
			this._i = AeccElevationTarget_object as AeccXRoadwayLib.IAeccElevationTarget;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double GetElevation(dynamic pAlignment,double StationOnAlignment,dynamic side) 
		{
			return this._i.GetElevation(pAlignment,StationOnAlignment,side);
		}

		///<summary>
		///
		///</summary>
		public dynamic Entity => this._i.Entity;

		///<summary>
		///
		///</summary>
		public dynamic TargetType => this._i.TargetType;
	}
}
