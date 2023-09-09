namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccPropertyEnumCrossSectionShape 
	{
		public Autodesk.AECC.Interop.Land.IAeccPropertyEnumCrossSectionShape _i;
		internal AeccPropertyEnumCrossSectionShape(object AeccPropertyEnumCrossSectionShape_object) 
		{
			this._i = AeccPropertyEnumCrossSectionShape_object as Autodesk.AECC.Interop.Land.IAeccPropertyEnumCrossSectionShape;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public void Set_Value(Autodesk.AECC.Interop.Land.AeccCrossSectionShapeType pVal) 
		{
			this._i.Value = pVal;
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;
	}
}
