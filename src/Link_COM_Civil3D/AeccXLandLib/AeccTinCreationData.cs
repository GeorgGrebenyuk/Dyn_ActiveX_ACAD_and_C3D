namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinCreationData 
	{
		public AeccXLandLib.IAeccTinCreationData _i;
		internal AeccTinCreationData(object AeccTinCreationData_object) 
		{
			this._i = AeccTinCreationData_object as AeccXLandLib.IAeccTinCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
