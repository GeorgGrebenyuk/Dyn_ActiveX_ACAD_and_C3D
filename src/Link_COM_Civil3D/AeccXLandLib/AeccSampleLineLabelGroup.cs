namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSampleLineLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccSampleLineLabelGroup _i;
		internal AeccSampleLineLabelGroup(object AeccSampleLineLabelGroup_object) 
		{
			this._i = AeccSampleLineLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccSampleLineLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic SampleLineGroup => this._i.SampleLineGroup;
	}
}
