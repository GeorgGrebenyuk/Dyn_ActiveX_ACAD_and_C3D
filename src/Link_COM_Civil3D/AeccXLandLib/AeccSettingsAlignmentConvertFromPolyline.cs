namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsAlignmentConvertFromPolyline 
	{
		public AeccXLandLib.IAeccSettingsAlignmentConvertFromPolyline _i;
		internal AeccSettingsAlignmentConvertFromPolyline(object AeccSettingsAlignmentConvertFromPolyline_object) 
		{
			this._i = AeccSettingsAlignmentConvertFromPolyline_object as AeccXLandLib.IAeccSettingsAlignmentConvertFromPolyline;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic AddCurvesBetweenTangents => this._i.AddCurvesBetweenTangents;

		///<summary>
		///
		///</summary>
		public dynamic EraseExistingEntities => this._i.EraseExistingEntities;
	}
}
