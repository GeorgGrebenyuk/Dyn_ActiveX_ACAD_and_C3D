﻿namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccNoteLabel 
	{
		public Autodesk.AECC.Interop.Land.IAeccNoteLabel _i;
		internal AeccNoteLabel(object AeccNoteLabel_object) 
		{
			this._i = AeccNoteLabel_object as Autodesk.AECC.Interop.Land.IAeccNoteLabel;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public string LabelTextContent => this._i.LabelTextContent;

		///<summary>
		///
		///</summary>
		public void Set_LabelTextContent(string pVal) 
		{
			this._i.LabelTextContent = pVal;
		}
	}
}
