namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentGeomPointLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentGeomPointLabelGroup _i;
		internal AeccAlignmentGeomPointLabelGroup(object AeccAlignmentGeomPointLabelGroup_object) 
		{
			this._i = AeccAlignmentGeomPointLabelGroup_object as AeccXLandLib.IAeccAlignmentGeomPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnGeomPoint(AeccXLandLib.AeccGeometryPointType Type) 
		{
			return this._i.LabelOnGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnGeomPoint(AeccXLandLib.AeccGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnGeomPoint = Type,pValue;
		}
	}
}
