namespace DynAeccXRoadwayLib 
{

	///<summary>
	///
	///</summary>
	public class AeccOffsetTarget 
	{
		public AeccXRoadwayLib.IAeccOffsetTarget _i;
		internal AeccOffsetTarget(object AeccOffsetTarget_object) 
		{
			this._i = AeccOffsetTarget_object as AeccXRoadwayLib.IAeccOffsetTarget;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double DistanceToAlignment(dynamic pAlignment,double StationOnAlignment,dynamic side,out double pXOnTarget,out double pYOnTarget) 
		{
			return this._i.DistanceToAlignment(pAlignment,StationOnAlignment,side,out pXOnTarget,out pYOnTarget);
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
