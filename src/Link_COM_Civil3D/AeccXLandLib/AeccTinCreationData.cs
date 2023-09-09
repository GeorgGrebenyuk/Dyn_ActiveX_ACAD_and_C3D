namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccTinCreationData 
	{
		public Autodesk.AECC.Interop.Land.IAeccTinCreationData _i;
		internal AeccTinCreationData(object AeccTinCreationData_object) 
		{
			this._i = AeccTinCreationData_object as Autodesk.AECC.Interop.Land.IAeccTinCreationData;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
