namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSuperElevationBandLabelingElement 
	{
		public AeccXLandLib.IAeccSuperElevationBandLabelingElement _i;
		internal AeccSuperElevationBandLabelingElement(object AeccSuperElevationBandLabelingElement_object) 
		{
			this._i = AeccSuperElevationBandLabelingElement_object as AeccXLandLib.IAeccSuperElevationBandLabelingElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
