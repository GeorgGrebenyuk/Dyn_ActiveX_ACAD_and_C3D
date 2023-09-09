namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileSagCurveLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileSagCurveLabelGroup _i;
		internal AeccProfileSagCurveLabelGroup(object AeccProfileSagCurveLabelGroup_object) 
		{
			this._i = AeccProfileSagCurveLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccProfileSagCurveLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
