namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumViewFrameAngle 
	{
		public AeccXLandLib.IAeccPropertyEnumViewFrameAngle _i;
		internal AeccPropertyEnumViewFrameAngle(object AeccPropertyEnumViewFrameAngle_object) 
		{
			this._i = AeccPropertyEnumViewFrameAngle_object as AeccXLandLib.IAeccPropertyEnumViewFrameAngle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXLandLib.AeccViewFrameAngleType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
