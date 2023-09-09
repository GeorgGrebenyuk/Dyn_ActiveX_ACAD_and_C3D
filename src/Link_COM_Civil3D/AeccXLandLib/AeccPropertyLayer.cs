namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyLayer 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyLayer _i;
		internal AeccPropertyLayer(object AeccPropertyLayer_object) 
		{
			this._i = AeccPropertyLayer_object as Autodesk.AECC.Interop.Land.IAeccPropertyLayer;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
