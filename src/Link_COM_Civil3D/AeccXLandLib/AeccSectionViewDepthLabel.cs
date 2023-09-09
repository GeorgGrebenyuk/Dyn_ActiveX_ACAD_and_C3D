namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSectionViewDepthLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccSectionViewDepthLabel _i;
		internal AeccSectionViewDepthLabel(object AeccSectionViewDepthLabel_object) 
		{
			this._i = AeccSectionViewDepthLabel_object as Autodesk.AECC.Interop.Land.IAeccSectionViewDepthLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
