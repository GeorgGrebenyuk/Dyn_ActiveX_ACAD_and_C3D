namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileCrestCurveLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileCrestCurveLabelGroup _i;
		internal AeccProfileCrestCurveLabelGroup(object AeccProfileCrestCurveLabelGroup_object) 
		{
			this._i = AeccProfileCrestCurveLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccProfileCrestCurveLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
