namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumViewFrameAngle 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumViewFrameAngle _i;
		internal AeccPropertyEnumViewFrameAngle(object AeccPropertyEnumViewFrameAngle_object) 
		{
			this._i = AeccPropertyEnumViewFrameAngle_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumViewFrameAngle;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccViewFrameAngleType pVal) 
		{
			this._i.Value = pVal;
		}
	}
}
