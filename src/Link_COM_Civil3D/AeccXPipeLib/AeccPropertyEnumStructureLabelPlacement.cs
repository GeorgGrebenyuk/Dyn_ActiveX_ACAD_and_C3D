namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStructureLabelPlacement 
	{
		public Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumStructureLabelPlacement _i;
		internal AeccPropertyEnumStructureLabelPlacement(object AeccPropertyEnumStructureLabelPlacement_object) 
		{
			this._i = AeccPropertyEnumStructureLabelPlacement_object as Autodesk.AECC.Interop.Pipe.IAeccPropertyEnumStructureLabelPlacement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Pipe.AeccStructureLabelPlacementType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
