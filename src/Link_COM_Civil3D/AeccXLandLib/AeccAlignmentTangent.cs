namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentTangent 
	{
		public AeccXLandLib.IAeccAlignmentTangent _i;
		internal AeccAlignmentTangent(object AeccAlignmentTangent_object) 
		{
			this._i = AeccAlignmentTangent_object as AeccXLandLib.IAeccAlignmentTangent;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public double Direction => this._i.Direction;

		///<summary>
		///
		///</summary>
		public dynamic LineConstraint => this._i.LineConstraint;

		///<summary>
		///
		///</summary>
		public object PassThroughPoint1 => this._i.PassThroughPoint1;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint1(object pVal) 
		{
			this._i.PassThroughPoint1 = pVal;
		}

		///<summary>
		///
		///</summary>
		public object PassThroughPoint2 => this._i.PassThroughPoint2;

		///<summary>
		///
		///</summary>
		public void Set_PassThroughPoint2(object pVal) 
		{
			this._i.PassThroughPoint2 = pVal;
		}

		///<summary>
		///
		///</summary>
		public double MidEasting => this._i.MidEasting;

		///<summary>
		///
		///</summary>
		public double MidNorthing => this._i.MidNorthing;
	}
}
