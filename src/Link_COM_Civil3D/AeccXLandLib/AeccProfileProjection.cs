namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileProjection 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileProjection _i;
		internal AeccProfileProjection(object AeccProfileProjection_object) 
		{
			this._i = AeccProfileProjection_object as Autodesk.AECC.Interop.Land.IAeccProfileProjection;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
