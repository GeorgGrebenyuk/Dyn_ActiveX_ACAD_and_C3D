namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileProjectionLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileProjectionLabel _i;
		internal AeccProfileProjectionLabel(object AeccProfileProjectionLabel_object) 
		{
			this._i = AeccProfileProjectionLabel_object as Autodesk.AECC.Interop.Land.IAeccProfileProjectionLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
