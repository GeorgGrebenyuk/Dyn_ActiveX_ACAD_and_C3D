namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccViewFrame 
	{
		public AeccXLandLib.IAeccViewFrame _i;
		internal AeccViewFrame(object AeccViewFrame_object) 
		{
			this._i = AeccViewFrame_object as AeccXLandLib.IAeccViewFrame;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
