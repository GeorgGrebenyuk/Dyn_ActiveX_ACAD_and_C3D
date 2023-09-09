namespace DynAeccXLandLib 
{

	///<summary>
	///
	///</summary>
	public class AeccLabelStyleDirectionArrowComponents 
	{
		public Autodesk.AECC.Interop.Land.IAeccLabelStyleDirectionArrowComponents _i;
		internal AeccLabelStyleDirectionArrowComponents(object AeccLabelStyleDirectionArrowComponents_object) 
		{
			this._i = AeccLabelStyleDirectionArrowComponents_object as Autodesk.AECC.Interop.Land.IAeccLabelStyleDirectionArrowComponents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}

		///<summary>
		///
		///</summary>
		public dynamic Count => this._i.Count;

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
		public dynamic Add(string Name) 
		{
			return this._i.Add(Name);
		}

		///<summary>
		///
		///</summary>
		public void Remove(object val) 
		{
			this._i.Remove(val);
		}
	}
}
