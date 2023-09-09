namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentVAGeomPointLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentVAGeomPointLabelGroup _i;
		internal AeccAlignmentVAGeomPointLabelGroup(object AeccAlignmentVAGeomPointLabelGroup_object) 
		{
			this._i = AeccAlignmentVAGeomPointLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentVAGeomPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Profile => this._i.Profile;

		///<summary>
		///
		///</summary>
		public void Set_Profile(object ppProfile) 
		{
			this._i.Profile = ppProfile;
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnVAGeomPoint(Autodesk.AECC.Interop.Land.AeccVerticalGeometryPointType Type) 
		{
			return this._i.LabelOnVAGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnVAGeomPoint(Autodesk.AECC.Interop.Land.AeccVerticalGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnVAGeomPoint = Type,pValue;
		}
	}
}
