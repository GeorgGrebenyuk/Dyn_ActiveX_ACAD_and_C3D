namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentGeomPointLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentGeomPointLabelGroup _i;
		internal AeccAlignmentGeomPointLabelGroup(object AeccAlignmentGeomPointLabelGroup_object) 
		{
			this._i = AeccAlignmentGeomPointLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentGeomPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnGeomPoint(Autodesk.AECC.Interop.Land.AeccGeometryPointType Type) 
		{
			return this._i.LabelOnGeomPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnGeomPoint(Autodesk.AECC.Interop.Land.AeccGeometryPointType Type,bool pValue) 
		{
			this._i.LabelOnGeomPoint = Type,pValue;
		}
	}
}
