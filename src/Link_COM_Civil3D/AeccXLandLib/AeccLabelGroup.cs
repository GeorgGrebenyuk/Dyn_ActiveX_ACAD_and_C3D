namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelGroup _i;
		internal AeccLabelGroup(object AeccLabelGroup_object) 
		{
			this._i = AeccLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
