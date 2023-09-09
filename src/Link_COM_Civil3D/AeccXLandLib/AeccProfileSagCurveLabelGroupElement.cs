namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileSagCurveLabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileSagCurveLabelGroupElement _i;
		internal AeccProfileSagCurveLabelGroupElement(object AeccProfileSagCurveLabelGroupElement_object) 
		{
			this._i = AeccProfileSagCurveLabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccProfileSagCurveLabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
