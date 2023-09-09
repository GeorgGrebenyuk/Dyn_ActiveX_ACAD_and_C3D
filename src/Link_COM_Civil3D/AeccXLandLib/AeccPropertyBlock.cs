namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyBlock 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyBlock _i;
		internal AeccPropertyBlock(object AeccPropertyBlock_object) 
		{
			this._i = AeccPropertyBlock_object as Autodesk.AECC.Interop.Land.IAeccPropertyBlock;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
