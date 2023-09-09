namespace DynAXDBLib 
{

	///<summary>
	///
	///</summary>
	public class AxDbDocumentEvents 
	{
		public AXDBLib.IAxDbDocumentEvents _i;
		internal AxDbDocumentEvents(object AxDbDocumentEvents_object) 
		{
			this._i = AxDbDocumentEvents_object as AXDBLib.IAxDbDocumentEvents;
			if (this._i == null) throw new System.Exception("Invalid casting");
		}
	}
}
