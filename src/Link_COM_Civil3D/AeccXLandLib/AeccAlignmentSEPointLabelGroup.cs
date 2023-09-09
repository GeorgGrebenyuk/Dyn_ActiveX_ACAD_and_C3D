namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentSEPointLabelGroup 
	{
		public AeccXLandLib.IAeccAlignmentSEPointLabelGroup _i;
		internal AeccAlignmentSEPointLabelGroup(object AeccAlignmentSEPointLabelGroup_object) 
		{
			this._i = AeccAlignmentSEPointLabelGroup_object as AeccXLandLib.IAeccAlignmentSEPointLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public bool LabelOnSEPoint(AeccXLandLib.AeccSuperElevTransPointType Type) 
		{
			return this._i.LabelOnSEPoint(Type);
		}

		///<summary>
		///
		///</summary>
		public void Set_LabelOnSEPoint(AeccXLandLib.AeccSuperElevTransPointType Type,bool pValue) 
		{
			this._i.LabelOnSEPoint = Type,pValue;
		}
	}
}
