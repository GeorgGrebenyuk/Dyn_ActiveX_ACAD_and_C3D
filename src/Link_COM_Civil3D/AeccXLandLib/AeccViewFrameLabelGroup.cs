namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrameLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccViewFrameLabelGroup _i;
		internal AeccViewFrameLabelGroup(object AeccViewFrameLabelGroup_object) 
		{
			this._i = AeccViewFrameLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccViewFrameLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
