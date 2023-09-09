namespace DynAeccXPipeLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumStructureLabelPlacement 
	{
		public AeccXPipeLib.IAeccPropertyEnumStructureLabelPlacement _i;
		internal AeccPropertyEnumStructureLabelPlacement(object AeccPropertyEnumStructureLabelPlacement_object) 
		{
			this._i = AeccPropertyEnumStructureLabelPlacement_object as AeccXPipeLib.IAeccPropertyEnumStructureLabelPlacement;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(AeccXPipeLib.AeccStructureLabelPlacementType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
