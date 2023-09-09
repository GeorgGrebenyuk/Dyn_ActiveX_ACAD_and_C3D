namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentVAGeomPointLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentVAGeomPointLabelGroup _i;
		internal AeccAlignmentVAGeomPointLabelGroup(object AeccAlignmentVAGeomPointLabelGroup_object) 
		{
			this._i = AeccAlignmentVAGeomPointLabelGroup_object as AeccXLandLib.IAeccAlignmentVAGeomPointLabelGroup;
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
		public bool LabelOnVAGeomPoint(AeccXLandLib.AeccVerticalGeometryPointType Type) 
		{
			return this._i.LabelOnVAGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnVAGeomPoint(AeccXLandLib.AeccVerticalGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnVAGeomPoint = Type,pValue;
		}
	}
}
