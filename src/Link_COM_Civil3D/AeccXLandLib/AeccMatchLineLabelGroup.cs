namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccMatchLineLabelGroup 
	{
		public AeccXLandLib.IAeccMatchLineLabelGroup _i;
		internal AeccMatchLineLabelGroup(object AeccMatchLineLabelGroup_object) 
		{
			this._i = AeccMatchLineLabelGroup_object as AeccXLandLib.IAeccMatchLineLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
