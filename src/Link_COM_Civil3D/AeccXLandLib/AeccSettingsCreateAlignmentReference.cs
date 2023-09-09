namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsCreateAlignmentReference 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentReference _i;
		internal AeccSettingsCreateAlignmentReference(object AeccSettingsCreateAlignmentReference_object) 
		{
			this._i = AeccSettingsCreateAlignmentReference_object as Autodesk.AECC.Interop.Land.IAeccSettingsCreateAlignmentReference;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
