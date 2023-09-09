namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLineLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccMatchLineLabelGroup _i;
		internal AeccMatchLineLabelGroup(object AeccMatchLineLabelGroup_object) 
		{
			this._i = AeccMatchLineLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccMatchLineLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
