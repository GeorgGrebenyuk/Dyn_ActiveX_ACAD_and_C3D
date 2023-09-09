namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccAlignmentDesignSpeedLabelGroup 
	{
		public Autodesk.AECC.Interop.Land.IAeccAlignmentDesignSpeedLabelGroup _i;
		internal AeccAlignmentDesignSpeedLabelGroup(object AeccAlignmentDesignSpeedLabelGroup_object) 
		{
			this._i = AeccAlignmentDesignSpeedLabelGroup_object as Autodesk.AECC.Interop.Land.IAeccAlignmentDesignSpeedLabelGroup;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
