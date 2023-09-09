namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSuperElevationBandLabelingElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccSuperElevationBandLabelingElement _i;
		internal AeccSuperElevationBandLabelingElement(object AeccSuperElevationBandLabelingElement_object) 
		{
			this._i = AeccSuperElevationBandLabelingElement_object as Autodesk.AECC.Interop.Land.IAeccSuperElevationBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
