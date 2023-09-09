namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileSagCurveLabelGroup 
	{
		public AeccXLandLib.IAeccProfileSagCurveLabelGroup _i;
		internal AeccProfileSagCurveLabelGroup(object AeccProfileSagCurveLabelGroup_object) 
		{
			this._i = AeccProfileSagCurveLabelGroup_object as AeccXLandLib.IAeccProfileSagCurveLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
