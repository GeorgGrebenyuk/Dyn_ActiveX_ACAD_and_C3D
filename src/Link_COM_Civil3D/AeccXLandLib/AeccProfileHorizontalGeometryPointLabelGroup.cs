namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileHorizontalGeometryPointLabelGroup 
	{
		public AeccXLandLib.IAeccProfileHorizontalGeometryPointLabelGroup _i;
		internal AeccProfileHorizontalGeometryPointLabelGroup(object AeccProfileHorizontalGeometryPointLabelGroup_object) 
		{
			this._i = AeccProfileHorizontalGeometryPointLabelGroup_object as AeccXLandLib.IAeccProfileHorizontalGeometryPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnHAGeomPoint(AeccXLandLib.AeccGeometryPointType Type) 
		{
			return this._i.LabelOnHAGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnHAGeomPoint(AeccXLandLib.AeccGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnHAGeomPoint = Type,pValue;
		}
	}
}
