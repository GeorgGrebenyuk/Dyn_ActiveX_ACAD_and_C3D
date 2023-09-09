namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSEPointLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentSEPointLabelGroup _i;
		internal AeccAlignmentSEPointLabelGroup(object AeccAlignmentSEPointLabelGroup_object) 
		{
			this._i = AeccAlignmentSEPointLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentSEPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnSEPoint(Autodesk.AECC.Interop.Land.AeccSuperElevTransPointType Type) 
		{
			return this._i.LabelOnSEPoint[Type];
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnSEPoint(Autodesk.AECC.Interop.Land.AeccSuperElevTransPointType Type,bool pValue) 
		{
			this._i.LabelOnSEPoint[Type]=pValue;
		}
	}
}
