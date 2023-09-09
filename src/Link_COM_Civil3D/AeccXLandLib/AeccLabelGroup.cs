namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelGroup 
	{
		public AeccXLandLib.IAeccLabelGroup _i;
		internal AeccLabelGroup(object AeccLabelGroup_object) 
		{
			this._i = AeccLabelGroup_object as AeccXLandLib.IAeccLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
