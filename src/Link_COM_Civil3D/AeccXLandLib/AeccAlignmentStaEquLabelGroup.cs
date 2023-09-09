namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentStaEquLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentStaEquLabelGroup _i;
		internal AeccAlignmentStaEquLabelGroup(object AeccAlignmentStaEquLabelGroup_object) 
		{
			this._i = AeccAlignmentStaEquLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentStaEquLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
