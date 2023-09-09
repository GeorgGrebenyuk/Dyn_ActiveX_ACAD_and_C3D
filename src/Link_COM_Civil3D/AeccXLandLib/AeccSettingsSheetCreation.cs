namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccSettingsSheetCreation 
	{
		public Autodesk.AECC.Interop.Land.IAeccSettingsSheetCreation _i;
		internal AeccSettingsSheetCreation(object AeccSettingsSheetCreation_object) 
		{
			this._i = AeccSettingsSheetCreation_object as Autodesk.AECC.Interop.Land.IAeccSettingsSheetCreation;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic CreationMethod => this._i.CreationMethod;

		///<summary>
		///
		///</summary>
		public dynamic NumberOfLayoutsPerDrawing => this._i.NumberOfLayoutsPerDrawing;

		///<summary>
		///
		///</summary>
		public dynamic AlignNorthArrow => this._i.AlignNorthArrow;

		///<summary>
		///
		///</summary>
		public dynamic NorthArrowBlockName => this._i.NorthArrowBlockName;

		///<summary>
		///
		///</summary>
		public dynamic UseExistingSheetSet => this._i.UseExistingSheetSet;

		///<summary>
		///
		///</summary>
		public dynamic ExistingSheetSet => this._i.ExistingSheetSet;

		///<summary>
		///
		///</summary>
		public dynamic AddNetworkLables => this._i.AddNetworkLables;

		///<summary>
		///
		///</summary>
		public dynamic AddToValut => this._i.AddToValut;

		///<summary>
		///
		///</summary>
		public dynamic AlignProfileAndPlanView => this._i.AlignProfileAndPlanView;
	}
}
