namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParcelFaceLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccParcelFaceLabel _i;
		internal AeccParcelFaceLabel(object AeccParcelFaceLabel_object) 
		{
			this._i = AeccParcelFaceLabel_object as Autodesk.AECC.Interop.Land.IAeccParcelFaceLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
