namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadPointCloudEx2 
	{
		public AXDBLib.IAcadPointCloudEx2 _i;
		internal AcadPointCloudEx2(object AcadPointCloudEx2_object) 
		{
			this._i = AcadPointCloudEx2_object as AXDBLib.IAcadPointCloudEx2;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string Segmentation => this._i.Segmentation;
	}
}
