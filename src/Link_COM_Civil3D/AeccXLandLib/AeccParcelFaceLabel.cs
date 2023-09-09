namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelFaceLabel 
	{
		public AeccXLandLib.IAeccParcelFaceLabel _i;
		internal AeccParcelFaceLabel(object AeccParcelFaceLabel_object) 
		{
			this._i = AeccParcelFaceLabel_object as AeccXLandLib.IAeccParcelFaceLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
