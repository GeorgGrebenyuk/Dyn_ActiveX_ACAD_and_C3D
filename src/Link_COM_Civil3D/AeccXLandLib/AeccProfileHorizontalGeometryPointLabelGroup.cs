namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccProfileHorizontalGeometryPointLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccProfileHorizontalGeometryPointLabelGroup _i;
		internal AeccProfileHorizontalGeometryPointLabelGroup(object AeccProfileHorizontalGeometryPointLabelGroup_object) 
		{
			this._i = AeccProfileHorizontalGeometryPointLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccProfileHorizontalGeometryPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnHAGeomPoint(Autodesk.AECC.Interop.Land.AeccGeometryPointType Type) 
		{
			return this._i.LabelOnHAGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnHAGeomPoint(Autodesk.AECC.Interop.Land.AeccGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnHAGeomPoint = Type,pValue;
		}
	}
}
