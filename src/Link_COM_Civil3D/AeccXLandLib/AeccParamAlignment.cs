﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccParamAlignment 
	{
		public Autodesk.AECC.Interop.Land.IAeccParamAlignment _i;
		internal AeccParamAlignment(object AeccParamAlignment_object) 
		{
			this._i = AeccParamAlignment_object as Autodesk.AECC.Interop.Land.IAeccParamAlignment;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Value => this._i.Value;

		///<summary>
		///
		///</summary>
		public void Set_Value(dynamic ppVal) 
		{
			this._i.Value = ppVal;
		}
	}
}
