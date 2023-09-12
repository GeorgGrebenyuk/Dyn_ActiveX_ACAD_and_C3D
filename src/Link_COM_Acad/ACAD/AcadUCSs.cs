namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AcadUCSs 
	{
		public Autodesk.AutoCAD.Interop.Common.IAcadUCSs _i;
		internal AcadUCSs(object AcadUCSs_object) 
		{
			this._i = AcadUCSs_object as Autodesk.AutoCAD.Interop.Common.IAcadUCSs;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Item(object Index) 
		{
			return this._i.Item(Index);
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

		///<summary>
		///
		///</summary>
		public dynamic Add(object Origin,object XAxisPoint,object YAxisPoint,string Name) 
		{
			return this._i.Add(Origin,XAxisPoint,YAxisPoint,Name);
		}
	}
}
