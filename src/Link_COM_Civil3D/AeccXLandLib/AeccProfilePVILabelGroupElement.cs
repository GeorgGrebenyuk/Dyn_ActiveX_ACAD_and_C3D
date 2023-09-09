namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfilePVILabelGroupElement 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfilePVILabelGroupElement _i;
		internal AeccProfilePVILabelGroupElement(object AeccProfilePVILabelGroupElement_object) 
		{
			this._i = AeccProfilePVILabelGroupElement_object as Autodesk.AECC.Interop.Land.IAeccProfilePVILabelGroupElement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
